namespace FPTeach
{
    partial class ponerNotas1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ponerNotas1));
            this.labelNota = new System.Windows.Forms.Label();
            this.ponerNota = new System.Windows.Forms.Button();
            this.labelAlumno = new System.Windows.Forms.Label();
            this.comboBoxNotas = new System.Windows.Forms.ComboBox();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota.Location = new System.Drawing.Point(428, 163);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(98, 39);
            this.labelNota.TabIndex = 1;
            this.labelNota.Text = "Nota:";
            // 
            // ponerNota
            // 
            this.ponerNota.Location = new System.Drawing.Point(344, 355);
            this.ponerNota.Name = "ponerNota";
            this.ponerNota.Size = new System.Drawing.Size(94, 46);
            this.ponerNota.TabIndex = 2;
            this.ponerNota.Text = "Poner Nota";
            this.ponerNota.UseVisualStyleBackColor = true;
            this.ponerNota.Click += new System.EventHandler(this.ponerNota_Click);
            // 
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumno.Location = new System.Drawing.Point(43, 163);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(150, 39);
            this.labelAlumno.TabIndex = 4;
            this.labelAlumno.Text = " Alumno:";
            // 
            // comboBoxNotas
            // 
            this.comboBoxNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNotas.FormattingEnabled = true;
            this.comboBoxNotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNotas.Location = new System.Drawing.Point(548, 169);
            this.comboBoxNotas.Name = "comboBoxNotas";
            this.comboBoxNotas.Size = new System.Drawing.Size(177, 33);
            this.comboBoxNotas.TabIndex = 22;
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(214, 174);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(116, 23);
            this.comboBoxAlumno.TabIndex = 25;
            this.comboBoxAlumno.Text = "Elije alumno";
            this.comboBoxAlumno.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ponerNotas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAlumno);
            this.Controls.Add(this.comboBoxNotas);
            this.Controls.Add(this.labelAlumno);
            this.Controls.Add(this.ponerNota);
            this.Controls.Add(this.labelNota);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ponerNotas1";
            this.Text = "Profesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ponerNotas1_FormClosing);
            this.Load += new System.EventHandler(this.ponerNotas1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Button ponerNota;
        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.ComboBox comboBoxNotas;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
    }
}