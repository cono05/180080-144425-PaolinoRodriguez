namespace Obligatorio
{
    partial class MenuGestionMaterias
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarAlumnoEnMateria = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AltaBajaDocenteBtn = new System.Windows.Forms.Button();
            this.ModificarMateriaBtn = new System.Windows.Forms.Button();
            this.BajaDeMateriaBtn = new System.Windows.Forms.Button();
            this.AltaDeMateriaBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AgregarAlumnoEnMateria);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.AltaBajaDocenteBtn);
            this.panel1.Controls.Add(this.ModificarMateriaBtn);
            this.panel1.Controls.Add(this.BajaDeMateriaBtn);
            this.panel1.Controls.Add(this.AltaDeMateriaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver al Menú Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Gestión Materias";
            // 
            // AgregarAlumnoEnMateria
            // 
            this.AgregarAlumnoEnMateria.Location = new System.Drawing.Point(550, 99);
            this.AgregarAlumnoEnMateria.Name = "AgregarAlumnoEnMateria";
            this.AgregarAlumnoEnMateria.Size = new System.Drawing.Size(94, 51);
            this.AgregarAlumnoEnMateria.TabIndex = 5;
            this.AgregarAlumnoEnMateria.Text = "Alta y Baja de Alumno en una Materia";
            this.AgregarAlumnoEnMateria.UseVisualStyleBackColor = true;
            this.AgregarAlumnoEnMateria.Click += new System.EventHandler(this.AgregarAlumnoEnMateria_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(550, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // AltaBajaDocenteBtn
            // 
            this.AltaBajaDocenteBtn.Location = new System.Drawing.Point(380, 196);
            this.AltaBajaDocenteBtn.Name = "AltaBajaDocenteBtn";
            this.AltaBajaDocenteBtn.Size = new System.Drawing.Size(94, 48);
            this.AltaBajaDocenteBtn.TabIndex = 3;
            this.AltaBajaDocenteBtn.Text = "Alta y baja Docente en Materia";
            this.AltaBajaDocenteBtn.UseVisualStyleBackColor = true;
            this.AltaBajaDocenteBtn.Click += new System.EventHandler(this.AltaBajaDocenteBtn_Click);
            // 
            // ModificarMateriaBtn
            // 
            this.ModificarMateriaBtn.Location = new System.Drawing.Point(195, 196);
            this.ModificarMateriaBtn.Name = "ModificarMateriaBtn";
            this.ModificarMateriaBtn.Size = new System.Drawing.Size(94, 48);
            this.ModificarMateriaBtn.TabIndex = 2;
            this.ModificarMateriaBtn.Text = "Modificar Materia";
            this.ModificarMateriaBtn.UseVisualStyleBackColor = true;
            this.ModificarMateriaBtn.Click += new System.EventHandler(this.ModificarMateriaBtn_Click);
            // 
            // BajaDeMateriaBtn
            // 
            this.BajaDeMateriaBtn.Location = new System.Drawing.Point(380, 99);
            this.BajaDeMateriaBtn.Name = "BajaDeMateriaBtn";
            this.BajaDeMateriaBtn.Size = new System.Drawing.Size(94, 51);
            this.BajaDeMateriaBtn.TabIndex = 1;
            this.BajaDeMateriaBtn.Text = "Baja de Materia";
            this.BajaDeMateriaBtn.UseVisualStyleBackColor = true;
            this.BajaDeMateriaBtn.Click += new System.EventHandler(this.BajaDeMateriaBtn_Click);
            // 
            // AltaDeMateriaBtn
            // 
            this.AltaDeMateriaBtn.Location = new System.Drawing.Point(195, 99);
            this.AltaDeMateriaBtn.Name = "AltaDeMateriaBtn";
            this.AltaDeMateriaBtn.Size = new System.Drawing.Size(94, 51);
            this.AltaDeMateriaBtn.TabIndex = 0;
            this.AltaDeMateriaBtn.Text = "Alta de Materia";
            this.AltaDeMateriaBtn.UseVisualStyleBackColor = true;
            this.AltaDeMateriaBtn.Click += new System.EventHandler(this.AltaDeMateriaBtn_Click);
            // 
            // MenuGestionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionMaterias";
            this.Size = new System.Drawing.Size(875, 406);
            this.Load += new System.EventHandler(this.MenuGestionMaterias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarAlumnoEnMateria;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AltaBajaDocenteBtn;
        private System.Windows.Forms.Button ModificarMateriaBtn;
        private System.Windows.Forms.Button BajaDeMateriaBtn;
        private System.Windows.Forms.Button AltaDeMateriaBtn;
        private System.Windows.Forms.Button button1;
    }
}
