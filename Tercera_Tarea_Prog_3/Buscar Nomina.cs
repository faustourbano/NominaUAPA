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
    public partial class Buscar_Nomina : Form
    {
        public int idnomina = 0;
        public string fechanomina = "";
        public string estatus = "";
        public Buscar_Nomina()
        {
            InitializeComponent();
            LlenarNomina(false);
            
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            RetornarDatos();
        }
        void LlenarNomina(bool filtrar )
        {
            Conexion.SentenciaSQL consultas = new Conexion.SentenciaSQL();
            DataTable dt = new DataTable();

            string sql = "select cod_nomina, fecha, totaldeducciones, TotalNomina, TotalSueldoNeto, Estatus from Nomina ";

            
            if (filtrar)
                sql = sql + " WHERE fecha >= '" + FormatoFecha(txtfechainicial.Text) + "' and fecha <= '" + FormatoFecha(txtfechafinal.Text) + "' ";


            sql = sql + " ORDER BY fecha DESC";
           dt = consultas.Consultas(sql);
            buscarnomina.DataSource = dt;
        }


        string FormatoFecha(string fecha)
        {
            DateTime f = Convert.ToDateTime(fecha);
            return f.ToString("yyyy/MM/dd");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            LlenarNomina(true);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            LlenarNomina(false);
        }

        private void buscarnomina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnaceptar.PerformClick();
        }


        void RetornarDatos()
        {           
            DataGridViewRow row = buscarnomina.SelectedRows[0];
            idnomina = int.Parse(row.Cells["codigo"].Value.ToString());
            fechanomina = row.Cells["fecha"].Value.ToString();
            estatus = row.Cells["estatus"].Value.ToString();
        }
    }
}
