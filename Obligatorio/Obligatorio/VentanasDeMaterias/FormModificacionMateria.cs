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

namespace Obligatorio.VentanasDeMaterias
{
    public partial class FormModificacionMateria : Form
    {
        private ModuloGestionMaterias moduloMaterias;
        
        public FormModificacionMateria(ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloMaterias = moduloMateria;
            CargarListBoxMaterias();
        }

        private void CargarListBoxMaterias()
        {
            listBoxMaterias.DataSource = null;
            listBoxMaterias.DataSource = moduloMaterias.ObtenerMaterias();
        }

        private void listBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)listBoxMaterias.SelectedItem;
            if (materia != null)
            {
                nombreNuevoTextBox.Text = materia.Nombre;
            }
        }

        private void ModificarNombreBtn_Click(object sender, EventArgs e)
        {
            try
            {

                Materia materia = (Materia)listBoxMaterias.SelectedItem;
                if (materia != null)
                {
                    string nombreNuevo = nombreNuevoTextBox.Text;
                    if (!string.IsNullOrEmpty(nombreNuevo) && !nombreNuevoTextBox.Text.Equals(materia.Nombre))
                    {
                        moduloMaterias.ModificarMateria(materia, nombreNuevo);
                        MessageBox.Show("El nombre de la materia se ha modificado correctamente.", MessageBoxButtons.OK.ToString());
                        listBoxMaterias.DataSource = null;
                        CargarListBoxMaterias();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
