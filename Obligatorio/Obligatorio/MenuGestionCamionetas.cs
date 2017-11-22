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
        private static MenuGestionCamionetas instancia;


        public static MenuGestionCamionetas ObtenerInstancia(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
            ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta)
        {
            if (instancia == null)
                instancia = new MenuGestionCamionetas(moduloAlumno, moduloDocente, moduloMateria, moduloCamioneta);
            return instancia;
        }
        public MenuGestionCamionetas( ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            CargarListBoxCamionetas();
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
            
        }
        private void CargarListBoxCamionetas()
        {
            listBoxCamionetas.DataSource = null;
            listBoxCamionetas.DataSource = moduloCamionetas.ObtenerCamionetas();
        }
    }
}
