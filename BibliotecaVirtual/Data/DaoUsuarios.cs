using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BibliotecaVirtual.Data;
using BibliotecaVirtual.Model;
using System.Configuration;

namespace BibliotecaVirtual.Data
{
    public class DaoUsuarios
    {    //Conexión SQL
        //string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString();
        string ConnectionString = ConfigurationManager.ConnectionStrings["Arturo"].ConnectionString;
        //Metodo Get
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
        public DataTable AutenticacionUsuario(string usuario, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Usuarios_Authenticate", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@NombreUsuario", usuario));
                        cmd.Parameters.Add(new SqlParameter("@Password", password));
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
        public DataTable LogLoginUsuario(int usuarioId, string ip)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_LoginLog_Insert", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@UsuarioId", usuarioId));
                        cmd.Parameters.Add(new SqlParameter("@Ip", ip));
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
        //Método Insert
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
                        cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", usuario.FechaNacimiento));
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
        public DataTable UpdateUsuarios(Usuarios usuario)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Usuarios_Update", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //parametros del sql
                        cmd.Parameters.Add(new SqlParameter("@UsuarioId", usuario.UsuarioId));
                        cmd.Parameters.Add(new SqlParameter("@Nombre", usuario.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@Apellidos", usuario.Apellidos));
                        cmd.Parameters.Add(new SqlParameter("@Edad", usuario.Edad));
                        cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", usuario.FechaNacimiento));
                        cmd.Parameters.Add(new SqlParameter("@Matricula", usuario.Matricula));
                        cmd.Parameters.Add(new SqlParameter("@Direccion", usuario.Direccion));
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

        public DataTable DeleteUsuarios(int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Usuarios_Delete", conn))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //parametros de sql
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