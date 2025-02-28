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
    public partial class MenuAlumno : Form
    {
        public MenuAlumno()
        {
            InitializeComponent();
        }
        private void MenuAlumno_Load(object sender, EventArgs e)
        {//establecemos el valor de las notas en las correspondientes labels
            notaEmprersa.Text = variablesCompartidas.A.Nota[6].ToString()+"  -  "+variablesCompartidas.A.Profesores[6];
            notaIngles.Text = variablesCompartidas.A.Nota[5].ToString() +"  -  "+ variablesCompartidas.A.Profesores[5];
            notaInterfaces.Text = variablesCompartidas.A.Nota[2].ToString() + "  -  " + variablesCompartidas.A.Profesores[2];
            notaPPS.Text = variablesCompartidas.A.Nota[1].ToString() + "  -  " + variablesCompartidas.A.Profesores[1];
            notaMoviles.Text = variablesCompartidas.A.Nota[4].ToString() + "  -  " + variablesCompartidas.A.Profesores[4];
            notaSGE.Text = variablesCompartidas.A.Nota[3].ToString() + "  -  " + variablesCompartidas.A.Profesores[3];
            NotaAcc.Text = variablesCompartidas.A.Nota[0].ToString() + "  -  " + variablesCompartidas.A.Profesores[0];
        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfilAlumno pa=new PerfilAlumno();
            pa.ShowDialog();
        }
        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void listaDeEjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
