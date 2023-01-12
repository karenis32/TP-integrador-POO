using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director : Persona
    {
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
        public string PostGrado { get; set; }

        public Director(int id, string nombre, string apellido, string domicilio, string telefono, string email, string Especialidad, int Matricula, string PostGrado) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            this.Especialidad = Especialidad;
            this.Matricula = Matricula;
            this.PostGrado = PostGrado;
        }
    }
}
