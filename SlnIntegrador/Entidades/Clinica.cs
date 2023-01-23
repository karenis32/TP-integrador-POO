using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Clínica")]
    public class Clinica
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Domicilio { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Director director { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Paciente> ListaPacientes { get; set; }
        public List<Habitacion> ListaHabitaciones { get; set; }

        public Clinica(int id, string nombre, string domicilio, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
        }
    }
}
