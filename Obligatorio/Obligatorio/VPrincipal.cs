using System.Windows.Forms;
using Persistencia;
using Logica;
using Dominio;
using Obligatorio.VentanasDeAlumno;
using System.Collections;

namespace Obligatorio
{
    class VPrincipal : Form
    {
        private Button buttonGestionarAlumno;
        private Button GestionarDocentesBtn;
        private Button GestionarMateriasBtn;
        private Button GestionarCamionetasBtn;
        private Panel PanelPrincipal;
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private ModuloGestionCamioneta moduloCamionetas;
        
        public VPrincipal()
        {
            InitializeComponent();
            RepositorioRam repositorio = new RepositorioRam();
            moduloAlumnos = new ModuloGestionAlumno( repositorio);
            moduloDocentes = new ModuloGestionDocente( repositorio);
            moduloMaterias = new ModuloGestionMaterias( repositorio);
            moduloCamionetas = new ModuloGestionCamioneta( repositorio);
            CargarDatosDePrueba( moduloMaterias,  moduloAlumnos,  moduloDocentes);
            CargarPanelPrincipal( moduloMaterias,  moduloAlumnos,  moduloDocentes,  moduloCamionetas);
        }
        private void CargarPanelPrincipal( ModuloGestionMaterias moduloMateria,  ModuloGestionAlumno moduloAlumno,
             ModuloGestionDocente moduloDocente,  ModuloGestionCamioneta moduloCamioneta)
        {
            PanelPrincipal.Controls.Clear();
            //PanelPrincipal.Controls.Add(new MenuPrincipal( moduloAlumno,  moduloDocente, moduloMateria,  moduloCamioneta));

        }
        private void InitializeComponent()
        {
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.buttonGestionarAlumno = new System.Windows.Forms.Button();
            this.GestionarDocentesBtn = new System.Windows.Forms.Button();
            this.GestionarMateriasBtn = new System.Windows.Forms.Button();
            this.GestionarCamionetasBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 107);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(875, 299);
            this.PanelPrincipal.TabIndex = 0;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonGestionarAlumno
            // 
            this.buttonGestionarAlumno.Location = new System.Drawing.Point(58, 23);
            this.buttonGestionarAlumno.Name = "buttonGestionarAlumno";
            this.buttonGestionarAlumno.Size = new System.Drawing.Size(94, 57);
            this.buttonGestionarAlumno.TabIndex = 2;
            this.buttonGestionarAlumno.Text = "Gestionar Alumnos";
            this.buttonGestionarAlumno.UseVisualStyleBackColor = true;
            this.buttonGestionarAlumno.Click += new System.EventHandler(this.buttonGestionarAlumno_Click);
            // 
            // GestionarDocentesBtn
            // 
            this.GestionarDocentesBtn.Location = new System.Drawing.Point(158, 23);
            this.GestionarDocentesBtn.Name = "GestionarDocentesBtn";
            this.GestionarDocentesBtn.Size = new System.Drawing.Size(94, 57);
            this.GestionarDocentesBtn.TabIndex = 3;
            this.GestionarDocentesBtn.Text = "Gestionar Docentes";
            this.GestionarDocentesBtn.UseVisualStyleBackColor = true;
            this.GestionarDocentesBtn.Click += new System.EventHandler(this.GestionarDocentesBtn_Click);
            // 
            // GestionarMateriasBtn
            // 
            this.GestionarMateriasBtn.Location = new System.Drawing.Point(258, 23);
            this.GestionarMateriasBtn.Name = "GestionarMateriasBtn";
            this.GestionarMateriasBtn.Size = new System.Drawing.Size(94, 57);
            this.GestionarMateriasBtn.TabIndex = 4;
            this.GestionarMateriasBtn.Text = "Gestionar Materias";
            this.GestionarMateriasBtn.UseVisualStyleBackColor = true;
            // 
            // GestionarCamionetasBtn
            // 
            this.GestionarCamionetasBtn.Location = new System.Drawing.Point(358, 23);
            this.GestionarCamionetasBtn.Name = "GestionarCamionetasBtn";
            this.GestionarCamionetasBtn.Size = new System.Drawing.Size(94, 57);
            this.GestionarCamionetasBtn.TabIndex = 5;
            this.GestionarCamionetasBtn.Text = "Gestionar Camionetas";
            this.GestionarCamionetasBtn.UseVisualStyleBackColor = true;
            // 
            // VPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(875, 406);
            this.Controls.Add(this.GestionarCamionetasBtn);
            this.Controls.Add(this.GestionarMateriasBtn);
            this.Controls.Add(this.GestionarDocentesBtn);
            this.Controls.Add(this.buttonGestionarAlumno);
            this.Controls.Add(this.PanelPrincipal);
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
        private void CargarDatosDePrueba( ModuloGestionMaterias moduloMaterias,  ModuloGestionAlumno moduloAlumnos,  ModuloGestionDocente moduloDocentes)
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
            docente.Nombre = "Pedro";
            docente.Apellido = "Lopez";
            Docente docente2 = Docente.CrearDocente();
            docente2.Cedula = "1222222-4";
            docente2.Nombre = "Martin";
            docente2.Apellido = "Leon";
            Docente docente3 = Docente.CrearDocente();
            docente3.Cedula = "1333333-4";
            docente3.Nombre = "Jose";
            docente3.Apellido = "Souza";

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

            /*Cambio de prueba*/
        }

        private void buttonGestionarAlumno_Click(object sender, System.EventArgs e)
        {
            if (!PanelPrincipal.Controls.Contains(MenuGestionAlumno.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas)))
            {
                PanelPrincipal.Controls.Add(MenuGestionAlumno.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas));
                MenuGestionAlumno.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas).Dock = DockStyle.Fill;
                MenuGestionAlumno.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas).BringToFront();
            }
            else
            {
                MenuGestionAlumno.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas).BringToFront();
            }
        }

        private void GestionarDocentesBtn_Click(object sender, System.EventArgs e)
        {
            if (!PanelPrincipal.Controls.Contains(MenuGestionDocente.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas)))
            {
                PanelPrincipal.Controls.Add(MenuGestionDocente.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas));
                MenuGestionDocente.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas).Dock = DockStyle.Fill;
                MenuGestionDocente.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas).BringToFront();
            }
            else
            {
                MenuGestionDocente.ObtenerInstancia(moduloAlumnos, moduloDocentes, moduloMaterias, moduloCamionetas).BringToFront();
            }
        }
    }
}