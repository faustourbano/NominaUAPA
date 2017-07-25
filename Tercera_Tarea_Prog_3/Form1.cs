using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Tercera_Tarea_Prog_3
{
    public partial class frmempleado1 : Form
    {
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmempleado_Load(object sender, EventArgs e)
        {
            //frmempleado1.show();
        }

        private static void show(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        public static void show()
        {
            throw new NotImplementedException();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar conectar = new Conexion.Conectar();

            MessageBox.Show(conectar.MiConexion());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfechaingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfechanacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
        }
    

