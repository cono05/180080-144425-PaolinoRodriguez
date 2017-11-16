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
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public FormAltaAlumno(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }
        private ICollection<Alumno> CargarListBoxAlumnos()
        {
            ICollection<Alumno> lista = new List<Alumno>();
            foreach (Alumno alumno in moduloAlumnos.ObtenerAlumnos())
            {
                lista.Add(alumno);
            }
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
                //Para limpiar todos los textboxes
                Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                listBoxAlumnos.DataSource = CargarListBoxAlumnos();
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
    }
}
