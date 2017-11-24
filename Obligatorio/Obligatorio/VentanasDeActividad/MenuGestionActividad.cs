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

namespace Obligatorio.VentanasDeActividad
{
    public partial class MenuGestionActividad : UserControl
    {
        private ModuloGestionActividad moduloActividades;

        private static MenuGestionActividad instancia;
        public static MenuGestionActividad ObtenerInstancia(ModuloGestionActividad moduloActividad)
        {
            if (instancia == null)
                instancia = new MenuGestionActividad(moduloActividad); 
            return instancia;
        }

        private MenuGestionActividad(ModuloGestionActividad moduloActividad)
        {
            InitializeComponent();            
            moduloActividades = moduloActividad;            
            CargarListBoxActividad();
        }

        private bool HayParaCargarLista(ModuloGestionActividad modulo)
        {
            return modulo.ObtenerActividades().Count > 0;
        }

        private void CargarListBoxActividad()
        {
            listBoxActividad.DataSource = null;
            listBoxActividad.DataSource = moduloActividades.ObtenerActividades();
            
        }
        public void CargarListBoxActividadesPublico()
        {
            CargarListBoxActividad();
        }

        private void AltaActividadBtn_Click(object sender, EventArgs e)
        {  
            FormAltaActividad altaActividad = new FormAltaActividad(moduloActividades);
            altaActividad.Show();
        }

        private void BajaActividadBtn_Click(object sender, EventArgs e)
        {   
            FormBajaActividad bajaActividad = new FormBajaActividad(moduloActividades);
            bajaActividad.Show();
        }

        private void ModificarActividadBtn_Click(object sender, EventArgs e)
        {   
            FormModificarActividad modificarActividad = new FormModificarActividad(moduloActividades);
            modificarActividad.Show();
        }
    }
}
