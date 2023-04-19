
using BlazorApp2.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlazorApp2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private readonly ApplicationDbContext _context;

        public FileController(IWebHostEnvironment env, ApplicationDbContext context)
        {
            _env = env;
            _context = context;
        }



        [HttpPost]

        public async Task<ActionResult<List<UploadResult>>> UploadFile(List<IFormFile> files)
        {
            //creamos el return object
            List<UploadResult> uploadResults = new List<UploadResult>();

            foreach (var file in files)
            {
                //creamos un objeto de uploadResult
                var uploadResult = new UploadResult();
                //random file name that is then secured--
                string trustedFileNameForFileStorage;
                //Este seria el nombre original del archivo
                var untrustedFileName = file.FileName;
                //sore the original file name

                uploadResult.FileName = untrustedFileName;
                var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);

                trustedFileNameForFileStorage = Path.GetRandomFileName();

                //get the path create folder
                var path = Path.Combine(_env.ContentRootPath, "uploads", trustedFileNameForFileStorage);

                //create the file and store it
                await using FileStream fs = new(path, FileMode.Create);
                await file.CopyToAsync(fs);

                uploadResult.StoredFileName = trustedFileNameForFileStorage;
                uploadResults.Add(uploadResult);

                //guardado upload result en la base de datos
                _context.UploadResults.Add(uploadResult);

            }

            await _context.SaveChangesAsync();

            return Ok(uploadResults);

        }

    }
}
