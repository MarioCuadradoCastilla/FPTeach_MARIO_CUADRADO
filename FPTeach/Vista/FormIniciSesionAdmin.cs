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
    public partial class FormIniciSesionAdmin : Form
    {
        int contador=0;
        public FormIniciSesionAdmin()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (contraseña.Text == "Admin123")
            {
                MessageBox.Show("Contraseña correcta");
                MenuAdmin menuAdmn= new MenuAdmin();
                this.Close();
                menuAdmn.ShowDialog();

            }
            else {
                contador++;
                MessageBox.Show("Contraseña incorrecta");
                if (contador == 3)
                {
                    MessageBox.Show("Espabila pringao ;)");
                    Application.Exit();
                }
            }
        }

        private void FormIniciSesionAdmin_Load(object sender, EventArgs e)
        {

        }

        private void FormIniciSesionAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
