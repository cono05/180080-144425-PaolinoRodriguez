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

namespace Obligatorio.VentanasDeDocente
{
    public partial class FormAltaDocente : Form
    {        
        private ModuloGestionDocente moduloDocentes;    
        public FormAltaDocente(   ModuloGestionDocente moduloDocente)
        {
            InitializeComponent();           
            moduloDocentes = moduloDocente;            
            listBoxDocentes.DataSource = CargarListBoxDocentes();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private ICollection<Docente> CargarListBoxDocentes()
        {
            listBoxDocentes.DataSource = null;
            ICollection<Docente> lista = moduloDocentes.ObtenerDocentes();
            return lista;
        }

        private void LimpiarTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }
        

        private void AltaDocenteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Docente docente = Docente.CrearDocente();
                docente.Nombre = textBoxNombre.Text;
                docente.Apellido = textBoxApellido.Text;
                docente.Cedula = textBoxCedula.Text;
                moduloDocentes.Alta(docente);
                string mensaje = string.Format("El docente {0} {1} CI {2} se ha agregado correctamente", docente.Nombre, docente.Apellido, docente.Cedula);
                MessageBox.Show(mensaje, MessageBoxButtons.OK.ToString());
                listBoxDocentes.DataSource = CargarListBoxDocentes();
                LimpiarTextBoxs();
                ActualizarListaDocentesEnMenuGestionDocentes();
            }
            catch (ExcepcionExisteDocenteConMismaCedula ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionDocenteSinNombre ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionDocenteSinApellido ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionDocenteSinCedula ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionFormatoCedulaIncorrecto ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListaDocentesEnMenuGestionDocentes()
        {
            MenuGestionDocente menuDocentes = MenuGestionDocente.ObtenerInstancia(moduloDocentes);
            menuDocentes.CargarListBoxDocentesPublico();
        }

    }
}
