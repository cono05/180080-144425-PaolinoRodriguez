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

namespace Obligatorio
{
    public partial class MenuPrincipal : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public MenuPrincipal( ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
            ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;            
        }

        private void GestionarMateriasBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionMaterias( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionarDocentesBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();            
            panel1.Controls.Add(new MenuGestionDocente( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));
        }

        private void buttonGestionarAlumno_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int i = panel1.Controls.Count;
            panel1.Controls.Add(new VentanasDeAlumno.MenuGestionAlumno( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));            
        }

        private void GestionarCamionetasBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionCamionetas( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));
        }
       
    }
}
