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
using Logica;
using Excepciones;
using Obligatorio.VentanasDeDocente;

namespace Obligatorio
{
    public partial class MenuGestionDocente : UserControl
    {        
        private ModuloGestionDocente moduloDocentes;
        private static MenuGestionDocente instancia;

        public static MenuGestionDocente ObtenerInstancia(ModuloGestionDocente moduloDocente)
        {
            if (instancia == null)
                instancia = new MenuGestionDocente(moduloDocente);
            return instancia;
        }

        private MenuGestionDocente(ModuloGestionDocente moduloDocente)
        {
            InitializeComponent();            
            moduloDocentes = moduloDocente;  
            CargarListBoxDocentes();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
        }

        private void AltaDocenteBtn_Click(object sender, EventArgs e)
        {
            FormAltaDocente altaDocente = new FormAltaDocente(moduloDocentes);
            altaDocente.Show();
        }

        private void ModificarDocenteBtn_Click(object sender, EventArgs e)
        {
            FormModificacionDocente modificarDocente = new FormModificacionDocente(moduloDocentes);
            modificarDocente.Show();
        }

        private void BajaDocenteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarListBoxDocentes()
        {
            listBoxDocentes.DataSource = null;
            listBoxDocentes.DataSource = moduloDocentes.ObtenerDocentes();            
        }

        public void CargarListBoxDocentesPublico()
        {
            listBoxDocentes.DataSource = null;
            CargarListBoxDocentes();
        }
    }
}
