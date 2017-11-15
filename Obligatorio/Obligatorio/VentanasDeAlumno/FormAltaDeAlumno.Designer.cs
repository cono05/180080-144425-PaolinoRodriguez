namespace Obligatorio.VentanasDeAlumno
{
    partial class FormAltaDeAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxAlumnos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de alumnos:";
            // 
            // ListBoxAlumnos
            // 
            this.ListBoxAlumnos.FormattingEnabled = true;
            this.ListBoxAlumnos.Location = new System.Drawing.Point(473, 64);
            this.ListBoxAlumnos.Name = "ListBoxAlumnos";
            this.ListBoxAlumnos.Size = new System.Drawing.Size(235, 316);
            this.ListBoxAlumnos.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Alta de Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cédula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "E-mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 202);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(188, 20);
            this.emailTextBox.TabIndex = 32;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.Location = new System.Drawing.Point(95, 151);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(188, 20);
            this.cedulaTextBox.TabIndex = 33;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(95, 112);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(188, 20);
            this.apellidoTextBox.TabIndex = 34;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(95, 74);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(188, 20);
            this.nombreTextBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "Formato esperado: 1234567-8";
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(215, 289);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(94, 51);
            this.BotonAgregar.TabIndex = 37;
            this.BotonAgregar.Text = "Agregar Alumno";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.AgregarAlumno_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(343, 289);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(94, 51);
            this.BotonCancelar.TabIndex = 38;
            this.BotonCancelar.Text = "Salir";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // FormAltaDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 406);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBoxAlumnos);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaDeAlumno";
            this.Text = "FormAltaDeAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonCancelar;
    }
}