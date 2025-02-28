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
    public partial class ponerNotas1 : Form
    {
        public ponerNotas1()
        {
            InitializeComponent();
        }
        private void ponerNotas1_Load(object sender, EventArgs e)
        {
            Profesor p=variablesCompartidas.P;
            List<Alumno> listaAlumnos=new List<Alumno>();
            for (int i = 0; i < Alumno.listaAlumnos.Count; i++) {//rellenamos el box con la lista de alumnos
                for (int j = 0; j < Alumno.listaAlumnos.Count; j++)
                {
                    if (Alumno.listaAlumnos[i].Profesores[j] == "Profesor: " + variablesCompartidas.P.Nombre + ", Id:" + variablesCompartidas.P.IdProfesor) {
                        listaAlumnos.Add(Alumno.listaAlumnos[i]);
                    }
                }

            }
            foreach (Alumno a in listaAlumnos)
            {
                comboBoxAlumno.Items.Add(a.Usuario);
            }
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Boolean validarDatos() { 
            Boolean validar = true;
            if(comboBoxAlumno.SelectedItem == null)
            {
                validar = false;
                MessageBox.Show("Falta elegir alumno");
            }
            if(comboBoxNotas.SelectedItem == null)
            {
                validar = false;
                MessageBox.Show("Falta elegir nota");
            }
            return validar;
        }
        private void ponerNota_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                for (int i = 0; i < Alumno.listaAlumnos.Count; i++)
                {
                    if (Alumno.listaAlumnos[i].Usuario == comboBoxAlumno.Text)
                    {
                        Alumno.listaAlumnos[i].Nota[verificarAsignatura()] = Int32.Parse(comboBoxNotas.Text);
                        MessageBox.Show("Se ha actualizado la nota");
                    }
                }
            }
            else {
 
            }
        }
        private int verificarAsignatura() { 
            if (variablesCompartidas.P.Asignatura == "Acceso a Datos") {
                return 0;
            }
            if (variablesCompartidas.P.Asignatura == "Procesos")
            {
                return 1;
            }
            if (variablesCompartidas.P.Asignatura == "Interfaces")
            {
                return 2;
            }
            if (variablesCompartidas.P.Asignatura == "Empresa")
            {
                return 6;
            }
            if (variablesCompartidas.P.Asignatura == "Aplicaciones Moviles")
            {
                return 4;
            }
            if (variablesCompartidas.P.Asignatura == "SGE")
            {
                return 3;
            }
            if (variablesCompartidas.P.Asignatura == "Ingles")
            {
                return 5;
            }
            return 0;
        }

        private void ponerNotas1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Guardad Cambios", "Guardando cambios...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                ControladorAlumnos.escribirAlumnos();//para guardar la nota
            }
            else
            {
                MessageBox.Show("Cambios no guardados");
            }
        }
    }
}
