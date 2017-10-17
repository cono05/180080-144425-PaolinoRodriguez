namespace Obligatorio
{
    partial class MenuGestionCamionetas
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
            this.RegistrarCamionetaBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.RegistrarCamionetaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegistrarCamionetaBtn
            // 
            this.RegistrarCamionetaBtn.Location = new System.Drawing.Point(221, 143);
            this.RegistrarCamionetaBtn.Name = "RegistrarCamionetaBtn";
            this.RegistrarCamionetaBtn.Size = new System.Drawing.Size(94, 40);
            this.RegistrarCamionetaBtn.TabIndex = 0;
            this.RegistrarCamionetaBtn.Text = "Alta de Camioneta";
            this.RegistrarCamionetaBtn.UseVisualStyleBackColor = true;
            this.RegistrarCamionetaBtn.Click += new System.EventHandler(this.RegistrarCamionetaBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Baja de Camioneta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar Camioneta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(397, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Volver Al menu Principal";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú Gestión de Camionetas";
            // 
            // MenuGestionCamionetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionCamionetas";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RegistrarCamionetaBtn;
    }
}
