namespace FPTeach
{
    partial class AlumnosProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosProfesor));
            this.boxAlumnos = new System.Windows.Forms.GroupBox();
            this.labelAlumnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxAlumnos
            // 
            this.boxAlumnos.Location = new System.Drawing.Point(84, 63);
            this.boxAlumnos.Name = "boxAlumnos";
            this.boxAlumnos.Size = new System.Drawing.Size(617, 312);
            this.boxAlumnos.TabIndex = 2;
            this.boxAlumnos.TabStop = false;
            this.boxAlumnos.Enter += new System.EventHandler(this.boxAlumnos_Enter);
            // 
            // labelAlumnos
            // 
            this.labelAlumnos.AutoSize = true;
            this.labelAlumnos.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnos.Location = new System.Drawing.Point(346, 21);
            this.labelAlumnos.Name = "labelAlumnos";
            this.labelAlumnos.Size = new System.Drawing.Size(123, 31);
            this.labelAlumnos.TabIndex = 3;
            this.labelAlumnos.Text = "Alumnos";
            this.labelAlumnos.Click += new System.EventHandler(this.label1_Click);
            // 
            // AlumnosProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAlumnos);
            this.Controls.Add(this.boxAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlumnosProfesor";
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.AlumnosProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxAlumnos;
        private System.Windows.Forms.Label labelAlumnos;
    }
}