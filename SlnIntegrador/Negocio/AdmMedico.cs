using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmMedico
    {
        public List<Medico> ListaMedicos { get; set; }

        public List<Medico> Listar()
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null;
        }

        public List<Medico> Listar(string especialidad)
        {
            //TODO Falta implementar código - Select a la tabla Medico filtrando especialidad....
            return null;
        }

        public int Insertar (Medico medico)
        {
            //TODO Falta implementar código - Insert a la tabla Medico...
            return 0;
        }

        public int Eliminar (int id)
        {
            //TODO Falta implementar código - Delete en la tabla Medico...
            return 0;
        }

        public Medico TraerUno (int id)
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null ;
        }

    }
}
