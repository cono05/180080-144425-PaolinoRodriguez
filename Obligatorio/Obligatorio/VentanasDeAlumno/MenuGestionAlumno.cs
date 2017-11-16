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

namespace Obligatorio.VentanasDeAlumno
{
    public partial class MenuGestionAlumno : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private static MenuGestionAlumno instancia;

        public static MenuGestionAlumno ObtenerInstancia(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta)
        {
            if (instancia == null)
                instancia = new MenuGestionAlumno(moduloAlumno, moduloDocente, moduloMateria, moduloCamioneta);
            return instancia;
        }

        public MenuGestionAlumno( ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void AltaAlumnoBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AltaDeAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void ModificarAlumnoBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ModificarAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void BajaAlumnoBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new BajaDeAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
