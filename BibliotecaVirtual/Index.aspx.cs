using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using BibliotecaVirtual.Biz;
namespace BibliotecaVirtual
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Usuarios> userList = new List<Usuarios>();
            userList = new BizUsuarios().GetUsuarios();
            grvUsers.DataSource = userList;
            grvUsers.DataBind();
            
        }
    }
}