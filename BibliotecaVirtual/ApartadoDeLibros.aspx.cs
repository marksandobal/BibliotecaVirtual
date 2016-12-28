using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.BizConextions;
using BibliotecaVirtual.Biz;


namespace BibliotecaVirtual
{
    public partial class ApartadoDeLibros : System.Web.UI.Page
    {
        string libroId;
        string usuarioId;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioId = (string)Session["UsuarioId"];
            if (!IsPostBack)
            {
                CargarddlClasificacion();
                if (Request.QueryString.HasKeys())
                {
                    libroId = Request.QueryString["Id"];                                      
                }
                hdLibroId.Value = "0";
                CargaGridLibros();
                CargarCampos();
                txtNombre.Enabled = false;
                txtMatricula.Enabled = false;
                txtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
                divMessage.Visible = false;
                CargaGridHistorial();
            }
           
        }
        protected void CargarddlClasificacion()
        {
            List<TipoLibros> list = new BizTipoLibros().GetClasificacion();
            ddlClasificacion.DataSource = list;
            ddlClasificacion.DataBind();
            ddlClasificacion.Items.Insert(0, new ListItem("Seleccione una clasificación"));
        }
        protected void CargarCampos()
        {
            hdLibroId.Value = libroId;
            List<Usuarios> usuarios = new BizUsuarios().GetUsuarios();

            if (usuarioId != null)
            {
                var usuario = usuarios.Where(a => a.UsuarioId == int.Parse(usuarioId)).FirstOrDefault();
                txtNombre.Text = usuario.Nombre;
                txtMatricula.Text = usuario.Matricula;
                txtTelefono.Text = usuario.Telefono;
                txtDireccion.Text = usuario.Direccion;
            }
            List<Libros> list = new BizLibros().GetLibros();
            if (libroId != null)
            {
                var libro = list.Where(a => a.LibroId == int.Parse(libroId)).FirstOrDefault();
                txtTitulo.Text = libro.Titulo;
                txtAutor.Text = libro.Autor;
                ddlClasificacion.SelectedValue = libro.TipoLibroId.ToString();
            }
        }
        protected void CargaGridLibros()
        {
            if (usuarioId != null)
            {
                List<ApartadoDeLibrosAuxView> list = new BizApartadoDeLibros().ApartadoDeLibrosGetByUsuarioId(int.Parse(usuarioId));
                grvLibros.DataSource = list;
                grvLibros.DataBind();
            }
        }
        protected void CargaGridHistorial()
        {
            if (usuarioId != null)
            {
                List<PrestamosAuxView> list = new BizPrestamos().GetPrestamos(int.Parse(usuarioId));
                grvHistorial.DataSource = list;
                grvHistorial.DataBind();
            }
        }
        protected void btnBusqueda_Click(object sender, EventArgs e)
        {
            Response.Redirect("Busqueda.aspx");
        }
        protected void grvLibros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {//Elimina registros de la Tabla Libros

                int libroId = (int)grvLibros.DataKeys[e.RowIndex]["LibroId"];
                new BizApartadoDeLibros().DeleteApartadoDeLibros(libroId, int.Parse(usuarioId));
                divMessage.Visible = true;
                lblMessage.Text = "Se ha quitado de la lista el Registro";
                divMessage.Attributes.Add("Class", "alert alert-success");
                CargaGridLibros();
            }
            catch (Exception ex)
            {
                string script = String.Format(@"alert('{0}');", Util.GetExMessage(ex));
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int libroId = Convert.ToInt32(hdLibroId.Value);
            bool vacio = validacion();
            if (vacio == false)
            {
                List<ApartadoDeLibrosAuxView> list = new BizApartadoDeLibros().ApartadoDeLibrosGetByUsuarioId(int.Parse(usuarioId));
                var existe = list.Where(a => a.LibroId == libroId).ToList();
                if (existe.Count > 0)
                {
                    divMessage.Visible = true;
                    lblMessage.Text = "El registro que intenta insertar ya Existe";
                    divMessage.Attributes.Add("Class", "alert alert-warning");
                }
                else
                {
                    new BizApartadoDeLibros().InsertApartadoDeLibros(libroId, int.Parse(usuarioId));
                    divMessage.Visible = true;
                    lblMessage.Text = "Se ha Guardado el Registro";
                    divMessage.Attributes.Add("Class", "alert alert-success");
                    CargaGridLibros();

                }

            }
            else
            {
                divMessage.Visible = true;
                lblMessage.Text = "Existen Campos Vacios";
                divMessage.Attributes.Add("Class", "alert alert-danger");
            }
        }
        private bool validacion()
        {
            bool vacio = false;
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                divTitulo.Attributes.Add("Class", "alert has-error");
                vacio = true;
            }
            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                divAutor.Attributes.Add("Class", "alert has-error");
                vacio = true;
            }
            return vacio;
        }
        protected void btnHistorial_Click(object sender, EventArgs e)
        {
            //UpHistorial.Update();
            //mpeHistorial.Show();
        }
    }
}