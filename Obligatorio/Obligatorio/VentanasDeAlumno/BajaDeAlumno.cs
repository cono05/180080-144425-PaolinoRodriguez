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

namespace Obligatorio.VentanasDeAlumno
{
    public partial class BajaDeAlumno : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public BajaDeAlumno(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos  = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = CargarListBoxAlumnos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = (Alumno)listBoxAlumnos.SelectedItem;
            if (alumno != null)
            {
                try
                {
                    moduloAlumnos.Baja(alumno);
                    listBoxAlumnos.DataSource = null;
                    listBoxAlumnos.DataSource = CargarListBoxAlumnos();
                }
                catch (ExcepcionNoExisteAlumno ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex) // Ver bien que otros errores podrian suceder
                {
                    throw ex;
                }
            }
        }

        public ICollection<Alumno> CargarListBoxAlumnos()
        {
            ICollection<Alumno> lista = new List<Alumno>();
            foreach (Alumno alumno in moduloAlumnos.repositorio.ObtenerAlumnos())
            {
                lista.Add(alumno);
            }
            return lista;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionAlumno(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }
    }
}
