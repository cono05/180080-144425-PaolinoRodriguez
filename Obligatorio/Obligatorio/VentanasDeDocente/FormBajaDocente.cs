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

namespace Obligatorio.VentanasDeDocente
{
    public partial class FormBajaDocente : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private ContenedorModulos contenedorModulos;
        public FormBajaDocente( ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente,  ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            listBoxDocentes.DataSource = CargarListBoxDocentes();
        }

        private ICollection<Docente> CargarListBoxDocentes()
        {
            listBoxDocentes.DataSource = null;
            ICollection<Docente> lista = moduloDocentes.ObtenerDocentes();
            return lista;
        }

        private void BajaDocenteBtn_Click(object sender, EventArgs e)
        {
            Docente docente = (Docente)listBoxDocentes.SelectedItem;
            if (docente != null)
            {
                try
                {
                    moduloDocentes.Baja(docente);
                    listBoxDocentes.DataSource = null;
                    listBoxDocentes.DataSource = CargarListBoxDocentes();
                    string mensaje = string.Format("El docente {0} {1} CI {2} se ha eliminado correctamente", docente.Nombre, docente.Apellido, docente.Cedula);
                    MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                    ActualizarListaDocentesEnMenuGestionDocentes();
                }
                catch (ExcepcionNoExisteDocente ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void ActualizarListaDocentesEnMenuGestionDocentes()
        {
            MenuGestionDocente menuDocentes = MenuGestionDocente.ObtenerInstancia(contenedorModulos/*, moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas*/);
            menuDocentes.CargarListBoxDocentesPublico();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
