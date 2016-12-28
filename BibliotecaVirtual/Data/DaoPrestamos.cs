using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using BibliotecaVirtual.Model;
using System.Data.SqlClient;

namespace BibliotecaVirtual.Data
{
    public class DaoPrestamos
    {
        string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString();
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
    }
}