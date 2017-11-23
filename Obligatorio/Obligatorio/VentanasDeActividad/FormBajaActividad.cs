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
    public partial class FormBajaActividad : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private ModuloGestionActividad moduloActividades;
        /*ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta, */
        public FormBajaActividad(ModuloGestionActividad moduloActividad)
        {
            InitializeComponent();
            //moduloAlumnos = moduloAlumno;
            //moduloDocentes = moduloDocente;
            //moduloMaterias = moduloMateria;
            //moduloCamionetas = moduloCamioneta;
            moduloActividades = moduloActividad;

            listBoxActividades.DataSource = null;
            listBoxActividades.DataSource = CargarListBoxActividades();
        }

        private ICollection<Actividad> CargarListBoxActividades()
        {
            listBoxActividades.DataSource = null;
            ICollection<Actividad> lista = moduloActividades.ObtenerActividades();
            return lista;
        }

        private void eliminarActividadBtn_Click(object sender, EventArgs e)
        {
            Actividad actividad = (Actividad)listBoxActividades.SelectedItem;
            if (actividad != null)
            {
                try
                {
                    moduloActividades.Baja(actividad);
                    listBoxActividades.DataSource = null;
                    listBoxActividades.DataSource = CargarListBoxActividades();
                    string mensaje = string.Format("Actividad {0} eliminada correctamente", actividad.Nombre);
                    MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                    ActualizarListaActividadesEnMenuGestionActividades();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una actividad de la lista.", MessageBoxButtons.OK.ToString());
            }
        }
        private void ActualizarListaActividadesEnMenuGestionActividades()
        {
            MenuGestionActividad menuActividad = MenuGestionActividad.ObtenerInstancia(moduloActividades);
            menuActividad.CargarListBoxActividadesPublico();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
