using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{

    public static class AdmMedico
    {
        public static List<Medico> ListaMedicos { get; set; }

        public static List<Medico> Listar()
        {

            //TODO Falta implementar código - Select a la tabla Medico....
            return null;


        }

        public static List<Medico> Listar(string especialidad)
        {
            //TODO Falta implementar código - Select a la tabla Medico filtrando especialidad....
            return null;


        }

        public static int Insertar(Medico medico)
        {
            //TODO Falta implementar código - Insert a la tabla Medico...
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO Falta implementar código - Delete en la tabla Medico...
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null;
        }

    }
}
