using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Paciente")]
    public class Paciente: Persona
    {
        [Required]
        public int NroHistoriaClinica { get; set; }

        public Medico medico { get; set; }
        public Enfermero enfermero { get; set; }
        public Clinica clinica { get; set; }

        public Paciente( string nombre, string apellido, string domicilio, string telefono, string email, int NroHistoriaClinica) : base( nombre, apellido, domicilio, telefono, email)
        {
            this.NroHistoriaClinica = NroHistoriaClinica;
        }

    }
}
