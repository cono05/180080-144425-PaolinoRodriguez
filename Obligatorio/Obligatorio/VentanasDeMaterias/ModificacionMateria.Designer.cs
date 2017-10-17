namespace Obligatorio
{
    partial class ModificacionMateria
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ModificarNombreBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreNuevoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MateriasListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ModificarNombreBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nombreNuevoTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MateriasListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver al Menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VolverAlMenuClickClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // ModificarNombreBtn
            // 
            this.ModificarNombreBtn.Location = new System.Drawing.Point(408, 145);
            this.ModificarNombreBtn.Name = "ModificarNombreBtn";
            this.ModificarNombreBtn.Size = new System.Drawing.Size(94, 40);
            this.ModificarNombreBtn.TabIndex = 5;
            this.ModificarNombreBtn.Text = "Modificar Nombre";
            this.ModificarNombreBtn.UseVisualStyleBackColor = true;
            this.ModificarNombreBtn.Click += new System.EventHandler(this.ModificarNombreBtnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de la materia:";
            // 
            // nombreNuevoTextBox
            // 
            this.nombreNuevoTextBox.Location = new System.Drawing.Point(325, 109);
            this.nombreNuevoTextBox.Name = "nombreNuevoTextBox";
            this.nombreNuevoTextBox.Size = new System.Drawing.Size(237, 20);
            this.nombreNuevoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Listado de Materias:";
            // 
            // MateriasListBox
            // 
            this.MateriasListBox.FormattingEnabled = true;
            this.MateriasListBox.Location = new System.Drawing.Point(67, 109);
            this.MateriasListBox.Name = "MateriasListBox";
            this.MateriasListBox.Size = new System.Drawing.Size(215, 225);
            this.MateriasListBox.TabIndex = 1;
            this.MateriasListBox.SelectedIndexChanged += new System.EventHandler(this.MateriasListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificación Materia";
            // 
            // ModificacionMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ModificacionMateria";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox MateriasListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModificarNombreBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreNuevoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
