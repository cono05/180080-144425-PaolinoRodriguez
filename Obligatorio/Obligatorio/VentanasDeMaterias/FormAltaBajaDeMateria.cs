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
    public partial class FormAltaBajaDeMateria : Form
    {
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionDocente moduloDocentes;
        public FormAltaBajaDeMateria(ModuloGestionDocente moduloDocente, ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();            
            moduloMaterias = moduloMateria;
            moduloDocentes = moduloDocente;        
            CargarListBoxMaterias();           
        }

        private void CargarListBoxMaterias()
        {
            listBoxMaterias.DataSource = null;
            listBoxMaterias.DataSource = moduloMaterias.ObtenerMaterias();
        }

        private void AgregarMateriaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia = Materia.CrearMateria();
                materia.Nombre = this.textBoxNombre.Text;
                moduloMaterias.Alta(materia);
                MessageBox.Show("La materia: " + materia.Nombre + ". Codigo: " + materia.Codigo + " se ha agregado correctamente", MessageBoxButtons.OK.ToString());
                textBoxNombre.Clear();
                CargarListBoxMaterias();
                ActualizarListBoxMateriasEnModuloGestionMaterias();
            }
            catch (ExcepcionExisteMateriaConMismoNombre exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ExcepcionMateriaSinNombre exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ExcepcionMateriaCodigoRepetido exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
            }
        }
        private void ActualizarListBoxMateriasEnModuloGestionMaterias()
        {
            MenuGestionMaterias moduloMateria = MenuGestionMaterias.ObtenerInstancia(moduloDocentes, moduloMaterias);
            moduloMateria.CargarListBoxMateriasPublico();
        }

        private void VolverAMenuGestionMateriasBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eliminarMateriaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia = (Materia)listBoxMaterias.SelectedItem;

                if (materia != null)
                {
                    moduloMaterias.Baja(materia);
                    listBoxMaterias.DataSource = null;
                    CargarListBoxMaterias();
                    MessageBox.Show("La materia ha sido dada de baja correctamente.", MessageBoxButtons.OK.ToString());
                    ActualizarListBoxMateriasEnModuloGestionMaterias();
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
        }
    }
}
