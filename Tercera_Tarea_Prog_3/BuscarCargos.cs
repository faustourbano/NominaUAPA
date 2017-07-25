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
    public partial class BuscarCargos : Form
    {
       public int Cod_cargo = 0;
        public BuscarCargos()
        {
            InitializeComponent();
            LlenarCargos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BuscarCargos_Load(object sender, EventArgs e)
        {

        }

        void LlenarCargos()
        {
            Conexion.SentenciaSQL consultas = new Conexion.SentenciaSQL();
            DataTable dt = new DataTable();

            string sql = "select cod_cargo, descripcion  from Cargos ";

            

            dt = consultas.Consultas(sql);
            dtbuscarempleado.DataSource = dt;
        }

        private void btncerrar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtbuscarempleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtbuscarempleado.SelectedRows[0];
            Cod_cargo = int.Parse(row.Cells["Cod"].Value.ToString());

            btnaceptar.PerformClick();
        }

        private void dtbuscarempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
