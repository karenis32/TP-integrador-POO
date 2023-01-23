using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Enfermero")]
    public class Enfermero : Persona
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string CUIL { get; set; }

        public Clinica clinica { get; set; }
        public List<Paciente> ListaPacientes { get; set; }

        public Enfermero(string nombre, string apellido, string domicilio, string telefono, string email, string CUIL) : base(nombre, apellido, domicilio, telefono, email)
        {
            this.CUIL = CUIL;
        }
    }
}
