namespace FPTeach
{
    partial class FormIniciSesionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciSesionAdmin));
            this.LabelInicioSesion = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelInicioSesion
            // 
            this.LabelInicioSesion.AutoSize = true;
            this.LabelInicioSesion.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInicioSesion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelInicioSesion.Location = new System.Drawing.Point(155, 79);
            this.LabelInicioSesion.Name = "LabelInicioSesion";
            this.LabelInicioSesion.Size = new System.Drawing.Size(510, 39);
            this.LabelInicioSesion.TabIndex = 1;
            this.LabelInicioSesion.Text = "Inicia Sesion como Administrador";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(130, 212);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(144, 31);
            this.labelContraseña.TabIndex = 9;
            this.labelContraseña.Text = "Contraseña";
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(330, 212);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(282, 31);
            this.contraseña.TabIndex = 10;
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(277, 307);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(191, 54);
            this.Entrar.TabIndex = 11;
            this.Entrar.Text = "Entrar como administrador";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // FormIniciSesionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.LabelInicioSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIniciSesionAdmin";
            this.Text = "FPTeach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIniciSesionAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormIniciSesionAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInicioSesion;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button Entrar;
    }
}