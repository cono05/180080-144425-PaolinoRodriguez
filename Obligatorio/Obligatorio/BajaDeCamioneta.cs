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
using Obligatorio.VentanasDeAlumno;

namespace Obligatorio
{
    public partial class BajaDeCamioneta : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public BajaDeCamioneta(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente,
            ref ModuloGestionMaterias moduloMateria, ref ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            CamionetasListBox.DataSource = null;
            CamionetasListBox.DataSource = CargarListBoxCamionetas();
        }

        private ICollection<Camioneta> CargarListBoxCamionetas()
        {
            ICollection<Camioneta> lista = new List<Camioneta>();
            foreach (Camioneta camioneta in moduloCamionetas.ObtenerCamionetas())
            {
                lista.Add(camioneta);
            }
            return lista;
        }

        private void EliminarCamionetaClick(object sender, EventArgs e)
        {
            Camioneta camioneta = (Camioneta)CamionetasListBox.SelectedItem;
            if (camioneta != null)
            {
                try
                {
                    moduloCamionetas.Baja(camioneta);
                    CamionetasListBox.DataSource = null;
                    CamionetasListBox.DataSource = CargarListBoxCamionetas();
                    string mensaje = string.Format("La camioneta: " + camioneta.ToString() + " se ha eliminado correctamente");
                    MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());

                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void VolverAlMenuBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }
    }
}
