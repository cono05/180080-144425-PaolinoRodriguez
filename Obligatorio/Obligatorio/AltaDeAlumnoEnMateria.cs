using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Logica;
using Excepciones;

namespace Obligatorio
{
    public partial class AltaDeAlumnoEnMateria : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        public AltaDeAlumnoEnMateria(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
        }

        private void MateriasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)MateriasListBox.SelectedItem;
            AlumnosNoCursanListBox.DataSource = null;
            AlumnosInscriptosListBox.DataSource = null;
            ICollection<Alumno> listaQueNoCursan = CargarListBoxAlumnosNoInscriptos(materia);
            ICollection<Alumno> listaQueCursan = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
            if (listaQueNoCursan.Count > 0)
            {
                AlumnosNoCursanListBox.DataSource = listaQueNoCursan;
            }
            if (listaQueCursan.Count > 0)
            {
                AlumnosInscriptosListBox.DataSource = listaQueCursan;
            }            
        }

        public ICollection<Alumno> CargarListBoxAlumnosNoInscriptos(Materia materia)
        {
            ICollection<Alumno> lista = new List<Alumno>();
            foreach (Alumno a in materia.Alumnos)
            {
                if (!moduloMaterias.EstaInscriptoEnLaMateria(materia, a))
                {
                    lista.Add(a);
                }
            }
            return lista;
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
    }
}
