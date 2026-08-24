using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
   public class Conexion_BD
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
