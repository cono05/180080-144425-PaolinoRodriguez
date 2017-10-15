using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Logica;
namespace Obligatorio
{
    public partial class BajaDeMateria : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public BajaDeMateria(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            MateriasListBox.DataSource = CargarListBoxMaterias();
            MateriasListBox.SetSelected(0, false);
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

        private void EliminarMateriaClick(object sender, EventArgs e)
        {
            try
            {
                Materia materia = (Materia)MateriasListBox.SelectedItem;

                if (materia != null)
                {
                    moduloMaterias.Baja(materia);
                    MateriasListBox.DataSource = null;
                    MateriasListBox.DataSource = CargarListBoxMaterias();
                    MessageBox.Show("La materia ha sido dada de baja correctamente.", MessageBoxButtons.OK.ToString());
                }
                else
                {
                    MessageBox.Show("Seleccione una materia de la lista.", MessageBoxButtons.OK.ToString());
                }

            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            finally
            {
            }
        }

        private void VolverAlMenuClick(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionMaterias(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }
    }
}
