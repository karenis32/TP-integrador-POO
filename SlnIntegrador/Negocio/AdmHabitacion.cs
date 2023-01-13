using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    static class AdmHabitacion
    {
        static List<Habitacion> ListaHabitaciones { get; set; }

        static List<Habitacion> Listar()
        {
            //TODO Falta implementar código - Select a la tabla Habitacion....
            //return null;

            List<Habitacion> ListaHabitaciones = new List<Habitacion>();

            ListaHabitaciones.Add(new Habitacion(1, 01, "Disponible"));
            ListaHabitaciones.Add(new Habitacion(2, 02, "Ocupada"));
            ListaHabitaciones.Add(new Habitacion(3, 03, "Disponible"));
            ListaHabitaciones.Add(new Habitacion(4,04, "Disponible"));
            ListaHabitaciones.Add(new Habitacion(5, 05, "Ocupada"));

            return ListaHabitaciones;
        }

        static List<Habitacion> Listar(string estado)
        {
            //TODO Falta implementar código - Select a la tabla Habitacion filtrando estado....
            return null;
        }

        static int Insertar(Habitacion habitacion)
        {
            //TODO Falta implementar código - Insert a la tabla Habitacion...
            return 0;
        }

        static int Eliminar(int id)
        {
            //TODO Falta implementar código - Delete en la tabla Habitacion...
            return 0;
        }

        static Habitacion TraerUno(int numero)
        {
            //TODO Falta implementar código - Select a la tabla Habitacion....
            return null;
        }
    }
}
