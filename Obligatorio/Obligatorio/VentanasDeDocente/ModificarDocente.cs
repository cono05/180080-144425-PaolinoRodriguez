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

namespace Obligatorio.VentanasDeDocente
{
    public partial class ModificarDocente : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public ModificarDocente(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            listBoxDocentes.DataSource = null;
            listBoxDocentes.DataSource = CargarListBoxDocentes();
        }

        private ICollection<Docente> CargarListBoxDocentes()
        {
            ICollection<Docente> lista = new List<Docente>();
            foreach (Docente docente in moduloDocentes.ObtenerDocentes())
            {
                lista.Add(docente);
            }
            return lista;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionDocente(ref moduloAlumnos, ref docenteSeleccionadomoduloDocentes, ref moduloMaterias));
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Docente docenteSeleccionado = (Docente)listBoxDocentes.SelectedItem;
            if(docenteSeleccionado != null)
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
                        string datosDespuesCambio = string.Format("Datos actuales: {0} {1} CI {2}",
                            docenteSeleccionado.Nombre, docenteSeleccionado.Apellido, docenteSeleccionado.Cedula);

                        string mensaje = string.Format("¡Modificación exitosa! \n" + datosAntesCambio + "\n" + datosDespuesCambio);
                        MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                        //Para limpiar todos los textboxes
                        panel1.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                        listBoxDocentes.DataSource = null;
                        listBoxDocentes.DataSource = CargarListBoxDocentes();
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
    }
}

