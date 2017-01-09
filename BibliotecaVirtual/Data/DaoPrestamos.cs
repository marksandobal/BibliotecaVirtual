using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using BibliotecaVirtual.Model;
using System.Data.SqlClient;
using System.Configuration;

namespace BibliotecaVirtual.Data
{
    public class DaoPrestamos
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Arturo"].ConnectionString;
        //string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString();
        public DataTable SearchLibros(string titulo, string autor, int? tipoLibroId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand cmd = new SqlCommand("sp_Libros_Search", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Titulo", titulo));
                        cmd.Parameters.Add(new SqlParameter("@autor", autor));
                        cmd.Parameters.Add(new SqlParameter(@"TipoLibroId", tipoLibroId));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public DataTable GetLibros()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand cmd = new SqlCommand("sp_Libros_Get", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
                catch( Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Obtengo los datos de la Tabla Prestamos con el sp "sp_Prestamos_Get" por medio del usuario
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <returns></returns>
        public DataTable GetPrestamos(int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Prestamos_Get", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@UsuarioId", usuarioId));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public DataTable GenerateReport(DateTime fechaInicio, DateTime fechaFinal, bool porFechaPrestamo)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Prestamos_Report", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@FechaInicio", fechaInicio));
                        cmd.Parameters.Add(new SqlParameter("@FechaTermino", fechaFinal));
                        cmd.Parameters.Add(new SqlParameter("@FechaPrestamo", porFechaPrestamo));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}