using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Medico")]
    public class Medico : Persona
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Especialidad { get; set; }

        [Required]
        public int Matricula { get; set; }

        public Clinica clinica { get; set; }
        public List<Paciente> ListaPacientes { get; set; }

        public Medico(string nombre, string apellido, string domicilio, string telefono, string email, string Especialidad, int Matricula) : base(nombre, apellido, domicilio, telefono, email)
        {
            this.Especialidad = Especialidad;
            this.Matricula = Matricula;
        }
    }
}
