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
    public partial class MenuGestionMaterias : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public MenuGestionMaterias(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
        }

        private void MenuGestionMaterias_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AltaDeMateriaBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AltaDeMateria(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void BajaDeMateriaBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new BajaDeMateria(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }
    }
}
