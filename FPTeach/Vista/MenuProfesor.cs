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
    public partial class MenuProfesor : Form
    {
        public MenuProfesor()
        {
            InitializeComponent();
        }

        private void ejerciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void añadirEjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Profesor_Load(object sender, EventArgs e)
        {

        }

        private void listaEjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listaAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosProfesor alumnosProfe=new AlumnosProfesor();
            alumnosProfe.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosProfesor aProfesor=new AlumnosProfesor();
            aProfesor.ShowDialog();
        }

        private void ponerNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuProfesor pNota = new MenuProfesor();
            pNota.ShowDialog();
        }

        private void ponerNotasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ponerNotas1 ponerNotas1 = new ponerNotas1();
            ponerNotas1.ShowDialog();
            
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfilProfesor pf = new PerfilProfesor();
            pf.ShowDialog();
        }
    }
}
