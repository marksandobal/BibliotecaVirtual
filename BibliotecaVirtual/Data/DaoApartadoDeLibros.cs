using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaVirtual.Data
{
    public class DaoApartadoDeLibros
    {
        string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString();
        public DataTable ApartadoDeLibrosGetByUserId(int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ApartadoDeLibros_Get", conn))
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
        public DataTable InsertApartadoDeLibros(int libroId, int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ApartadoDeLibros_Insert", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@LibroId", libroId));
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
        public DataTable DeleteApartadoDeLibros(int libroId,int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ApartadoDeLibros_Delete", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@LibroId", libroId));
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
    }
}