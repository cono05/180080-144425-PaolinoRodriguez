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
using Logica;

namespace Obligatorio.VentanasDeAlumno
{
    public partial class FormBajaAlumno : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private ContenedorModulos contenedorModulos;
        public FormBajaAlumno(ContenedorModulos contenedor /*ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,*/
                                                                  /*ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta*/)
        {
            InitializeComponent();
            //moduloAlumnos = moduloAlumno;
            //moduloDocentes = moduloDocente;
            //moduloMaterias = moduloMateria;
            //moduloCamionetas = moduloCamioneta;
            contenedorModulos = contenedor;
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }

        private ICollection<Alumno> CargarListBoxAlumnos()
        {
            listBoxAlumnos.DataSource = null;
            ModuloGestionAlumno modulo = (ModuloGestionAlumno)contenedorModulos.ObtenerModulo("ModuloAlumnos");
            ICollection<Alumno> lista = modulo.ObtenerAlumnos();
            return lista;
        }

        private void EliminarAlumnoBtn_Click(object sender, EventArgs e)
        {
            Alumno alumno = (Alumno)listBoxAlumnos.SelectedItem;
            if (alumno != null)
            {
                try
                {
                    //moduloAlumnos.Baja(alumno);
                    ModuloGestionAlumno modulo = (ModuloGestionAlumno)contenedorModulos.ObtenerModulo("ModuloAlumnos");
                    modulo.Baja(alumno);
                    //listBoxAlumnos.DataSource = null;
                    listBoxAlumnos.DataSource = CargarListBoxAlumnos();
                    string mensaje = string.Format("El alumno {0} {1} CI {2} se ha eliminado correctamente", alumno.Nombre, alumno.Apellido, alumno.Cedula);
                    MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                    ActualizarListaAlumnosEnMenuGestionAlumnos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("Debe seleccionar un alumno de la lista.", MessageBoxButtons.OK.ToString());
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void ActualizarListaAlumnosEnMenuGestionAlumnos()
        {
            MenuGestionAlumno menuAlumnos = MenuGestionAlumno.ObtenerInstancia(contenedorModulos/*moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas*/);
            menuAlumnos.CargarListBoxAlumnosPublico();
        }
    }
}
