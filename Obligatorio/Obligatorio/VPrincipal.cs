using System.Windows.Forms;

namespace Obligatorio
{
    class VPrincipal : Form
    {
        private Panel panel1;

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
            // 
            // VPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(875, 406);
            this.Controls.Add(this.panel1);
            this.Name = "VPrincipal";
            this.ResumeLayout(false);

        }
    }
}