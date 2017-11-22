namespace Obligatorio
{
    partial class FormBajaCamioneta
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
            this.VolverAlMenuBtn = new System.Windows.Forms.Button();
            this.EliminarCamioneta = new System.Windows.Forms.Button();
            this.listBoxCamionetas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VolverAlMenuBtn
            // 
            this.VolverAlMenuBtn.Location = new System.Drawing.Point(315, 271);
            this.VolverAlMenuBtn.Name = "VolverAlMenuBtn";
            this.VolverAlMenuBtn.Size = new System.Drawing.Size(94, 40);
            this.VolverAlMenuBtn.TabIndex = 9;
            this.VolverAlMenuBtn.Text = "Salir";
            this.VolverAlMenuBtn.UseVisualStyleBackColor = true;
            this.VolverAlMenuBtn.Click += new System.EventHandler(this.VolverAlMenuBtn_Click);
            // 
            // EliminarCamioneta
            // 
            this.EliminarCamioneta.Location = new System.Drawing.Point(180, 271);
            this.EliminarCamioneta.Name = "EliminarCamioneta";
            this.EliminarCamioneta.Size = new System.Drawing.Size(94, 40);
            this.EliminarCamioneta.TabIndex = 8;
            this.EliminarCamioneta.Text = "Eliminar Camioneta";
            this.EliminarCamioneta.UseVisualStyleBackColor = true;
            this.EliminarCamioneta.Click += new System.EventHandler(this.EliminarCamioneta_Click);
            // 
            // listBoxCamionetas
            // 
            this.listBoxCamionetas.FormattingEnabled = true;
            this.listBoxCamionetas.Location = new System.Drawing.Point(204, 66);
            this.listBoxCamionetas.Name = "listBoxCamionetas";
            this.listBoxCamionetas.Size = new System.Drawing.Size(178, 186);
            this.listBoxCamionetas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listado de Camionetas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baja de Camioneta";
            // 
            // FormBajaCamioneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 334);
            this.Controls.Add(this.VolverAlMenuBtn);
            this.Controls.Add(this.EliminarCamioneta);
            this.Controls.Add(this.listBoxCamionetas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBajaCamioneta";
            this.Text = "FormBajaCamioneta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VolverAlMenuBtn;
        private System.Windows.Forms.Button EliminarCamioneta;
        private System.Windows.Forms.ListBox listBoxCamionetas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}