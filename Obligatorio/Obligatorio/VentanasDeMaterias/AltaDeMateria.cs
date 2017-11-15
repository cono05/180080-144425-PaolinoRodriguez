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
    public partial class AltaDeMateria : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        public AltaDeMateria( ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
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

        private void VolverAMenuGestionMateriasBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionMaterias( moduloAlumnos,  moduloDocentes,  moduloMaterias,  moduloCamionetas));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
