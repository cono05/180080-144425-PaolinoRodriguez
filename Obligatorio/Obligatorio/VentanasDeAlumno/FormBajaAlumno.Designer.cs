namespace Obligatorio.VentanasDeAlumno
{
    partial class FormBajaAlumno
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
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarAlumnoBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Baja de Alumno";
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(117, 67);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(197, 225);
            this.listBoxAlumnos.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Listado de Alumnos:";
            // 
            // eliminarAlumnoBtn
            // 
            this.eliminarAlumnoBtn.Location = new System.Drawing.Point(353, 258);
            this.eliminarAlumnoBtn.Name = "eliminarAlumnoBtn";
            this.eliminarAlumnoBtn.Size = new System.Drawing.Size(94, 34);
            this.eliminarAlumnoBtn.TabIndex = 16;
            this.eliminarAlumnoBtn.Text = "Eliminar Alumno";
            this.eliminarAlumnoBtn.UseVisualStyleBackColor = true;
            this.eliminarAlumnoBtn.Click += new System.EventHandler(this.EliminarAlumnoBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(465, 258);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(94, 34);
            this.SalirBtn.TabIndex = 17;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // FormBajaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 334);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.eliminarAlumnoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAlumnos);
            this.Controls.Add(this.label6);
            this.Name = "FormBajaAlumno";
            this.Text = "FormBajaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarAlumnoBtn;
        private System.Windows.Forms.Button SalirBtn;
    }
}