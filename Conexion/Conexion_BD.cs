using System;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    public static class Conexion_BD
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-P3T7POF; Initial Catalog = dbFactura; Integrated Security = True");
            conexion.Open();
            DataSet Ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, conexion);
            DA.Fill(Ds);
            conexion.Close();
            return Ds;
        }
    }
}
