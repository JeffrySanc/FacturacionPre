using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Conexion
{
    /// <summary>
    /// Capa única de acceso a datos. Todas las consultas del sistema deben pasar por aquí,
    /// siempre con parámetros (@nombre) para evitar inyección SQL.
    /// </summary>
    public static class Conexion_BD
    {
        private static string CadenaConexion
        {
            get
            {
                ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["ConexionBD"];
                if (cs == null || string.IsNullOrWhiteSpace(cs.ConnectionString))
                    throw new InvalidOperationException(
                        "No se encontró la cadena de conexión 'ConexionBD' en el archivo de configuración.");
                return cs.ConnectionString;
            }
        }

        private static SqlConnection Abrir()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            return conexion;
        }

        private static void CargarParametros(SqlCommand comando, SqlParameter[] parametros)
        {
            if (parametros != null && parametros.Length > 0)
                comando.Parameters.AddRange(parametros);
        }

        /// <summary>Ejecuta una consulta SELECT y devuelve el resultado en un DataSet.</summary>
        public static DataSet Ejecutar(string sql, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection conexion = Abrir())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    CargarParametros(comando, parametros);
                    DataSet ds = new DataSet();
                    adaptador.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión con la base de datos: " + ex.Message, ex);
            }
        }

        /// <summary>Ejecuta INSERT/UPDATE/DELETE y devuelve la cantidad de filas afectadas.</summary>
        public static int EjecutarComando(string sql, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection conexion = Abrir())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    CargarParametros(comando, parametros);
                    return comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la operación en la base de datos: " + ex.Message, ex);
            }
        }

        /// <summary>Ejecuta una consulta que devuelve un único valor (ej. SCOPE_IDENTITY, MAX, COUNT).</summary>
        public static object EjecutarEscalar(string sql, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlConnection conexion = Abrir())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    CargarParametros(comando, parametros);
                    return comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta en la base de datos: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Ejecuta varias operaciones dentro de una misma transacción: si alguna falla,
        /// se revierte todo (nada queda guardado a medias).
        /// Cada función recibe el SqlCommand listo para asignarle CommandText/parámetros.
        /// El resultado devuelto corresponde a la última operación.
        /// </summary>
        public static object EjecutarEnTransaccion(Func<SqlCommand, object>[] operaciones)
        {
            if (operaciones == null || operaciones.Length == 0)
                return null;

            try
            {
                using (SqlConnection conexion = Abrir())
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        object resultado = null;
                        foreach (Func<SqlCommand, object> operacion in operaciones)
                        {
                            using (SqlCommand comando = conexion.CreateCommand())
                            {
                                comando.Transaction = transaccion;
                                resultado = operacion(comando);
                            }
                        }
                        transaccion.Commit();
                        return resultado;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        throw new Exception("La operación fue cancelada y no se guardó nada: " + ex.Message, ex);
                    }
                }
            }
            catch (Exception ex) when (!(ex is InvalidOperationException))
            {
                throw new Exception("Error de conexión con la base de datos: " + ex.Message, ex);
            }
        }
    }

    /// <summary>Utilidades de seguridad (hash de contraseñas).</summary>
    public static class Seguridad
    {
        /// <summary>Devuelve el hash SHA256 en hexadecimal del texto recibido.</summary>
        public static string HashSHA256(string texto)
        {
            using (System.Security.Cryptography.SHA256 sha =
                System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(texto ?? string.Empty));
                StringBuilder sb = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
