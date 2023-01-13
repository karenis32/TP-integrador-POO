using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DacMedico
    {
        public List<Medico> ListaMedicos { get; set; }

        public List<Medico> Select()
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null;
        }

        public List<Medico> Select(string especialidad)
        {
            //TODO Falta implementar código - Select a la tabla Medico filtrando especialidad....
            return null;
        }

        public int Insert(Medico medico)
        {
            //TODO Falta implementar código - Insert a la tabla Medico...
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO Falta implementar código - Delete en la tabla Medico...
            return 0;
        }

        public Medico SelectById(int id)
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null;
        }
    }
}
