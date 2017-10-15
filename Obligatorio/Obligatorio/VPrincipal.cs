using System.Windows.Forms;
using Persistencia;
using Logica;
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
            ModuloGestionDocente moduloDocentes = new ModuloGestionDocente(repositorio);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(ref repositorio);
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
    }
}