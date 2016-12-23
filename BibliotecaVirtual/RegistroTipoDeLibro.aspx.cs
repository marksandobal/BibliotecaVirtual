using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using BibliotecaVirtual.BizConextions;
    using System.Data;

namespace BibliotecaVirtual
{
    public partial class RegistroTipoDeLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuarioId = (string)Session["UsuarioId"];
            if (!IsPostBack)
            {
                if (usuarioId == "" || usuarioId == null)
                    Response.Redirect("~/Session.aspx");
            }
            LoadGridTipoLibros();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                if (!string.IsNullOrEmpty(txtClasificacion.Text))
                {
                    div1.Visible = false;
                    
                    new BizTipoLibros().InsertTipoLibros(txtClasificacion.Text);
                    string script = String.Format(@"alert('Se ha guardado correctamente el Registro');");
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                    LoadGridTipoLibros();
                    txtClasificacion.Text = string.Empty;
                    divclasificacion.Attributes.Remove("class");
                    
                }
                else {
                    div1.Visible = true;
                    lblError.Text = "El Campo Clasificación se encuentra Vacio.";
                    div1.Attributes.Add("Class", "alert-danger");
                    divclasificacion.Attributes.Add("class", "has-error");
                }
            }
            catch (Exception ex) {
                string script = String.Format(@"alert('{0}');", Util.GetExMessage(ex));
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
            }
        }

        protected void LoadGridTipoLibros()
        {
            List<TipoLibros> list = new BizTipoLibros().GetClasificacion();
            grvClasificacion.DataSource = list;
            grvClasificacion.DataBind();
        }
    }
}