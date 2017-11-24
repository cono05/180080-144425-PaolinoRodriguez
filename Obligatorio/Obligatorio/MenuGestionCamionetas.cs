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

namespace Obligatorio
{
    public partial class MenuGestionCamionetas : UserControl
    {
        private ModuloGestionCamioneta moduloCamionetas;
        private static MenuGestionCamionetas instancia;


        public static MenuGestionCamionetas ObtenerInstancia(ModuloGestionCamioneta moduloCamioneta)
        {
            if (instancia == null)
                instancia = new MenuGestionCamionetas(moduloCamioneta);
            return instancia;
        }
        public MenuGestionCamionetas(ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloCamionetas = moduloCamioneta;
            CargarListBoxCamionetas();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarCamionetaBtn_Click(object sender, EventArgs e)
        {
            FormAltaDeCamioneta altaCamioneta = new FormAltaDeCamioneta(moduloCamionetas);
            altaCamioneta.Show();
        }

        private void EliminarCamionetaBtn_Click(object sender, EventArgs e)
        {
            if (moduloCamionetas.ObtenerCamionetas().Count > 0)
            {
                FormBajaCamioneta bajaCamioneta = new FormBajaCamioneta(moduloCamionetas);
                bajaCamioneta.Show();
            }
            else
            {
                MessageBox.Show("No existen camionetas en el sistema", MessageBoxButtons.OK.ToString());
            }
        }

        private void VolverAlMenuBtnClick(object sender, EventArgs e)
        {
            
        }
        private void CargarListBoxCamionetas()
        {
            listBoxCamionetas.DataSource = null;
            listBoxCamionetas.DataSource = moduloCamionetas.ObtenerCamionetas();
        }

        public void CargarListBoxCamionetasPublico()
        {
            listBoxCamionetas.DataSource = null;
            CargarListBoxCamionetas();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void VerCamionetasOrdenadasPorRendimiento_Click(object sender, EventArgs e)
        {

        }
    }
}
