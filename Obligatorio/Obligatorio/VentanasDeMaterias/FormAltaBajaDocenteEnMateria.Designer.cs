namespace Obligatorio.VentanasDeMaterias
{
    partial class FormAltaBajaDocenteEnMateria
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
            this.docentesNoDictanListBox = new System.Windows.Forms.ListBox();
            this.docentesDictanListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AsignarDocenteBtn = new System.Windows.Forms.Button();
            this.VolverAlMenuBtn = new System.Windows.Forms.Button();
            this.QuitarDocenteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMaterias
            // 
            this.listBoxMaterias.FormattingEnabled = true;
            this.listBoxMaterias.Location = new System.Drawing.Point(12, 80);
            this.listBoxMaterias.Name = "listBoxMaterias";
            this.listBoxMaterias.Size = new System.Drawing.Size(207, 212);
            this.listBoxMaterias.TabIndex = 4;
            this.listBoxMaterias.SelectedIndexChanged += new System.EventHandler(this.listBoxMaterias_SelectedIndexChanged);
            // 
            // docentesNoDictanListBox
            // 
            this.docentesNoDictanListBox.FormattingEnabled = true;
            this.docentesNoDictanListBox.Location = new System.Drawing.Point(274, 80);
            this.docentesNoDictanListBox.Name = "docentesNoDictanListBox";
            this.docentesNoDictanListBox.Size = new System.Drawing.Size(218, 212);
            this.docentesNoDictanListBox.TabIndex = 7;
            // 
            // docentesDictanListBox
            // 
            this.docentesDictanListBox.FormattingEnabled = true;
            this.docentesDictanListBox.Location = new System.Drawing.Point(544, 80);
            this.docentesDictanListBox.Name = "docentesDictanListBox";
            this.docentesDictanListBox.Size = new System.Drawing.Size(207, 212);
            this.docentesDictanListBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Docentes que no dictan la materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Docentes que dictan la materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Listado de Materias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Alta y Baja de Docentes en Materias";
            // 
            // AsignarDocenteBtn
            // 
            this.AsignarDocenteBtn.Location = new System.Drawing.Point(337, 298);
            this.AsignarDocenteBtn.Name = "AsignarDocenteBtn";
            this.AsignarDocenteBtn.Size = new System.Drawing.Size(94, 40);
            this.AsignarDocenteBtn.TabIndex = 15;
            this.AsignarDocenteBtn.Text = "Asignar Docente a la Materia";
            this.AsignarDocenteBtn.UseVisualStyleBackColor = true;
            this.AsignarDocenteBtn.Click += new System.EventHandler(this.AsignarDocenteBtn_Click);
            // 
            // VolverAlMenuBtn
            // 
            this.VolverAlMenuBtn.Location = new System.Drawing.Point(466, 298);
            this.VolverAlMenuBtn.Name = "VolverAlMenuBtn";
            this.VolverAlMenuBtn.Size = new System.Drawing.Size(94, 40);
            this.VolverAlMenuBtn.TabIndex = 16;
            this.VolverAlMenuBtn.Text = "Salir";
            this.VolverAlMenuBtn.UseVisualStyleBackColor = true;
            this.VolverAlMenuBtn.Click += new System.EventHandler(this.VolverAlMenuBtn_Click);
            // 
            // QuitarDocenteBtn
            // 
            this.QuitarDocenteBtn.Location = new System.Drawing.Point(604, 298);
            this.QuitarDocenteBtn.Name = "QuitarDocenteBtn";
            this.QuitarDocenteBtn.Size = new System.Drawing.Size(94, 40);
            this.QuitarDocenteBtn.TabIndex = 17;
            this.QuitarDocenteBtn.Text = "Quitar Docente de la Materia";
            this.QuitarDocenteBtn.UseVisualStyleBackColor = true;
            this.QuitarDocenteBtn.Click += new System.EventHandler(this.QuitarDocenteBtn_Click);
            // 
            // FormAltaBajaDocenteEnMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 362);
            this.Controls.Add(this.QuitarDocenteBtn);
            this.Controls.Add(this.VolverAlMenuBtn);
            this.Controls.Add(this.AsignarDocenteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docentesDictanListBox);
            this.Controls.Add(this.docentesNoDictanListBox);
            this.Controls.Add(this.listBoxMaterias);
            this.Name = "FormAltaBajaDocenteEnMateria";
            this.Text = "FormAltaBajaDocenteEnMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMaterias;
        private System.Windows.Forms.ListBox docentesNoDictanListBox;
        private System.Windows.Forms.ListBox docentesDictanListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AsignarDocenteBtn;
        private System.Windows.Forms.Button VolverAlMenuBtn;
        private System.Windows.Forms.Button QuitarDocenteBtn;
    }
}