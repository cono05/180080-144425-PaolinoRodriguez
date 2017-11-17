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
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarAlumnoEnMateria = new System.Windows.Forms.Button();
            this.AltaBajaDocenteBtn = new System.Windows.Forms.Button();
            this.ModificarMateriaBtn = new System.Windows.Forms.Button();
            this.AltaDeMateriaBtn = new System.Windows.Forms.Button();
            this.listBoxMaterias = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxMaterias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AgregarAlumnoEnMateria);
            this.panel1.Controls.Add(this.AltaBajaDocenteBtn);
            this.panel1.Controls.Add(this.ModificarMateriaBtn);
            this.panel1.Controls.Add(this.AltaDeMateriaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 322);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Gestión Materias";
            // 
            // AgregarAlumnoEnMateria
            // 
            this.AgregarAlumnoEnMateria.Location = new System.Drawing.Point(325, 99);
            this.AgregarAlumnoEnMateria.Name = "AgregarAlumnoEnMateria";
            this.AgregarAlumnoEnMateria.Size = new System.Drawing.Size(94, 51);
            this.AgregarAlumnoEnMateria.TabIndex = 5;
            this.AgregarAlumnoEnMateria.Text = "Alta y baja de Alumno en una Materia";
            this.AgregarAlumnoEnMateria.UseVisualStyleBackColor = true;
            this.AgregarAlumnoEnMateria.Click += new System.EventHandler(this.AgregarAlumnoEnMateria_Click);
            // 
            // AltaBajaDocenteBtn
            // 
            this.AltaBajaDocenteBtn.Location = new System.Drawing.Point(325, 182);
            this.AltaBajaDocenteBtn.Name = "AltaBajaDocenteBtn";
            this.AltaBajaDocenteBtn.Size = new System.Drawing.Size(94, 51);
            this.AltaBajaDocenteBtn.TabIndex = 3;
            this.AltaBajaDocenteBtn.Text = "Alta y baja de Docente en Materia";
            this.AltaBajaDocenteBtn.UseVisualStyleBackColor = true;
            this.AltaBajaDocenteBtn.Click += new System.EventHandler(this.AltaBajaDocenteBtn_Click);
            // 
            // ModificarMateriaBtn
            // 
            this.ModificarMateriaBtn.Location = new System.Drawing.Point(195, 182);
            this.ModificarMateriaBtn.Name = "ModificarMateriaBtn";
            this.ModificarMateriaBtn.Size = new System.Drawing.Size(94, 51);
            this.ModificarMateriaBtn.TabIndex = 2;
            this.ModificarMateriaBtn.Text = "Modificación de Materia";
            this.ModificarMateriaBtn.UseVisualStyleBackColor = true;
            this.ModificarMateriaBtn.Click += new System.EventHandler(this.ModificarMateriaBtn_Click);
            // 
            // AltaDeMateriaBtn
            // 
            this.AltaDeMateriaBtn.Location = new System.Drawing.Point(195, 99);
            this.AltaDeMateriaBtn.Name = "AltaDeMateriaBtn";
            this.AltaDeMateriaBtn.Size = new System.Drawing.Size(94, 51);
            this.AltaDeMateriaBtn.TabIndex = 0;
            this.AltaDeMateriaBtn.Text = "Alta y baja de Materia";
            this.AltaDeMateriaBtn.UseVisualStyleBackColor = true;
            this.AltaDeMateriaBtn.Click += new System.EventHandler(this.AltaBajaDeMateriaBtn_Click);
            // 
            // listBoxMaterias
            // 
            this.listBoxMaterias.FormattingEnabled = true;
            this.listBoxMaterias.Location = new System.Drawing.Point(521, 99);
            this.listBoxMaterias.Name = "listBoxMaterias";
            this.listBoxMaterias.Size = new System.Drawing.Size(223, 186);
            this.listBoxMaterias.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Listado de Materias:";
            // 
            // MenuGestionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionMaterias";
            this.Size = new System.Drawing.Size(875, 322);
            this.Load += new System.EventHandler(this.MenuGestionMaterias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarAlumnoEnMateria;
        private System.Windows.Forms.Button AltaBajaDocenteBtn;
        private System.Windows.Forms.Button ModificarMateriaBtn;
        private System.Windows.Forms.Button AltaDeMateriaBtn;
        private System.Windows.Forms.ListBox listBoxMaterias;
        private System.Windows.Forms.Label label2;
    }
}
