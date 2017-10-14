namespace Obligatorio
{
    partial class MenuPrincipal
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
            this.GestionarAlumnosBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GestionarCamionetasBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GestionarAlumnosBtn
            // 
            this.GestionarAlumnosBtn.Location = new System.Drawing.Point(207, 130);
            this.GestionarAlumnosBtn.Name = "GestionarAlumnosBtn";
            this.GestionarAlumnosBtn.Size = new System.Drawing.Size(94, 40);
            this.GestionarAlumnosBtn.TabIndex = 0;
            this.GestionarAlumnosBtn.Text = "Gestionar Alumnos";
            this.GestionarAlumnosBtn.UseVisualStyleBackColor = true;
            this.GestionarAlumnosBtn.Click += new System.EventHandler(this.GestionarAlumnosBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gestionar Materias";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GestionarCamionetasBtn
            // 
            this.GestionarCamionetasBtn.Location = new System.Drawing.Point(526, 130);
            this.GestionarCamionetasBtn.Name = "GestionarCamionetasBtn";
            this.GestionarCamionetasBtn.Size = new System.Drawing.Size(94, 40);
            this.GestionarCamionetasBtn.TabIndex = 2;
            this.GestionarCamionetasBtn.Text = "Gestionar Camionetas";
            this.GestionarCamionetasBtn.UseVisualStyleBackColor = true;
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(370, 284);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(94, 40);
            this.SalirBtn.TabIndex = 3;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(339, 48);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(156, 26);
            this.lblMenuPrincipal.TabIndex = 4;
            this.lblMenuPrincipal.Text = "Menú Principal";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.GestionarCamionetasBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GestionarAlumnosBtn);
            this.Name = "MenuPrincipal";
            this.Size = new System.Drawing.Size(875, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GestionarAlumnosBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GestionarCamionetasBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.Label lblMenuPrincipal;
    }
}
