using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Director")]
    public class Director : Persona
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [Required]
        public int Matricula { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string PostGrado { get; set; }

        public Clinica clinica { get; set; }

        public Director(string nombre, string apellido, string domicilio, string telefono, string email, string Especialidad, int Matricula, string PostGrado) : base(nombre, apellido, domicilio, telefono, email)
        {
            this.Especialidad = Especialidad;
            this.Matricula = Matricula;
            this.PostGrado = PostGrado;
        }
    }
}
