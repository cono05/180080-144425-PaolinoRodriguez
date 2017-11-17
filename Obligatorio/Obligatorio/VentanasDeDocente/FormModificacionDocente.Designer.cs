namespace Obligatorio.VentanasDeDocente
{
    partial class FormModificacionDocente
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
            this.listBoxDocentes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modificarDocenteBtn = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDocentes
            // 
            this.listBoxDocentes.FormattingEnabled = true;
            this.listBoxDocentes.Location = new System.Drawing.Point(40, 85);
            this.listBoxDocentes.Name = "listBoxDocentes";
            this.listBoxDocentes.Size = new System.Drawing.Size(181, 225);
            this.listBoxDocentes.TabIndex = 43;
            this.listBoxDocentes.SelectedIndexChanged += new System.EventHandler(this.listBoxDocentes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Modificar Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Listado de docentes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cedula:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(330, 140);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(188, 20);
            this.textBoxApellido.TabIndex = 49;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(329, 85);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(188, 20);
            this.textBoxNombre.TabIndex = 50;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(330, 191);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(188, 20);
            this.textBoxCedula.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 12);
            this.label6.TabIndex = 52;
            this.label6.Text = "Formato esperado: 1234567-8";
            // 
            // modificarDocenteBtn
            // 
            this.modificarDocenteBtn.Location = new System.Drawing.Point(279, 276);
            this.modificarDocenteBtn.Name = "modificarDocenteBtn";
            this.modificarDocenteBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.modificarDocenteBtn.Size = new System.Drawing.Size(94, 34);
            this.modificarDocenteBtn.TabIndex = 53;
            this.modificarDocenteBtn.Text = "Modificar Docente";
            this.modificarDocenteBtn.UseVisualStyleBackColor = true;
            this.modificarDocenteBtn.Click += new System.EventHandler(this.modificarDocenteBtn_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(424, 276);
            this.salir.Name = "salir";
            this.salir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salir.Size = new System.Drawing.Size(94, 34);
            this.salir.TabIndex = 54;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // FormModificacionDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 334);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificarDocenteBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDocentes);
            this.Name = "FormModificacionDocente";
            this.Text = "FormModificacionDocente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDocentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modificarDocenteBtn;
        private System.Windows.Forms.Button salir;
    }
}