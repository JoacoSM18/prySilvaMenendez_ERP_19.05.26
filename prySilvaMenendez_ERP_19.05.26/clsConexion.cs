using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_ERP_19._05._26
{
    public class clsConexion
    {
        public class ConexionBaseDeDatos
        {
            public OleDbConnection conexion;
            public string error;
            public bool Conectar(string cadena)
            {
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
            public void Desconectar()
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            public DataTable Consultar(string sql)
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
