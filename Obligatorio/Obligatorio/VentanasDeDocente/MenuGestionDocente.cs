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
using Obligatorio.VentanasDeDocente;

namespace Obligatorio
{
    public partial class MenuGestionDocente : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        private static MenuGestionDocente instancia;

        public static MenuGestionDocente ObtenerInstancia(ModuloGestionAlumno moduloAlumno, ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria, ModuloGestionCamioneta moduloCamioneta)
        {
            if (instancia == null)
                instancia = new MenuGestionDocente(moduloAlumno, moduloDocente, moduloMateria, moduloCamioneta);
            return instancia;
        }

        private MenuGestionDocente(ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente,
             ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
            
            
            CargarListBoxDocentes();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void AltaDocenteBtn_Click(object sender, EventArgs e)
        {
            FormAltaDocente altaDocente = new FormAltaDocente(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas);
            altaDocente.Show();
        }

        private void ModificarDocenteBtn_Click(object sender, EventArgs e)
        {
            FormModificacionDocente modificarDocente = new FormModificacionDocente(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas);
            modificarDocente.Show();
        }

        private void BajaDocenteBtn_Click(object sender, EventArgs e)
        {
            //FormBajaDocente bajaDocente = new FormBajaDocente(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas);
            //bajaDocente.Show();
        }

        private void CargarListBoxDocentes()
        {
            listBoxDocentes.DataSource = null;
            listBoxDocentes.DataSource = moduloDocentes.ObtenerDocentes();            
        }

        public void CargarListBoxDocentesPublico()
        {
            listBoxDocentes.DataSource = null;
            CargarListBoxDocentes();
        }
    }
}
