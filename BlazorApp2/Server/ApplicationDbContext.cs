﻿using BlazorApp2.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Server
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public DbSet<Persona> Personas
        {
            get; set;
        }
        public DbSet<Rol> Roles
        {
            get; set;
        }
        public DbSet<Team> Teams
        {
            get; set;
        }
        public DbSet<UploadResult> UploadResults
        {
            get; set;
        }


    }
}
