namespace Obligatorio.VentanasDeDocente
{
    partial class FormBajaDocente
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
            this.listBoxDocentes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bajaDocenteBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDocentes
            // 
            this.listBoxDocentes.FormattingEnabled = true;
            this.listBoxDocentes.Location = new System.Drawing.Point(108, 61);
            this.listBoxDocentes.Name = "listBoxDocentes";
            this.listBoxDocentes.Size = new System.Drawing.Size(181, 225);
            this.listBoxDocentes.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Baja De Docente";
            // 
            // bajaDocenteBtn
            // 
            this.bajaDocenteBtn.Location = new System.Drawing.Point(347, 176);
            this.bajaDocenteBtn.Name = "bajaDocenteBtn";
            this.bajaDocenteBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bajaDocenteBtn.Size = new System.Drawing.Size(94, 34);
            this.bajaDocenteBtn.TabIndex = 35;
            this.bajaDocenteBtn.Text = "Eliminar Docente";
            this.bajaDocenteBtn.UseVisualStyleBackColor = true;
            this.bajaDocenteBtn.Click += new System.EventHandler(this.BajaDocenteBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(347, 252);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salirBtn.Size = new System.Drawing.Size(94, 34);
            this.salirBtn.TabIndex = 36;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Listado de docentes:";
            // 
            // FormBajaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.bajaDocenteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDocentes);
            this.Name = "FormBajaDocente";
            this.Text = "FormBajaDocente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDocentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bajaDocenteBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Label label2;
    }
}