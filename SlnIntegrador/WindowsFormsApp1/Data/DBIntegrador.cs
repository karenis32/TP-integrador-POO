using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace WindowsFormsApp1.Data
{
    public class DBIntegrador: DbContext
    {
        public DBIntegrador() : base("KeyDB") { }

        public DbSet<Clinica> clinica { get; set; }
        public DbSet<Director> director { get; set; }
        public DbSet<Enfermero> enfermero { get;set; }
        public DbSet<Habitacion> habitacion { get;set; }
        public DbSet<Medico> medico { get; set; }
        public DbSet<Paciente> paciente { get; set;}
    }
}
