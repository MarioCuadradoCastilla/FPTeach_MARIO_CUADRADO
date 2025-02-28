namespace FPTeach
{
    partial class ListaAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaAlumnos));
            this.boxAlumnos = new System.Windows.Forms.GroupBox();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.eleminar = new System.Windows.Forms.Button();
            this.labelListaAlumnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxAlumnos
            // 
            this.boxAlumnos.Location = new System.Drawing.Point(93, 51);
            this.boxAlumnos.Name = "boxAlumnos";
            this.boxAlumnos.Size = new System.Drawing.Size(631, 328);
            this.boxAlumnos.TabIndex = 1;
            this.boxAlumnos.TabStop = false;
            this.boxAlumnos.Enter += new System.EventHandler(this.boxAlumnos_Enter);
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            "Usuario",
            "Correo"});
            this.comboBoxOrdenar.Location = new System.Drawing.Point(185, 407);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(148, 24);
            this.comboBoxOrdenar.TabIndex = 20;
            this.comboBoxOrdenar.Text = "Ordenar por ";
            this.comboBoxOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenar_SelectedIndexChanged);
            // 
            // eleminar
            // 
            this.eleminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleminar.Location = new System.Drawing.Point(442, 396);
            this.eleminar.Name = "eleminar";
            this.eleminar.Size = new System.Drawing.Size(110, 42);
            this.eleminar.TabIndex = 21;
            this.eleminar.Text = "Eliminar";
            this.eleminar.UseVisualStyleBackColor = true;
            this.eleminar.Click += new System.EventHandler(this.eleminar_Click_1);
            // 
            // labelListaAlumnos
            // 
            this.labelListaAlumnos.AutoSize = true;
            this.labelListaAlumnos.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaAlumnos.Location = new System.Drawing.Point(283, 9);
            this.labelListaAlumnos.Name = "labelListaAlumnos";
            this.labelListaAlumnos.Size = new System.Drawing.Size(269, 39);
            this.labelListaAlumnos.TabIndex = 22;
            this.labelListaAlumnos.Text = "Lista de Alumnos";
            // 
            // ListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelListaAlumnos);
            this.Controls.Add(this.eleminar);
            this.Controls.Add(this.comboBoxOrdenar);
            this.Controls.Add(this.boxAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaAlumnos";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaAlumnos_FormClosing);
            this.Load += new System.EventHandler(this.ListaAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxAlumnos;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.Button eleminar;
        private System.Windows.Forms.Label labelListaAlumnos;
    }
}