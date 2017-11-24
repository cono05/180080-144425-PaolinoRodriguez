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

namespace Obligatorio.VentanasDeDocente
{
    public partial class FormModificacionDocente : Form
    {
        private ModuloGestionDocente moduloDocentes;
       
        public FormModificacionDocente( ModuloGestionDocente moduloDocente)
        {
            InitializeComponent();
            moduloDocentes = moduloDocente;            
            CargarListBoxDocentes();
        }

        private void CargarListBoxDocentes()
        {
            listBoxDocentes.DataSource = null;
            listBoxDocentes.DataSource = moduloDocentes.ObtenerDocentes();
        }

        private void LimpiarTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }
        private void modificarDocenteBtn_Click(object sender, EventArgs e)
        {
            Docente docenteSeleccionado = (Docente)listBoxDocentes.SelectedItem;
            if (docenteSeleccionado != null)
            {
                try
                {
                    Docente aux = Docente.CrearDocente();
                    aux.Nombre = textBoxNombre.Text;
                    aux.Apellido = textBoxApellido.Text;
                    aux.Cedula = textBoxCedula.Text;
                    if (!SonIguales(docenteSeleccionado, aux))
                    {
                        string datosAntesCambio = string.Format("Datos previos: {0} {1} CI {2}",
                        docenteSeleccionado.Nombre, docenteSeleccionado.Apellido, docenteSeleccionado.Cedula);
                        moduloDocentes.ModificarDocente(ref docenteSeleccionado, aux);

                        docenteSeleccionado = moduloDocentes.ObtenerDocentePorID(docenteSeleccionado.Id);

                        string datosDespuesCambio = string.Format("Datos actuales: {0} {1} CI {2}",
                            docenteSeleccionado.Nombre, docenteSeleccionado.Apellido, docenteSeleccionado.Cedula);
                        string mensaje = string.Format("¡Modificación exitosa! \n" + datosAntesCambio + "\n" + datosDespuesCambio);
                        MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                        LimpiarTextBoxs();
                        CargarListBoxDocentes();
                        ActualizarListaDocentesEnMenuGestionDocentes();
                    }
                }
                catch (ExcepcionExisteDocenteConMismaCedula ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ExcepcionDocenteSinNombre ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ExcepcionDocenteSinApellido ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ExcepcionDocenteSinCedula ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ExcepcionFormatoCedulaIncorrecto ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool SonIguales(Docente d1, Docente d2)
        {
            return d1.Nombre.Equals(d2.Nombre) && d1.Apellido.Equals(d2.Apellido)
                    && d1.Cedula.Equals(d2.Cedula);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listBoxDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Docente docenteSeleccionado = (Docente)listBoxDocentes.SelectedItem;
            if (docenteSeleccionado != null)
            {
                textBoxNombre.Text = docenteSeleccionado.Nombre;
                textBoxApellido.Text = docenteSeleccionado.Apellido;
                textBoxCedula.Text = docenteSeleccionado.Cedula;
            }
        }

        private void ActualizarListaDocentesEnMenuGestionDocentes()
        {
            MenuGestionDocente menuDocentes = MenuGestionDocente.ObtenerInstancia(moduloDocentes);
            menuDocentes.CargarListBoxDocentesPublico();
        }
    }
}
