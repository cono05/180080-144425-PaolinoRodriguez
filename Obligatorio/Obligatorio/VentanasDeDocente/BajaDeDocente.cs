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

namespace Obligatorio.VentanasDeDocente
{
    public partial class BajaDeDocente : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public BajaDeDocente(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos  = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            listBoxDocentes.DataSource = null;
            listBoxDocentes.DataSource = CargarListBoxDocentes();
        }

        private ICollection<Docente> CargarListBoxDocentes()
        {
            ICollection<Docente> lista = new List<Docente>();
            foreach (Docente docente in moduloDocentes.ObtenerDocentes())
            {
                lista.Add(docente);
            }
            return lista;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionDocente(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
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
    }
}
