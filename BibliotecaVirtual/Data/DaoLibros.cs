using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;
using System.Configuration;

namespace BibliotecaVirtual.Data
{
    public class DaoLibros
    {//hacre en prestamos
        string ConnectionString = ConfigurationManager.ConnectionStrings["Arturo"].ConnectionString;
        //string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString();
        public DataTable SearchLibros(string titulo,string autor,int? tipoLibroId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Libros_Search", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Titulo", titulo));
                        cmd.Parameters.Add(new SqlParameter("@Autor", autor));
                        cmd.Parameters.Add(new SqlParameter("@TipoLibroId",tipoLibroId));
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
                    using (SqlCommand cmd = new SqlCommand("sp_Libros_Get", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        // cmd.Parameters.Add(new SqlParameter("@Titulo", libros.Titulo));
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
        public DataTable InsertLibros(Libros libros)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Libros_insert", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Titulo", libros.Titulo));
                        cmd.Parameters.Add(new SqlParameter("@Autor", libros.Autor));
                        cmd.Parameters.Add(new SqlParameter("@Edicion", libros.Edicion));
                        cmd.Parameters.Add(new SqlParameter("@Editorial", libros.Editorial));
                        cmd.Parameters.Add(new SqlParameter("@FechaPublicacion", libros.FechaPublicacion));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion", libros.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@TipoLibroId", libros.TipoLibroId));
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
        public DataTable UpdateLibros(Libros libros)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Libros_Update", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@LibroId", libros.LibroId));
                        cmd.Parameters.Add(new SqlParameter("@Titulo", libros.Titulo));
                        cmd.Parameters.Add(new SqlParameter("@Autor", libros.Autor));
                        cmd.Parameters.Add(new SqlParameter("@Edicion", libros.Edicion));
                        cmd.Parameters.Add(new SqlParameter("@Editorial", libros.Editorial));
                        cmd.Parameters.Add(new SqlParameter("@FechaPublicacion", libros.FechaPublicacion));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion", libros.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@TipoLibroId", libros.TipoLibroId));
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

        public DataTable DeleteLibros(int libroId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Libros_Delete", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@LibroId", libroId));
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