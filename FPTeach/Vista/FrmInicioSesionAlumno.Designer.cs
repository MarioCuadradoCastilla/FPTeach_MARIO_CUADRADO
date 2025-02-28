using System;

namespace FPTeach
{
    partial class FrmInicioSesionAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesionAlumno));
            this.LabelInicioSesion = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelInicioSesion
            // 
            this.LabelInicioSesion.AutoSize = true;
            this.LabelInicioSesion.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInicioSesion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabelInicioSesion.Location = new System.Drawing.Point(207, 49);
            this.LabelInicioSesion.Name = "LabelInicioSesion";
            this.LabelInicioSesion.Size = new System.Drawing.Size(415, 39);
            this.LabelInicioSesion.TabIndex = 0;
            this.LabelInicioSesion.Text = "Inicia Sesion como Alumno";
            // 
            // labelRegistro
            // 
            this.labelRegistro.Location = new System.Drawing.Point(0, 0);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(100, 23);
            this.labelRegistro.TabIndex = 8;
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(271, 142);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(282, 31);
            this.usuario.TabIndex = 2;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(271, 242);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(282, 31);
            this.contraseña.TabIndex = 3;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(284, 310);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(93, 39);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Location = new System.Drawing.Point(422, 310);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(93, 39);
            this.IniciarSesion.TabIndex = 5;
            this.IniciarSesion.Text = "Iniciar Sesion";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(123, 140);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(101, 31);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(107, 240);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(144, 31);
            this.labelContraseña.TabIndex = 7;
            this.labelContraseña.Text = "Contraseña";
            // 
            // FrmInicioSesionAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.LabelInicioSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicioSesionAlumno";
            this.Text = "FPTeach";
            this.Load += new System.EventHandler(this.FPTeach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label LabelInicioSesion;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelContraseña;
    }
}