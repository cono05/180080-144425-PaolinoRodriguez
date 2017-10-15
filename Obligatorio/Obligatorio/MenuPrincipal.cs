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

namespace Obligatorio
{
    public partial class MenuPrincipal : UserControl
    {
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;

        public MenuPrincipal(ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente, ref ModuloGestionMaterias moduloMateria)
        {
            InitializeComponent();
            moduloAlumnos = moduloAlumno;
            moduloDocentes = moduloDocente;
            moduloMaterias = moduloMateria;
            CargarDatosDePrueba();
        }

        private void GestionarMateriasBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuGestionMaterias(ref moduloAlumnos, ref moduloDocentes, ref moduloMaterias));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarDatosDePrueba()
        {
            Alumno alumno = Alumno.CrearAlumno();
            alumno.Nombre = "Jose";
            alumno.Apellido = "Lopez";
            alumno.Cedula = "1234567-8";
            alumno.Mail = "j@gmail.com";
            Alumno alumno2 = Alumno.CrearAlumno();
            alumno2.Nombre = "Pedro";
            alumno2.Apellido = "Diaz";
            alumno2.Cedula = "1234222-8";
            alumno2.Mail = "pp@gmail.com";
            Alumno alumno3 = Alumno.CrearAlumno();
            alumno3.Nombre = "Daniel";
            alumno3.Apellido = "Perez";
            alumno3.Cedula = "1234333-8";
            alumno3.Mail = "dd@gmail.com";

            Materia materia = Materia.CrearMateria();
            materia.Nombre = "Diseño 1";
            Materia materia2 = Materia.CrearMateria();
            materia2.Nombre = "Diseño 2";
            moduloAlumnos.Alta(alumno);
            moduloAlumnos.Alta(alumno2);
            moduloAlumnos.Alta(alumno3);
            moduloMaterias.Alta(materia);
            moduloMaterias.Alta(materia2);
            moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
            moduloMaterias.AgregarAlumnoEnMateria(materia2, alumno2);
            moduloMaterias.AgregarAlumnoEnMateria(materia2, alumno3);
        }
    }
}
