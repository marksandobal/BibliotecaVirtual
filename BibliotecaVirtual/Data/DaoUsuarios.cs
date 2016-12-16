﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BibliotecaVirtual.Data;

namespace BibliotecaVirtual.Data
{
    public class DaoUsuarios
    {
        //Cadena de Conexion... Escribe donde dice Arturo, Pon tu nombre, o PEPE como gustes.
        string ConnectionString = new Conextion().BiBliotecaVirtualConnectionString("Arturo");

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
    }
}