using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_ERP_19._05._26
{
    public class clsConexion
    {
        public class ConexionBaseDeDatos
        {
                public static OleDbConnection conexion;
                public static string error;
                public static bool Conectar() 
                {
                    string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BaseDatos", "SilvaMenendez.accdb");
                    string cadena = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + ruta;

                    try
                    {
                        conexion = new OleDbConnection(cadena);
                        conexion.Open();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                        return false;
                    }
                }

                public static void Desconectar()
                {
                    if (conexion != null && conexion.State == ConnectionState.Open)
                        conexion.Close();
                }

                public static DataTable Consultar(string sql)
                {
                    DataTable tabla = new DataTable();
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter(sql, conexion);
                        da.Fill(tabla);
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                    }
                    return tabla;
                }
        }
    }
}
