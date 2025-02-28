namespace FPTeach
{
    partial class InicioSesionProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesionProfesor));
            this.LabelInicioSesion = new System.Windows.Forms.Label();
            this.idProfesor = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.labelIdProfesor = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelInicioSesion
            // 
            this.LabelInicioSesion.AutoSize = true;
            this.LabelInicioSesion.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInicioSesion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelInicioSesion.Location = new System.Drawing.Point(203, 65);
            this.LabelInicioSesion.Name = "LabelInicioSesion";
            this.LabelInicioSesion.Size = new System.Drawing.Size(423, 39);
            this.LabelInicioSesion.TabIndex = 1;
            this.LabelInicioSesion.Text = "Inicia Sesion como Profesor";
            // 
            // idProfesor
            // 
            this.idProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProfesor.Location = new System.Drawing.Point(267, 165);
            this.idProfesor.Name = "idProfesor";
            this.idProfesor.Size = new System.Drawing.Size(282, 31);
            this.idProfesor.TabIndex = 3;
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(267, 245);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(282, 31);
            this.contraseña.TabIndex = 4;
            // 
            // labelIdProfesor
            // 
            this.labelIdProfesor.AutoSize = true;
            this.labelIdProfesor.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdProfesor.Location = new System.Drawing.Point(119, 163);
            this.labelIdProfesor.Name = "labelIdProfesor";
            this.labelIdProfesor.Size = new System.Drawing.Size(142, 31);
            this.labelIdProfesor.TabIndex = 7;
            this.labelIdProfesor.Text = "ID Profesor";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(119, 245);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(144, 31);
            this.labelContraseña.TabIndex = 8;
            this.labelContraseña.Text = "Contraseña";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(293, 324);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(93, 39);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Location = new System.Drawing.Point(429, 324);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(93, 39);
            this.IniciarSesion.TabIndex = 10;
            this.IniciarSesion.Text = "Iniciar Sesion";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // InicioSesionProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelIdProfesor);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.idProfesor);
            this.Controls.Add(this.LabelInicioSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesionProfesor";
            this.Text = "FPTeach";
            this.Load += new System.EventHandler(this.InicioSesionProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInicioSesion;
        private System.Windows.Forms.TextBox idProfesor;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label labelIdProfesor;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button IniciarSesion;
    }
}