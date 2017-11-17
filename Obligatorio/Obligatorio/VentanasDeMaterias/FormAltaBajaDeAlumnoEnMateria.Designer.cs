namespace Obligatorio.VentanasDeMaterias
{
    partial class FormAltaBajaDeAlumnoEnMateria
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
            this.listBoxMaterias = new System.Windows.Forms.ListBox();
            this.alumnosNoCursanListBox = new System.Windows.Forms.ListBox();
            this.alumnosInscriptosListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InscribirAlumnoEnMateriaBtn = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.desinscribirAlumnoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMaterias
            // 
            this.listBoxMaterias.FormattingEnabled = true;
            this.listBoxMaterias.Location = new System.Drawing.Point(12, 80);
            this.listBoxMaterias.Name = "listBoxMaterias";
            this.listBoxMaterias.Size = new System.Drawing.Size(207, 212);
            this.listBoxMaterias.TabIndex = 3;
            this.listBoxMaterias.SelectedIndexChanged += new System.EventHandler(this.listBoxMaterias_SelectedIndexChanged);
            // 
            // alumnosNoCursanListBox
            // 
            this.alumnosNoCursanListBox.FormattingEnabled = true;
            this.alumnosNoCursanListBox.Location = new System.Drawing.Point(274, 80);
            this.alumnosNoCursanListBox.Name = "alumnosNoCursanListBox";
            this.alumnosNoCursanListBox.Size = new System.Drawing.Size(218, 212);
            this.alumnosNoCursanListBox.TabIndex = 6;
            // 
            // alumnosInscriptosListBox
            // 
            this.alumnosInscriptosListBox.FormattingEnabled = true;
            this.alumnosInscriptosListBox.Location = new System.Drawing.Point(531, 80);
            this.alumnosInscriptosListBox.Name = "alumnosInscriptosListBox";
            this.alumnosInscriptosListBox.Size = new System.Drawing.Size(207, 212);
            this.alumnosInscriptosListBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alta y baja de Alumno en Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Listado de Alumnos que no cursan la materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alumnos inscriptos en la materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Listado de Materias:";
            // 
            // InscribirAlumnoEnMateriaBtn
            // 
            this.InscribirAlumnoEnMateriaBtn.Location = new System.Drawing.Point(337, 310);
            this.InscribirAlumnoEnMateriaBtn.Name = "InscribirAlumnoEnMateriaBtn";
            this.InscribirAlumnoEnMateriaBtn.Size = new System.Drawing.Size(94, 40);
            this.InscribirAlumnoEnMateriaBtn.TabIndex = 13;
            this.InscribirAlumnoEnMateriaBtn.Text = "Inscribir Alumno";
            this.InscribirAlumnoEnMateriaBtn.UseVisualStyleBackColor = true;
            this.InscribirAlumnoEnMateriaBtn.Click += new System.EventHandler(this.InscribirAlumnoEnMateriaBtn_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(480, 310);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 40);
            this.salir.TabIndex = 14;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // desinscribirAlumnoBtn
            // 
            this.desinscribirAlumnoBtn.Location = new System.Drawing.Point(622, 310);
            this.desinscribirAlumnoBtn.Name = "desinscribirAlumnoBtn";
            this.desinscribirAlumnoBtn.Size = new System.Drawing.Size(94, 40);
            this.desinscribirAlumnoBtn.TabIndex = 15;
            this.desinscribirAlumnoBtn.Text = "Desinscribir Alumno";
            this.desinscribirAlumnoBtn.UseVisualStyleBackColor = true;
            this.desinscribirAlumnoBtn.Click += new System.EventHandler(this.desinscribirAlumnoBtn_Click);
            // 
            // FormAltaBajaDeAlumnoEnMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 362);
            this.Controls.Add(this.desinscribirAlumnoBtn);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.InscribirAlumnoEnMateriaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alumnosInscriptosListBox);
            this.Controls.Add(this.alumnosNoCursanListBox);
            this.Controls.Add(this.listBoxMaterias);
            this.Name = "FormAltaBajaDeAlumnoEnMateria";
            this.Text = "FormAltaBajaDeAlumnoEnMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMaterias;
        private System.Windows.Forms.ListBox alumnosNoCursanListBox;
        private System.Windows.Forms.ListBox alumnosInscriptosListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InscribirAlumnoEnMateriaBtn;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button desinscribirAlumnoBtn;
    }
}