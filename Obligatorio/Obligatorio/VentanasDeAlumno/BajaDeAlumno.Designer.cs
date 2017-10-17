namespace Obligatorio.VentanasDeAlumno
{
    partial class BajaDeAlumno
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
            this.ListBoxAlumnos = new System.Windows.Forms.ListBox();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxAlumnos);
            this.panel1.Controls.Add(this.BotonVolver);
            this.panel1.Controls.Add(this.BotonEliminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ListBoxAlumnos
            // 
            this.ListBoxAlumnos.FormattingEnabled = true;
            this.ListBoxAlumnos.Location = new System.Drawing.Point(205, 143);
            this.ListBoxAlumnos.Name = "ListBoxAlumnos";
            this.ListBoxAlumnos.Size = new System.Drawing.Size(235, 160);
            this.ListBoxAlumnos.TabIndex = 25;
            // 
            // BotonVolver
            // 
            this.BotonVolver.Location = new System.Drawing.Point(556, 252);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(94, 51);
            this.BotonVolver.TabIndex = 24;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(556, 143);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(94, 51);
            this.BotonEliminar.TabIndex = 23;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.EliminarAlumnoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Baja De Alumno";
            // 
            // BajaDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BajaDeAlumno";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBoxAlumnos;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Label label1;
    }
}
