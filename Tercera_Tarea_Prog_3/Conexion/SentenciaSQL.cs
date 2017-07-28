using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tercera_Tarea_Prog_3.Conexion
{

    public class SentenciaSQL
    {
        public SQLiteConnection conexion = new SQLiteConnection(@"Data Source=C:\SQLiteDB\Nomina.s3db;");
        public bool InsertSQL(string sql)
        {
            try
            {
                conexion.Open();
                SQLiteCommand Command = new SQLiteCommand(sql, conexion);
                int i = Command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                string n = e.Message;
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public int  InsertSQLMaster(string sql)
        {
            int   id = 0;
            try
            {
                conexion.Open();
                SQLiteCommand Command = new SQLiteCommand( conexion);
                Command.CommandType = CommandType.Text;
                Command.CommandText = sql;
                object i = Command.ExecuteScalar();
                id = int.Parse(i.ToString());
            }
            catch (Exception e)

            {
                string n = e.Message;
            }
            finally
            {
                conexion.Close();
            }
            return id;
        }


        public DataTable Consultas(string sql)
        {
            DataTable dt = new DataTable();
            try
            {

                
                conexion.Open();
                SQLiteCommand Command;
                Command = conexion.CreateCommand();
                Command.CommandText = sql;
                SQLiteDataAdapter da = new SQLiteDataAdapter(Command);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                conexion.Close();
            }

            return dt;
        }

      
    }
}
