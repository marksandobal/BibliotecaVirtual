using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BibliotecaVirtual.Data;
using BibliotecaVirtual.Model;
namespace BibliotecaVirtual.Data
{
    public class DaoUsuarios
    {
        //Cadena de Conexion... Escribe donde dice Arturo, Pon tu nombre, o PEPE como gustes.
        string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString("Pepe");

        public DataTable GetUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Usuarios_GetUsers", conn))
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

        public DataTable InsertUsuarios(Usuarios usuario)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Usuarios_Insert", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Nombre", usuario.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@Apellidos", usuario.Apellidos));
                        cmd.Parameters.Add(new SqlParameter("@Edad", usuario.Edad));
                        cmd.Parameters.Add(new SqlParameter("@FechaDeNacimiento", usuario.FechaNacimiento));
                        cmd.Parameters.Add(new SqlParameter("@Matricula", usuario.Matricula));
                        cmd.Parameters.Add(new SqlParameter("@Direccion", usuario.Direccion));
                        cmd.Parameters.Add(new SqlParameter("@Telefono", usuario.Telefono));
                        cmd.Parameters.Add(new SqlParameter("@Activo", usuario.Activo));
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