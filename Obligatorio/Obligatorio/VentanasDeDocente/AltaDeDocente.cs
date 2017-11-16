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
using Excepciones;

namespace Obligatorio.VentanasDeDocente
{
    public partial class AltaDeDocente : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;

        public AltaDeDocente(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, 
            ref ModuloGestionMaterias moduloMateria, ref ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos  = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionDocente( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));
        }

        private void AgregarDocenteBtn_Click(object sender, EventArgs e)
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
                //Para limpiar todos los textboxes
                panel1.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
