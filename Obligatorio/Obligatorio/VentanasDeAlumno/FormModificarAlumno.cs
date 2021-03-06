﻿using System;
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
    public partial class FormModificarAlumno : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        
        public FormModificarAlumno(ModuloGestionAlumno moduloAlumno)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            
            CargarListBoxAlumnos();
        }

        private void ModificarAlumnoBtn_Click(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)listBoxAlumnos.SelectedItem;
            if (alumnoSeleccionado != null)
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
                        alumnoSeleccionado = moduloAlumnos.ObtenerAlumnoPorId(alumnoSeleccionado.Id);

                        string datosDespuesCambio = string.Format("Datos actuales: {0} {1} CI {2} email {3}",
                            alumnoSeleccionado.Nombre, alumnoSeleccionado.Apellido, alumnoSeleccionado.Cedula, alumnoSeleccionado.Mail);

                        string mensaje = string.Format("¡Modificación exitosa!\n" + datosAntesCambio + "\n" + datosDespuesCambio);
                        MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                        LimpiarTextBoxs();
                        CargarListBoxAlumnos();
                        ActualizarListaAlumnosEnMenuGestionAlumnos();
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
            return a1.Nombre.Equals(a2.Nombre) && a1.Apellido.Equals(a2.Apellido)
                    && a1.Cedula.Equals(a2.Cedula) && a1.Mail.Equals(a2.Mail);
        }

        private void CargarListBoxAlumnos()
        {
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = moduloAlumnos.ObtenerAlumnos();
            
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

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)listBoxAlumnos.SelectedItem;
            if (alumnoSeleccionado != null)
            {
                textBoxNombre.Text = alumnoSeleccionado.Nombre;
                textBoxApellido.Text = alumnoSeleccionado.Apellido;
                textBoxCedula.Text = alumnoSeleccionado.Cedula;
                textBoxEmail.Text = alumnoSeleccionado.Mail;
            }
        }
    }
}
