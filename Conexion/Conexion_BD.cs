using System;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    public class Conexion_BD
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conexion = new SqlConnection(
                @"Data Source=DESKTOP-LQA6N6S\SQLEXPRESS;Initial Catalog=dbFactura;Integrated Security=True");

            try
            {
                conexion.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd, conexion);
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión con la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}