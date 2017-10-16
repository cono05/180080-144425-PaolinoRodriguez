using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Excepciones;
using Dominio;

namespace Obligatorio.VentanasDeAlumno
{
    public partial class AltaDeAlumno : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public AltaDeAlumno(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = Alumno.CrearAlumno();
                alumno.Nombre = textBoxNombre.Text;
                alumno.Apellido = textBoxApellido.Text;
                alumno.Cedula = textBoxCedula.Text;
                alumno.Mail = textBoxEmail.Text;
                moduloAlumnos.Alta(alumno);

                string mensaje = string.Format("El alumno {0} {1} CI {2} se ha agregado correctamente", alumno.Nombre, alumno.Apellido, alumno.Cedula);
                MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                //Para limpiar todos los textboxes
                panel1.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }
    }
}
