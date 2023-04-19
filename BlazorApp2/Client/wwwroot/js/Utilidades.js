/*recibe un filename y crea un anchor dinamicamente que hace click para que se descargue el archivo*/

function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-strem;base64," + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}


function CustomConfirm(titulo, mensaje, tipo) {
    return new Promise((resolve) => {
        Swal.fire({
            title: titulo,
            text: mensaje,
            type: tipo,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Confirmar'
        }).then((result) => {
            if (result.value) {
                resolve(true);
            } else {
                resolve(false);
            }
        });
    });
}