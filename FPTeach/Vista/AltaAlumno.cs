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
    public partial class AltaAlumno : Form
    {
        public AltaAlumno()
        {
            InitializeComponent();

        }


        private void AltaAlumno_Load(object sender, EventArgs e)
        {
            //Añadir profesores de Acceso a Datos
            List<Profesor> listaProfesorAcc = Profesor.listaProfesores.Where(p => p.Asignatura == "Acceso a Datos").ToList();
            foreach (Profesor profesor in listaProfesorAcc)
            {
                comboBoxAcc.Items.Add("Profesor: "+profesor.Nombre+", Id :"+profesor.IdProfesor);
            }
            //Añadir profesores de Procesos
            List<Profesor> listaProfesorProcesos= Profesor.listaProfesores.Where(p => p.Asignatura == "Procesos").ToList();
            foreach (Profesor profesor in listaProfesorProcesos)
            {
                comboBoxProcesos.Items.Add("Profesor: " + profesor.Nombre + ", Id :" + profesor.IdProfesor);
            }
            //Añadir profesores de SGE
            List<Profesor> listaProfesorSGE = Profesor.listaProfesores.Where(p => p.Asignatura == "SGE").ToList();
            foreach (Profesor profesor in listaProfesorSGE)
            {
                comboBoxSGE.Items.Add("Profesor: " + profesor.Nombre + ", Id :" + profesor.IdProfesor);
            }
            //Añadir profesores de Ingles
            List<Profesor> listaProfesorIngles = Profesor.listaProfesores.Where(p => p.Asignatura == "Ingles").ToList();
            foreach (Profesor profesor in listaProfesorIngles)
            {
                comboBoxIngles.Items.Add("Profesor: " + profesor.Nombre + ", Id :" + profesor.IdProfesor);
            }
            //Añadir profesores de Empresa
            List<Profesor> listaProfesorEmpresa = Profesor.listaProfesores.Where(p => p.Asignatura == "Empresa").ToList();
            foreach (Profesor profesor in listaProfesorEmpresa)
            {
                comboBoxEmpresa.Items.Add("Profesor: " + profesor.Nombre + ", Id :" + profesor.IdProfesor);
            }
            //Añadir profesores de Aplicaciones Móviles
            List<Profesor> listaProfesorMoviles = Profesor.listaProfesores.Where(p => p.Asignatura == "Aplicaciones Moviles").ToList();
            foreach (Profesor profesor in listaProfesorMoviles)
            {
                comboBoxMoviles.Items.Add("Profesor: " + profesor.Nombre + ", Id :" + profesor.IdProfesor);
            }
            //Añadir profesores de Interfaces
            List<Profesor> listaProfesorInterfaces = Profesor.listaProfesores.Where(p => p.Asignatura == "Interfaces").ToList();
            foreach (Profesor profesor in listaProfesorInterfaces)
            {
                comboBoxInterfaces.Items.Add("Profesor: " + profesor.Nombre + ", Id :" + profesor.IdProfesor);
            }
        }
        private bool validarDatos() {
            bool darAlta = true;

            if (usuario.Text == "")
            {
                usuario.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                usuario.BackColor = Color.White;

            }

            if (correo.Text == "")
            {
                correo.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                correo.BackColor = Color.White;
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

            if (contraseña.Text == "")
            {
                contraseña.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                contraseña.BackColor = Color.White;
            }

            if (comboBoxAcc.Text == "")
            {
                comboBoxAcc.BackColor = Color.Red;
                darAlta = false;
            }

            else
            {
                comboBoxAcc.BackColor = Color.White;
            }

            if (comboBoxInterfaces.Text == "")
            {
                comboBoxInterfaces.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                comboBoxInterfaces.BackColor = Color.White;
            }

            if (comboBoxProcesos.Text == "")
            {
                comboBoxProcesos.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                comboBoxProcesos.BackColor = Color.White;
            }

            if (comboBoxSGE.Text == "")
            {
                comboBoxSGE.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                comboBoxSGE.BackColor = Color.White;
            }

            if (comboBoxIngles.Text == "")
            {
                comboBoxIngles.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                comboBoxIngles.BackColor = Color.White;
            }

            if (comboBoxMoviles.Text == "")
            {
                comboBoxMoviles.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                comboBoxMoviles.BackColor = Color.White;
            }

            if (comboBoxEmpresa.Text == "")
            {
                comboBoxEmpresa.BackColor = Color.Red;
                darAlta = false;
            }
            else
            {
                comboBoxEmpresa.BackColor = Color.White;
            }

            int i;
            for (i = 0; i < Alumno.listaAlumnos.Count; i++)
            {
                if (Alumno.listaAlumnos[i].Usuario == usuario.Text)
                {
                    MessageBox.Show("Este nombre de usuario ya esta registrado");
                    darAlta = false;
                    usuario.Clear();
                }
            }
            return darAlta;
        }
        private void darDeAlta_Click(object sender, EventArgs e)
        {
            if (validarDatos()== true)
            {
                Alumno a=new Alumno(usuario.Text, correo.Text, dni.Text, contraseña.Text, new string[7], new int[7]);
                //creamos listas con solo el profesor que hemos seleccionado en los comboBox para las asignaturas para ir metiendolos al array de profesores
                List<Profesor> listaProfesorAcceso2= Profesor.listaProfesores.Where(p => "Profesor: " + p.Nombre + ", Id :" + p.IdProfesor == comboBoxAcc.SelectedItem.ToString()).ToList();
                a.Profesores[0] ="Profesor: "+listaProfesorAcceso2[0].Nombre+", Id:"+listaProfesorAcceso2[0].IdProfesor;//introducimos el profesor seleccionado de la asignatura especifica
                for (int s = 0; s < Profesor.listaProfesores.Count; s++) {//le introducimos el alumno al profesor
                    if ("Profesor: " + Profesor.listaProfesores[s].Nombre + ", Id:" + Profesor.listaProfesores[s].IdProfesor == a.Profesores[0])
                    {
                        Profesor.listaProfesores[s].ListaAlumnos.Add(a.Usuario);
                    }
                }

                List <Profesor> listaProfesorProcesos2= Profesor.listaProfesores.Where(p => "Profesor: " + p.Nombre + ", Id :" + p.IdProfesor == comboBoxProcesos.SelectedItem.ToString()).ToList();
                a.Profesores[1] = "Profesor: " + listaProfesorProcesos2[0].Nombre + ", Id:" + listaProfesorProcesos2[0].IdProfesor;//introducimos el profesor seleccionado de la asignatura especifica
                for (int s = 0; s < Profesor.listaProfesores.Count; s++)
                {//le introducimos el alumno al profesor
                    if ("Profesor: " + Profesor.listaProfesores[s].Nombre + ", Id:" + Profesor.listaProfesores[s].IdProfesor == a.Profesores[1])
                    {
                        Profesor.listaProfesores[s].ListaAlumnos.Add(a.Usuario);
                    }
                }

                List<Profesor> listaProfesorInterfaces2 = Profesor.listaProfesores.Where(p => "Profesor: " + p.Nombre + ", Id :" + p.IdProfesor == comboBoxInterfaces.SelectedItem.ToString()).ToList();
                a.Profesores[2] = "Profesor: " + listaProfesorInterfaces2[0].Nombre + ", Id:" + listaProfesorInterfaces2[0].IdProfesor;//introducimos el profesor seleccionado de la asignatura especifica
                for (int s = 0; s < Profesor.listaProfesores.Count; s++)
                {//le introducimos el alumno al profesor
                    if ("Profesor: " + Profesor.listaProfesores[s].Nombre + ", Id:" + Profesor.listaProfesores[s].IdProfesor == a.Profesores[2])
                    {
                        Profesor.listaProfesores[s].ListaAlumnos.Add(a.Usuario);
                    }
                }

                List<Profesor> listaProfesorSGE2 = Profesor.listaProfesores.Where(p => "Profesor: " + p.Nombre + ", Id :" + p.IdProfesor == comboBoxSGE.SelectedItem.ToString()).ToList();
                a.Profesores[3] = "Profesor: " + listaProfesorSGE2[0].Nombre + ", Id:" + listaProfesorSGE2[0].IdProfesor;//introducimos el profesor seleccionado de la asignatura especifica
                for (int s = 0; s < Profesor.listaProfesores.Count; s++)
                {//le introducimos el alumno al profesor
                    if ("Profesor: " + Profesor.listaProfesores[s].Nombre + ", Id:" + Profesor.listaProfesores[s].IdProfesor == a.Profesores[3])
                    {
                        Profesor.listaProfesores[s].ListaAlumnos.Add(a.Usuario);
                    }
                }

                List<Profesor> listaProfesorMoviles2 = Profesor.listaProfesores.Where(p => "Profesor: " + p.Nombre + ", Id :" + p.IdProfesor == comboBoxMoviles.SelectedItem.ToString()).ToList();
                a.Profesores[4] = "Profesor: " + listaProfesorMoviles2[0].Nombre + ", Id:" + listaProfesorMoviles2[0].IdProfesor;//introducimos el profesor seleccionado de la asignatura especifica
                for (int s = 0; s < Profesor.listaProfesores.Count; s++)
                {//le introducimos el alumno al profesor
                    if ("Profesor: " + Profesor.listaProfesores[s].Nombre + ", Id:" + Profesor.listaProfesores[s].IdProfesor == a.Profesores[4])
                    {
                        Profesor.listaProfesores[s].ListaAlumnos.Add(a.Usuario);
                    }
                }

                List<Profesor> listaProfesorIngles2 = Profesor.listaProfesores.Where(p => "Profesor: " + p.Nombre + ", Id :" + p.IdProfesor == comboBoxIngles.SelectedItem.ToString()).ToList();
                a.Profesores[5] = "Profesor: " + listaProfesorIngles2[0].Nombre + ", Id:" + listaProfesorIngles2[0].IdProfesor;//introducimos el profesor seleccionado de la asignatura especifica
                for (int s = 0; s < Profesor.listaProfesores.Count; s++)
                {//le introducimos el alumno al profesor
                    if ("Profesor: " + Profesor.listaProfesores[s].Nombre + ", Id:" + Profesor.listaProfesores[s].IdProfesor == a.Profesores[5])
                    {
                        Profesor.listaProfesores[s].ListaAlumnos.Add(a.Usuario);
                    }
                }

                List<Profesor> listaProfesorEmpresa2 = Profesor.listaProfesores.Where(p => "Profesor: " + p.Nombre + ", Id :" + p.IdProfesor == comboBoxEmpresa.SelectedItem.ToString()).ToList();
                a.Profesores[6] = "Profesor: " + listaProfesorEmpresa2[0].Nombre + ", Id:" + listaProfesorEmpresa2[0].IdProfesor;//introducimos el profesor seleccionado de la asignatura especifica
                for (int s = 0; s < Profesor.listaProfesores.Count; s++)
                {//le introducimos el alumno al profesor
                    if ("Profesor: " + Profesor.listaProfesores[s].Nombre + ", Id:" + Profesor.listaProfesores[s].IdProfesor == a.Profesores[6])
                    {
                        Profesor.listaProfesores[s].ListaAlumnos.Add(a.Usuario);
                    }
                }

                Alumno.listaAlumnos.Add(a);//añadimos el alumno a la lista de alumnos
                MessageBox.Show("Dado de alta con exito");
                usuario.Clear();
                correo.Clear();
                contraseña.Clear();
                dni.Clear();
                comboBoxAcc.Items.Clear();
            } else
            {
                MessageBox.Show("Faltan Argumentos");
            }
        }

        private void AltaAlumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Guardad Cambios", "Guardando cambios...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                ControladorAlumnos.escribirAlumnos();
                ControladorProfesor.escribirProfesores();

            }
            else
            {
                MessageBox.Show("Cambios no guardados");
            }
        }
    }
}
