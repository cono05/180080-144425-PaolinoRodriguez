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

namespace Obligatorio.VentanasDeActividad
{
    public partial class FormModificarActividad : Form
    {
        //private ModuloGestionAlumno moduloAlumnos;
        //private ModuloGestionDocente moduloDocentes;
        //private ModuloGestionMaterias moduloMaterias;
        //private ModuloGestionCamioneta moduloCamionetas;
        private ModuloGestionActividad moduloActividades;
        // ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente, ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta, 
        public FormModificarActividad(ModuloGestionActividad moduloActividad)
        {
            InitializeComponent();
            //moduloAlumnos = moduloAlumno;
            //moduloDocentes = moduloDocente;
            //moduloMaterias = moduloMateria;
            //moduloCamionetas = moduloCamioneta;
            moduloActividades = moduloActividad;

            listBoxActividad.DataSource = null;
            listBoxActividad.DataSource = CargarListBoxActividad();
        }

        private ICollection<Actividad> CargarListBoxActividad()
        {
            listBoxActividad.DataSource = null;
            ICollection<Actividad> lista = moduloActividades.ObtenerActividades();
            return lista;
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool SonIguales(Actividad actividad1, Actividad actividad2)
        {
            return actividad1.Nombre.Equals(actividad2.Nombre) && actividad1.Costo == actividad2.Costo && actividad1.Fecha.CompareTo(actividad2.Fecha) != 0;
        }

        private void LimpiarTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void ModificarActividadBtn_Click(object sender, EventArgs e)
        {
            Actividad actividadSeleccionada = (Actividad)listBoxActividad.SelectedItem;
            if(actividadSeleccionada != null)
            {
                try
                {
                    Actividad aux = Actividad.CrearActividad();
                    aux.Nombre = textBoxNombre.Text;
                    decimal salida;
                    decimal.TryParse(textBoxCosto.Text, out salida);
                    aux.Costo = salida;
                    aux.Fecha = fechaPicker.Value;

                    if(!SonIguales(actividadSeleccionada, aux))
                    {
                        string datosAntesCambio = string.Format("Datos previos: {0} costo {1} fecha {2}",
                            actividadSeleccionada.Nombre, actividadSeleccionada.Costo.ToString(), actividadSeleccionada.Fecha.ToString());

                        moduloActividades.ModificarActividad(ref actividadSeleccionada, aux);

                        string datosDespuesCambio = string.Format("Datos previos: {0} costo {1} fecha {2}",
                            actividadSeleccionada.Nombre, actividadSeleccionada.Costo.ToString(), actividadSeleccionada.Fecha.ToString());

                        string mensaje = string.Format("¡Modificación exitosa!\n" + datosAntesCambio + "\n" + datosDespuesCambio);
                        MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                        LimpiarTextBoxs();
                        CargarListBoxActividad();
                        ActualizarListaActividadesEnMenuGestionActividades();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ActualizarListaActividadesEnMenuGestionActividades()
        {   // moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, 
            MenuGestionActividad menuActividad = MenuGestionActividad.ObtenerInstancia(moduloActividades);
            menuActividad.CargarListBoxActividadesPublico();
        }
    }
}
