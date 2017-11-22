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

        public static MenuGestionActividad ObtenerInstancia(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta, ModuloGestionActividad moduloActividad)
        {
            if (instancia == null)
                instancia = new MenuGestionActividad(moduloAlumno, moduloDocente, moduloMateria, moduloCamioneta, moduloActividad);
            return instancia;
        }

        public MenuGestionActividad(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta, ModuloGestionActividad moduloActividad)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            moduloActividades = moduloActividad;
            listBoxActividad.DataSource = CargarListBoxActividad();
        }

        private bool HayParaCargarLista(ModuloGestionActividad modulo)
        {
            return modulo.ObtenerActividades().Count > 0;
        }

        private ICollection<Actividad> CargarListBoxActividad()
        {
            listBoxActividad.DataSource = null;

            ICollection<Actividad> lista = null; 
            if (moduloActividades.ObtenerActividades() != null)
            {
                lista = moduloActividades.ObtenerActividades();
            }
            
            return lista;
        }
        public void CargarListBoxActividadesPublico()
        {
            listBoxActividad.DataSource = null;
            listBoxActividad.DataSource = CargarListBoxActividad();
        }

        private void AltaActividadBtn_Click(object sender, EventArgs e)
        {
            FormAltaActividad altaActividad = new FormAltaActividad(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, moduloActividades);
            altaActividad.Show();
        }

        private void BajaActividadBtn_Click(object sender, EventArgs e)
        {
            FormBajaActividad bajaActividad = new FormBajaActividad(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, moduloActividades);
            bajaActividad.Show();
        }

        private void ModificarActividadBtn_Click(object sender, EventArgs e)
        {
            FormModificarActividad modificarActividad = new FormModificarActividad(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas, moduloActividades);
            modificarActividad.Show();
        }
    }
}
