using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string ruta = @"C:\Users\Alumno\source\repos\prySilvaMenendez_ERP_19.05.26\prySilvaMenendez_ERP_19.05.26\BaseDatos\SilvaMenendez.accdb";
                //string ruta = @"C:\Users\joako\source\repos\prySilvaMenendez_ERP_19.05.26\prySilvaMenendez_ERP_19.05.26\BaseDatos\SilvaMenendez.accdb";
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
                if (conexion != null && conexion.State == ConnectionState.Open) conexion.Close();
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
                    MessageBox.Show(ex.Message);
                    error = ex.Message;
                }
                return tabla;
            }
            public static void Ejecutar(string sql)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    error = ex.Message;
                }
            }
            public static void AuditarSesion(string usuario, bool acceso)
            {
                try
                {
                    string sql = "INSERT INTO AuditoriaInicioSesion (FechayHora, Usuario, AccesoCorrecto) " + "VALUES (#" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "#, '" + usuario + "', " + acceso + ")";
                    OleDbCommand cmd = new OleDbCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    error = ex.Message;
                }
            }
            public static void AuditarAccion(string usuario, string accion)
            {
                try
                {
                    string sql = "INSERT INTO AuditoriaInicioSesion (FechayHora, Usuario, Accion) " + "VALUES (#" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "#, '" + usuario + "', '" + accion + "')";
                    OleDbCommand cmd = new OleDbCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    error = ex.Message;
                }
            }
        }
    }
}
