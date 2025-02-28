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
    public partial class PerfilAlumno : Form
    {
        public PerfilAlumno()
        {
            InitializeComponent();
        }

        private void PerfilAlumno_Load(object sender, EventArgs e)
        {
            labeLusuario.Text = variablesCompartidas.A.Usuario;
            labelcorreo.Text = variablesCompartidas.A.Correo;
            labelcontraseña1.Text = variablesCompartidas.A.Contraseña;
            labeldni.Text = variablesCompartidas.A.Dni;

        }
    }
}
