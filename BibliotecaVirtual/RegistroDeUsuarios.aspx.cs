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
    }
}