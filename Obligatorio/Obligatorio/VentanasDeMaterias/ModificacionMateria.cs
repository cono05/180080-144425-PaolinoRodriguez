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

namespace Obligatorio
{
    public partial class ModificacionMateria : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public ModificacionMateria( ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            MateriasListBox.DataSource = null;
            MateriasListBox.DataSource = CargarListBoxMaterias();
            //MateriasListBox.SetSelected(0, false);
        }

        private void ModificarNombreBtnClick(object sender, EventArgs e)
        {
            try
            {

                Materia materia = (Materia)MateriasListBox.SelectedItem;
                if (materia != null)
                {
                    string nombreNuevo = nombreNuevoTextBox.Text;
                    if (!string.IsNullOrEmpty(nombreNuevo) && !nombreNuevoTextBox.Text.Equals(materia.Nombre))
                    {
                        moduloMaterias.ModificarMateria(materia, nombreNuevo);
                        MessageBox.Show("El nombre de la materia se ha modificado correctamente.", MessageBoxButtons.OK.ToString());
                        MateriasListBox.DataSource = null;
                        MateriasListBox.DataSource = CargarListBoxMaterias();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una materia de la lista.", MessageBoxButtons.OK.ToString());
                }
                
            }
            catch (ExcepcionExisteMateriaConMismoNombre exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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

        private void VolverAlMenuClickClick(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionMaterias( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));
        }

        private void MateriasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)MateriasListBox.SelectedItem;
            if (materia != null)
            {
                nombreNuevoTextBox.Text = materia.Nombre;
            }
            
        }
    }
}
