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

namespace Obligatorio
{
    public partial class AltaDeCamioneta : UserControl
    {
        public AltaDeCamioneta()
        {
            InitializeComponent();
        }

        private void AgregarCamionetaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Camioneta camioneta = Camioneta.CrearCamioneta();
                camioneta.Marca = this.MarcaTextBox.Text;
                camioneta.Chapa = ChapaTextBox.Text;
                camioneta.Capacidad = Int32.Parse(CapacidadTextBox.Text);
                //moduloMaterias.Alta(materia);
                //MessageBox.Show("La materia: " + materia.Nombre + ". Codigo: " + materia.Codigo + " se ha agregado correctamente", MessageBoxButtons.OK.ToString());
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
