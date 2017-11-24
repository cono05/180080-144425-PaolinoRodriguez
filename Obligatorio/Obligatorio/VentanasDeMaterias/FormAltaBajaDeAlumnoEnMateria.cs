using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Excepciones;
using Logica;

namespace Obligatorio.VentanasDeMaterias
{
    public partial class FormAltaBajaDeAlumnoEnMateria : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public FormAltaBajaDeAlumnoEnMateria(ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloMaterias = moduloMateria;
            CargarListBoxMaterias();
        }
        private void CargarListBoxMaterias()
        {
            listBoxMaterias.DataSource = null;
            listBoxMaterias.DataSource = moduloMaterias.ObtenerMaterias();
        }

        private void InscribirAlumnoEnMateriaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = (Alumno)alumnosNoCursanListBox.SelectedItem;
                Materia materia = (Materia)listBoxMaterias.SelectedItem;
                if (alumno != null)
                {
                    moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
                    alumnosNoCursanListBox.DataSource = null;
                    //alumnosNoCursanListBox.DataSource = null;
                    alumnosNoCursanListBox.DataSource = CargarListBoxAlumnosNoInscriptos(materia);
                   // alumnosInscriptosListBox.DataSource = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
                    CargarListBoxAlumnosInscriptosEnMateria(materia);
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

        private void salir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void desinscribirAlumnoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumnoADesinscribir = (Alumno)alumnosInscriptosListBox.SelectedItem;
                Materia materia = (Materia)listBoxMaterias.SelectedItem;
                if (alumnoADesinscribir != null)
                {
                    moduloMaterias.EliminarAlumnoDeUnaMateria(materia, alumnoADesinscribir);
                    alumnosInscriptosListBox.DataSource = null;
                    alumnosInscriptosListBox.DataSource = null;
                    alumnosNoCursanListBox.DataSource = CargarListBoxAlumnosNoInscriptos(materia);
                    alumnosInscriptosListBox.DataSource = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
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

        private void listBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)listBoxMaterias.SelectedItem;
            alumnosNoCursanListBox.DataSource = null;
            alumnosInscriptosListBox.DataSource = null;
            ICollection<Alumno> listaQueNoCursan = CargarListBoxAlumnosNoInscriptos(materia);
            ICollection<Alumno> listaQueCursan = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
            if (listaQueNoCursan.Count > 0)
            {
                alumnosNoCursanListBox.DataSource = listaQueNoCursan;
            }
            if (listaQueCursan.Count > 0)
            {
                alumnosInscriptosListBox.DataSource = listaQueCursan;
            }            
        }

        private void CargarListBoxAlumnosInscriptosEnMateria(Materia materia)
        {
            alumnosInscriptosListBox.DataSource = null;
            alumnosInscriptosListBox.DataSource = moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia);
        }
    }
}
