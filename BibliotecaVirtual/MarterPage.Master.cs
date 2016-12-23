using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaVirtual
{
    public partial class MarterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCloseSession_Click(object sender, EventArgs e)
        {
            Session["UsuarioId"] = null;
            Response.Redirect("~/Session.aspx");
        }
    }
}