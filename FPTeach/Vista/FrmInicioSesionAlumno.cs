using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FPTeach
{
    public partial class FrmInicioSesionAlumno : Form
    {

        public FrmInicioSesionAlumno()
        {
            InitializeComponent();
        }
        private void FPTeach_Load(object sender, EventArgs e)
        {

        }
        private bool validarLogin(String usuario2, String contraseña2)
        {
            bool login = false;
            bool salir = false;
            int i = 0;
            while (i < Alumno.listaAlumnos.Count && salir == false)
            {
                if (usuario2 == Alumno.listaAlumnos[i].Usuario)
                {
                    login = true;
                    salir = true;
                }
                i++;
            }
            if (login == true)
            {
                if (contraseña2 != Alumno.listaAlumnos[i-1].Contraseña)
                {
                    login = false;
                    MessageBox.Show("Contraseña Incorrecta");
                    contraseña.Clear();
                }
                else
                {
                    MessageBox.Show("Inicio de sesión completado");
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe");
                usuario.Clear();
            }
            return login;
        }
   
   

        int contador = 0;
        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if (validarLogin(usuario.Text, contraseña.Text) == true)
            {
                for (int i = 0; i < Alumno.listaAlumnos.Count; i++)
                {
                    if (Alumno.listaAlumnos[i].Usuario == usuario.Text)
                    {
                        variablesCompartidas.A = Alumno.listaAlumnos[i];
                    }
                }
                MenuAlumno menA = new MenuAlumno();
                menA.ShowDialog();
                this.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            usuario.Clear();
            contraseña.Clear();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
