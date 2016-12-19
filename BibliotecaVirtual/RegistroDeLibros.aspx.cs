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
                bool validacion = false;
                validacion = ValidacionDeCampos();
                if (validacion == false)
                {
                    divError.Visible = false;
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

                    txtTitulo.Text = string.Empty;
                    txtEdicion.Text = string.Empty;
                    txtAutor.Text = string.Empty;
                    txtFechaPublicacion.Text = DateTime.Today.ToString("yyyy-MM-dd");
                    txtEditorial.Text = string.Empty;
                    txtArea.Text = string.Empty;
                    

                    divTitulo.Attributes.Remove("class");
                    divEdicion.Attributes.Remove("class");
                    divAutor.Attributes.Remove("class");
                    divEditorial.Attributes.Remove("class");
                    divDescripcion.Attributes.Remove("class");

                }
                else
                {
                    divError.Visible = true;
                    lblError.Text = "Algunos de los campos se encuentra vacio";
                    divError.Attributes.Add("Class", "alert-danger");
                    //divTitulo.Attributes.Add("Class", "has-error");
                    //divEdicion.Attributes.Add("Class", "has-error");
                    //divAutor.Attributes.Add("Class", "has-error");
                    //divEditorial.Attributes.Add("Class", "has-error");
                    //divDescripcion.Attributes.Add("Class", "has-error");
                }
            }
            catch (Exception ex)
            {
                string script = String.Format(@"alert('{0}');", Util.GetExMessage(ex));
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                //WebUtil.SendErrorLog(ex);
            }
        }

        protected bool ValidacionDeCampos()
        {
            bool vacio = false;
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                divTitulo.Attributes.Add("Class", "has-error");
                vacio = true;
                return vacio;
            }
            if (string.IsNullOrEmpty(txtEdicion.Text))
            {
                divEdicion.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                divAutor.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            if (string.IsNullOrEmpty(txtEditorial.Text))
            {
                divEditorial.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            if (string.IsNullOrEmpty(txtArea.Text))
            {
                divDescripcion.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            return vacio;
        }
    }
}