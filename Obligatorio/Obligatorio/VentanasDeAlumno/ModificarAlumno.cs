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
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }

        public ICollection<Alumno> CargarListBoxAlumnos()
        {
            ICollection<Alumno> lista = new List<Alumno>();
            foreach (Alumno alumno in moduloAlumnos.repositorio.ObtenerAlumnos())
            {
                lista.Add(alumno);
            }
            return lista;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)listBoxAlumnos.SelectedItem;
            try
            {
                Alumno aux = Alumno.ClonarAlumno(alumnoSeleccionado);
                string datos = textBoxNombre.Text + ";" + textBoxApellido.Text + ";" + textBoxCedula.Text + ";" + textBoxEmail.Text;
                moduloAlumnos.ModificarAlumno(alumnoSeleccionado, datos);

                if (!aux.Equals(alumnoSeleccionado))
                {
                    string mensaje = string.Format("\t¡Modificación exitosa! \nDatos previos: {0} {1} CI {2} email {3} \nDatos actuales: " + 
                        "{4} {5} CI {6} email {7}", aux.Nombre, aux.Apellido, aux.Cedula, aux.Mail, alumnoSeleccionado.Nombre, 
                            alumnoSeleccionado.Apellido, alumnoSeleccionado.Cedula, alumnoSeleccionado.Mail);

                    MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                }
                
                //Para limpiar todos los textboxes
                panel1.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                listBoxAlumnos.DataSource = null;
                listBoxAlumnos.DataSource = CargarListBoxAlumnos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)listBoxAlumnos.SelectedItem;
            if(alumnoSeleccionado != null)
            {
                textBoxNombre.Text   = alumnoSeleccionado.Nombre;
                textBoxApellido.Text = alumnoSeleccionado.Apellido;
                textBoxCedula.Text   = alumnoSeleccionado.Cedula;
                textBoxEmail.Text    = alumnoSeleccionado.Mail;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }
    }
}
