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
    public partial class frmcargo : Form
    {
        public frmcargo()
        {
            InitializeComponent();
            LimpiarEntrada();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();

            if (sentenciaSQL.InsertSQL(
                "INSERT INTO Cargos (descripcion) VALUES ('" + txtdescripcion.Text + "')"))
                MessageBox.Show("OK");
            else
                MessageBox.Show("ERROR");

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();
            if (int.Parse(txtcodigo.Text) > 0)
            {
                ActualizarEmpleado();
            }
            else
            {
                if (ValidarEntrada())
                {
                    if (sentenciaSQL.InsertSQL(
                        "INSERT INTO Cargos (descripcion)"

                        +
                        " VALUES ('"
                        +
                        txtdescripcion.Text + "')"))
                    {
                        MessageBox.Show("Guardado Correctamente");
                        LimpiarEntrada();

                        HabilitarBotones("Guardar");
                    }
                    else
                        MessageBox.Show("ERROR al Guardar");
                }

            }

        }
        void ActualizarEmpleado()
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();

            if (ValidarEntrada())
            {
                string sql = "update Cargos set descripcion='" + txtdescripcion.Text + "'" +
                    " where cod_cargo=" + txtcodigo.Text;

                if (sentenciaSQL.InsertSQL(sql))
                {
                    MessageBox.Show("Actualizado Correctamente");
                    LimpiarEntrada();

                    HabilitarBotones("Crear");
                }
                else
                    MessageBox.Show("ERROR al Actualizar");
            }



        }
        bool ValidarEntrada()
        {
            if (txtcodigo.Text.Length == 0)
            {
                MessageBox.Show("Completar el código");
                txtcodigo.Focus();
                return false;
            }
            return true;

        }
        void LimpiarEntrada()
        {
            txtcodigo.Text = "0";
            txtdescripcion.Text = "";
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


            }
            if (txtcodigo.Text != "0")
                btnborrar.Enabled = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarCargos buscarCargos = new BuscarCargos();

            DialogResult resultado = buscarCargos.ShowDialog();

            if (resultado == DialogResult.OK)
                LlenarCargos(buscarCargos.Cod_cargo);
        }

        private void LlenarCargos(int cod_cargo)
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();
            DataTable dt = new DataTable();

            dt = sentenciaSQL.Consultas("SELECT * FROM Cargos WHERE cod_cargo=" + cod_cargo);

            if (dt.Rows.Count > 0)
            {
                txtcodigo.Text = dt.Rows[0]["Cod_cargo"].ToString();
                txtdescripcion.Text = dt.Rows[0]["descripcion"].ToString();
                
                HabilitarBotones("Buscar");
            }

        }
    

        private void btncrear_Click(object sender, EventArgs e)
        {
            HabilitarBotones("Crear");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Borrar", "Seguro desea Borrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Conexion.SentenciaSQL sentenciasql = new Conexion.SentenciaSQL();

                string sql = "Delete from Empleado where Cod_empleado = " + txtdescripcion.Text;
                if (sentenciasql.InsertSQL(sql))
                {
                    MessageBox.Show("Borrado Correctamente");
                    LimpiarEntrada();
                }

                else
                {
                    MessageBox.Show("No Borrado");
                }
            }
            }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones("Cancelar");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
