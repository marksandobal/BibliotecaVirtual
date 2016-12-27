using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Model;
using BibliotecaVirtual.Biz;

namespace BibliotecaVirtual
{
    public partial class RegistroDeUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

            }
            CargaGridUsuarios();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios list = new Usuarios();

            list.Nombre = txtName.Text;
            list.Apellidos = txtSurname.Text;
            list.Matricula = txtEnrollment.Text;
            list.Direccion = txtAddress.Text;
            list.Edad = Convert.ToInt32(txtAge.Text);
            list.Telefono = txtPhone.Text;
            list.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            list.Activo = chkActive.Checked;

            BizUsuarios bizUsuaios = new BizUsuarios();
            bizUsuaios.InsertUsuarios(list);
            
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuarios list = new Usuarios();

            list.Nombre = txtName.Text;
            list.Apellidos = txtSurname.Text;
            list.Matricula = txtEnrollment.Text;
            list.Direccion = txtAddress.Text;
            list.Edad = Convert.ToInt32(txtAge.Text);
            list.Telefono = txtPhone.Text;
            list.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            list.Activo = chkActive.Checked;

            BizUsuarios bizUsuarios = new BizUsuarios();
            bizUsuarios.UpdateUsuarios(list);
        }
        //carga de usuarios
        protected void CargaGridUsuarios()
        {
            List<Usuarios> listUsuarios = new BizUsuarios().GetUsuarios();
            //grvUsuarios_RowDeleting
            grvUsuarios.DataSource = listUsuarios;
            grvUsuarios.DataBind();

        }
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = ((sender as LinkButton).Parent.Parent as GridViewRow).RowIndex;
            int usuariosId = (int)grvUsuarios.DataKeys[rowIndex]["UsuarioId"];
            List<Usuarios> list = new BizUsuarios().GetUsuarios();
            var usuario = list.Where(a => a.UsuarioId == usuariosId).FirstOrDefault();
            //asignar valores a controles
            txtName.Text = usuario.Nombre;
            txtSurname.Text = usuario.Apellidos;
            txtAge.Text = usuario.Edad.ToString();
            txtAddress.Text = usuario.Direccion;
            txtEnrollment.Text = usuario.Matricula;
            txtFechaNacimiento.Text = usuario.FechaNacimiento.ToString("yyyy-MM-dd");
            txtPhone.Text = usuario.Telefono;
            chkActive.Checked = usuario.Activo;
        }

        protected void grvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        //validacion de campos que no esten vacios
        protected bool ValidacionCampos()
        {
            bool vacio = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                divNombre.Attributes.Add("class", "has-error");
                vacio = true;
            }
            else
            {
                divNombre.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                divApellido.Attributes.Add("class", "has-error");
                vacio = true;
            }
            else
            {
                divApellido.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtEnrollment.Text))
            {
                divMatricula.Attributes.Add("class", "has-error");
                vacio = true;
            }
            else
            {
                divMatricula.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                divDireccion.Attributes.Add("class", "has-error");
                vacio = true;
            }
            else
            {
                divDireccion.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                divTelefono.Attributes.Add("class", "has-error");
                vacio = true;
            }
            else
            {
                divTelefono.Attributes.Remove("class");
            }
            if (string.IsNullOrEmpty(txtFechaNacimiento.Text))
            {
                divFechaNacimiento.Attributes.Add("class", "has-error");
                vacio = true;
            }
            else
            {
                divFechaNacimiento.Attributes.Remove("class");
            }
            return vacio;
        }
    }
}