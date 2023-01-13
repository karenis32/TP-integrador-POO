using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    static class AdmPaciente
    {
        static List<Paciente> Listapacientes { get; set; }

        static List<Paciente> Listar()
        {
            //TODO Falta implementar código - Select a la tabla Paciente....
            //return null;

            List<Paciente> ListaPaciente = new List<Paciente>();

            ListaPaciente.Add(new Paciente(1, "Juan", "Perez", "Calle 123", "123456", "juan@hotmail", 1562));
            ListaPaciente.Add(new Paciente(2, "Sofia", "Perez", "Calle 123", "123456", "sofia@hotmail", 1586));
            ListaPaciente.Add(new Paciente(3, "Ana", "Perez", "Calle 123", "123456", "ana@hotmail", 8952));
            ListaPaciente.Add(new Paciente(4, "Pedro", "Santos", "Calle 123", "123456", "pedro@hotmail", 1562));
            ListaPaciente.Add(new Paciente(5, "Andres", "Ramos", "Calle 123", "123456", "andres@hotmail", 6523));

            return ListaPaciente;
        }

        static int Insertar(Paciente paciente)
        {
            //TODO Falta implementar código - Insert a la tabla Paciente...
            return 0;
        }

        static int Eliminar(int id)
        {
            //TODO Falta implementar código - Delete en la tabla Paciente...
            return 0;
        }

        static Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO Falta implementar código - Select a la tabla Paciente....
            return null;
        }
    }
}
