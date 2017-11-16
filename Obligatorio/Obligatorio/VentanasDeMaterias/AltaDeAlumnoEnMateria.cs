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
        private ModuloGestionCamioneta moduloCamionetas;
        public AltaDeAlumnoEnMateria(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente,
            ref ModuloGestionMaterias moduloMateria, ref ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            MateriasListBox.DataSource = null;
            MateriasListBox.DataSource = CargarListBoxMaterias();
            
            AlumnosInscriptosListBox.DataSource = null;
            //AlumnosInscriptosListBox.SetSelected(0,false);
            AlumnosNoCursanListBox.DataSource = null;
            //AlumnosNoCursanListBox.SetSelected(0, false);
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
            //AlumnosInscriptosListBox.SetSelected(0, false);
            //AlumnosNoCursanListBox.SetSelected(0, false);
        }

        public ICollection<Alumno> CargarListBoxAlumnosNoInscriptos(Materia materia)
        {
            ICollection<Alumno> lista = new List<Alumno>();
            foreach (Alumno a in moduloMaterias.ObtenerAlumnos())
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

        private void InscribirAlumnoBtnClick(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = (Alumno)AlumnosNoCursanListBox.SelectedItem;
                Materia materia = (Materia)MateriasListBox.SelectedItem;
                if (alumno != null)
                {
                    moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
                    AlumnosInscriptosListBox.DataSource = null;
                    AlumnosNoCursanListBox.DataSource = null;
                    AlumnosNoCursanListBox.DataSource = CargarListBoxAlumnosNoInscriptos(materia);
                    AlumnosInscriptosListBox.DataSource = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
                    MessageBox.Show("El alumno " + alumno.ToString() + " se ha inscripto correctamente en " + materia.ToString(), MessageBoxButtons.OK.ToString());
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún alumno.", MessageBoxButtons.OK.ToString());
                }
            }
            catch (ExcepcionAlumnoYaCursaLaMateria excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new MenuGestionMaterias(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void DesinscribirAlumnoBtnClick(object sender, EventArgs e)
        {
            try
            {
                Alumno alumnoADesinscribir = (Alumno)AlumnosInscriptosListBox.SelectedItem;
                Materia materia = (Materia)MateriasListBox.SelectedItem;
                if (alumnoADesinscribir != null)
                {
                    moduloMaterias.EliminarAlumnoDeUnaMateria(materia, alumnoADesinscribir);
                    AlumnosInscriptosListBox.DataSource = null;
                    AlumnosNoCursanListBox.DataSource = null;
                    AlumnosNoCursanListBox.DataSource = CargarListBoxAlumnosNoInscriptos(materia);
                    AlumnosInscriptosListBox.DataSource = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
                    MessageBox.Show("El alumno " + alumnoADesinscribir.ToString() + " se ha eliminado correctamente de " + materia.ToString(), MessageBoxButtons.OK.ToString());
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún alumno.", MessageBoxButtons.OK.ToString());
                }
            }
            catch (ExcepcionAlumnoYaCursaLaMateria excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }
    }
}
