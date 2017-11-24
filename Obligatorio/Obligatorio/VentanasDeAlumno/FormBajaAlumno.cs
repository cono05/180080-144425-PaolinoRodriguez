using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Logica;

namespace Obligatorio.VentanasDeAlumno
{
    public partial class FormBajaAlumno : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
       
        public FormBajaAlumno(ModuloGestionAlumno moduloAlumno)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            
            CargarListBoxAlumnos();
        }

        private void CargarListBoxAlumnos()
        {
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = moduloAlumnos.ObtenerAlumnos();
        }

        private void EliminarAlumnoBtn_Click(object sender, EventArgs e)
        {
            Alumno alumno = (Alumno)listBoxAlumnos.SelectedItem;
            if (alumno != null)
            {
                try
                {                    
                    moduloAlumnos.Baja(alumno);                   
                    CargarListBoxAlumnos();
                    string mensaje = string.Format("El alumno {0} {1} CI {2} se ha eliminado correctamente", alumno.Nombre, alumno.Apellido, alumno.Cedula);
                    MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                    ActualizarListaAlumnosEnMenuGestionAlumnos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("Debe seleccionar un alumno de la lista.", MessageBoxButtons.OK.ToString());
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void ActualizarListaAlumnosEnMenuGestionAlumnos()
        {
            MenuGestionAlumno menuAlumnos = MenuGestionAlumno.ObtenerInstancia(moduloAlumnos);
            menuAlumnos.CargarListBoxAlumnosPublico();
        }
    }
}
