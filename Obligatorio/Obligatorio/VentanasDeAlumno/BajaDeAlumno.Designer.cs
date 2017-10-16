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
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxAlumnos);
            this.panel1.Controls.Add(this.buttonVolver);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(205, 143);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(235, 160);
            this.listBoxAlumnos.TabIndex = 25;
            this.listBoxAlumnos.SelectedIndexChanged += new System.EventHandler(this.listBoxAlumnos_SelectedIndexChanged);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(556, 252);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(94, 51);
            this.buttonVolver.TabIndex = 24;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(556, 143);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 51);
            this.buttonEliminar.TabIndex = 23;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label1;
    }
}
