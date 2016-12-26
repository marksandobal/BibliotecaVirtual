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
            if (!IsPostBack)
            {
                hdTipoLibroId.Value = "0";
            }
            LoadGridTipoLibros();
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                int tipoLibroId = int.Parse(hdTipoLibroId.Value);
                if (!string.IsNullOrEmpty(txtClasificacion.Text))
                {
                    div1.Visible = false;

                    if (tipoLibroId > 0)
                    {
                        new BizTipoLibros().UpdateTipoLibros(tipoLibroId, txtClasificacion.Text);
                        div1.Visible = true;
                        lblError.Text = "El registro se ha guardado";
                        div1.Attributes.Add("Class", "alert alert-success");
                        btnGuardar.Text = "Agregar";
                    }
                    else
                    {
                        List<TipoLibros> list = new BizTipoLibros().GetClasificacion();
                        var existe = list.Where(a => a.Clasificacion == txtClasificacion.Text).ToList();
                        if (existe.Count > 0)
                        {
                            div1.Visible = true;
                            lblError.Text = "El registro que intenta insertar ya Existe";
                            div1.Attributes.Add("Class", "alert alert-warning");
                        }
                        else {
                            new BizTipoLibros().InsertTipoLibros(txtClasificacion.Text);
                            div1.Visible = true;
                            lblError.Text = "El registro se ha guardado";
                            div1.Attributes.Add("Class", "alert alert-success");
                        }


                    }                
                    //string script = String.Format(@"alert('Se ha guardado correctamente el Registro');");
                    //ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
                    LoadGridTipoLibros();
                    txtClasificacion.Text = string.Empty;
                    divclasificacion.Attributes.Remove("class");
                    
                }
                else {
                    div1.Visible = true;
                    lblError.Text = "El Campo Clasificación se encuentra Vacio.";
                    div1.Attributes.Add("Class", "alert alert-danger");
                    divclasificacion.Attributes.Add("class", "alert has-error");
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
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = ((sender as LinkButton).Parent.Parent as GridViewRow).RowIndex;
            int tipolibroId = (int)grvClasificacion.DataKeys[rowIndex]["TipoLibroId"];
            hdTipoLibroId.Value = tipolibroId.ToString();
            List<TipoLibros> list = new BizTipoLibros().GetClasificacion();

            var tipoLibro = list.Where(a => a.TipoLibroId == tipolibroId).FirstOrDefault();

            txtClasificacion.Text = tipoLibro.Clasificacion;
            btnGuardar.Text = "Actualizar";
        }

        protected void grvClasificacion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {//Elimina registros de la Tabla Libros
                int id = (int)grvClasificacion.DataKeys[e.RowIndex]["TipoLibroId"];//Obtengo el ID del registro para realizar la eliminacion por ID
                new BizTipoLibros().DeleteTipoLibros(id);
                div1.Visible = true;
                lblError.Text = "Se ha eliminado el Registro";
                div1.Attributes.Add("Class", "alert alert-success");
                LoadGridTipoLibros();
            }
            catch (Exception ex)
            {
                string script = String.Format(@"alert('{0}');", Util.GetExMessage(ex));
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtClasificacion.Text = string.Empty;
            divclasificacion.Attributes.Remove("Class");
            div1.Visible = false;
        }

    }
}