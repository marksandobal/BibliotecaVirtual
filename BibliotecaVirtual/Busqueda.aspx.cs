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
        string usuarioId;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioId = (string)Session["UsuarioId"];          
            if (!IsPostBack)
            {
                CargarddlCategoria();
                SearchLibros(txtTitulo.Text,txtAutor.Text,null);
            }
        }//hacer
        protected void SearchLibros(string titulo, string autor, int? tipoLibroId)
        {
            List<Libros> list = new BizLibros().SearchLibros(titulo, autor, tipoLibroId);
            grvLibros.DataSource = list;
            grvLibros.DataBind();

            foreach (GridViewRow rw in grvLibros.Rows)
            {
                string status = (string)grvLibros.DataKeys[rw.RowIndex]["Estado"];
                LinkButton btn = (rw.FindControl("lnkApartar") as LinkButton);

                if (status == "Disponible")
                {
                    btn.Attributes.Add("Class", "btn btn-success");
                    btn.Text = "Prestar";
                }
                else {
                    btn.Attributes.Add("Class", "btn btn-warning");
                    btn.Text = "Apartar";
                }

            }

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
            string status = (string)grvLibros.DataKeys[rowIndex]["Estado"];

            if (status == "Disponible")
            {
                Response.Redirect("Prestamos.aspx?id=" + libroId);
            }
            else {
                Response.Redirect("ApartadoDeLibros.aspx?id=" + libroId);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            SearchLibros(txtTitulo.Text, txtAutor.Text, null);
        }
        protected void grvLibros_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.Cells[7].Text == "En Prestamo")
            {
                e.Row.Cells[7].Attributes.Add("Class", "text-warning");
                e.Row.Cells[7].Font.Bold = true;
                //e.Row.Cells[7].BackColor = System.Drawing.Color.FromName("#f0ad4e");
            }
            else if(e.Row.Cells[7].Text == "Disponible")
            {
                e.Row.Cells[7].Attributes.Add("Class", "text-success");
                e.Row.Cells[7].Font.Bold = true;
            }
        }
    }
}