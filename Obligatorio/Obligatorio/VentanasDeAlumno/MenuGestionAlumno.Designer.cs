﻿namespace Obligatorio.VentanasDeAlumno
{
    partial class MenuGestionAlumno
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BajaAlumnoBtn = new System.Windows.Forms.Button();
            this.ModificarAlumnoBtn = new System.Windows.Forms.Button();
            this.AltaAlumnoBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxAlumnos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BajaAlumnoBtn);
            this.panel1.Controls.Add(this.ModificarAlumnoBtn);
            this.panel1.Controls.Add(this.AltaAlumnoBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 322);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(442, 80);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(223, 186);
            this.listBoxAlumnos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Listado de alumnos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menú Gestión Alumnos";
            // 
            // BajaAlumnoBtn
            // 
            this.BajaAlumnoBtn.Location = new System.Drawing.Point(253, 159);
            this.BajaAlumnoBtn.Name = "BajaAlumnoBtn";
            this.BajaAlumnoBtn.Size = new System.Drawing.Size(94, 51);
            this.BajaAlumnoBtn.TabIndex = 7;
            this.BajaAlumnoBtn.Text = "Baja Alumno";
            this.BajaAlumnoBtn.UseVisualStyleBackColor = true;
            this.BajaAlumnoBtn.Click += new System.EventHandler(this.BajaAlumnoBtn_Click);
            // 
            // ModificarAlumnoBtn
            // 
            this.ModificarAlumnoBtn.Location = new System.Drawing.Point(253, 230);
            this.ModificarAlumnoBtn.Name = "ModificarAlumnoBtn";
            this.ModificarAlumnoBtn.Size = new System.Drawing.Size(94, 51);
            this.ModificarAlumnoBtn.TabIndex = 6;
            this.ModificarAlumnoBtn.Text = "Modificar Alumno";
            this.ModificarAlumnoBtn.UseVisualStyleBackColor = true;
            this.ModificarAlumnoBtn.Click += new System.EventHandler(this.ModificarAlumnoBtn_Click);
            // 
            // AltaAlumnoBtn
            // 
            this.AltaAlumnoBtn.Location = new System.Drawing.Point(253, 80);
            this.AltaAlumnoBtn.Name = "AltaAlumnoBtn";
            this.AltaAlumnoBtn.Size = new System.Drawing.Size(94, 51);
            this.AltaAlumnoBtn.TabIndex = 5;
            this.AltaAlumnoBtn.Text = "Alta Alumno";
            this.AltaAlumnoBtn.UseVisualStyleBackColor = true;
            this.AltaAlumnoBtn.Click += new System.EventHandler(this.AltaAlumnoBtn_Click);
            // 
            // MenuGestionAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionAlumno";
            this.Size = new System.Drawing.Size(875, 322);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BajaAlumnoBtn;
        private System.Windows.Forms.Button ModificarAlumnoBtn;
        private System.Windows.Forms.Button AltaAlumnoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAlumnos;
    }
}
