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
            this.verCamionetasXRendimiento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCamionetas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RegistrarCamionetaBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.verCamionetasXRendimiento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxCamionetas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.RegistrarCamionetaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 322);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // verCamionetasXRendimiento
            // 
            this.verCamionetasXRendimiento.Location = new System.Drawing.Point(338, 159);
            this.verCamionetasXRendimiento.Name = "verCamionetasXRendimiento";
            this.verCamionetasXRendimiento.Size = new System.Drawing.Size(94, 48);
            this.verCamionetasXRendimiento.TabIndex = 7;
            this.verCamionetasXRendimiento.Text = "Ver camionetas ordenadas por rendimiento";
            this.verCamionetasXRendimiento.UseVisualStyleBackColor = true;
            this.verCamionetasXRendimiento.Click += new System.EventHandler(this.VerCamionetasOrdenadasPorRendimiento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listado de Camionetas:";
            // 
            // listBoxCamionetas
            // 
            this.listBoxCamionetas.FormattingEnabled = true;
            this.listBoxCamionetas.Location = new System.Drawing.Point(496, 85);
            this.listBoxCamionetas.Name = "listBoxCamionetas";
            this.listBoxCamionetas.Size = new System.Drawing.Size(184, 173);
            this.listBoxCamionetas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú Gestión de Camionetas";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar Camioneta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Baja de Camioneta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EliminarCamionetaBtn_Click);
            // 
            // RegistrarCamionetaBtn
            // 
            this.RegistrarCamionetaBtn.Location = new System.Drawing.Point(194, 85);
            this.RegistrarCamionetaBtn.Name = "RegistrarCamionetaBtn";
            this.RegistrarCamionetaBtn.Size = new System.Drawing.Size(94, 48);
            this.RegistrarCamionetaBtn.TabIndex = 0;
            this.RegistrarCamionetaBtn.Text = "Alta de Camioneta";
            this.RegistrarCamionetaBtn.UseVisualStyleBackColor = true;
            this.RegistrarCamionetaBtn.Click += new System.EventHandler(this.RegistrarCamionetaBtn_Click);
            // 
            // MenuGestionCamionetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionCamionetas";
            this.Size = new System.Drawing.Size(875, 322);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RegistrarCamionetaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCamionetas;
        private System.Windows.Forms.Button verCamionetasXRendimiento;
    }
}
