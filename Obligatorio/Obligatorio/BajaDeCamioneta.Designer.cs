namespace Obligatorio
{
    partial class BajaDeCamioneta
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
            this.VolverAlMenuBtn = new System.Windows.Forms.Button();
            this.EliminarCamioneta = new System.Windows.Forms.Button();
            this.CamionetasListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VolverAlMenuBtn);
            this.panel1.Controls.Add(this.EliminarCamioneta);
            this.panel1.Controls.Add(this.CamionetasListBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // VolverAlMenuBtn
            // 
            this.VolverAlMenuBtn.Location = new System.Drawing.Point(472, 329);
            this.VolverAlMenuBtn.Name = "VolverAlMenuBtn";
            this.VolverAlMenuBtn.Size = new System.Drawing.Size(94, 40);
            this.VolverAlMenuBtn.TabIndex = 4;
            this.VolverAlMenuBtn.Text = "Volver al Menú";
            this.VolverAlMenuBtn.UseVisualStyleBackColor = true;
            this.VolverAlMenuBtn.Click += new System.EventHandler(this.VolverAlMenuBtn_Click);
            // 
            // EliminarCamioneta
            // 
            this.EliminarCamioneta.Location = new System.Drawing.Point(327, 329);
            this.EliminarCamioneta.Name = "EliminarCamioneta";
            this.EliminarCamioneta.Size = new System.Drawing.Size(94, 40);
            this.EliminarCamioneta.TabIndex = 3;
            this.EliminarCamioneta.Text = "Eliminar Camioneta";
            this.EliminarCamioneta.UseVisualStyleBackColor = true;
            this.EliminarCamioneta.Click += new System.EventHandler(this.EliminarCamionetaClick);
            // 
            // CamionetasListBox
            // 
            this.CamionetasListBox.FormattingEnabled = true;
            this.CamionetasListBox.Location = new System.Drawing.Point(355, 99);
            this.CamionetasListBox.Name = "CamionetasListBox";
            this.CamionetasListBox.Size = new System.Drawing.Size(178, 199);
            this.CamionetasListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listado de Camionetas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baja de Camioneta";
            // 
            // BajaDeCamioneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BajaDeCamioneta";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button VolverAlMenuBtn;
        private System.Windows.Forms.Button EliminarCamioneta;
        private System.Windows.Forms.ListBox CamionetasListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
