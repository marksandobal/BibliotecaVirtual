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
        string id;
        string usuarioId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarddlClasificacion();
                if (Request.QueryString.HasKeys())
                {
                     id = Request.QueryString["Id"];
                    usuarioId = Session["UsuarioId"].ToString();
                    CargarCampos();
                    
                }           
                
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
            List<Usuarios> usuarios = new BizUsuarios().GetUsuarios();
            var usuario = usuarios.Where(a => a.UsuarioId == int.Parse(usuarioId)).FirstOrDefault();

            txtNombre.Text = usuario.Nombre;
            txtMatricula.Text = usuario.Matricula;
            txtTelefono.Text = usuario.Telefono;
            txtDireccion.Text = usuario.Direccion;

            List<Libros> list = new BizLibros().GetLibros();
            var libro = list.Where(a => a.LibroId == int.Parse(id)).FirstOrDefault();

            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            ddlClasificacion.SelectedValue = libro.TipoLibroId.ToString();
        }
        protected void CargarGridLibros()
        {
            
        }
    }
}