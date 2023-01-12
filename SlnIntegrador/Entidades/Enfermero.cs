using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero : Persona
    {
        public string CUIL { get; set; }

        public Enfermero(int id, string nombre, string apellido, string domicilio, string telefono, string email, string CUIL) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            this.CUIL = CUIL;
        }
    }
}
