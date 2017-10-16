﻿using System;
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
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public MenuGestionMaterias(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
        }

        private void MenuGestionMaterias_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AltaDeMateriaBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AltaDeMateria(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuPrincipal(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void BajaDeMateriaBtn_Click(object sender, EventArgs e)
        {
            if (moduloMaterias.HayMateriasRegistradas())
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new BajaDeMateria(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
            }
            else
            {
                MessageBox.Show("No existen materias en el sistema", MessageBoxButtons.OK.ToString());
            }

            
        }

        private void AgregarAlumnoEnMateria_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AltaDeAlumnoEnMateria(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void ModificarMateriaBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ModificacionMateria(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void AltaBajaDocenteBtn_Click(object sender, EventArgs e)
        {
            if (moduloDocentes.HayDocentesRegistrados())
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new AltaBajaDocenteEnMateria(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
            }
            else
            {
                MessageBox.Show("No existen Docentes en el sistema", MessageBoxButtons.OK.ToString());
            }
            
        }
    }
}