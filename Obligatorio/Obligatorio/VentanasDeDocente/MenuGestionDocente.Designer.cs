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
            this.ModificarDocenteBtn = new System.Windows.Forms.Button();
            this.BajaDocenteBtn = new System.Windows.Forms.Button();
            this.AltaDocenteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDocentes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxDocentes);
            this.panel1.Controls.Add(this.ModificarDocenteBtn);
            this.panel1.Controls.Add(this.BajaDocenteBtn);
            this.panel1.Controls.Add(this.AltaDocenteBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 322);
            this.panel1.TabIndex = 0;
            // 
            // ModificarDocenteBtn
            // 
            this.ModificarDocenteBtn.Location = new System.Drawing.Point(253, 230);
            this.ModificarDocenteBtn.Name = "ModificarDocenteBtn";
            this.ModificarDocenteBtn.Size = new System.Drawing.Size(94, 51);
            this.ModificarDocenteBtn.TabIndex = 12;
            this.ModificarDocenteBtn.Text = "Modificar Docente";
            this.ModificarDocenteBtn.UseVisualStyleBackColor = true;
            this.ModificarDocenteBtn.Click += new System.EventHandler(this.ModificarDocenteBtn_Click);
            // 
            // BajaDocenteBtn
            // 
            this.BajaDocenteBtn.Location = new System.Drawing.Point(253, 159);
            this.BajaDocenteBtn.Name = "BajaDocenteBtn";
            this.BajaDocenteBtn.Size = new System.Drawing.Size(94, 51);
            this.BajaDocenteBtn.TabIndex = 11;
            this.BajaDocenteBtn.Text = "Baja de Docente";
            this.BajaDocenteBtn.UseVisualStyleBackColor = true;
            this.BajaDocenteBtn.Click += new System.EventHandler(this.BajaDocenteBtn_Click);
            // 
            // AltaDocenteBtn
            // 
            this.AltaDocenteBtn.Location = new System.Drawing.Point(253, 80);
            this.AltaDocenteBtn.Name = "AltaDocenteBtn";
            this.AltaDocenteBtn.Size = new System.Drawing.Size(94, 51);
            this.AltaDocenteBtn.TabIndex = 10;
            this.AltaDocenteBtn.Text = "Alta de Docente";
            this.AltaDocenteBtn.UseVisualStyleBackColor = true;
            this.AltaDocenteBtn.Click += new System.EventHandler(this.AltaDocenteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menú Gestión Docentes";
            // 
            // listBoxDocentes
            // 
            this.listBoxDocentes.FormattingEnabled = true;
            this.listBoxDocentes.Location = new System.Drawing.Point(442, 80);
            this.listBoxDocentes.Name = "listBoxDocentes";
            this.listBoxDocentes.Size = new System.Drawing.Size(223, 186);
            this.listBoxDocentes.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Listado de Docentes:";
            // 
            // MenuGestionDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionDocente";
            this.Size = new System.Drawing.Size(875, 322);
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
        private System.Windows.Forms.ListBox listBoxDocentes;
        private System.Windows.Forms.Label label2;
    }
}
