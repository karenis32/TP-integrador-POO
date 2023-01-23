using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table ("Habitación")]
    public class Habitacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Número { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Estado { get; set; }

        public Clinica clinica { get; set; }

        public Habitacion(int id, int número, string estado)
        {
            Id = id;
            Número = número;
            Estado = estado;
        }
    }
}
