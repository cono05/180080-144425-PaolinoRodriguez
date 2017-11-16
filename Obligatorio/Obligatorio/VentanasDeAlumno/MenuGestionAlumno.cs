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
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void AltaAlumnoBtn_Click(object sender, EventArgs e)
        {
            FormAltaAlumno altaAlumno = new FormAltaAlumno(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas);
            altaAlumno.Show();
        }

        private void ModificarAlumnoBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ModificarAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void BajaAlumnoBtn_Click(object sender, EventArgs e)
        {
            FormBajaAlumno bajaAlumno = new FormBajaAlumno(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas);
            bajaAlumno.Show();
            //panel1.Controls.Clear();
            //panel1.Controls.Add(new BajaDeAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private ICollection<Alumno> CargarListBoxAlumnos()
        {
            ICollection<Alumno> lista = new List<Alumno>();
            foreach (Alumno alumno in moduloAlumnos.ObtenerAlumnos())
            {
                lista.Add(alumno);
            }
            return lista;
        }
        public void CargarListBoxAlumnosPublico()
        {
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }

    }
}
