using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Biz;
using System.Net;
using System.Net.NetworkInformation;

namespace BibliotecaVirtual
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = this.txtUsuario.Text.Replace(";", "").Replace("--", "");
            string password = this.txtContraseña.Text.Replace(";", "").Replace("--", "");

           List<Usuarios> usuario = new BizUsuarios().AutenticacionUsuario(user, password);
            if (usuario.Count > 0)
            {
                if (usuario[0].Activo == true)
                {
                    Session["UsuarioId"] = usuario[0].UsuarioId.ToString();

                    IPHostEntry host;
                    string localIP = "";
                    host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily.ToString() == "InterNetwork")
                        {
                            localIP = ip.ToString();
                        }
                    }

                    new BizUsuarios().InsertLoginLog(usuario[0].UsuarioId, localIP);
                    Response.Redirect("~/Inicio.aspx");
                }
                else {
                    lblError.Text = "El Usuario con el que intenta Ingresar, se encuentra inactivo";
                }
            }
            else {
                lblError.Text = "Usuario o Contraseña incorrecta.";
            }
          
        }
    }
}