namespace Obligatorio
{
    partial class MenuGestionDocente
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVolver);
            this.panel1.Controls.Add(this.buttonModificar);
            this.panel1.Controls.Add(this.buttonBaja);
            this.panel1.Controls.Add(this.buttonAlta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(397, 271);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(94, 40);
            this.buttonVolver.TabIndex = 13;
            this.buttonVolver.Text = "Volver al Menú Principal";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(593, 135);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(94, 40);
            this.buttonModificar.TabIndex = 12;
            this.buttonModificar.Text = "Modificar Docente";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(397, 135);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(94, 40);
            this.buttonBaja.TabIndex = 11;
            this.buttonBaja.Text = "Baja de Docente";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(201, 135);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(94, 40);
            this.buttonAlta.TabIndex = 10;
            this.buttonAlta.Text = "Alta de Docente";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menú Gestión Docentes";
            // 
            // MenuGestionDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuGestionDocente";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
    }
}
