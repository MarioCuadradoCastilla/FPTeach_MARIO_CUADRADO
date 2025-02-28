using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTeach
{
    public partial class FormEntrada : System.Windows.Forms.Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {
            ControladorAlumnos.leerAlumnos();
            ControladorProfesor.leerProfesores();
            
        }
  
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            FrmInicioSesionAlumno inicioSesionAlumno = new FrmInicioSesionAlumno();
            inicioSesionAlumno.ShowDialog();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            InicioSesionProfesor inicioSesionProfesor = new InicioSesionProfesor();
            inicioSesionProfesor.ShowDialog();
        }
        private void Label3_Click(object sender, EventArgs e)
        {
            FormIniciSesionAdmin IniciaSesionAdmnin = new FormIniciSesionAdmin();
            IniciaSesionAdmnin.ShowDialog();

        }
    }
}
