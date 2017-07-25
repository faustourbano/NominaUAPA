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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
    }
}
