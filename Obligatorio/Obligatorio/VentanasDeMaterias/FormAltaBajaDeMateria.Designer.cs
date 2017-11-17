namespace Obligatorio.VentanasDeMaterias
{
    partial class FormAltaBajaDeMateria
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.listBoxMaterias = new System.Windows.Forms.ListBox();
            this.eliminarMateriaBtn = new System.Windows.Forms.Button();
            this.AgregarMateriaBtn = new System.Windows.Forms.Button();
            this.VolverAMenuGestionMateriasBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alta y baja de Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la nueva Materia:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(170, 79);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(204, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // listBoxMaterias
            // 
            this.listBoxMaterias.FormattingEnabled = true;
            this.listBoxMaterias.Location = new System.Drawing.Point(433, 79);
            this.listBoxMaterias.Name = "listBoxMaterias";
            this.listBoxMaterias.Size = new System.Drawing.Size(181, 173);
            this.listBoxMaterias.TabIndex = 34;
            this.listBoxMaterias.SelectedIndexChanged += new System.EventHandler(this.listBoxMaterias_SelectedIndexChanged);
            // 
            // eliminarMateriaBtn
            // 
            this.eliminarMateriaBtn.Location = new System.Drawing.Point(480, 277);
            this.eliminarMateriaBtn.Name = "eliminarMateriaBtn";
            this.eliminarMateriaBtn.Size = new System.Drawing.Size(94, 34);
            this.eliminarMateriaBtn.TabIndex = 35;
            this.eliminarMateriaBtn.Text = "Eliminar Materia";
            this.eliminarMateriaBtn.UseVisualStyleBackColor = true;
            this.eliminarMateriaBtn.Click += new System.EventHandler(this.eliminarMateriaBtn_Click);
            // 
            // AgregarMateriaBtn
            // 
            this.AgregarMateriaBtn.Location = new System.Drawing.Point(223, 105);
            this.AgregarMateriaBtn.Name = "AgregarMateriaBtn";
            this.AgregarMateriaBtn.Size = new System.Drawing.Size(94, 34);
            this.AgregarMateriaBtn.TabIndex = 36;
            this.AgregarMateriaBtn.Text = "Agregar Materia";
            this.AgregarMateriaBtn.UseVisualStyleBackColor = true;
            this.AgregarMateriaBtn.Click += new System.EventHandler(this.AgregarMateriaBtn_Click);
            // 
            // VolverAMenuGestionMateriasBtn
            // 
            this.VolverAMenuGestionMateriasBtn.Location = new System.Drawing.Point(223, 271);
            this.VolverAMenuGestionMateriasBtn.Name = "VolverAMenuGestionMateriasBtn";
            this.VolverAMenuGestionMateriasBtn.Size = new System.Drawing.Size(94, 34);
            this.VolverAMenuGestionMateriasBtn.TabIndex = 37;
            this.VolverAMenuGestionMateriasBtn.Text = "Salir";
            this.VolverAMenuGestionMateriasBtn.UseVisualStyleBackColor = true;
            this.VolverAMenuGestionMateriasBtn.Click += new System.EventHandler(this.VolverAMenuGestionMateriasBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Listado de Materias:";
            // 
            // FormAltaBajaDeMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VolverAMenuGestionMateriasBtn);
            this.Controls.Add(this.AgregarMateriaBtn);
            this.Controls.Add(this.eliminarMateriaBtn);
            this.Controls.Add(this.listBoxMaterias);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaBajaDeMateria";
            this.Text = "FormAltaBajaDeMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ListBox listBoxMaterias;
        private System.Windows.Forms.Button eliminarMateriaBtn;
        private System.Windows.Forms.Button AgregarMateriaBtn;
        private System.Windows.Forms.Button VolverAMenuGestionMateriasBtn;
        private System.Windows.Forms.Label label3;
    }
}