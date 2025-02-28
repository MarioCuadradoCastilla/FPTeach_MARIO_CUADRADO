namespace FPTeach
{
    partial class AltaProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaProfesor));
            this.LabelAltaAlumno = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.labelDNIe = new System.Windows.Forms.Label();
            this.numSS = new System.Windows.Forms.TextBox();
            this.labelNumeroSS = new System.Windows.Forms.Label();
            this.labelAsignatura = new System.Windows.Forms.Label();
            this.BoxAsignaturas = new System.Windows.Forms.ComboBox();
            this.darDeAlta = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProfesor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelAltaAlumno
            // 
            this.LabelAltaAlumno.AutoSize = true;
            this.LabelAltaAlumno.BackColor = System.Drawing.Color.IndianRed;
            this.LabelAltaAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAltaAlumno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelAltaAlumno.Location = new System.Drawing.Point(310, 9);
            this.LabelAltaAlumno.Name = "LabelAltaAlumno";
            this.LabelAltaAlumno.Size = new System.Drawing.Size(219, 39);
            this.LabelAltaAlumno.TabIndex = 2;
            this.LabelAltaAlumno.Text = "Alta  Profesor";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(152, 117);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(109, 31);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(117, 165);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(144, 31);
            this.labelContraseña.TabIndex = 9;
            this.labelContraseña.Text = "Contraseña";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(277, 119);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(282, 31);
            this.nombre.TabIndex = 10;
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(277, 167);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(282, 31);
            this.contraseña.TabIndex = 11;
            // 
            // dni
            // 
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(277, 219);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(282, 31);
            this.dni.TabIndex = 15;
            // 
            // labelDNIe
            // 
            this.labelDNIe.AutoSize = true;
            this.labelDNIe.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNIe.Location = new System.Drawing.Point(202, 217);
            this.labelDNIe.Name = "labelDNIe";
            this.labelDNIe.Size = new System.Drawing.Size(59, 31);
            this.labelDNIe.TabIndex = 16;
            this.labelDNIe.Text = "DNI";
            // 
            // numSS
            // 
            this.numSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSS.Location = new System.Drawing.Point(277, 271);
            this.numSS.Name = "numSS";
            this.numSS.Size = new System.Drawing.Size(282, 31);
            this.numSS.TabIndex = 17;
            // 
            // labelNumeroSS
            // 
            this.labelNumeroSS.AutoSize = true;
            this.labelNumeroSS.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroSS.Location = new System.Drawing.Point(117, 269);
            this.labelNumeroSS.Name = "labelNumeroSS";
            this.labelNumeroSS.Size = new System.Drawing.Size(144, 31);
            this.labelNumeroSS.TabIndex = 19;
            this.labelNumeroSS.Text = "Numero SS";
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignatura.Location = new System.Drawing.Point(124, 320);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(137, 31);
            this.labelAsignatura.TabIndex = 20;
            this.labelAsignatura.Text = "Asignatura";
            this.labelAsignatura.Click += new System.EventHandler(this.labelGrado_Click);
            // 
            // BoxAsignaturas
            // 
            this.BoxAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAsignaturas.FormattingEnabled = true;
            this.BoxAsignaturas.Items.AddRange(new object[] {
            "Acceso a Datos",
            "Aplicaciones Moviles",
            "Procesos",
            "Interfaces",
            "SGE",
            "Empresa",
            "Ingles"});
            this.BoxAsignaturas.Location = new System.Drawing.Point(277, 320);
            this.BoxAsignaturas.Name = "BoxAsignaturas";
            this.BoxAsignaturas.Size = new System.Drawing.Size(282, 33);
            this.BoxAsignaturas.TabIndex = 21;
            this.BoxAsignaturas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // darDeAlta
            // 
            this.darDeAlta.Location = new System.Drawing.Point(429, 379);
            this.darDeAlta.Name = "darDeAlta";
            this.darDeAlta.Size = new System.Drawing.Size(100, 37);
            this.darDeAlta.TabIndex = 22;
            this.darDeAlta.Text = "Dar de Alta";
            this.darDeAlta.UseVisualStyleBackColor = true;
            this.darDeAlta.Click += new System.EventHandler(this.darDeAlta_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(300, 379);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 37);
            this.cancelar.TabIndex = 23;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Profesor";
            // 
            // IdProfesor
            // 
            this.IdProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProfesor.Location = new System.Drawing.Point(275, 67);
            this.IdProfesor.Name = "IdProfesor";
            this.IdProfesor.Size = new System.Drawing.Size(282, 31);
            this.IdProfesor.TabIndex = 25;
            this.IdProfesor.TextChanged += new System.EventHandler(this.IdProfesor_TextChanged);
            // 
            // AltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdProfesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.darDeAlta);
            this.Controls.Add(this.BoxAsignaturas);
            this.Controls.Add(this.labelAsignatura);
            this.Controls.Add(this.labelNumeroSS);
            this.Controls.Add(this.numSS);
            this.Controls.Add(this.labelDNIe);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.LabelAltaAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaProfesor";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaProfesor_FormClosing);
            this.Load += new System.EventHandler(this.AltaProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAltaAlumno;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label labelDNIe;
        private System.Windows.Forms.TextBox numSS;
        private System.Windows.Forms.Label labelNumeroSS;
        private System.Windows.Forms.Label labelAsignatura;
        private System.Windows.Forms.ComboBox BoxAsignaturas;
        private System.Windows.Forms.Button darDeAlta;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdProfesor;
    }
}