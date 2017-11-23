namespace Obligatorio.VentanasDeActividad
{
    partial class FormAltaActividad
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
            this.salirBtn = new System.Windows.Forms.Button();
            this.altaDeActividadBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxActividades = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.numericCosto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(240, 265);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(94, 34);
            this.salirBtn.TabIndex = 30;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // altaDeActividadBtn
            // 
            this.altaDeActividadBtn.Location = new System.Drawing.Point(108, 265);
            this.altaDeActividadBtn.Name = "altaDeActividadBtn";
            this.altaDeActividadBtn.Size = new System.Drawing.Size(94, 34);
            this.altaDeActividadBtn.TabIndex = 29;
            this.altaDeActividadBtn.Text = "Registrar Actividad";
            this.altaDeActividadBtn.UseVisualStyleBackColor = true;
            this.altaDeActividadBtn.Click += new System.EventHandler(this.altaDeActividadBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Listado de Actividades:";
            // 
            // listBoxActividades
            // 
            this.listBoxActividades.FormattingEnabled = true;
            this.listBoxActividades.Location = new System.Drawing.Point(376, 74);
            this.listBoxActividades.Name = "listBoxActividades";
            this.listBoxActividades.Size = new System.Drawing.Size(230, 225);
            this.listBoxActividades.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Alta De Actividad";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(120, 74);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(195, 20);
            this.nombreTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-103, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-103, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-103, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-103, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(120, 185);
            this.fechaPicker.MinDate = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(195, 20);
            this.fechaPicker.TabIndex = 31;
            this.fechaPicker.Value = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            // 
            // numericCosto
            // 
            this.numericCosto.DecimalPlaces = 2;
            this.numericCosto.Location = new System.Drawing.Point(120, 129);
            this.numericCosto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCosto.Name = "numericCosto";
            this.numericCosto.Size = new System.Drawing.Size(195, 20);
            this.numericCosto.TabIndex = 63;
            this.numericCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormAltaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 349);
            this.Controls.Add(this.numericCosto);
            this.Controls.Add(this.fechaPicker);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.altaDeActividadBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxActividades);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaActividad";
            this.Text = "FormAltaActividad";
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Button altaDeActividadBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxActividades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.NumericUpDown numericCosto;
    }
}