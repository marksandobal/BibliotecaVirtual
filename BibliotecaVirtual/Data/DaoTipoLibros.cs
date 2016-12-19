using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Data
{
    public class DaoTipoLibros
    {
        string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString("Arturo");

        public DataTable GetClasificacionDeLibros()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_TipoLibros_Get", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.Add(new SqlParameter("@palletId", palletId));
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
        public DataTable InsertTipoLibros(string clasificacion)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_TipoLibros_Insert", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Clasificacion", clasificacion));
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