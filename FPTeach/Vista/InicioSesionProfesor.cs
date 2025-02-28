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
    public partial class InicioSesionProfesor : Form
    {
        
        public InicioSesionProfesor()
        {
            InitializeComponent();
        }

        private void InicioSesionProfesor_Load(object sender, EventArgs e)
        {

        }
        private bool validarLogin(string idprofesor, string contraseña2) {
            bool login=false;
            bool salir = false;
            int i=0;
            while(i<Profesor.listaProfesores.Count  && salir==false)
            {
                if (idprofesor == Profesor.listaProfesores[i].IdProfesor)
                {
                    login = true;
                    salir= true;
                }
                i++;
            }
            if (login == true) {
                if (contraseña2 != Profesor.listaProfesores[i-1].Contraseña)
                {
                    login = false;
                    MessageBox.Show("Contraseña Incorrecta");
                    contraseña.Clear();
                }
                else {
                    MessageBox.Show("Inicio de sesión completado");
                }
            }
            else
            {
                MessageBox.Show("El id no existe");
                idProfesor.Clear();
            }
            return login;
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if(validarLogin(idProfesor.Text,contraseña.Text)==true)
            {
                for (int i = 0; i < Profesor.listaProfesores.Count; i++)
                {
                     if (Profesor.listaProfesores[i].IdProfesor == idProfesor.Text)
                     {
                            variablesCompartidas.P= Profesor.listaProfesores[i];
                     }
                }
                MenuProfesor menp= new MenuProfesor();
                this.Close();
                menp.ShowDialog();
            }
        }
    }
}
