namespace Obligatorio.VentanasDeActividad
{
    partial class FormBajaActividad
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
            this.SalirBtn = new System.Windows.Forms.Button();
            this.eliminarActividadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxActividades = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(453, 281);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(94, 34);
            this.SalirBtn.TabIndex = 22;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // eliminarActividadBtn
            // 
            this.eliminarActividadBtn.Location = new System.Drawing.Point(341, 281);
            this.eliminarActividadBtn.Name = "eliminarActividadBtn";
            this.eliminarActividadBtn.Size = new System.Drawing.Size(94, 34);
            this.eliminarActividadBtn.TabIndex = 21;
            this.eliminarActividadBtn.Text = "Eliminar Actividad";
            this.eliminarActividadBtn.UseVisualStyleBackColor = true;
            this.eliminarActividadBtn.Click += new System.EventHandler(this.eliminarActividadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Listado de Actividades:";
            // 
            // listBoxActividades
            // 
            this.listBoxActividades.FormattingEnabled = true;
            this.listBoxActividades.Location = new System.Drawing.Point(105, 90);
            this.listBoxActividades.Name = "listBoxActividades";
            this.listBoxActividades.Size = new System.Drawing.Size(197, 225);
            this.listBoxActividades.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Baja de Actividad";
            // 
            // FormBajaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 378);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.eliminarActividadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxActividades);
            this.Controls.Add(this.label6);
            this.Name = "FormBajaActividad";
            this.Text = "FormBajaActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.Button eliminarActividadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxActividades;
        private System.Windows.Forms.Label label6;
    }
}