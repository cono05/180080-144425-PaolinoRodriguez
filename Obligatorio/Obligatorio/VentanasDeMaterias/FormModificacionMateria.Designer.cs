namespace Obligatorio.VentanasDeMaterias
{
    partial class FormModificacionMateria
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
            this.listBoxMaterias = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreNuevoTextBox = new System.Windows.Forms.TextBox();
            this.ModificarNombreBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificación de Materia";
            // 
            // listBoxMaterias
            // 
            this.listBoxMaterias.FormattingEnabled = true;
            this.listBoxMaterias.Location = new System.Drawing.Point(12, 79);
            this.listBoxMaterias.Name = "listBoxMaterias";
            this.listBoxMaterias.Size = new System.Drawing.Size(215, 225);
            this.listBoxMaterias.TabIndex = 2;
            this.listBoxMaterias.SelectedIndexChanged += new System.EventHandler(this.listBoxMaterias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listado de Materias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de la materia:";
            // 
            // nombreNuevoTextBox
            // 
            this.nombreNuevoTextBox.Location = new System.Drawing.Point(252, 79);
            this.nombreNuevoTextBox.Name = "nombreNuevoTextBox";
            this.nombreNuevoTextBox.Size = new System.Drawing.Size(237, 20);
            this.nombreNuevoTextBox.TabIndex = 6;
            // 
            // ModificarNombreBtn
            // 
            this.ModificarNombreBtn.Location = new System.Drawing.Point(331, 105);
            this.ModificarNombreBtn.Name = "ModificarNombreBtn";
            this.ModificarNombreBtn.Size = new System.Drawing.Size(94, 40);
            this.ModificarNombreBtn.TabIndex = 7;
            this.ModificarNombreBtn.Text = "Modificar Nombre";
            this.ModificarNombreBtn.UseVisualStyleBackColor = true;
            this.ModificarNombreBtn.Click += new System.EventHandler(this.ModificarNombreBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Volver al Menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormModificacionMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModificarNombreBtn);
            this.Controls.Add(this.nombreNuevoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMaterias);
            this.Controls.Add(this.label1);
            this.Name = "FormModificacionMateria";
            this.Text = "FormModificacionMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMaterias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreNuevoTextBox;
        private System.Windows.Forms.Button ModificarNombreBtn;
        private System.Windows.Forms.Button button1;
    }
}