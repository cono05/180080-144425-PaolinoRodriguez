﻿namespace Obligatorio
{
    partial class AltaDeAlumnoEnMateria
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MateriasListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AlumnosNoCursanListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AlumnosInscriptosListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(398, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.AlumnosInscriptosListBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.AlumnosNoCursanListBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MateriasListBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 406);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Alumno en Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listado de Materias:";
            // 
            // MateriasListBox
            // 
            this.MateriasListBox.FormattingEnabled = true;
            this.MateriasListBox.Location = new System.Drawing.Point(36, 81);
            this.MateriasListBox.Name = "MateriasListBox";
            this.MateriasListBox.Size = new System.Drawing.Size(207, 212);
            this.MateriasListBox.TabIndex = 2;
            this.MateriasListBox.SelectedIndexChanged += new System.EventHandler(this.MateriasListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Listado de Alumnos que no cursan la materia:";
            // 
            // AlumnosNoCursanListBox
            // 
            this.AlumnosNoCursanListBox.FormattingEnabled = true;
            this.AlumnosNoCursanListBox.Location = new System.Drawing.Point(322, 81);
            this.AlumnosNoCursanListBox.Name = "AlumnosNoCursanListBox";
            this.AlumnosNoCursanListBox.Size = new System.Drawing.Size(207, 212);
            this.AlumnosNoCursanListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alumnos inscriptos en la materia:";
            // 
            // AlumnosInscriptosListBox
            // 
            this.AlumnosInscriptosListBox.FormattingEnabled = true;
            this.AlumnosInscriptosListBox.Location = new System.Drawing.Point(615, 81);
            this.AlumnosInscriptosListBox.Name = "AlumnosInscriptosListBox";
            this.AlumnosInscriptosListBox.Size = new System.Drawing.Size(207, 212);
            this.AlumnosInscriptosListBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Inscribir Alumno";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "Volver al Menú";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AltaDeAlumnoEnMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AltaDeAlumnoEnMateria";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox MateriasListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox AlumnosInscriptosListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox AlumnosNoCursanListBox;
        private System.Windows.Forms.Label label3;
    }
}
