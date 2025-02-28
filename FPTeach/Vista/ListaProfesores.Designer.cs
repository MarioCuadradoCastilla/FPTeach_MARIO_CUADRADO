namespace FPTeach
{
    partial class ListaProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProfesores));
            this.boxProfesores = new System.Windows.Forms.GroupBox();
            this.eleminar = new System.Windows.Forms.Button();
            this.labelListaProfesores = new System.Windows.Forms.Label();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boxProfesores
            // 
            this.boxProfesores.Location = new System.Drawing.Point(12, 51);
            this.boxProfesores.Name = "boxProfesores";
            this.boxProfesores.Size = new System.Drawing.Size(632, 330);
            this.boxProfesores.TabIndex = 0;
            this.boxProfesores.TabStop = false;
            this.boxProfesores.Enter += new System.EventHandler(this.boxProfesores_Enter);
            // 
            // eleminar
            // 
            this.eleminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleminar.Location = new System.Drawing.Point(275, 396);
            this.eleminar.Name = "eleminar";
            this.eleminar.Size = new System.Drawing.Size(110, 42);
            this.eleminar.TabIndex = 1;
            this.eleminar.Text = "Eliminar";
            this.eleminar.UseVisualStyleBackColor = true;
            this.eleminar.Click += new System.EventHandler(this.eleminar_Click);
            // 
            // labelListaProfesores
            // 
            this.labelListaProfesores.AutoSize = true;
            this.labelListaProfesores.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaProfesores.Location = new System.Drawing.Point(186, 9);
            this.labelListaProfesores.Name = "labelListaProfesores";
            this.labelListaProfesores.Size = new System.Drawing.Size(294, 39);
            this.labelListaProfesores.TabIndex = 0;
            this.labelListaProfesores.Text = "Lista de profesores";
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            "ID Profesor",
            "Nombre"});
            this.comboBoxOrdenar.Location = new System.Drawing.Point(650, 139);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(148, 24);
            this.comboBoxOrdenar.TabIndex = 17;
            this.comboBoxOrdenar.Text = "Ordenar por ";
            this.comboBoxOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenar_SelectedIndexChanged);
            // 
            // comboBoxFiltrar
            // 
            this.comboBoxFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Items.AddRange(new object[] {
            "Acceso a Datos",
            "Aplicaciones Moviles",
            "Procesos",
            "Interfaces",
            "SGE",
            "Empresa",
            "Ingles",
            "No filtrar"});
            this.comboBoxFiltrar.Location = new System.Drawing.Point(650, 238);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(148, 24);
            this.comboBoxFiltrar.TabIndex = 18;
            this.comboBoxFiltrar.Text = "Filtrar por asignatura";
            this.comboBoxFiltrar.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // ListaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFiltrar);
            this.Controls.Add(this.comboBoxOrdenar);
            this.Controls.Add(this.labelListaProfesores);
            this.Controls.Add(this.eleminar);
            this.Controls.Add(this.boxProfesores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaProfesores";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaProfesores_FormClosing);
            this.Load += new System.EventHandler(this.ListaProfesores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxProfesores;
        private System.Windows.Forms.Button eleminar;
        private System.Windows.Forms.Label labelListaProfesores;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.ComboBox comboBoxFiltrar;
    }
}