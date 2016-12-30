using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Biz;
using BibliotecaVirtual.BizConextions;



namespace BibliotecaVirtual
{
    public partial class Prestamos : System.Web.UI.Page
    {
        string libroId;
        string UsuarioId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            PrestamosAuxView list = new PrestamosAuxView();

            list.Titulo = txtTitulo.Text;
            list.Autor = txtAutor.Text;
            list.Clasificacion = txtCategoria.Text;
            //tengo problemas con bizprestamos no pude terminarlo
            BizPrestamos bizPrestamos = new BizPrestamos();
            //BizPrestamos.
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        protected void CargaGridUsuarios()
        {
           // List<Prestamos> listLibros = new  BizPrestamos()
           if(UsuarioId != null)
            {
               // List<PrestamosAuxView> list = new BizPrestamos().GetPrestamos();
               

            }
        }
    }
}