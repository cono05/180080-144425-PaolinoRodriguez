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
using Excepciones;
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
            ICollection<Docente> listaQueNoDictanLaMateria = CargarListBoxDocentesNoDictan(materia);
            ICollection<Docente> listaQueDictanLaMateria = CargarListBoxDocentesDictanMateria(materia);
            if (listaQueNoDictanLaMateria.Count > 0)
            {
                DocentesNoDictanListBox.DataSource = listaQueNoDictanLaMateria;
                DocentesNoDictanListBox.SetSelected(0, false);
            }
            if (listaQueDictanLaMateria.Count > 0)
            {
                DocentesQueDictanListBox.DataSource = listaQueDictanLaMateria;
                DocentesQueDictanListBox.SetSelected(0, false);
            }
            
            
        }

        public ICollection<Docente> CargarListBoxDocentesNoDictan(Materia materia)
        {
            ICollection<Docente> lista = new List<Docente>();
            foreach (Docente d in moduloDocentes.ObtenerDocentes())
            {
                if (!moduloDocentes.EstaInscritoEnLaMateria(d, materia))
                {
                    lista.Add(d);
                }
            }
            return lista;
        }

        public ICollection<Docente> CargarListBoxDocentesDictanMateria(Materia materia)
        {
            ICollection<Docente> lista = new List<Docente>();
            foreach (Docente d in moduloDocentes.ObtenerDocentes())
            {
                if (moduloDocentes.EstaInscritoEnLaMateria(d, materia))
                {
                    lista.Add(d);
                }
            }
            return lista;
        }

        private void AsignarDocenteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Docente docente = (Docente)DocentesNoDictanListBox.SelectedItem;
                Materia materia = (Materia)MateriasListBox.SelectedItem;
                if (docente != null)
                {
                    moduloDocentes.InscribirDocenteEnMateria(docente, materia);
                    DocentesQueDictanListBox.DataSource = null;
                    DocentesNoDictanListBox.DataSource = null;
                    DocentesNoDictanListBox.DataSource = CargarListBoxDocentesNoDictan(materia);
                    DocentesQueDictanListBox.DataSource = CargarListBoxDocentesDictanMateria(materia);
                    MessageBox.Show("El Docente " + docente.ToString() + " se ha asignado correctamente en " + materia.ToString(), MessageBoxButtons.OK.ToString());
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún alumno.", MessageBoxButtons.OK.ToString());
                }
            }
            catch (ExcepcionDocenteYaDictaEstaMateria excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            finally
            {

            }
        }

        private void QuitarDocenteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Docente DocenteADesinscribir = (Docente)DocentesQueDictanListBox.SelectedItem;
                Materia materia = (Materia)MateriasListBox.SelectedItem;
                if (DocenteADesinscribir != null)
                {
                    moduloDocentes.DesinscribirDocenteEnMateria(DocenteADesinscribir, materia);
                    DocentesQueDictanListBox.DataSource = null;
                    DocentesNoDictanListBox.DataSource = null;
                    DocentesNoDictanListBox.DataSource = CargarListBoxDocentesNoDictan(materia);
                    DocentesQueDictanListBox.DataSource = CargarListBoxDocentesDictanMateria(materia);
                    MessageBox.Show("El Docente " + DocenteADesinscribir.ToString() + " se ha eliminado correctamente de " + materia.ToString(), MessageBoxButtons.OK.ToString());
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún Docente.", MessageBoxButtons.OK.ToString());
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
         }

        private void VolverAlMenuBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionMaterias(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }
    }
}
