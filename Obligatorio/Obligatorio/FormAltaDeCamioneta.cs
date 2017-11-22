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

namespace Obligatorio
{
    public partial class FormAltaDeCamioneta : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public FormAltaDeCamioneta(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
            ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
        }

        private void AgregarCamionetaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Camioneta camioneta = Camioneta.CrearCamioneta();
                camioneta.Marca = this.MarcaTextBox.Text;
                camioneta.Chapa = ChapaTextBox.Text;
                camioneta.Capacidad = Int32.Parse(CapacidadTextBox.Text);
                camioneta.ConsumoCada100Km = Int32.Parse(textBoxConsumo.Text);
                camioneta.RelacionCantAlumnosConsumo = camioneta.Capacidad / camioneta.ConsumoCada100Km;
                moduloCamionetas.Alta(camioneta);
                MessageBox.Show("La camioneta: " + camioneta.ToString() + " se ha agregado correctamente", MessageBoxButtons.OK.ToString());
                LimpiarTextBoxs();
                ActualizarListaCamionetasEnMenuGestionCamionetas();
            }
            catch (ExcepcionCamionetaSinMarca exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ExcepcionCapacidadNoValida exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ExcepcionCamionetaSinChapa exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ExcepcionCamionetaConsumoNoValido exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
            }
        }

        private void LimpiarTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void ActualizarListaCamionetasEnMenuGestionCamionetas()
        {
            MenuGestionCamionetas menuCamionetas = MenuGestionCamionetas.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas);
            menuCamionetas.CargarListBoxCamionetasPublico();
        }
    }
}
