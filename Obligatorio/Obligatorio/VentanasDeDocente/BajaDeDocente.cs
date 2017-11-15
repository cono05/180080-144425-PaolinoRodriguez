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
        private ModuloGestionCamioneta moduloCamionetas;

        public BajaDeDocente( ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente,  ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos  = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            ListBoxDocentes.DataSource = null;
            ListBoxDocentes.DataSource = CargarListBoxDocentes();
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

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionDocente( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));
        }

        private void EliminarDocenteBtn_Click(object sender, EventArgs e)
        {
            Docente docente = (Docente)ListBoxDocentes.SelectedItem;
            if (docente != null)
            {
                try
                {
                    moduloDocentes.Baja(docente);
                    ListBoxDocentes.DataSource = null;
                    ListBoxDocentes.DataSource = CargarListBoxDocentes();
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
