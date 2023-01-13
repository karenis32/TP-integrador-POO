using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmPaciente
    {
        public List<Paciente> Listapacientes { get; set; }

        public List<Paciente> Listar()
        {
            //TODO Falta implementar código - Select a la tabla Paciente....
            return null;
        }

        public int Insertar(Paciente paciente)
        {
            //TODO Falta implementar código - Insert a la tabla Paciente...
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO Falta implementar código - Delete en la tabla Paciente...
            return 0;
        }

        public Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO Falta implementar código - Select a la tabla Paciente....
            return null;
        }
    }
}
