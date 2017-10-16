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

namespace Obligatorio.Alumno
{
    public partial class ModificarAlumno : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public ModificarAlumno()
        {
            InitializeComponent();
        }

        public ModificarAlumno(ref ModuloGestionAlumno moduloAlumnos, ref ModuloGestionDocente moduloDocentes, ref ModuloGestionMaterias moduloMaterias)
        {
            this.moduloAlumnos = moduloAlumnos;
            this.moduloDocentes = moduloDocentes;
            this.moduloMaterias = moduloMaterias;
        }
    }
}
