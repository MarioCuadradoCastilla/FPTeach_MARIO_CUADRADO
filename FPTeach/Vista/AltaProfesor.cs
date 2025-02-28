using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FPTeach
{
    public partial class AltaProfesor : Form
    {
        public AltaProfesor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelGrado_Click(object sender, EventArgs e)
        {

        }

        private void darDeAlta_Click(object sender, EventArgs e)
        {
            bool darAlta = true;

            if (IdProfesor.Text == "")
            {
                IdProfesor.BackColor = Color.Red;
                darAlta= false;
            }
            else
            {
                IdProfesor.BackColor = Color.White;

            }

            if (nombre.Text == "")
            {
                nombre.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                nombre.BackColor = Color.White;
            }

            if (contraseña.Text == "")
            {
                contraseña.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                contraseña.BackColor = Color.White;
            }

            if (dni.Text == "")
            {
                dni.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                dni.BackColor = Color.White;
            }

            if (numSS.Text == "")
            {
                numSS.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                numSS.BackColor = Color.White;
            }

            if (BoxAsignaturas.Text == "")
            {
                BoxAsignaturas.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                BoxAsignaturas.BackColor = Color.White;
            }
            int i;
            for (i = 0; i <Profesor.listaProfesores.Count; i++)
            {
                if (Profesor.listaProfesores[i].IdProfesor == IdProfesor.Text)
                {
                    MessageBox.Show("Este id ya esta registrado");
                    darAlta = false;
                    IdProfesor.Clear();
                }
            }
            if ( darAlta==true)
            {
                List<string>listaAlumno = new List<string>();
                Profesor.listaProfesores.Add(new Profesor(IdProfesor.Text, nombre.Text, contraseña.Text, dni.Text, numSS.Text, BoxAsignaturas.Text, listaAlumno));
                MessageBox.Show("Dado de alta con exito");
                IdProfesor.Clear();
                nombre.Clear();
                contraseña.Clear();
                dni.Clear();
                numSS.Clear();
            }
            else {
                MessageBox.Show("Faltan Argumentos");
            }
        }

        private void IdProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaProfesor_Load(object sender, EventArgs e)
        {

        }

        private void AltaProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Guardad Cambios", "Guardando cambios...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                ControladorProfesor.escribirProfesores();
            }
            else
            {
                MessageBox.Show("Cambios no guardados");
            }
        }
    }
}
