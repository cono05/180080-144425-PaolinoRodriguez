namespace Obligatorio.VentanasDeActividad
{
    partial class MenuGestionActividad
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxActividad = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BajaActividadBtn = new System.Windows.Forms.Button();
            this.ModificarActividadBtn = new System.Windows.Forms.Button();
            this.AltaActividadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxActividad
            // 
            this.listBoxActividad.FormattingEnabled = true;
            this.listBoxActividad.Location = new System.Drawing.Point(432, 79);
            this.listBoxActividad.Name = "listBoxActividad";
            this.listBoxActividad.Size = new System.Drawing.Size(335, 186);
            this.listBoxActividad.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Listado de actividades:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menú Gestión Actividades";
            // 
            // BajaActividadBtn
            // 
            this.BajaActividadBtn.Location = new System.Drawing.Point(243, 158);
            this.BajaActividadBtn.Name = "BajaActividadBtn";
            this.BajaActividadBtn.Size = new System.Drawing.Size(94, 51);
            this.BajaActividadBtn.TabIndex = 13;
            this.BajaActividadBtn.Text = "Baja Actividad";
            this.BajaActividadBtn.UseVisualStyleBackColor = true;
            this.BajaActividadBtn.Click += new System.EventHandler(this.BajaActividadBtn_Click);
            // 
            // ModificarActividadBtn
            // 
            this.ModificarActividadBtn.Location = new System.Drawing.Point(243, 229);
            this.ModificarActividadBtn.Name = "ModificarActividadBtn";
            this.ModificarActividadBtn.Size = new System.Drawing.Size(94, 51);
            this.ModificarActividadBtn.TabIndex = 12;
            this.ModificarActividadBtn.Text = "Modificar Actividad";
            this.ModificarActividadBtn.UseVisualStyleBackColor = true;
            this.ModificarActividadBtn.Click += new System.EventHandler(this.ModificarActividadBtn_Click);
            // 
            // AltaActividadBtn
            // 
            this.AltaActividadBtn.Location = new System.Drawing.Point(243, 79);
            this.AltaActividadBtn.Name = "AltaActividadBtn";
            this.AltaActividadBtn.Size = new System.Drawing.Size(94, 51);
            this.AltaActividadBtn.TabIndex = 11;
            this.AltaActividadBtn.Text = "Alta Actividad";
            this.AltaActividadBtn.UseVisualStyleBackColor = true;
            this.AltaActividadBtn.Click += new System.EventHandler(this.AltaActividadBtn_Click);
            // 
            // MenuGestionActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxActividad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BajaActividadBtn);
            this.Controls.Add(this.ModificarActividadBtn);
            this.Controls.Add(this.AltaActividadBtn);
            this.Name = "MenuGestionActividad";
            this.Size = new System.Drawing.Size(875, 322);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxActividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BajaActividadBtn;
        private System.Windows.Forms.Button ModificarActividadBtn;
        private System.Windows.Forms.Button AltaActividadBtn;
    }
}
