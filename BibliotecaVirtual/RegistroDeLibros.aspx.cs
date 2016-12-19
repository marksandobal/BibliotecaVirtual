using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Data;
using BibliotecaVirtual.BizConextions;

namespace BibliotecaVirtual
{
    public partial class RegistroDeLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFechaPublicacion.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try {

                if (!string.IsNullOrEmpty(txtTitulo.Text) && !string.IsNullOrEmpty(txtEdicion.Text) 
                    && !string.IsNullOrEmpty(txtAutor.Text) && !string.IsNullOrEmpty(txtEditorial.Text) 
                                                                && !string.IsNullOrEmpty(txtArea.Text))
                {
                    Libros libro = new Libros();

                    libro.Titulo = txtTitulo.Text;
                    libro.Edicion = txtEdicion.Text;
                    libro.Autor = txtAutor.Text;
                    libro.FechaPublicacion = Convert.ToDateTime(txtFechaPublicacion.Text);
                    libro.Editorial = txtEditorial.Text;
                    libro.Descripcion = txtArea.Text;
                    libro.TipoLibro = "De Prueba";
                    BizLibros bizLibros = new BizLibros();
                    bizLibros.InsertLibros(libro);
                    string script = String.Format(@"alert('El registro se ha guardado correctamente');");
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                }
                else
                {
                    string script = String.Format(@"alert('Existen uno o mas campos Vacios');");
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                }
            }
            catch (Exception ex)
            {
                //string script = String.Format(@"alert('{0}');", Util.GetExMessage(ex));
                //ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                //WebUtil.SendErrorLog(ex);
            }
        }
    }
}