using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    static class DacMedico
    {
        static List<Medico> ListaMedicos { get; set; }

        static List<Medico> Select()
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null;
        }

        static List<Medico> Select(string especialidad)
        {
            //TODO Falta implementar código - Select a la tabla Medico filtrando especialidad....
            return null;
        }

        static int Insert(Medico medico)
        {
            //TODO Falta implementar código - Insert a la tabla Medico...
            return 0;
        }

        static int Eliminar(int id)
        {
            //TODO Falta implementar código - Delete en la tabla Medico...
            return 0;
        }

        static Medico SelectById(int id)
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null;
        }
    }
}
