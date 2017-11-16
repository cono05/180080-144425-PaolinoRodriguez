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
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public MenuGestionCamionetas(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente,
            ref ModuloGestionMaterias moduloMateria, ref ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarCamionetaBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AltaDeCamioneta(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void EliminarCamionetaBtn_Click(object sender, EventArgs e)
        {
            if (moduloCamionetas.ObtenerCamionetas().Count > 0)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new BajaDeCamioneta(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
            }
            else
            {
                MessageBox.Show("No existen camionetas en el sistema", MessageBoxButtons.OK.ToString());
            }
        }

        private void VolverAlMenuBtnClick(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }
    }
}
