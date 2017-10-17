using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Excepciones;
using Logica;

namespace Obligatorio
{
    public partial class AltaDeCamioneta : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public AltaDeCamioneta(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente,
            ref ModuloGestionMaterias moduloMateria, ref ModuloGestionCamioneta moduloCamioneta)
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
                moduloCamionetas.Alta(camioneta);
                MessageBox.Show("La camioneta: " + camioneta.ToString()+" se ha agregado correctamente", MessageBoxButtons.OK.ToString());
                //textBoxNombre.Clear();
            }
            catch (ExcepcionExisteMateriaConMismoNombre exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ExcepcionMateriaSinNombre exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ExcepcionMateriaCodigoRepetido exception)
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
    }
}
