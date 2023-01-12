using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Número { get; set; }
        public string Estado { get; set; }

        public Habitacion(int id, int número, string estado)
        {
            Id = id;
            Número = número;
            Estado = estado;
        }
    }
}
