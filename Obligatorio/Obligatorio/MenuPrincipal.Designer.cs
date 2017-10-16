namespace Obligatorio
{
    partial class MenuPrincipal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.GestionarMateriasBtn = new System.Windows.Forms.Button();
            this.GestionarDocentesBtn = new System.Windows.Forms.Button();
            this.buttonGestionarAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.GestionarMateriasBtn);
            this.panel1.Controls.Add(this.GestionarDocentesBtn);
            this.panel1.Controls.Add(this.buttonGestionarAlumno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // GestionarMateriasBtn
            // 
            this.GestionarMateriasBtn.Location = new System.Drawing.Point(447, 121);
            this.GestionarMateriasBtn.Name = "GestionarMateriasBtn";
            this.GestionarMateriasBtn.Size = new System.Drawing.Size(94, 40);
            this.GestionarMateriasBtn.TabIndex = 3;
            this.GestionarMateriasBtn.Text = "Gestionar Materias";
            this.GestionarMateriasBtn.UseVisualStyleBackColor = true;
            this.GestionarMateriasBtn.Click += new System.EventHandler(this.GestionarMateriasBtn_Click);
            // 
            // GestionarDocentesBtn
            // 
            this.GestionarDocentesBtn.Location = new System.Drawing.Point(311, 121);
            this.GestionarDocentesBtn.Name = "GestionarDocentesBtn";
            this.GestionarDocentesBtn.Size = new System.Drawing.Size(94, 40);
            this.GestionarDocentesBtn.TabIndex = 2;
            this.GestionarDocentesBtn.Text = "Gestionar Docentes";
            this.GestionarDocentesBtn.UseVisualStyleBackColor = true;
            this.GestionarDocentesBtn.Click += new System.EventHandler(this.GestionarDocentesBtn_Click);
            // 
            // buttonGestionarAlumno
            // 
            this.buttonGestionarAlumno.Location = new System.Drawing.Point(167, 121);
            this.buttonGestionarAlumno.Name = "buttonGestionarAlumno";
            this.buttonGestionarAlumno.Size = new System.Drawing.Size(94, 40);
            this.buttonGestionarAlumno.TabIndex = 1;
            this.buttonGestionarAlumno.Text = "Gestionar Alumnos";
            this.buttonGestionarAlumno.UseVisualStyleBackColor = true;
            this.buttonGestionarAlumno.Click += new System.EventHandler(this.buttonGestionarAlumno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button GestionarMateriasBtn;
        private System.Windows.Forms.Button GestionarDocentesBtn;
        private System.Windows.Forms.Button buttonGestionarAlumno;
    }
}
