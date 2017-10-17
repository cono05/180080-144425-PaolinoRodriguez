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

        public MenuGestionDocente(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, 
            ref ModuloGestionMaterias moduloMateria, ref ModuloGestionCamioneta moduloCamioneta)
        {
            InitializeComponent();
            moduloAlumnos  = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            moduloCamionetas = moduloCamioneta;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new VentanasDeDocente.AltaDeDocente(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new VentanasDeDocente.ModificarDocente(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new VentanasDeDocente.BajaDeDocente(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias, ref moduloCamionetas));
        }
    }
}
