namespace Obligatorio
{
    partial class AltaDeCamioneta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.ChapaTextBox = new System.Windows.Forms.TextBox();
            this.CapacidadTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgregarCamionetaBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AgregarCamionetaBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CapacidadTextBox);
            this.panel1.Controls.Add(this.ChapaTextBox);
            this.panel1.Controls.Add(this.MarcaTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Camioneta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chapa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidad:";
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Location = new System.Drawing.Point(312, 124);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(183, 20);
            this.MarcaTextBox.TabIndex = 4;
            // 
            // ChapaTextBox
            // 
            this.ChapaTextBox.Location = new System.Drawing.Point(312, 161);
            this.ChapaTextBox.Name = "ChapaTextBox";
            this.ChapaTextBox.Size = new System.Drawing.Size(183, 20);
            this.ChapaTextBox.TabIndex = 5;
            // 
            // CapacidadTextBox
            // 
            this.CapacidadTextBox.Location = new System.Drawing.Point(312, 207);
            this.CapacidadTextBox.Name = "CapacidadTextBox";
            this.CapacidadTextBox.Size = new System.Drawing.Size(39, 20);
            this.CapacidadTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "(Número entre 1 y 40)";
            // 
            // AgregarCamionetaBtn
            // 
            this.AgregarCamionetaBtn.Location = new System.Drawing.Point(279, 302);
            this.AgregarCamionetaBtn.Name = "AgregarCamionetaBtn";
            this.AgregarCamionetaBtn.Size = new System.Drawing.Size(94, 40);
            this.AgregarCamionetaBtn.TabIndex = 8;
            this.AgregarCamionetaBtn.Text = "Agregar Camioneta";
            this.AgregarCamionetaBtn.UseVisualStyleBackColor = true;
            this.AgregarCamionetaBtn.Click += new System.EventHandler(this.AgregarCamionetaBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Volver al Menú";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AltaDeCamioneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AltaDeCamioneta";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CapacidadTextBox;
        private System.Windows.Forms.TextBox ChapaTextBox;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AgregarCamionetaBtn;
    }
}
