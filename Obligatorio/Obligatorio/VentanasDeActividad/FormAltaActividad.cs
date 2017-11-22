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
    public partial class FormAltaActividad : Form
    {

        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private ModuloGestionActividad moduloActividades;

        public FormAltaActividad(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta, ModuloGestionActividad moduloActividad)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            moduloActividades = moduloActividad;

            listBoxActividades.DataSource = null;
            listBoxActividades.DataSource = CargarListBoxActividad();
        }
        private ICollection<Actividad> CargarListBoxActividad()
        {
            listBoxActividades.DataSource = null;
            ICollection<Actividad> lista = moduloActividades.ObtenerActividades();
            return lista;
        }



        private void altaDeActividadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad actividad = Actividad.CrearActividad();
                actividad.Nombre = nombreTextBox.Text;

                decimal costo;
                Decimal.TryParse(costoTextBox.Text, out costo);
                actividad.Costo = costo;
                actividad.Fecha = fechaPicker.Value;
                moduloActividades.Alta(actividad);

                
                string mensaje = string.Format("La actividad {0} se ha agregado correctamente", actividad.Nombre);
                MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                listBoxActividades.DataSource = CargarListBoxActividad();
                
                
                LimpiarTextBoxs();
                ActualizarListaActividadesEnMenuGestionActividades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void ActualizarListaActividadesEnMenuGestionActividades()
        {
            MenuGestionActividad menuActividad = MenuGestionActividad.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, moduloActividades);
            menuActividad.CargarListBoxActividadesPublico();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
