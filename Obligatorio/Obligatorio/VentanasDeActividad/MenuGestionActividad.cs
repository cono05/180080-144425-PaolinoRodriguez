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

namespace Obligatorio.VentanasDeActividad
{
    public partial class MenuGestionActividad : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private ModuloGestionActividad moduloActividades;

        private static MenuGestionActividad instancia;
        //ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente, ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta, 
        public static MenuGestionActividad ObtenerInstancia(ModuloGestionActividad moduloActividad)
        {
            if (instancia == null)
                instancia = new MenuGestionActividad(moduloActividad); //moduloAlumno, moduloDocente, moduloMateria, moduloCamioneta, 
            return instancia;
        }

        public MenuGestionActividad(ModuloGestionActividad moduloActividad)
        {
            InitializeComponent();
            //moduloAlumnos = moduloAlumno;
            //moduloDocentes = moduloDocente;
            //moduloMaterias = moduloMateria;
            //moduloCamionetas = moduloCamioneta;
            moduloActividades = moduloActividad;
            /*listBoxActividad.DataSource = */
            CargarListBoxActividad();
        }

        private bool HayParaCargarLista(ModuloGestionActividad modulo)
        {
            return modulo.ObtenerActividades().Count > 0;
        }

        private /*ICollection<Actividad>*/ void CargarListBoxActividad()
        {
            listBoxActividad.DataSource = null;
            listBoxActividad.DataSource = moduloActividades.ObtenerActividades();
            //ICollection<Actividad> lista = null; 
            //if (moduloActividades.ObtenerActividades() != null)
            //{
            //    lista = moduloActividades.ObtenerActividades();
            ////}
            
            //return lista;
        }
        public void CargarListBoxActividadesPublico()
        {
            //listBoxActividad.DataSource = null;
            //listBoxActividad.DataSource =
            CargarListBoxActividad();
        }

        private void AltaActividadBtn_Click(object sender, EventArgs e)
        {   // moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, 
            FormAltaActividad altaActividad = new FormAltaActividad(moduloActividades);
            altaActividad.Show();
        }

        private void BajaActividadBtn_Click(object sender, EventArgs e)
        {   // moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, 
            FormBajaActividad bajaActividad = new FormBajaActividad(moduloActividades);
            bajaActividad.Show();
        }

        private void ModificarActividadBtn_Click(object sender, EventArgs e)
        {   // moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, 
            FormModificarActividad modificarActividad = new FormModificarActividad(moduloActividades);
            modificarActividad.Show();
        }
    }
}
