using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.BizConextions;

namespace BibliotecaVirtual
{
    public partial class Busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            if (!IsPostBack)
            {
                CargarddlCategoria();
                //SearchLibros(txtTitulo.Text,txtAutor.Text,null);
            }
        }//hacer
        protected void SearchLibros(string titulo, string autor, int? tipoLibroId)
        {
            List<Libros> list = new BizLibros().SearchLibros(titulo, autor, tipoLibroId);
            grvLibros.DataSource = list;
            grvLibros.DataBind();
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchLibros(txtTitulo.Text,txtAutor.Text, int.Parse(ddlCategoria.SelectedValue));
        }
        protected void CargarddlCategoria()
        {
            List<TipoLibros> list = new BizTipoLibros().GetClasificacion();

            ddlCategoria.DataSource = list;
            ddlCategoria.DataBind();
            //ddlCategoria.Items.Insert(0, new ListItem("Seleccione una clasificación"));
        }
        protected void lnkApartar_Click(object sender, EventArgs e)
        {
            int rowIndex = ((sender as LinkButton).Parent.Parent as GridViewRow).RowIndex;
            int libroId = (int)grvLibros.DataKeys[rowIndex]["LibroId"];

            Response.Redirect("ApartadoDeLibros.aspx?id=" + libroId);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            SearchLibros(txtTitulo.Text, txtAutor.Text, null);
        }
        protected void btnHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}