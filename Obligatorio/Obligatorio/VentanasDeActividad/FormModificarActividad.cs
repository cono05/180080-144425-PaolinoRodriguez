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

namespace Obligatorio.VentanasDeActividad
{
    public partial class FormModificarActividad : Form
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private ModuloGestionActividad moduloActividades;

        public FormModificarActividad(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente, ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta, ModuloGestionActividad moduloActividad)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            moduloActividades = moduloActividad;

            listBoxActividad.DataSource = null;
            listBoxActividad.DataSource = CargarListBoxActividad();
        }

        private ICollection<Actividad> CargarListBoxActividad()
        {
            listBoxActividad.DataSource = null;
            ICollection<Actividad> lista = moduloActividades.ObtenerActividades();
            return lista;
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModificarActividadBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
