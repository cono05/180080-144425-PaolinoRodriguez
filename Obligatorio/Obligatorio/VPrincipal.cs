using System.Windows.Forms;
using Persistencia;
using Logica;
using Dominio;
namespace Obligatorio
{
    class VPrincipal : Form
    {
        private Panel panel1;

        public VPrincipal()
        {
            InitializeComponent();
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionAlumno moduloAlumnos = new ModuloGestionAlumno(ref repositorio);
            ModuloGestionDocente moduloDocentes = new ModuloGestionDocente(ref repositorio);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(ref repositorio);
            CargarDatosDePrueba(ref moduloMaterias, ref moduloAlumnos, ref moduloDocentes);
            CargarPanelPrincipal(ref moduloMaterias, ref moduloAlumnos, ref moduloDocentes);
        }
        private void CargarPanelPrincipal(ref ModuloGestionMaterias moduloMateria, ref ModuloGestionAlumno moduloAlumno, ref ModuloGestionDocente moduloDocente)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MenuPrincipal(ref moduloAlumno, ref moduloDocente,ref moduloMateria));
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(875, 406);
            this.Controls.Add(this.panel1);
            this.Name = "VPrincipal";
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            this.ResumeLayout(false);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VPrincipal_Load(object sender, System.EventArgs e)
        {

        }
        private void CargarDatosDePrueba(ref ModuloGestionMaterias moduloMaterias, ref ModuloGestionAlumno moduloAlumnos, ref ModuloGestionDocente moduloDocentes)
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

            Docente docente = Docente.CrearDocente();
            docente.Cedula = "1222333-4";
            Docente docente2 = Docente.CrearDocente();
            docente2.Cedula = "1222222-4";
            Docente docente3 = Docente.CrearDocente();
            docente3.Cedula = "1333333-4";

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
            moduloDocentes.Alta(docente);
            moduloDocentes.Alta(docente2);
            moduloDocentes.Alta(docente3);
        }
    }
}