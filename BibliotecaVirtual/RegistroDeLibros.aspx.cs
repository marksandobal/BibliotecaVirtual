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
            string usuarioId = (string)Session["UsuarioId"];

            if (!IsPostBack)
            {   //======== Validacion de Sesión Activa =========
                if (usuarioId == "" || usuarioId == null)
                    Response.Redirect("~/Session.aspx");
                //======== Validacion de Sesión Activa =========

                txtFechaPublicacion.Text = DateTime.Today.ToString("yyyy-MM-dd");
                LoadGridLibros();
                LoadDDlClasificacion();
                if (grvLibros.SelectedIndex <= 0)
                {
                    LimpiarCampos();
                }
            }
            hdLibroId.Value = "0";
        }
        //Limpia los campos del formulario
        protected void LimpiarCampos()
        {
            txtTitulo.Text = string.Empty;
            txtEdicion.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtFechaPublicacion.Text = DateTime.Today.ToString("yyyy-MM-dd");
            txtEditorial.Text = string.Empty;
            txtArea.Text = string.Empty;
        }
        //Realiza la carga de Datos en el GridView
        protected void LoadGridLibros()
        {
            List<Libros> list = new BizLibros().GetLibros();
            grvLibros.DataSource = list;
            grvLibros.DataBind();
        }
        //Realiza la Carga de Datos en el DropDownList
        protected void LoadDDlClasificacion()
        {
            List<TipoLibros> list = new BizTipoLibros().GetClasificacion();
            ddlClasificación.DataSource = list;
            ddlClasificación.DataBind();
            ddlClasificación.Items.Insert(0, new ListItem("Seleccione una clasificación"));
        }
        //Guarda los datos en la Tabla Libros
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                bool validacion = ValidacionDeCampos();
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
                    libro.TipoLibroId = int.Parse(ddlClasificación.SelectedValue);
                    BizLibros bizLibros = new BizLibros();

                    List<Libros> list = new BizLibros().GetLibros();
                    var existe = list.Where(a => a.Titulo == libro.Titulo && a.Autor == libro.Autor && a.Edicion == libro.Edicion && a.Editorial == libro.Editorial && a.Clasificacion == Convert.ToString(ddlClasificación.SelectedItem)).ToList();
                    if (existe.Count > 0)
                    {
                        string script = String.Format(@"alert('El registro que intenta guardar ya existe');");
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                    }
                    else
                    {
                        //Si el HidenField tiene un valor, entonces el registro existe, por lo tanto lo actualiza           
                        if (int.Parse(hdLibroId.Value) > 0)
                        {
                            libro.LibroId = int.Parse(hdLibroId.Value);
                            bizLibros.UpdateLibros(libro);
                        }
                        else
                        {
                            bizLibros.InsertLibros(libro);
                        }
                        string script = String.Format(@"alert('El registro se ha guardado correctamente');");
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                        LimpiarCampos();
                        LoadGridLibros();
                    }
                }
                else
                {
                    divError.Visible = true;
                    lblError.Text = "Algunos de los campos se encuentra vacio";
                    divError.Attributes.Add("Class", "alert-danger");
                }
            }
            catch (Exception ex)
            {
                string script = String.Format(@"alert('{0}');", Util.GetExMessage(ex));
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                //WebUtil.SendErrorLog(ex);
            }
        }
        protected void grvLibros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {//Elimina registros de la Tabla Libros
                int id = (int)grvLibros.DataKeys[e.RowIndex]["LibroId"];//Obtengo el ID del registro para realizar la eliminacion por ID
                new BizLibros().DeleteLibros(id);
                LoadGridLibros();
            }
            catch (Exception ex)
            {
                string script = String.Format(@"alert('{0}');", Util.GetExMessage(ex));
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
            }
        }
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = ((sender as LinkButton).Parent.Parent as GridViewRow).RowIndex;
            int libroId = (int)grvLibros.DataKeys[rowIndex]["LibroId"];//Obtengo el ID del Registro y filtro para mostrar los datos en la vista
            hdLibroId.Value = Convert.ToString(libroId);
            List<Libros> list = new BizLibros().GetLibros();
            var libro = list.Where(a => a.LibroId == libroId).FirstOrDefault();//Linq Básico, filtra los registros por ID
            //Asigno valores a los controles
            txtTitulo.Text = libro.Titulo;
            txtEdicion.Text = libro.Edicion;
            txtAutor.Text = libro.Autor;
            txtFechaPublicacion.Text = libro.FechaPublicacion.ToString("yyyy-MM-dd");
            txtEditorial.Text = libro.Editorial;
            ddlClasificación.SelectedValue = Convert.ToString(libro.TipoLibroId);
            txtArea.Text = libro.Descripcion;
        }
        //Valida que los campos no esten vacios
        protected bool ValidacionDeCampos()
        {
            bool vacio = false;
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                divTitulo.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            else {
                divTitulo.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtEdicion.Text))
            {
                divEdicion.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            else {
                divEdicion.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                divAutor.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            else {
                divAutor.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtEditorial.Text))
            {
                divEditorial.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            else {
                divEditorial.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtArea.Text))
            {
                divDescripcion.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            else {
                divDescripcion.Attributes.Remove("class");
            }

            if (ddlClasificación.SelectedIndex == 0)
            {
                divddlClasificacion.Attributes.Add("Class", "has-error");
                vacio = true;
            }
            else
            {
                divddlClasificacion.Attributes.Remove("class");
            }
            return vacio;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            divError.Visible = false;
            divTitulo.Attributes.Remove("class");
            divEdicion.Attributes.Remove("class");
            divAutor.Attributes.Remove("class");
            divEditorial.Attributes.Remove("class");
            divDescripcion.Attributes.Remove("class");
        }
    }
}