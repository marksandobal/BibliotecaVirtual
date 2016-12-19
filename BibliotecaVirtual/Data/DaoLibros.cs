using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BibliotecaVirtual.Model;

namespace BibliotecaVirtual.Data
{
    public class DaoLibros
    {
        string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString("Arturo");

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
                        cmd.Parameters.Add(new SqlParameter("@TipoLibro", libros.TipoLibro));
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