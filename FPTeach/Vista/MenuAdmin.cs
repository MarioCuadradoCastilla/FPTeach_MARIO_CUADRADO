using FPTeach.Vista;
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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }
        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaAlumno regAlumno = new AltaAlumno();
            regAlumno.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesores lProfesores = new ListaProfesores();
            lProfesores.ShowDialog();
        }
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProfesor altaProfesor = new AltaProfesor();
            altaProfesor.ShowDialog();
        }

        private void listaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAlumnos listaAlumnos = new ListaAlumnos(); 
            listaAlumnos.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecursos fr=new FormRecursos();
            fr.ShowDialog();
        }
    }
}
