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
    public partial class AlumnosProfesor : Form
    {
        public AlumnosProfesor()
        {
            InitializeComponent();
        }
        private void AlumnosProfesor_Load(object sender, EventArgs e)
        {
            mostrarProfesores(variablesCompartidas.P.ListaAlumnos);
        }
        private int posicionInicial;
        private int contadorNombres;

        public void crearEtiquetaAlumno(string alumno)
        {
            System.Windows.Forms.Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GrupoLbl.Location = new System.Drawing.Point(10, this.posicionInicial);
            GrupoLbl.Name = alumno;
            GrupoLbl.Size = new System.Drawing.Size(290, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = alumno;
            boxAlumnos.Controls.Add(GrupoLbl);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }
        private void mostrarProfesores(List<string> listaAlumnos)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;

            foreach (string item in listaAlumnos)
            {
                crearEtiquetaAlumno(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boxAlumnos_Enter(object sender, EventArgs e)
        {

        }

    }
}
