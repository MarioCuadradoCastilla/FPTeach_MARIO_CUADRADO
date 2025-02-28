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
    public partial class ListaAlumnos : Form
    {
        public ListaAlumnos()
        {
            InitializeComponent();
            mostrarAlumnos(Alumno.listaAlumnos);
        }

        private void ListaAlumnos_Load(object sender, EventArgs e)
        {

        }
        private int posicionInicial;
        private int contadorNombres;
        public void crearEtiquetaAlumno(Alumno a)//crear etiquetas
        {
            CheckBox Grupocb = new System.Windows.Forms.CheckBox();
            Grupocb.AutoSize = true;
            Grupocb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Grupocb.Location = new System.Drawing.Point(10, this.posicionInicial);
            Grupocb.Name = a.Usuario;
            Grupocb.Size = new System.Drawing.Size(290, 20);
            Grupocb.TabIndex = 1;
            Grupocb.Text = "Usuario alumno: " +a.Usuario + ", Correo: " +a.Correo + ", DNI: "+a.Dni;
            boxAlumnos.Controls.Add(Grupocb);
            this.posicionInicial += 20;
        }
        private void mostrarAlumnos(List<Alumno> listaAlumno)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;

            foreach (Alumno item in listaAlumno)
            {
                crearEtiquetaAlumno(item);
            }
        }
        private void eleminar_Click_1(object sender, EventArgs e)//eliminar el alumno
        {
            foreach (CheckBox cb in boxAlumnos.Controls)
            {
                if (cb.Checked)
                {
                    int posicion = Alumno.listaAlumnos.FindIndex(x => x.Usuario == cb.Name);
                    if (posicion != -1)
                    {
                       for (int i = 0; i < Alumno.listaAlumnos[posicion].Profesores.Length; i++)
                        {//eliminamos tambien de la lista de alumnos de los prosores el alumno
                            for (int j = 0; j < Profesor.listaProfesores.Count; j++)
                            {
                                if ("Profesor: " + Profesor.listaProfesores[j].Nombre + ", Id:" + Profesor.listaProfesores[j].IdProfesor == Alumno.listaAlumnos[posicion].Profesores[i])
                                {
                                    for (int k = 0; k < Profesor.listaProfesores[j].ListaAlumnos.Count; k++)
                                    {
                                        if (Profesor.listaProfesores[j].ListaAlumnos[k] == Alumno.listaAlumnos[posicion].Usuario)
                                        {
                                            Profesor.listaProfesores[j].ListaAlumnos.RemoveAt(k);
                                        }
                                    }
                                }
                            }
                        }
                        Alumno.listaAlumnos.RemoveAt(posicion);
                    }

                }
            }
            this.boxAlumnos.Controls.Clear();
            mostrarAlumnos(Alumno.listaAlumnos);
        }

        private void ListaAlumnos_FormClosing(object sender, FormClosingEventArgs e)//preguntamos antes de salir siquiere guardar los cambios y ya escribimos en json los profesores y en xml los alumnos
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

        private void boxAlumnos_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrdenar.SelectedItem.ToString() == "Usuario")//ordenar por usuario
            {
                List<Alumno> listaAlumnoUsuario = Alumno.listaAlumnos.OrderBy(x => x.Usuario).ToList();

                for (int j = 0; j < listaAlumnoUsuario.Count; j++)
                {
                    crearEtiquetaAlumno(listaAlumnoUsuario[j]);
                }
                this.boxAlumnos.Controls.Clear();
                mostrarAlumnos(listaAlumnoUsuario);
            }

            if (comboBoxOrdenar.SelectedItem.ToString() == "Correo")//ordenar por correo
            {
                List<Alumno> listaAlumnoCorreo = Alumno.listaAlumnos.OrderBy(x => x.Correo).ToList();

                for (int j = 0; j < listaAlumnoCorreo.Count; j++)
                {
                    crearEtiquetaAlumno(listaAlumnoCorreo[j]);
                }
                this.boxAlumnos.Controls.Clear();
                mostrarAlumnos(listaAlumnoCorreo);
            }
        }
    }
}
