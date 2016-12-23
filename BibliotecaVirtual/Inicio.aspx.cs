using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaVirtual
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuarioId = (string)Session["UsuarioId"];
            if (!IsPostBack)
            {
                if (usuarioId == "" || usuarioId == null)
                    Response.Redirect("~/Session.aspx");
            }
        }

        protected void btnCloseSession_Click(object sender, EventArgs e)
        {
            Session["UsuarioId"] = null;
            Response.Redirect("~/Session.aspx");
        }
    }
}