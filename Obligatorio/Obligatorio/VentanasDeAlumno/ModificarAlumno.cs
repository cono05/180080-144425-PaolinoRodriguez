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
using Dominio;
using Excepciones;

namespace Obligatorio.VentanasDeAlumno
{
    public partial class ModificarAlumno : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public ModificarAlumno(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            ListBoxAlumnos.DataSource = null;
            ListBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }

        private ICollection<Alumno> CargarListBoxAlumnos()
        {
            ICollection<Alumno> lista = new List<Alumno>();
            foreach (Alumno alumno in moduloAlumnos.repositorio.ObtenerAlumnos())
            {
                lista.Add(alumno);
            }
            return lista;
        }

        private void ModificarDocenteBtn_Click(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)ListBoxAlumnos.SelectedItem;
            if(alumnoSeleccionado != null)
            {
                try
                {
                    Alumno aux = Alumno.CrearAlumno();
                    aux.Nombre = textBoxNombre.Text;
                    aux.Apellido = textBoxApellido.Text;
                    aux.Cedula = textBoxCedula.Text;
                    aux.Mail = textBoxEmail.Text;

                    if (!SonIguales(alumnoSeleccionado, aux))
                    {
                        string datosAntesCambio = string.Format("Datos previos: {0} {1} CI {2} email {3}",
                            alumnoSeleccionado.Nombre, alumnoSeleccionado.Apellido, alumnoSeleccionado.Cedula, alumnoSeleccionado.Mail);
                        moduloAlumnos.ModificarAlumno(ref alumnoSeleccionado, aux);
                        string datosDespuesCambio = string.Format("Datos actuales: {0} {1} CI {2} email {3}",
                            alumnoSeleccionado.Nombre, alumnoSeleccionado.Apellido, alumnoSeleccionado.Cedula, alumnoSeleccionado.Mail);

                        string mensaje = string.Format("¡Modificación exitosa!\n" + datosAntesCambio + "\n" + datosDespuesCambio);
                        MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                        //Para limpiar todos los textboxes
                        panel1.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                        ListBoxAlumnos.DataSource = null;
                        ListBoxAlumnos.DataSource = CargarListBoxAlumnos();
                    }
                }
                catch (ExcepcionExisteAlumnoConMismaCedula ex)
                {
                    MessageBox.Show(ex.Message);
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
                catch (ExcepcionAlumnoSinEmail ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ExcepcionFormatoCedulaIncorrecto ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ExcepcionExisteAlumnoConMismoEmail ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool SonIguales(Alumno a1, Alumno a2)
        {
            return  a1.Nombre.Equals(a2.Nombre) && a1.Apellido.Equals(a2.Apellido) 
                    && a1.Cedula.Equals(a2.Cedula) && a1.Mail.Equals(a2.Mail);
        }

        private void ListBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)ListBoxAlumnos.SelectedItem;
            if(alumnoSeleccionado != null)
            {
                textBoxNombre.Text   = alumnoSeleccionado.Nombre;
                textBoxApellido.Text = alumnoSeleccionado.Apellido;
                textBoxCedula.Text   = alumnoSeleccionado.Cedula;
                textBoxEmail.Text    = alumnoSeleccionado.Mail;
            }
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }
    }
}
