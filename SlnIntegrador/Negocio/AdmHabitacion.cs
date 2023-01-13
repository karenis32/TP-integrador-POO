using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmHabitacion
    {
        public List<Habitacion> ListaHabitaciones { get; set; }

        public List<Habitacion> Listar()
        {
            //TODO Falta implementar código - Select a la tabla Habitacion....
            return null;
        }

        public List<Habitacion> Listar(string estado)
        {
            //TODO Falta implementar código - Select a la tabla Habitacion filtrando estado....
            return null;
        }

        public int Insertar(Habitacion habitacion)
        {
            //TODO Falta implementar código - Insert a la tabla Habitacion...
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO Falta implementar código - Delete en la tabla Habitacion...
            return 0;
        }

        public Habitacion TraerUno(int numero)
        {
            //TODO Falta implementar código - Select a la tabla Habitacion....
            return null;
        }
    }
}
