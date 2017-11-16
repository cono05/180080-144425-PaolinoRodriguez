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

        public MenuGestionDocente( ModuloGestionAlumno moduloAlumno,  ModuloGestionDocente moduloDocente, 
             ModuloGestionMaterias moduloMateria,  ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos  = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void AltaDocenteBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new VentanasDeDocente.AltaDeDocente(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void ModificarDocenteBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new VentanasDeDocente.ModificarDocente(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void BajaDocenteBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new VentanasDeDocente.BajaDeDocente(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }
    }
}
