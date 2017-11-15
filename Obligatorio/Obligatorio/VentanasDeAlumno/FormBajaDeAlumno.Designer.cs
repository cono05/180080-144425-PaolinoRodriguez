namespace Obligatorio.VentanasDeAlumno
{
    partial class FormBajaDeAlumno
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxAlumnos = new System.Windows.Forms.ListBox();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxAlumnos
            // 
            this.ListBoxAlumnos.FormattingEnabled = true;
            this.ListBoxAlumnos.Location = new System.Drawing.Point(177, 78);
            this.ListBoxAlumnos.Name = "ListBoxAlumnos";
            this.ListBoxAlumnos.Size = new System.Drawing.Size(235, 316);
            this.ListBoxAlumnos.TabIndex = 26;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(459, 179);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(94, 51);
            this.BotonEliminar.TabIndex = 27;
            this.BotonEliminar.Text = "Eliminar Alumno";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            // 
            // BotonVolver
            // 
            this.BotonVolver.Location = new System.Drawing.Point(578, 179);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(94, 51);
            this.BotonVolver.TabIndex = 28;
            this.BotonVolver.Text = "Salir";
            this.BotonVolver.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Baja de Alumno";
            // 
            // FormBajaDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonVolver);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.ListBoxAlumnos);
            this.Name = "FormBajaDeAlumno";
            this.Text = "FormBajaDeAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxAlumnos;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Label label2;
    }
}