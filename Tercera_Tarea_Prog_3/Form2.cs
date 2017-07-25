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
    public partial class EmpleadoForm : Form
    {
        string NombreImagen = "";
        public EmpleadoForm()
        {
            InitializeComponent();
            LimpiarEntrada();
        }

      

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();
            if (int.Parse(txtid.Text) > 0)
            {
                ActualizarEmpleado();
            }
            else
            {
                if (ValidarEntrada())
                {
                    if (sentenciaSQL.InsertSQL(
                        "INSERT INTO Empleado (Cedula,nombre,Apellidos,telefono,direccion,Cod_cargo,Fecha_de_Nacimiento,fechaingreso,fecha,sueldo,Sexo,NombreImagen)"

                        +
                        " VALUES ('"
                        +
                        txtcedula.Text + "','" +
                        txtnombre.Text + "','" +
                        txtapellidos.Text + "','" +
                        txttelefono.Text + "','" +

                        txtdireccion.Text + "'," +
                        cbocargo.SelectedValue.ToString() + ",'" +
                         FormatoFecha(txtfechanacimiento.Text) + "','" +
                        FormatoFecha(txtfechaingreso.Text) + "','" +
                         FormatoFecha(DateTime.Now.ToString()) + "'," +
                        txtsueldo.Text + ",'" +
                        cbosexo.Text.Substring(0, 1) + "','"+
                        NombreImagen +"')"
                        ))
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
                string sql = "update Empleado set cedula='" + txtcedula.Text + "'," +
                      "nombre='" +
                    txtnombre.Text + "', Apellidos='" +
                    txtapellidos.Text + "',telefono='" +
                    txttelefono.Text + "',direccion='" +

                    txtdireccion.Text + "',Cod_cargo=" +
                    cbocargo.SelectedValue.ToString() + ",Fecha_de_Nacimiento='" +
                     FormatoFecha(txtfechanacimiento.Text) + "',fechaingreso='" +
                   FormatoFecha(txtfechaingreso.Text) + "',sueldo=" +
                    txtsueldo.Text + ",Sexo='" +
                     cbosexo.Text.Substring(0, 1) + "', NombreImagen='" + NombreImagen + "' where cod_empleado=" + txtid.Text;

                    if (sentenciaSQL.InsertSQL(sql))
                    {
                        MessageBox.Show("Actualizado Correctamente");
                        LimpiarEntrada();

                        HabilitarBotones("Guardar");
                    }
                    else
                        MessageBox.Show("ERROR al Actualizar");
                }
            


        }


        string FormatoFecha(string fecha)
        {
            DateTime f = Convert.ToDateTime(fecha);
            return f.ToString("yyyy/MM/dd");
        }

        void CargarCargos()
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();
            DataTable dt = new DataTable();

            dt = sentenciaSQL.Consultas("select cod_cargo, descripcion from cargos");

            cbocargo.DataSource = null;
            cbocargo.DataSource = dt;
            cbocargo.DisplayMember = "descripcion";
            cbocargo.ValueMember = "cod_cargo";

        }


        void LimpiarEntrada()
        {
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtid.Text = "0";
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txtfechaingreso.Text = DateTime.Now.ToString();
            txtfechanacimiento.Text = DateTime.Now.ToString();
            txtsueldo.Text = "";
            txttelefono.Text = "";
            CargarCargos();
            pictureEmpleado.ImageLocation = @"C:\NOMINA\User.png";
            NombreImagen = @"C:\NOMINA\User.png";

        }

        bool ValidarEntrada()
        {
            if (txtcedula.Text.Length < 13)
            {
                MessageBox.Show("Completar la Cedula");
                txtcedula.Focus();
                return false;
            }

            if (txtnombre.Text.Length == 0)
            {
                MessageBox.Show("Completar el Nombre");
                txtnombre.Focus();
                return false;
            }
            if (txtapellidos.Text.Length == 0)
            {
                MessageBox.Show("Completar Apellidos");
                txtapellidos.Focus();
                return false;
            }
            if (txtdireccion.Text.Length == 0)
            {
                MessageBox.Show("Completar la Direccion");
                txtdireccion.Focus();
                return false;
            }
            if (txttelefono.Text.Length< 13)
            {
                MessageBox.Show("Completar Telefono");
                txttelefono.Focus();
                return false;
            }
            if (txtsueldo.Text.Length == 0)
            {
                MessageBox.Show("Completar el Sueldo");
                txtsueldo.Focus();
                return false;
            }

            DateTime fecha = Convert.ToDateTime(txtfechanacimiento.Text);

            if (fecha > DateTime.Now)
            {
                MessageBox.Show("Verificar Fecha Nacimiento");
                txttelefono.Focus();
                return false;
            }
            return true;
        }


        private void btncerrar_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            HabilitarBotones("Crear");
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
                GruposDatos.Enabled = false;
                GrupoNomina.Enabled = false;
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
                GruposDatos.Enabled = true;
                GrupoNomina.Enabled = true;
            }
            if (txtid.Text != "0")
                btnborrar.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones("Cancelar");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar_Empleado buscarEmpleado = new Buscar_Empleado();

            DialogResult resultado = buscarEmpleado.ShowDialog();

            if (resultado == DialogResult.OK)
                LlenarEmpleado(buscarEmpleado.idEmpleado);

        }

        void LlenarEmpleado(int idEmpleado)
        {
            Conexion.SentenciaSQL sentenciaSQL = new Conexion.SentenciaSQL();
            DataTable dt = new DataTable();

            dt = sentenciaSQL.Consultas("SELECT * FROM Empleado WHERE Cod_Empleado=" + idEmpleado);

            if (dt.Rows.Count > 0)
            {
                txtfecha.Text = dt.Rows[0]["fecha"].ToString();
                txtid.Text = dt.Rows[0]["Cod_Empleado"].ToString();
                txtcedula.Text = dt.Rows[0]["Cedula"].ToString();
                txtnombre.Text = dt.Rows[0]["nombre"].ToString();
                txtapellidos.Text = dt.Rows[0]["Apellidos"].ToString();
                txtdireccion.Text = dt.Rows[0]["direccion"].ToString();
                txtsueldo.Text = dt.Rows[0]["sueldo"].ToString();
                txttelefono.Text = dt.Rows[0]["telefono"].ToString();
                txtfechaingreso.Text = dt.Rows[0]["fechaingreso"].ToString();
                txtfechanacimiento.Text = dt.Rows[0]["fecha_de_nacimiento"].ToString();
                cbocargo.SelectedValue = dt.Rows[0]["Cod_cargo"].ToString();
                pictureEmpleado.ImageLocation =  dt.Rows[0]["NombreImagen"].ToString(); 
                NombreImagen = dt.Rows[0]["NombreImagen"].ToString();


                if (dt.Rows[0]["sexo"].ToString() == "F")
                    cbosexo.SelectedIndex = 0;
                else
                    cbosexo.SelectedIndex = 1;

                HabilitarBotones("Buscar");
            }
            
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            
           DialogResult resultado= MessageBox.Show("Borrar", "Seguro desea Borrar?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado==DialogResult.Yes)
            {
                Conexion.SentenciaSQL sentenciasql = new Conexion.SentenciaSQL();

                string sql = "Delete from Empleado where Cod_empleado = " + txtid.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.fi
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureEmpleado.Image = Image.FromFile(openFileDialog1.FileName);
                NombreImagen = openFileDialog1.FileName;
                
            }
        }

        private void txtfechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (txtfechanacimiento.Text.Length > 0)
            {
                DateTime fn = Convert.ToDateTime(FormatoFecha(txtfechanacimiento.Text));
                lbedad.Text = (DateTime.Now.Year - fn.Year).ToString();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            frmcargo Cargo = new frmcargo();
            Cargo.Show();
        }
    }
}