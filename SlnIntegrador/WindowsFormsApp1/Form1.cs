using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Datos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarMedicos()
        {
            gridMedicos.DataSource = AdmMedico.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridMedicos.DataSource = AdmMedico.Listar();

            gridPacientes.DataSource = AdmPaciente.Listar();

        }

        private void btn_medicoEspecialidad_Click(object sender, EventArgs e)
        {

            List<Medico> ListaMedico = new List<Medico>();

            ListaMedico.Add(new Medico("Juan", "Perez", "Calle 123", "123456", "juan@hotmail", "Clinico", 1562));
            ListaMedico.Add(new Medico("Sofia", "Perez", "Calle 123", "123456", "sofia@hotmail", "Clinico", 1586));
            ListaMedico.Add(new Medico("Ana", "Perez", "Calle 123", "123456", "ana@hotmail", "Pediatra", 8952));
            ListaMedico.Add(new Medico("Pedro", "Santos", "Calle 123", "123456", "pedro@hotmail", "Traumatologo", 1562));
            ListaMedico.Add(new Medico("Andres", "Ramos", "Calle 123", "123456", "andres@hotmail", "Traumatologo", 6523));

            int Contador = 0;

            for (int i = 0; i < ListaMedico.Count; i++)
            {
                if (ListaMedico[i].Especialidad == "Clinico")
                {
                    medicosEspecialidad.Items.Add(ListaMedico[i].Nombre + " " + ListaMedico[i].Apellido);
                    Contador++;
                }
            }

            lbl_cantMedicos.Text= "Nro de Médicos Clínicos: " + Contador.ToString();


        }

        private void btn_estadoHabitaciones_Click(object sender, EventArgs e)
        {
            List<Habitacion> ListaHabitaciones = new List<Habitacion>();

            ListaHabitaciones.Add(new Habitacion(1, 01, "Disponible"));
            ListaHabitaciones.Add(new Habitacion(2, 02, "Ocupada"));
            ListaHabitaciones.Add(new Habitacion(3, 03, "Disponible"));
            ListaHabitaciones.Add(new Habitacion(4, 04, "Disponible"));
            ListaHabitaciones.Add(new Habitacion(5, 05, "Ocupada"));

            for (int i = 0; i < ListaHabitaciones.Count; i++)
            {

                estadoHabitaciones.Items.Add("Habitación nro: " + ListaHabitaciones[i].Número + ". " + ListaHabitaciones[i].Estado);

            }

        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico("Flor", "Sanchez", "Calle 123", "4654656", "flor@hotmail.com", "Pediatra", 6546);

            int filasAfectadas = AdmMedico.Insertar(medico);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Ok");
                MostrarMedicos();

            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                Medico medico = AdmMedico.TraerUno(id);
                if (medico != null)
                {
                    medico.Nombre = "jorge";
                    int filasAfectadas = AdmMedico.Eliminar(medico.Id);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Ok");
                        MostrarMedicos();
                    }
                }
            }
        }

        private void btn_traerUno_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);

                Medico medico = AdmMedico.TraerUno(id);
                MessageBox.Show(medico.Nombre);
            }
        }
    }
}
