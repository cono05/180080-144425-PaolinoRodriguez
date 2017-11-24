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

namespace Obligatorio.VentanasDeAlumno
{
    public partial class MenuGestionAlumno : UserControl
    {
       private ModuloGestionAlumno moduloAlumnos;
       private static MenuGestionAlumno instancia;

        public static MenuGestionAlumno ObtenerInstancia(ModuloGestionAlumno moduloAlumno)
        {
            if (instancia == null)
                instancia = new MenuGestionAlumno(moduloAlumno);
            return instancia;
        }

        private MenuGestionAlumno(ModuloGestionAlumno moduloAlumno)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
        
        }

        private void AltaAlumnoBtn_Click(object sender, EventArgs e)
        {
            FormAltaAlumno altaAlumno = new FormAltaAlumno(moduloAlumnos);
        altaAlumno.Show();
        }

        private void ModificarAlumnoBtn_Click(object sender, EventArgs e)
        {
            FormModificarAlumno modificarAlumno = new FormModificarAlumno(moduloAlumnos);
            modificarAlumno.Show();
        }

        private void BajaAlumnoBtn_Click(object sender, EventArgs e)
        {
            FormBajaAlumno bajaAlumno = new FormBajaAlumno(moduloAlumnos);
            bajaAlumno.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private ICollection<Alumno> CargarListBoxAlumnos()
        {
            listBoxAlumnos.DataSource = null;
            ICollection<Alumno> lista = moduloAlumnos.ObtenerAlumnos();
            return lista;
        }
        public void CargarListBoxAlumnosPublico()
        {
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }
    }
}
