using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace FPTeach
{
    public partial class ListaProfesores : Form
    {
        public ListaProfesores()
        {
            InitializeComponent();
        }

        private void ListaProfesores_Load(object sender, EventArgs e)
        {
            mostrarProfesores(Profesor.listaProfesores);
        }

        private void boxProfesores_Enter(object sender, EventArgs e)
        {

        }
        private int posicionInicial;
        private int contadorNombres;
        public void crearEtiquetaProfesor(Profesor p)
        {
            System.Windows.Forms.CheckBox Grupocb = new System.Windows.Forms.CheckBox();
            Grupocb.AutoSize = true;
            Grupocb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Grupocb.Location = new System.Drawing.Point(10, this.posicionInicial);
            Grupocb.Name = p.IdProfesor;
            Grupocb.Size = new System.Drawing.Size(290, 20);
            Grupocb.TabIndex = 1;
            Grupocb.Text = "Id Profesor:" + p.IdProfesor + ", Nombre: " + p.Nombre + ", Asignatura: " + p.Asignatura;
            boxProfesores.Controls.Add(Grupocb);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }
        private void mostrarProfesores(List <Profesor> listaProfesores)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            /*for (int i = 0; i < lista.Count; i++)
            {
                crearEtiqueta(lista[i]);
            }*/

            foreach (Profesor item in listaProfesores)
            {
                crearEtiquetaProfesor(item);
            }
        }

        private void eleminar_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in boxProfesores.Controls)
            {
                if (cb.Checked)
                {
                    int posicion = Profesor.listaProfesores.FindIndex(x => x.IdProfesor == cb.Name);
                    if (posicion != -1)
                    {

                        for (int i = 0; i < Profesor.listaProfesores[posicion].ListaAlumnos.Count; i++) {//eliminamos tambien de la lista de profesores de los alumnos el profesor
                            for (int j = 0; j < Alumno.listaAlumnos.Count; j++) {
                                if(Alumno.listaAlumnos[j].Usuario== Profesor.listaProfesores[posicion].ListaAlumnos[i])
                                {
                                    for (int k = 0; k < Alumno.listaAlumnos[j].Profesores.Length; k++) {
                                        if (Alumno.listaAlumnos[j].Profesores[k] == "Profesor: " + Profesor.listaProfesores[posicion].Nombre + ", Id:" + Profesor.listaProfesores[posicion].IdProfesor) {
                                            Alumno.listaAlumnos[j].Profesores[k] = "Sin profesor";
                                        }
                                    }
                                }
                            }
                        }
                        Profesor.listaProfesores.RemoveAt(posicion);

                    }

                }
            }
            this.boxProfesores.Controls.Clear();
            mostrarProfesores(Profesor.listaProfesores);
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrdenar.SelectedItem.ToString() == "ID Profesor") {//ordenar por idprofesor
                List<Profesor> listaProfesorId = Profesor.listaProfesores.OrderBy(x => x.IdProfesor).ToList();

                for (int j = 0; j < listaProfesorId.Count; j++)
                {
                    crearEtiquetaProfesor(listaProfesorId[j]);
                }
                    this.boxProfesores.Controls.Clear();
                    mostrarProfesores(listaProfesorId);
                }

            if (comboBoxOrdenar.SelectedItem.ToString() == "Nombre") {//ordenar por nombre
                List<Profesor> listaProfesorNombre = Profesor.listaProfesores.OrderBy(x => x.Nombre).ToList();

                for (int j = 0; j < listaProfesorNombre.Count; j++)
                {
                    crearEtiquetaProfesor(listaProfesorNombre[j]);
                }
                this.boxProfesores.Controls.Clear();
                mostrarProfesores(listaProfesorNombre);
            }
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFiltrar.Text== "No filtrar")
            {
                this.boxProfesores.Controls.Clear();
                mostrarProfesores(Profesor.listaProfesores);
            }
            else {
                List<Profesor> listaProfesorFiltrada = Profesor.listaProfesores.Where(p => p.Asignatura == comboBoxFiltrar.Text).ToList();
                this.boxProfesores.Controls.Clear();
                mostrarProfesores(listaProfesorFiltrada);
            }
                List<Profesor> personasFiltradas = Profesor.listaProfesores.Where(p => p.Asignatura ==comboBoxFiltrar.Text).ToList();
        }

        private void ListaProfesores_FormClosing(object sender, FormClosingEventArgs e)
        {//pedir confirmacion para escribir en los archivos de profesores y alumnos(json y xml)
            DialogResult dialogo = MessageBox.Show("Guardad Cambios", "Guardando cambios...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                ControladorProfesor.escribirProfesores();
                ControladorAlumnos.escribirAlumnos();
            }
            else
            {
                MessageBox.Show("Cambios no guardados");
            }
        }
    }
}
