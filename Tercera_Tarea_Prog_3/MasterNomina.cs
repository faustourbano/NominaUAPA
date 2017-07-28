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
    public partial class MasterNomina : Form
    {
        DataTable dt = new DataTable();
        public MasterNomina()
        {
            InitializeComponent();
            LimpiarEntrada();
            CrearDataTable();
        }

        private void MasterNomina_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones("Cancelar");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar_Nomina buscarnomina = new Buscar_Nomina();

            DialogResult resultado = buscarnomina.ShowDialog();

            if (resultado == DialogResult.OK)
                {
                txtcodigo.Text = buscarnomina.idnomina.ToString();
                txtfecha.Text = buscarnomina.fechanomina;
                cheprocesada.Checked = buscarnomina.estatus == "P" ? true : false;
                LlenarDetalle(buscarnomina.idnomina);

                HabilitarBotones("Buscar");


                if (cheprocesada.Checked)
                {
                    btnbuscar.Enabled = true;
                    grDatosEmpleados.Enabled = false;
                    btncrear.Enabled = true;
                    btnguardar.Enabled = false;
                    btnborrar.Enabled = true;
                    dtdetallesnomina.Enabled = false;                   
                    cheprocesada.Enabled = false;
                    MessageBox.Show("Nomina Procesada. No se puede editar");
                }
               
            }

        }

        private void LlenarDetalle(int idnomina)
        {
            Conexion.SentenciaSQL consultas = new Conexion.SentenciaSQL();
            DataTable dtDetalle = new DataTable();

            string sql = "select iddetalle, codempleado, nombre,  cargo, sueldo, ISR, SS, Otros, deducciones, sueldoneto, estatus  " +
                        "from NominaDetalleVista1 where cod_nomina =" + idnomina;

            dtDetalle = consultas.Consultas(sql);
            
            if (dtDetalle.Rows.Count > 0)
            {
                foreach (DataRow dtRow in dtDetalle.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["iddetalle"] = dtRow["iddetalle"].ToString();
                    row["codempleado"] = dtRow["codempleado"].ToString();
                    row["nombre"] = dtRow["nombre"].ToString();
                    row["cargo"] = dtRow["cargo"].ToString();
                    row["sueldo"] = string.Format("{0:N2}",  dtRow["sueldo"]);
                    row["IRS"] = string.Format("{0:N2}", dtRow["ISR"]);
                    row["SS"] = string.Format("{0:N2}", dtRow["SS"]);
                    row["Otros"] = string.Format("{0:N2}", dtRow["Otros"]);
                    row["deducciones"] = string.Format("{0:N2}", dtRow["deducciones"]);
                    row["sueldoneto"] = string.Format("{0:N2}", dtRow["sueldoneto"]);
                    row["Estatus"] = dtRow["estatus"].ToString();

                    dt.Rows.Add(row);
                }

                dtdetallesnomina.DataSource = dt;

            }
            
            
            
            
            //dtdetallesnomina.DataSource = dt;
            Totales();
        }

        private void btnbus_Click(object sender, EventArgs e)
        {
            Buscar_Empleado buscarempleado = new Buscar_Empleado();
            DialogResult resultado = buscarempleado.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                LlenarEmpleado(buscarempleado.idEmpleado);
                txtcodempleado.Focus();
            }
        }

        void LlenarEmpleado(int idEmpleado)
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();
            DataTable dt = new DataTable();

            dt = sentenciaSQL.Consultas("SELECT cod_empleado, nombre, Apellidos, sueldo, c.descripcion FROM Empleado e " +
                "inner join Cargos c on c.cod_cargo=e.Cod_cargo and Cod_Empleado=" + idEmpleado);

            if (dt.Rows.Count > 0)
            {
                txtcodempleado.Text = dt.Rows[0]["Cod_Empleado"].ToString();
                txtnombre.Text = dt.Rows[0]["nombre"].ToString() + " " + dt.Rows[0]["Apellidos"].ToString();
                lbcargo.Text = dt.Rows[0]["descripcion"].ToString();
                txtsueldo.Text = string.Format("{0:N2}", dt.Rows[0]["sueldo"]);
                btnagregar.Focus();
            }
            else
            {
                MessageBox.Show("Empleado no Encontrado");
            }
        }


        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LlenarEmpleado(Convert.ToInt32(txtcodempleado.Text));
                if (txtnombre.Text.Length > 0)
                {
                    btnagregar.Focus();
                }

            }

        }
        void LimpiarEntrada()
        {
            txtcodigo.Text = "0";
            txtfecha.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtcodempleado.Text = "";
            txtnombre.Text = "";
            txtsueldo.Text = "";
            
            cheprocesada.Checked = false;
            txttotal.Text = "";
            txttotalnomina.Text = "";
            txttotaldeducciones.Text = "";
            txtsueldoneto.Text = "";
            dt.Rows.Clear();
            dtdetallesnomina.DataSource = dt;
            cheprocesada.Enabled = true;
            dtdetallesnomina.Enabled = true;
        }
        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (ValidarEmpleadoDetalles())
            {
                //MessageBox.Show(dt.Rows.Count.ToString());
                DataRow row = dt.NewRow();
                row["iddetalle"] = 0;
                row["codempleado"] = txtcodempleado.Text;
                row["nombre"] = txtnombre.Text;
                row["cargo"] = lbcargo.Text;
                row["sueldo"] = txtsueldo.Text;
                row["IRS"] = (Convert.ToDouble(txtsueldo.Text) * 0.12).ToString("N2");
                row["SS"] = (Convert.ToDouble(txtsueldo.Text) * 0.04).ToString("N2");
                row["Otros"] = (Convert.ToDouble(txtsueldo.Text) * 0.2).ToString("N2");
                row["deducciones"] = (Convert.ToDouble(row["IRS"].ToString()) + Convert.ToDouble(row["SS"].ToString()) +
                                       Convert.ToDouble(row["Otros"].ToString())).ToString("N2");
                row["sueldoneto"] = (Convert.ToDouble(txtsueldo.Text) - Convert.ToDouble(row["deducciones"].ToString())).ToString("N2");
                row["Estatus"] = "A";
                
                dt.Rows.Add(row);

                dtdetallesnomina.DataSource = dt;
                txtcodempleado.Text = "";
                txtnombre.Text = "";
                txtsueldo.Text = "";
                txtcodempleado.Focus();
                Totales();
            }
            else
            {
                MessageBox.Show("Empleado Se Encuentra Agregado");
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Totales()
        {
            double totaldeducciones = 0;
            double totalsueldoneto = 0;
            for (int i = 0; i <= dtdetallesnomina.Rows.Count - 1; i++)
            {
                if (dtdetallesnomina.Rows[i].Cells["Estatus"].Value.ToString() == "A")
                {
                    totaldeducciones += Convert.ToDouble(dtdetallesnomina.Rows[i].Cells["deducciones"].Value.ToString());
                    totalsueldoneto += Convert.ToDouble(dtdetallesnomina.Rows[i].Cells["sueldoneto"].Value.ToString());
                }
            }

            txttotaldeducciones.Text = totaldeducciones.ToString("N2");
            txtsueldoneto.Text = totalsueldoneto.ToString("N2");
            txttotalnomina.Text = (totaldeducciones + totalsueldoneto).ToString("N2");
            txttotal.Text = dtdetallesnomina.Rows.Count.ToString();

        }
        bool ValidarEmpleadoDetalles()
        {
            if (txtnombre.Text.Length == 0)
            {
                MessageBox.Show("Definir empleado");
                txtcodempleado.Focus();

                return false;
            }

            string id = "";

            for (int i = 0; i <= dtdetallesnomina.Rows.Count - 1; i++)
            {
                id = dtdetallesnomina.Rows[i].Cells["Cod"].Value.ToString();
                string Estatus = dtdetallesnomina.Rows[i].Cells["Estatus"].Value.ToString();
                if (id == txtcodempleado.Text && Estatus == "A")
                {
                    txtcodempleado.Focus();
                    return false;
                }
            }

            return true;
        }

        private void txttotalnomina_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (dtdetallesnomina.Rows.Count == 0)
            {
                MessageBox.Show("Definir Empleado Para la Nomina");
                txtcodempleado.Focus();
            }
            else
            {
                Conexion.SentenciaSQL sentenciasql = new Conexion.SentenciaSQL();
                string estatus = cheprocesada.Checked ? "P" : "S";

                if (txtcodigo.Text == "0")
                {

                    string sql = "INSERT INTO Nomina (Fecha, TotalSueldoNeto, Totaldeducciones, TotalNomina, Estatus) VALUES ('" +
                        DateTime.Now.ToString("yyyy/MM/dd") + "'," +
                       FormatoNumero(txtsueldoneto.Text) + "," +
                        FormatoNumero(txttotaldeducciones.Text) + "," +
                       FormatoNumero(txttotalnomina.Text) + ",'" +
                        estatus + "'); SELECT last_insert_rowid()";
                    int codMaster = sentenciasql.InsertSQLMaster(sql);
                    if (codMaster > 0)
                    {
                        InsertarNominaDetalle(codMaster);
                        MessageBox.Show("Guardado Correctamente");
                        LimpiarEntrada();
                        HabilitarBotones("Guardar");
                    }
                    else
                        MessageBox.Show("Error Al Guardar");
                }
                else
                {
                    string sql = "UPDATE Nomina SET TotalSueldoNeto=" +
                         FormatoNumero(txtsueldoneto.Text) + "," +
                         "Totaldeducciones=" + FormatoNumero(txttotaldeducciones.Text) + "," +
                         "TotalNomina=" + FormatoNumero(txttotalnomina.Text) + "," +
                         "Estatus='" + estatus + "' WHERE cod_nomina=" + txtcodigo.Text;

                    if (sentenciasql.InsertSQL(sql))
                    {
                        InsertarNominaDetalle(int.Parse(txtcodigo.Text));
                        MessageBox.Show("Guardado Correctamente");
                        LimpiarEntrada();
                        HabilitarBotones("Guardar");
                    }
                }
            }
        }

        void InsertarNominaDetalle(int codnomina)
        {
            for (int i = 0; i <= dtdetallesnomina.Rows.Count - 1; i++)
            {
                Conexion.SentenciaSQL sentenciasql = new Conexion.SentenciaSQL();
                int idDetalleNomina = int.Parse(dtdetallesnomina.Rows[i].Cells["iddetalles"].Value.ToString());

                if (idDetalleNomina == 0)
                {

                    string sql = "INSERT INTO DetalleNomina (cod_nomina, cod_empleado, sueldo, Otros, ISR, SS, SueldoNeto, Estatus) VALUES (" +
                        codnomina + "," +
                        dtdetallesnomina.Rows[i].Cells["Cod"].Value.ToString() + "," +
                       FormatoNumero(dtdetallesnomina.Rows[i].Cells["sueldobruto"].Value.ToString()) + "," +
                       FormatoNumero(dtdetallesnomina.Rows[i].Cells["Otros"].Value.ToString()) + "," +
                       FormatoNumero(dtdetallesnomina.Rows[i].Cells["ISR"].Value.ToString()) + "," +
                       FormatoNumero(dtdetallesnomina.Rows[i].Cells["SS"].Value.ToString()) + "," +
                       FormatoNumero(dtdetallesnomina.Rows[i].Cells["SueldoNeto"].Value.ToString()) + ",'" +
                       dtdetallesnomina.Rows[i].Cells["Estatus"].Value.ToString() + "')";

                    sentenciasql.InsertSQL(sql);
                }
                else
                {
                    string sql = "UPDATE DetalleNomina SET Estatus='" +                       
                                  dtdetallesnomina.Rows[i].Cells["Estatus"].Value.ToString() + "' " +
                                  "WHERE iddetallenomina=" + idDetalleNomina;

                    sentenciasql.InsertSQL(sql);
                }
            }
        }

        void HabilitarBotones(string boton)
        {
            if (boton == "Guardar" || boton == "Cancelar")
            {

                LimpiarEntrada();
                btncrear.Enabled = true;
                btnborrar.Enabled = false;
                btnguardar.Enabled = false;
                btncerrar.Enabled = true;
                btnbuscar.Enabled = true;
                btncancelar.Enabled = false;
                grDatosEmpleados.Enabled = false;
            }
            else
            {
                // LimpiarEntrada();
                btncrear.Enabled = false;
                btnborrar.Enabled = false;
                btnguardar.Enabled = true;
                btncerrar.Enabled = true;
                btnbuscar.Enabled = false;
                btncancelar.Enabled = true;
                grDatosEmpleados.Enabled = true;
            }
           
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            HabilitarBotones("Crear");
            LimpiarEntrada();
            txtcodempleado.Focus();
        }

        string FormatoNumero(string Numero)
        {
            double n = Convert.ToDouble(Numero);
            return n.ToString("00.00");
        }

        void CrearDataTable()
        {
            dt.Columns.Add("iddetalle");
            dt.Columns.Add("codempleado");
            dt.Columns.Add("nombre");
            dt.Columns.Add("cargo");
            dt.Columns.Add("sueldo");
            dt.Columns.Add("IRS");
            dt.Columns.Add("SS");
            dt.Columns.Add("Otros");
            dt.Columns.Add("deducciones");
            dt.Columns.Add("sueldoneto");
            dt.Columns.Add("Estatus");
        }

        private void dtdetallesnomina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult resultado = MessageBox.Show("Seguro desea borrar?", "borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    int idRow = dtdetallesnomina.CurrentRow.Index;

                    DataGridViewRow row = dtdetallesnomina.Rows[idRow];
                    row.Cells["iddetalle"].Value = "I";
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    Totales();
                    txtcodempleado.Focus();
                }                
            }
        }
    }
}
 