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
    public partial class FormAltaBajaDocenteEnMateria : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public FormAltaBajaDocenteEnMateria(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
            ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            CargarListBoxMaterias();
        }

        private void CargarListBoxMaterias()
        {
            listBoxMaterias.DataSource = null;
            listBoxMaterias.DataSource = moduloMaterias.ObtenerMaterias();
        }

        private void AsignarDocenteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Docente docente = (Docente)docentesNoDictanListBox.SelectedItem;
                Materia materia = (Materia)listBoxMaterias.SelectedItem;
                if (docente != null)
                {
                    moduloDocentes.InscribirDocenteEnMateria(docente, materia);
                    docentesDictanListBox.DataSource = null;
                    docentesNoDictanListBox.DataSource = null;
                    CargarListBoxDocentesNoDictan(materia);
                    CargarListBoxDocentesDictanMateria(materia);
                    MessageBox.Show("El docente " + docente.ToString() + " se ha asignado correctamente en " + materia.ToString(), MessageBoxButtons.OK.ToString());
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún docente.", MessageBoxButtons.OK.ToString());
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
        }

        private void listBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)listBoxMaterias.SelectedItem;
            CargarListBoxDocentesDictanMateria(materia);
            CargarListBoxDocentesNoDictan(materia);
        }
        public void CargarListBoxDocentesNoDictan(Materia materia)
        {
            docentesNoDictanListBox.DataSource = null;
            ICollection<Docente> lista = new List<Docente>();
            foreach (Docente d in moduloDocentes.ObtenerDocentes())
            {
                if (!moduloDocentes.EstaInscritoEnLaMateria(d, materia))
                {
                    lista.Add(d);
                }
            }
            docentesNoDictanListBox.DataSource = lista;
        }
        public void /*ICollection<Docente>*/ CargarListBoxDocentesDictanMateria(Materia materia)
        {
            docentesDictanListBox.DataSource = null;
            docentesDictanListBox.DataSource = moduloMaterias.ObtenerDocentesDeUnaMateria(materia);
            //ICollection<Docente> lista = new List<Docente>();
            //foreach (Docente d in moduloDocentes.ObtenerDocentes())
            //{
            //    if (moduloDocentes.EstaInscritoEnLaMateria(d, materia))
            //    {
            //        lista.Add(d);
            //    }
            //}
            //return lista;
        }

        private void VolverAlMenuBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void QuitarDocenteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Docente DocenteADesinscribir = (Docente)docentesDictanListBox.SelectedItem;
                Materia materia = (Materia)listBoxMaterias.SelectedItem;
                if (DocenteADesinscribir != null)
                {
                    moduloDocentes.DesinscribirDocenteEnMateria(DocenteADesinscribir, materia);
                    //docentesDictanListBox.DataSource = null;
                    //docentesNoDictanListBox.DataSource = null;
                    CargarListBoxDocentesNoDictan(materia);
                    CargarListBoxDocentesDictanMateria(materia);
                    MessageBox.Show("El docente " + DocenteADesinscribir.ToString() + " se ha eliminado correctamente de " + materia.ToString(), MessageBoxButtons.OK.ToString());
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún docente.", MessageBoxButtons.OK.ToString());
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }
    }
}
