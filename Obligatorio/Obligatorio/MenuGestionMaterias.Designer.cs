namespace Obligatorio
{
    partial class MenuGestionMaterias
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
            System.Windows.Forms.Button button5;
            this.button1 = new System.Windows.Forms.Button();
            this.EliminarMateriaBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VerMateriasBtn = new System.Windows.Forms.Button();
            this.VerDocentesDeMateriaBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alta de materia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EliminarMateriaBtn
            // 
            this.EliminarMateriaBtn.Location = new System.Drawing.Point(397, 95);
            this.EliminarMateriaBtn.Name = "EliminarMateriaBtn";
            this.EliminarMateriaBtn.Size = new System.Drawing.Size(94, 40);
            this.EliminarMateriaBtn.TabIndex = 1;
            this.EliminarMateriaBtn.Text = "Baja de Materia";
            this.EliminarMateriaBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar Materia";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VerMateriasBtn
            // 
            this.VerMateriasBtn.Location = new System.Drawing.Point(220, 181);
            this.VerMateriasBtn.Name = "VerMateriasBtn";
            this.VerMateriasBtn.Size = new System.Drawing.Size(94, 40);
            this.VerMateriasBtn.TabIndex = 3;
            this.VerMateriasBtn.Text = "Ver Materias";
            this.VerMateriasBtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(397, 181);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(94, 40);
            button5.TabIndex = 4;
            button5.Text = "Inscribir Alumno a Materia";
            button5.UseVisualStyleBackColor = true;
            // 
            // VerDocentesDeMateriaBtn
            // 
            this.VerDocentesDeMateriaBtn.Location = new System.Drawing.Point(567, 181);
            this.VerDocentesDeMateriaBtn.Name = "VerDocentesDeMateriaBtn";
            this.VerDocentesDeMateriaBtn.Size = new System.Drawing.Size(94, 40);
            this.VerDocentesDeMateriaBtn.TabIndex = 5;
            this.VerDocentesDeMateriaBtn.Text = "Ver Docentes de Materias";
            this.VerDocentesDeMateriaBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Volver al Menú Principal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuGestionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.VerDocentesDeMateriaBtn);
            this.Controls.Add(button5);
            this.Controls.Add(this.VerMateriasBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EliminarMateriaBtn);
            this.Controls.Add(this.button1);
            this.Name = "MenuGestionMaterias";
            this.Size = new System.Drawing.Size(875, 406);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EliminarMateriaBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button VerMateriasBtn;
        private System.Windows.Forms.Button VerDocentesDeMateriaBtn;
        private System.Windows.Forms.Button button2;
    }
}
