namespace Obligatorio.VentanasDeActividad
{
    partial class FormModificarActividad
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
            this.SalirBtn = new System.Windows.Forms.Button();
            this.ModificarActividadBtn = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxActividad = new System.Windows.Forms.ListBox();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.numericCosto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Seleccione el actividad:";
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(368, 260);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(96, 55);
            this.SalirBtn.TabIndex = 59;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // ModificarActividadBtn
            // 
            this.ModificarActividadBtn.Location = new System.Drawing.Point(218, 260);
            this.ModificarActividadBtn.Name = "ModificarActividadBtn";
            this.ModificarActividadBtn.Size = new System.Drawing.Size(96, 55);
            this.ModificarActividadBtn.TabIndex = 58;
            this.ModificarActividadBtn.Text = "Modificar";
            this.ModificarActividadBtn.UseVisualStyleBackColor = true;
            this.ModificarActividadBtn.Click += new System.EventHandler(this.ModificarActividadBtn_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(396, 70);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(201, 20);
            this.textBoxNombre.TabIndex = 54;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Modificar Actividad";
            // 
            // listBoxActividad
            // 
            this.listBoxActividad.FormattingEnabled = true;
            this.listBoxActividad.Location = new System.Drawing.Point(35, 69);
            this.listBoxActividad.Name = "listBoxActividad";
            this.listBoxActividad.Size = new System.Drawing.Size(265, 160);
            this.listBoxActividad.TabIndex = 47;
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(396, 159);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(201, 20);
            this.fechaPicker.TabIndex = 61;
            // 
            // numericCosto
            // 
            this.numericCosto.DecimalPlaces = 2;
            this.numericCosto.Location = new System.Drawing.Point(396, 114);
            this.numericCosto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCosto.Name = "numericCosto";
            this.numericCosto.Size = new System.Drawing.Size(201, 20);
            this.numericCosto.TabIndex = 62;
            this.numericCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormModificarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 347);
            this.Controls.Add(this.numericCosto);
            this.Controls.Add(this.fechaPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.ModificarActividadBtn);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxActividad);
            this.Name = "FormModificarActividad";
            this.Text = "FormModificarActividad";
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.Button ModificarActividadBtn;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxActividad;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.NumericUpDown numericCosto;
    }
}