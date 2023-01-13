using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    static class AdmMedico
    {
        static List<Medico> ListaMedicos { get; set; }


        static List<Medico> Listar()
        {
            /*
            //TODO Falta implementar código - Select a la tabla Medico....
            return null;}
            */
            List<Medico> ListaMedico = new List<Medico>();

            ListaMedico.Add(new Medico(1,"Juan","Perez","Calle 123","123456","juan@hotmail","Clinico",1562));
            ListaMedico.Add(new Medico(2, "Sofia", "Perez", "Calle 123", "123456", "sofia@hotmail", "Clinico", 1586));
            ListaMedico.Add(new Medico(3, "Ana", "Perez", "Calle 123", "123456", "ana@hotmail", "Pediatra", 8952));
            ListaMedico.Add(new Medico(4, "Pedro", "Santos", "Calle 123", "123456", "pedro@hotmail", "Traumatologo", 1562));
            ListaMedico.Add(new Medico(5, "Andres", "Ramos", "Calle 123", "123456", "andres@hotmail", "Traumatologo", 6523));

            return ListaMedico;

        }

        static List<Medico> Listar(string especialidad)
        {
            //TODO Falta implementar código - Select a la tabla Medico filtrando especialidad....
            return null;
        }

        static int Insertar (Medico medico)
        {
            //TODO Falta implementar código - Insert a la tabla Medico...
            return 0;
        }

        static int Eliminar (int id)
        {
            //TODO Falta implementar código - Delete en la tabla Medico...
            return 0;
        }

        static Medico TraerUno (int id)
        {
            //TODO Falta implementar código - Select a la tabla Medico....
            return null ;
        }

    }
}
