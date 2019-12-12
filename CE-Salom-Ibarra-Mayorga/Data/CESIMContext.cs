using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CESIM.Models;

namespace CESIM.Data
{
    public class CESIMContext : DbContext
    {
        public CESIMContext (DbContextOptions<CESIMContext> options)
            : base(options)
        {
        }

        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Matricula> Matriculas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docente>().ToTable("Docente");
            modelBuilder.Entity<Grado>().ToTable("Grado");
            modelBuilder.Entity<Tutor>().ToTable("Tutor");
            modelBuilder.Entity<Estudiante>().ToTable("Estudiante");

            modelBuilder.Entity<Matricula>().ToTable("Matricula");

        }

        public DbSet<CESIM.Models.Docente> Docente { get; set; }
    }
}
