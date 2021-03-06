﻿using System.Windows.Forms;
using Persistencia;
using Logica;
using Dominio;
using Obligatorio.VentanasDeAlumno;
using System;


namespace Obligatorio
{
    class VPrincipal : Form
    {
        private Button GestionarAlumnosBtn;
        private Button GestionarDocentesBtn;
        private Button GestionarMateriasBtn;
        private Button GestionarCamionetasBtn;
        private Button button5;
        private Panel PanelPrincipal;
        private ModuloGestionAlumno moduloAlumnos;
        private ModuloGestionDocente moduloDocentes;
        private ModuloGestionMaterias moduloMaterias;
        private Button gestionarActividadesBtn;
        private ModuloGestionCamioneta moduloCamionetas;
        private ModuloGestionActividad moduloActividades;
        private RepositorioBD repositorio;

        public VPrincipal()
        {
            InitializeComponent();
            repositorio = new RepositorioBD();
            moduloAlumnos = new ModuloGestionAlumno(repositorio);
            moduloDocentes = new ModuloGestionDocente(repositorio);
            moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloCamionetas = new ModuloGestionCamioneta(repositorio);
            moduloActividades = new ModuloGestionActividad(repositorio);
                        
        }
        private void CargarPanelPrincipal(UserControl userControl)
        {
            if (!PanelPrincipal.Controls.Contains(userControl))
            {
                PanelPrincipal.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
            {
                userControl.BringToFront();
            }
            
        }
        private void InitializeComponent()
        {
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.GestionarAlumnosBtn = new System.Windows.Forms.Button();
            this.GestionarDocentesBtn = new System.Windows.Forms.Button();
            this.GestionarMateriasBtn = new System.Windows.Forms.Button();
            this.GestionarCamionetasBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gestionarActividadesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 84);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(875, 322);
            this.PanelPrincipal.TabIndex = 0;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GestionarAlumnosBtn
            // 
            this.GestionarAlumnosBtn.Location = new System.Drawing.Point(81, 12);
            this.GestionarAlumnosBtn.Name = "GestionarAlumnosBtn";
            this.GestionarAlumnosBtn.Size = new System.Drawing.Size(96, 55);
            this.GestionarAlumnosBtn.TabIndex = 1;
            this.GestionarAlumnosBtn.Text = "Gestionar Alumnos";
            this.GestionarAlumnosBtn.UseVisualStyleBackColor = true;
            this.GestionarAlumnosBtn.Click += new System.EventHandler(this.GestionarAlumnosBtn_Click);
            // 
            // GestionarDocentesBtn
            // 
            this.GestionarDocentesBtn.Location = new System.Drawing.Point(194, 12);
            this.GestionarDocentesBtn.Name = "GestionarDocentesBtn";
            this.GestionarDocentesBtn.Size = new System.Drawing.Size(98, 55);
            this.GestionarDocentesBtn.TabIndex = 2;
            this.GestionarDocentesBtn.Text = "Gestionar Docentes";
            this.GestionarDocentesBtn.UseVisualStyleBackColor = true;
            this.GestionarDocentesBtn.Click += new System.EventHandler(this.GestionarDocentesBtn_Click);
            // 
            // GestionarMateriasBtn
            // 
            this.GestionarMateriasBtn.Location = new System.Drawing.Point(311, 12);
            this.GestionarMateriasBtn.Name = "GestionarMateriasBtn";
            this.GestionarMateriasBtn.Size = new System.Drawing.Size(98, 55);
            this.GestionarMateriasBtn.TabIndex = 3;
            this.GestionarMateriasBtn.Text = "Gestionar Materias";
            this.GestionarMateriasBtn.UseVisualStyleBackColor = true;
            this.GestionarMateriasBtn.Click += new System.EventHandler(this.GestionarMateriasBtn_Click);
            // 
            // GestionarCamionetasBtn
            // 
            this.GestionarCamionetasBtn.Location = new System.Drawing.Point(429, 12);
            this.GestionarCamionetasBtn.Name = "GestionarCamionetasBtn";
            this.GestionarCamionetasBtn.Size = new System.Drawing.Size(98, 55);
            this.GestionarCamionetasBtn.TabIndex = 4;
            this.GestionarCamionetasBtn.Text = "Gestionar Camionetas";
            this.GestionarCamionetasBtn.UseVisualStyleBackColor = true;
            this.GestionarCamionetasBtn.Click += new System.EventHandler(this.GestionarCamionetasBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(669, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 55);
            this.button5.TabIndex = 5;
            this.button5.Text = "Gestionar Cuotas y Actividades";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // gestionarActividadesBtn
            // 
            this.gestionarActividadesBtn.Location = new System.Drawing.Point(548, 12);
            this.gestionarActividadesBtn.Name = "gestionarActividadesBtn";
            this.gestionarActividadesBtn.Size = new System.Drawing.Size(98, 55);
            this.gestionarActividadesBtn.TabIndex = 7;
            this.gestionarActividadesBtn.Text = "Gestionar Actividades";
            this.gestionarActividadesBtn.UseVisualStyleBackColor = true;
            this.gestionarActividadesBtn.Click += new System.EventHandler(this.gestionarActividadesBtn_Click);
            // 
            // VPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(875, 406);
            this.Controls.Add(this.gestionarActividadesBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.GestionarCamionetasBtn);
            this.Controls.Add(this.GestionarMateriasBtn);
            this.Controls.Add(this.GestionarDocentesBtn);
            this.Controls.Add(this.GestionarAlumnosBtn);
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
        private void CargarDatosDePrueba(ref ModuloGestionMaterias moduloMaterias, ref ModuloGestionAlumno moduloAlumnos, ref ModuloGestionDocente moduloDocentes)
        {
            Camioneta camioneta1 = Camioneta.CrearCamioneta();
            camioneta1.Chapa = "AAA1111";
            camioneta1.Capacidad = 10;
            camioneta1.Marca = "Ford";
            camioneta1.ConsumoCada100Km = 15;
            camioneta1.RelacionCantAlumnosConsumo = 10 / 15;

            Camioneta camioneta2 = Camioneta.CrearCamioneta();
            camioneta2.Chapa = "AAA2222";
            camioneta2.Capacidad = 20;
            camioneta2.Marca = "Chevrolet";
            camioneta2.ConsumoCada100Km = 20;
            camioneta2.RelacionCantAlumnosConsumo = 20/20;
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
            moduloDocentes.Alta(docente);
            moduloDocentes.Alta(docente2);
            moduloDocentes.Alta(docente3);

            moduloCamionetas.Alta(camioneta1);
            moduloCamionetas.Alta(camioneta2);
            moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
            moduloMaterias.AgregarAlumnoEnMateria(materia2, alumno2);
            moduloMaterias.AgregarAlumnoEnMateria(materia2, alumno3);
            
        }

        private void GestionarAlumnosBtn_Click(object sender, System.EventArgs e)
        {
            MenuGestionAlumno menuAlumnos = MenuGestionAlumno.ObtenerInstancia(moduloAlumnos);
            CargarPanelPrincipal(menuAlumnos);
            menuAlumnos.CargarListBoxAlumnosPublico();            
        }

        private void GestionarDocentesBtn_Click(object sender, System.EventArgs e)
        {
            MenuGestionDocente menuDocentes = MenuGestionDocente.ObtenerInstancia(moduloDocentes);
            CargarPanelPrincipal(menuDocentes);
        }

        private void GestionarMateriasBtn_Click(object sender, System.EventArgs e)
        {
            MenuGestionMaterias menuMaterias = MenuGestionMaterias.ObtenerInstancia(moduloDocentes, moduloMaterias);
            CargarPanelPrincipal(menuMaterias);
        }

        private void GestionarCamionetasBtn_Click(object sender, System.EventArgs e)
        {
            MenuGestionCamionetas menuCamionetas = MenuGestionCamionetas.ObtenerInstancia(moduloCamionetas);
            CargarPanelPrincipal(menuCamionetas);
        }

        private void CargarDatosBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                CargarDatosDePrueba(ref moduloMaterias, ref moduloAlumnos, ref moduloDocentes);
                MessageBox.Show("Datos de prueba cargados con exito.", MessageBoxButtons.OK.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gestionarActividadesBtn_Click(object sender, EventArgs e)
        {   
            Obligatorio.VentanasDeActividad.MenuGestionActividad menuActividades = VentanasDeActividad.MenuGestionActividad.ObtenerInstancia(moduloActividades);
            CargarPanelPrincipal(menuActividades);

        }

        private void vaciarTablasBtn_Click(object sender, EventArgs e)
        {
            this.repositorio.VaciarTablas();
            MessageBox.Show("Las tablas de la base de datos se han vaciado correctamente.", MessageBoxButtons.OK.ToString());
        }
    }
}