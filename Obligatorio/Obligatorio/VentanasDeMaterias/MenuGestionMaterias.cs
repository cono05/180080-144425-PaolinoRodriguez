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
using Obligatorio.VentanasDeMaterias;

namespace Obligatorio
{
    public partial class MenuGestionMaterias : UserControl
    {
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionDocente moduloDocentes;
        private static MenuGestionMaterias instancia;

        public static MenuGestionMaterias ObtenerInstancia(ModuloGestionDocente moduloDocente, ModuloGestionMaterias moduloMateria)
        {
            if (instancia == null)
                instancia = new MenuGestionMaterias(moduloDocente, moduloMateria);
            return instancia;
        }

        private MenuGestionMaterias(ModuloGestionDocente moduloDocente, ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloMaterias = moduloMateria;
            moduloDocentes=moduloDocente;
            CargarListBoxMaterias();
        }

        private void MenuGestionMaterias_Load(object sender, EventArgs e)
        {

        }

        private void AltaBajaDeMateriaBtn_Click(object sender, EventArgs e)
        {
            FormAltaBajaDeMateria altaBajaMateria = new FormAltaBajaDeMateria(moduloDocentes, moduloMaterias);
            altaBajaMateria.Show();
        }



        private void BajaDeMateriaBtn_Click(object sender, EventArgs e)
        { 

        }

        private void AgregarAlumnoEnMateria_Click(object sender, EventArgs e)
        {
            FormAltaBajaDeAlumnoEnMateria altaBajaAlumnoEnMateria = new FormAltaBajaDeAlumnoEnMateria(moduloMaterias);
            altaBajaAlumnoEnMateria.Show();
        }

        private void ModificarMateriaBtn_Click(object sender, EventArgs e)
        {
            FormModificacionMateria modificacionMateria = new FormModificacionMateria(moduloMaterias);
            modificacionMateria.Show();
        }

        private void AltaBajaDocenteBtn_Click(object sender, EventArgs e)
        {
            if (moduloDocentes.HayDocentesRegistrados())
            {
                FormAltaBajaDocenteEnMateria altaBajaDocenteEnMateria = new FormAltaBajaDocenteEnMateria(moduloDocentes,moduloMaterias);
                altaBajaDocenteEnMateria.Show();
            }
            else
            {
                MessageBox.Show("No existen Docentes en el sistema", MessageBoxButtons.OK.ToString());
            }
        }

        private void CargarListBoxMaterias()
        {
            listBoxMaterias.DataSource = null;
            listBoxMaterias.DataSource = moduloMaterias.ObtenerMaterias();
        }

        public void CargarListBoxMateriasPublico()
        {
            CargarListBoxMaterias();
        }
    }
}
