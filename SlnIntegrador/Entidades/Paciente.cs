using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente: Persona
    {
        public int NroHistoriaClinica { get; set; }

        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, int NroHistoriaClinica) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            this.NroHistoriaClinica = NroHistoriaClinica;
        }

    }
}
