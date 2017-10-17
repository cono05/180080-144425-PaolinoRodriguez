namespace Obligatorio.VentanasDeDocente
{
    partial class BajaDeDocente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBoxDocentes = new System.Windows.Forms.ListBox();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.EliminarDocenteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxDocentes);
            this.panel1.Controls.Add(this.VolverBtn);
            this.panel1.Controls.Add(this.EliminarDocenteBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // ListBoxDocentes
            // 
            this.ListBoxDocentes.FormattingEnabled = true;
            this.ListBoxDocentes.Location = new System.Drawing.Point(208, 131);
            this.ListBoxDocentes.Name = "ListBoxDocentes";
            this.ListBoxDocentes.Size = new System.Drawing.Size(235, 160);
            this.ListBoxDocentes.TabIndex = 29;
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(559, 240);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(94, 51);
            this.VolverBtn.TabIndex = 28;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // EliminarDocenteBtn
            // 
            this.EliminarDocenteBtn.Location = new System.Drawing.Point(559, 131);
            this.EliminarDocenteBtn.Name = "EliminarDocenteBtn";
            this.EliminarDocenteBtn.Size = new System.Drawing.Size(94, 51);
            this.EliminarDocenteBtn.TabIndex = 27;
            this.EliminarDocenteBtn.Text = "Eliminar";
            this.EliminarDocenteBtn.UseVisualStyleBackColor = true;
            this.EliminarDocenteBtn.Click += new System.EventHandler(this.EliminarDocenteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Baja De Docente";
            // 
            // BajaDeDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BajaDeDocente";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBoxDocentes;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button EliminarDocenteBtn;
        private System.Windows.Forms.Label label1;
    }
}
