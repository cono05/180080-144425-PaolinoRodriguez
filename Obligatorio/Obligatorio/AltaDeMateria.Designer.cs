namespace Obligatorio
{
    partial class AltaDeMateria
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.AgregarMateriaBtn = new System.Windows.Forms.Button();
            this.VolverAMenuGestionMateriasBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VolverAMenuGestionMateriasBtn);
            this.panel1.Controls.Add(this.AgregarMateriaBtn);
            this.panel1.Controls.Add(this.textBoxNombre);
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
            this.label1.Location = new System.Drawing.Point(331, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(288, 132);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(252, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // AgregarMateriaBtn
            // 
            this.AgregarMateriaBtn.Location = new System.Drawing.Point(288, 253);
            this.AgregarMateriaBtn.Name = "AgregarMateriaBtn";
            this.AgregarMateriaBtn.Size = new System.Drawing.Size(94, 40);
            this.AgregarMateriaBtn.TabIndex = 3;
            this.AgregarMateriaBtn.Text = "Agregar Materia";
            this.AgregarMateriaBtn.UseVisualStyleBackColor = true;
            this.AgregarMateriaBtn.Click += new System.EventHandler(this.AgregarMateriaBtn_Click);
            // 
            // VolverAMenuGestionMateriasBtn
            // 
            this.VolverAMenuGestionMateriasBtn.Location = new System.Drawing.Point(446, 253);
            this.VolverAMenuGestionMateriasBtn.Name = "VolverAMenuGestionMateriasBtn";
            this.VolverAMenuGestionMateriasBtn.Size = new System.Drawing.Size(94, 40);
            this.VolverAMenuGestionMateriasBtn.TabIndex = 4;
            this.VolverAMenuGestionMateriasBtn.Text = "Volver al Menú";
            this.VolverAMenuGestionMateriasBtn.UseVisualStyleBackColor = true;
            this.VolverAMenuGestionMateriasBtn.Click += new System.EventHandler(this.VolverAMenuGestionMateriasBtn_Click);
            // 
            // AltaDeMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AltaDeMateria";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button VolverAMenuGestionMateriasBtn;
        private System.Windows.Forms.Button AgregarMateriaBtn;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
