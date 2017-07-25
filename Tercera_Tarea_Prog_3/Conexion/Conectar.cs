using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace Tercera_Tarea_Prog_3.Conexion
{
    public class Conectar
    {
        
        public Conectar()
        {
           //constructor

        }

        public string MiConexion()
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source= Nomina.s3db; version = 3");
            try
            {
                conexion.Open();
                return "OK";
            }
            catch (Exception ex)
            {
                return "error " + ex.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

    }

    
}