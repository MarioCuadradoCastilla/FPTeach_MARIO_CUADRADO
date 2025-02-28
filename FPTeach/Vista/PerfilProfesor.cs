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
    public partial class PerfilProfesor : Form
    {
        public PerfilProfesor()
        {
            InitializeComponent();
        }

        private void PerfilProfeso_Load(object sender, EventArgs e)
        {
            label1nombr.Text = variablesCompartidas.P.Nombre;
            label2contraseña.Text = variablesCompartidas.P.Contraseña;
            label3dni.Text = variablesCompartidas.P.Dni;
            label4Numseg.Text = variablesCompartidas.P.Numseg;
            label5Asign.Text = variablesCompartidas.P.Asignatura;
            labelId.Text = variablesCompartidas.P.IdProfesor;

        }
    }
}
