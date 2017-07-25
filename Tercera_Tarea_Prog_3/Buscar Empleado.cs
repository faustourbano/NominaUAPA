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
    public partial class Buscar_Empleado : Form
    {
        public int idEmpleado = 0;

        public Buscar_Empleado()
        {
            InitializeComponent();
            LlenarEmpleados();
            cmbbuscar.SelectedIndex = 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtvalor1_TextChanged(object sender, EventArgs e)
        {
            LlenarEmpleados();
        }

        void LlenarEmpleados()
        {
            Conexion.SentenciaSQL consultas = new Conexion.SentenciaSQL();
            DataTable dt = new DataTable();

            string sql = "select Cod_empleado, cedula, nombre, Apellidos from Empleado ";
         
            if (cmbbuscar.SelectedIndex == 0 && txtvalor1.Text.Length > 0)
                sql = sql + " WHERE Cod_Empleado=" + txtvalor1.Text.Trim();

            if (cmbbuscar.SelectedIndex == 1 && txtvalor1.Text.Length > 0)
                sql = sql + " WHERE Cedula LIKE '" + txtvalor1.Text.Trim() + "%'";

            if (cmbbuscar.SelectedIndex == 2 && txtvalor1.Text.Length > 0)
                sql = sql + " WHERE Nombre LIKE '%" + txtvalor1.Text.Trim() + "%'";

            if (cmbbuscar.SelectedIndex == 3 && txtvalor1.Text.Length > 0)
                sql = sql + " WHERE Apellidos LIKE '%" + txtvalor1.Text.Trim() + "%'";

            dt = consultas.Consultas(sql);
            BuscarEmpleado.DataSource = dt;
        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {           
            LlenarEmpleados();
            txtvalor1.Focus();
        }

        private void btncerrar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = BuscarEmpleado.SelectedRows[0];
            idEmpleado = int.Parse(row.Cells["Cod_empleado"].Value.ToString());


            btnaceptar.PerformClick();
        }
    }
}
