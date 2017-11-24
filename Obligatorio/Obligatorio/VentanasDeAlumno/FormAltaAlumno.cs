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
using Excepciones;
using Logica;

namespace Obligatorio.VentanasDeAlumno
{
    public partial class FormAltaAlumno : Form
    {
        
        private ModuloGestionAlumno moduloAlumnos;
        
        
        public FormAltaAlumno(ModuloGestionAlumno moduloAlumno)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }
        private ICollection<Alumno> CargarListBoxAlumnos()
        {
            listBoxAlumnos.DataSource = null;
            ICollection<Alumno> lista = moduloAlumnos.ObtenerAlumnos();
            return lista;
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void altaDeAlumnoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = Alumno.CrearAlumno();
                alumno.Nombre = nombreTextBox.Text;
                alumno.Apellido = apellidoTextBox.Text;
                alumno.Cedula = cedulaTextBox.Text;
                alumno.Mail = emailTextBox.Text;
                moduloAlumnos.Alta(alumno);
                string mensaje = string.Format("El alumno {0} {1} CI {2} se ha agregado correctamente", alumno.Nombre, alumno.Apellido, alumno.Cedula);
                MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                listBoxAlumnos.DataSource = CargarListBoxAlumnos();
                LimpiarTextBoxs();
                ActualizarListaAlumnosEnMenuGestionAlumnos();
            }
            catch (ExcepcionAlumnoSinNombre ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionAlumnoSinApellido ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionAlumnoSinCedula ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionFormatoCedulaIncorrecto ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionExisteAlumnoConMismaCedula ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionAlumnoSinEmail ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }
        private void ActualizarListaAlumnosEnMenuGestionAlumnos()
        {
            MenuGestionAlumno menuAlumnos = MenuGestionAlumno.ObtenerInstancia(moduloAlumnos);
            menuAlumnos.CargarListBoxAlumnosPublico();
        }       
    }
}
