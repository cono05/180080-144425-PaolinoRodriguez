namespace Obligatorio.VentanasDeMaterias
{
    partial class AltaBajaDocenteEnMateria
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MateriasListBox = new System.Windows.Forms.ListBox();
            this.DocentesNoDictanListBox = new System.Windows.Forms.ListBox();
            this.DocentesQueDictanListBox = new System.Windows.Forms.ListBox();
            this.AsignarDocenteBtn = new System.Windows.Forms.Button();
            this.VolverAlMenuBtn = new System.Windows.Forms.Button();
            this.QuitarDocenteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QuitarDocenteBtn);
            this.panel1.Controls.Add(this.VolverAlMenuBtn);
            this.panel1.Controls.Add(this.AsignarDocenteBtn);
            this.panel1.Controls.Add(this.DocentesQueDictanListBox);
            this.panel1.Controls.Add(this.DocentesNoDictanListBox);
            this.panel1.Controls.Add(this.MateriasListBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta y Baja de Docentes en Materias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listado de materias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado de Docentes que no dictan la Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Listado de Docentes de la Materia:";
            // 
            // MateriasListBox
            // 
            this.MateriasListBox.FormattingEnabled = true;
            this.MateriasListBox.Location = new System.Drawing.Point(48, 102);
            this.MateriasListBox.Name = "MateriasListBox";
            this.MateriasListBox.Size = new System.Drawing.Size(207, 212);
            this.MateriasListBox.TabIndex = 4;
            this.MateriasListBox.SelectedIndexChanged += new System.EventHandler(this.MateriasListBox_SelectedIndexChanged);
            // 
            // DocentesNoDictanListBox
            // 
            this.DocentesNoDictanListBox.FormattingEnabled = true;
            this.DocentesNoDictanListBox.Location = new System.Drawing.Point(327, 102);
            this.DocentesNoDictanListBox.Name = "DocentesNoDictanListBox";
            this.DocentesNoDictanListBox.Size = new System.Drawing.Size(207, 212);
            this.DocentesNoDictanListBox.TabIndex = 5;
            // 
            // DocentesQueDictanListBox
            // 
            this.DocentesQueDictanListBox.FormattingEnabled = true;
            this.DocentesQueDictanListBox.Location = new System.Drawing.Point(618, 102);
            this.DocentesQueDictanListBox.Name = "DocentesQueDictanListBox";
            this.DocentesQueDictanListBox.Size = new System.Drawing.Size(207, 212);
            this.DocentesQueDictanListBox.TabIndex = 6;
            // 
            // AsignarDocenteBtn
            // 
            this.AsignarDocenteBtn.Location = new System.Drawing.Point(389, 330);
            this.AsignarDocenteBtn.Name = "AsignarDocenteBtn";
            this.AsignarDocenteBtn.Size = new System.Drawing.Size(94, 40);
            this.AsignarDocenteBtn.TabIndex = 7;
            this.AsignarDocenteBtn.Text = "Asignar Docente a la Materia";
            this.AsignarDocenteBtn.UseVisualStyleBackColor = true;
            // 
            // VolverAlMenuBtn
            // 
            this.VolverAlMenuBtn.Location = new System.Drawing.Point(539, 330);
            this.VolverAlMenuBtn.Name = "VolverAlMenuBtn";
            this.VolverAlMenuBtn.Size = new System.Drawing.Size(94, 40);
            this.VolverAlMenuBtn.TabIndex = 8;
            this.VolverAlMenuBtn.Text = "Volver al Menú";
            this.VolverAlMenuBtn.UseVisualStyleBackColor = true;
            // 
            // QuitarDocenteBtn
            // 
            this.QuitarDocenteBtn.Location = new System.Drawing.Point(693, 330);
            this.QuitarDocenteBtn.Name = "QuitarDocenteBtn";
            this.QuitarDocenteBtn.Size = new System.Drawing.Size(94, 40);
            this.QuitarDocenteBtn.TabIndex = 9;
            this.QuitarDocenteBtn.Text = "Quitar Docente de la Materia";
            this.QuitarDocenteBtn.UseVisualStyleBackColor = true;
            // 
            // AltaBajaDocenteEnMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AltaBajaDocenteEnMateria";
            this.Size = new System.Drawing.Size(875, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DocentesQueDictanListBox;
        private System.Windows.Forms.ListBox DocentesNoDictanListBox;
        private System.Windows.Forms.ListBox MateriasListBox;
        private System.Windows.Forms.Button QuitarDocenteBtn;
        private System.Windows.Forms.Button VolverAlMenuBtn;
        private System.Windows.Forms.Button AsignarDocenteBtn;
    }
}
