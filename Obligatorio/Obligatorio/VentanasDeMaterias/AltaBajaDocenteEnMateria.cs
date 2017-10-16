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
namespace Obligatorio.VentanasDeMaterias
{
    public partial class AltaBajaDocenteEnMateria : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        public AltaBajaDocenteEnMateria(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            MateriasListBox.DataSource = null;
            MateriasListBox.DataSource = CargarListBoxMaterias();
        }
        public ICollection<Materia> CargarListBoxMaterias()
        {
            ICollection<Materia> lista = new List<Materia>();
            foreach (Materia materia in moduloMaterias.ObtenerMaterias())
            {
                lista.Add(materia);
            }
            return lista;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MateriasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)MateriasListBox.SelectedItem;
            DocentesNoDictanListBox.DataSource = null;
            DocentesQueDictanListBox.DataSource = null;
            ICollection<Alumno> listaQueNoCursan = CargarListBoxDocentesNoDictan(materia);
            ICollection<Alumno> listaQueCursan = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
            if (listaQueNoCursan.Count > 0)
            {
                AlumnosNoCursanListBox.DataSource = listaQueNoCursan;
            }
            if (listaQueCursan.Count > 0)
            {
                AlumnosInscriptosListBox.DataSource = listaQueCursan;
            }
            AlumnosInscriptosListBox.SetSelected(0, false);
            AlumnosNoCursanListBox.SetSelected(0, false);
        }

        public ICollection<Docente> CargarListBoxDocentesNoDictan(Materia materia)
        {
            ICollection<Docente> lista = new List<Docente>();
            //foreach (Alumno a in moduloMaterias.obtener())
            //{
            //    if (!moduloMaterias.EstaInscriptoEnLaMateria(materia, a))
            //    {
            //        lista.Add(a);
            //    }
            //}
            return lista;
        }
    }
}
