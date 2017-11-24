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

namespace Obligatorio
{
    public partial class FormBajaCamioneta : Form
    {        
        private ModuloGestionCamioneta moduloCamionetas;
        public FormBajaCamioneta(ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();            
            moduloCamionetas = moduloCamioneta;
            CargarListBoxCamionetas();
        }

        private void VolverAlMenuBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void EliminarCamioneta_Click(object sender, EventArgs e)
        {
            Camioneta camioneta = (Camioneta)listBoxCamionetas.SelectedItem;
            if (camioneta != null)
            {
                try
                {
                    moduloCamionetas.Baja(camioneta);
                    CargarListBoxCamionetas();
                    string mensaje = string.Format("La camioneta: " + camioneta.ToString() + " se ha eliminado correctamente");
                    MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                    ActualizarListaCamionetasEnMenuGestionCamionetas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CargarListBoxCamionetas()
        {
            listBoxCamionetas.DataSource = null;
            listBoxCamionetas.DataSource = moduloCamionetas.ObtenerCamionetas();
        }

        private void ActualizarListaCamionetasEnMenuGestionCamionetas()
        {
            MenuGestionCamionetas menuCamionetas = MenuGestionCamionetas.ObtenerInstancia(moduloCamionetas);
            menuCamionetas.CargarListBoxCamionetasPublico();
        }
    }
}
