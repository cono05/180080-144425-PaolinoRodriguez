using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using Logica;
namespace Obligatorio
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionAlumno moduloGestionAlumnos = new ModuloGestionAlumno(repositorio);
            ModuloGestionDocente moduloGestionDocentes = new ModuloGestionDocente(repositorio);
            ModuloGestionMaterias moduloGestionMaterias = new ModuloGestionMaterias(ref repositorio);
        }

        private void CargarPanelPrincipal(ref ModuloGestionAlumno modulosGestionAlumno, ref ModuloGestionDocente moduloGestionDocente,
                                            ref ModuloGestionMaterias moduloGestionMaterias)
        {
            panelPrincipal.Controls.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
