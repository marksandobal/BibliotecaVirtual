using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;

namespace BibliotecaVirtual.Biz
{
    public class BizUsuarios
    {
        public List<Usuarios> GetUsuarios()
        {
            DaoUsuarios dao = new DaoUsuarios();
            DataTable dt = dao.GetUsuarios();

            List<Usuarios> userList = new List<Usuarios>();

            foreach (DataRow dr in dt.Rows)
            {
                Usuarios users = new Usuarios();

                users.UsuarioId = (int)dr["UsuarioId"];
                users.Nombre = (string)dr["Nombre"];
                users.Apellidos = (string)dr["Apellidos"];
                users.Edad = (int)dr["Edad"];
                users.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                users.Matricula = (string)dr["Matricula"];
                users.Direccion = (string)dr["Direccion"];
                users.Telefono = (string)dr["Telefono"];
                users.Activo = (bool)dr["Activo"];
                userList.Add(users);
            }

            return userList;
        }
    }
}