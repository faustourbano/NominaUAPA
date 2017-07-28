using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tercera_Tarea_Prog_3
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleado = new EmpleadoForm();
            empleado.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcargo cargo = new frmcargo();
            cargo.Show();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterNomina nomina = new MasterNomina();
            nomina.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
