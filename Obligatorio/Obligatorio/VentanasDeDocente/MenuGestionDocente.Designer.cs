namespace Obligatorio
{
    partial class MenuGestionDocente
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
            this.VolverBtn = new System.Windows.Forms.Button();
            this.ModificarDocenteBtn = new System.Windows.Forms.Button();
            this.BajaDocenteBtn = new System.Windows.Forms.Button();
            this.AltaDocenteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VolverBtn);
            this.panel1.Controls.Add(this.ModificarDocenteBtn);
            this.panel1.Controls.Add(this.BajaDocenteBtn);
            this.panel1.Controls.Add(this.AltaDocenteBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(397, 271);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(94, 40);
            this.VolverBtn.TabIndex = 13;
            this.VolverBtn.Text = "Volver al Menú Principal";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // ModificarDocenteBtn
            // 
            this.ModificarDocenteBtn.Location = new System.Drawing.Point(593, 135);
            this.ModificarDocenteBtn.Name = "ModificarDocenteBtn";
            this.ModificarDocenteBtn.Size = new System.Drawing.Size(94, 40);
            this.ModificarDocenteBtn.TabIndex = 12;
            this.ModificarDocenteBtn.Text = "Modificar Docente";
            this.ModificarDocenteBtn.UseVisualStyleBackColor = true;
            this.ModificarDocenteBtn.Click += new System.EventHandler(this.ModificarDocenteBtn_Click);
            // 
            // BajaDocenteBtn
            // 
            this.BajaDocenteBtn.Location = new System.Drawing.Point(397, 135);
            this.BajaDocenteBtn.Name = "BajaDocenteBtn";
            this.BajaDocenteBtn.Size = new System.Drawing.Size(94, 40);
            this.BajaDocenteBtn.TabIndex = 11;
            this.BajaDocenteBtn.Text = "Baja de Docente";
            this.BajaDocenteBtn.UseVisualStyleBackColor = true;
            this.BajaDocenteBtn.Click += new System.EventHandler(this.BajaDocenteBtn_Click);
            // 
            // AltaDocenteBtn
            // 
            this.AltaDocenteBtn.Location = new System.Drawing.Point(201, 135);
            this.AltaDocenteBtn.Name = "AltaDocenteBtn";
            this.AltaDocenteBtn.Size = new System.Drawing.Size(94, 40);
            this.AltaDocenteBtn.TabIndex = 10;
            this.AltaDocenteBtn.Text = "Alta de Docente";
            this.AltaDocenteBtn.UseVisualStyleBackColor = true;
            this.AltaDocenteBtn.Click += new System.EventHandler(this.AltaDocenteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menú Gestión Docentes";
            // 
            // MenuGestionDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionDocente";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ModificarDocenteBtn;
        private System.Windows.Forms.Button BajaDocenteBtn;
        private System.Windows.Forms.Button AltaDocenteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VolverBtn;
    }
}
