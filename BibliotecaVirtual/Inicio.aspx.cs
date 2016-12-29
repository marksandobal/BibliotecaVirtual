using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaVirtual
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuarioId = (string)Session["UsuarioId"];
            string rolId = (string)Session["RolId"];
            if (!IsPostBack)
            {
                if (usuarioId == "" || usuarioId == null)
                    Response.Redirect("~/Session.aspx");

                liMenuRegistros.Visible = false;
                liMenuServicios.Visible = false;
                MenuRol(rolId);
            }
        }

        protected void MenuRol(string rolId)
        {
            switch (rolId)
            {
                case "1":
                    liMenuRegistros.Visible = true;
                    liMenuServicios.Visible = true;
                    break;
                case "2":
                    liMenuRegistros.Visible = true;
                    break;
                case "3":
                    liMenuServicios.Visible = true;
                    break;
            }
        }
        //protected void MenuAdmin()
        //{
        //    string menu = string.Format(@"
        //                                <nav class='nav'>
        //                                    <ul data-type ='navbar' class='sf-menu'>
        //                                    <li><a href ='Inicio.aspx'>Inicio</a>
        //                                    </li>
        //                                    <li><a href=''>Registros</a>
        //                                        <ul>
        //                                        <li><a href = 'RegistroDeLibros.aspx'> Registro De Libros</a></li>
        //                                        <li><a href = 'RegistroDeUsuarios.aspx'> Registro De Usuarios</a></li>
        //                                        <li><a href = 'RegistroTipoDeLibro.aspx'> Registro Clasificación Libros</a></li>
        //                                        </ul>
        //                                    </li>
        //                                    <li><a href = ''>Serviciós</a>
        //                                        <ul>
        //                                            <li><a href= 'ApartadoDeLibros.aspx'> Apartado de Libros</a></li>
        //                                            <li><a href = 'Busqueda.aspx'> Busqueda de Libros</a></li>
        //                                            <li><a href = 'Prestamos.aspx'> Prestamos de Libros</a></li>
        //                                        </ul>
        //                                    </li>
        //                                    <li><a href = '' > Acerca De</a>
        //                                        <ul>
        //                                        <li><a href = '#' > Lorem ipsum dolor</a></li>
        //                                        <li><a href = '#' > Conse ctetur adipisicing</a></li>
        //                                        <li><a href = '#' > Elit sed do eiusmod
        //                                            <ul>
        //                                            <li><a href = '#' > Lorem ipsum</a></li>
        //                                            <li><a href = '#' > Conse adipisicing</a></li>
        //                                            <li><a href = '#' > Sit amet dolore</a></li>
        //                                            </ul></a>
        //                                        </li>
        //                                        <li><a href = '#' > Incididunt ut labore</a></li>
        //                                        <li><a href = '#' > Et dolore magna</a></li>
        //                                        <li><a href = '#' > Ut enim ad minim</a></li>
        //                                        </ul>
        //                                    </li>
        //                                    <li><a href = '' > Contactos </ a >
        //                                    </li>
        //                                    </ul>   
        //                                </nav>            
        //                             ");
        //    this.ltMenu.Text = menu;
        //}
        //protected void MenuDocente()
        //{
        //    string menu = string.Format(@"
        //                                <nav class='nav'>
        //                                  <ul data-type ='navbar' class='sf-menu'>
        //                                    <li><a href ='Inicio.aspx'>Inicio</a>
        //                                    </li>
        //                                    <li><a href='index-2.html'>Registros</a>
        //                                      <ul>
        //                                        <li><a href = 'RegistroDeLibros.aspx'> Registro De Libros</a></li>
        //                                        <li><a href = 'RegistroDeUsuarios.aspx'> Registro De Usuarios</a></li>
        //                                        <li><a href = 'RegistroTipoDeLibro.aspx'> Registro Clasificación Libros</a></li>
        //                                      </ul>
        //                                    </li>
        //                                    <li><a href = 'index-1.html' > Acerca De</a>
        //                                      <ul>
        //                                        <li><a href = '#' > Lorem ipsum dolor</a></li>
        //                                        <li><a href = '#' > Conse ctetur adipisicing</a></li>
        //                                        <li><a href = '#' > Elit sed do eiusmod
        //                                          <ul>
        //                                            <li><a href = '#' > Lorem ipsum</a></li>
        //                                            <li><a href = '#' > Conse adipisicing</a></li>
        //                                            <li><a href = '#' > Sit amet dolore</a></li>
        //                                          </ul></a>
        //                                        </li>
        //                                        <li><a href = '#' > Incididunt ut labore</a></li>
        //                                        <li><a href = '#' > Et dolore magna</a></li>
        //                                        <li><a href = '#' > Ut enim ad minim</a></li>
        //                                      </ul>
        //                                    </li>
        //                                    <li><a href = 'index-4.html' > Contactos </ a >
        //                                    </li>
        //                                  </ul>   
        //                                </nav>
        //                                ");
        //    this.ltMenu.Text = menu;
        //}
        //protected void MenuAlumno()
        //{
        //    string menu = string.Format(@"
        //                                <nav class='nav'>
        //                                  <ul data-type ='navbar' class='sf-menu'>
        //                                    <li><a href ='Inicio.aspx'>Inicio</a>
        //                                    </li>
        //                                    <li><a href = 'index-3.html'>Serviciós</a>
        //                                      <ul>
        //                                          <li><a href= 'ApartadoDeLibros.aspx'> Apartado de Libros</a></li>
        //                                          <li><a href = 'Busqueda.aspx'> Busqueda de Libros</a></li>
        //                                          <li><a href = 'Prestamos.aspx'> Prestamos de Libros</a></li>
        //                                      </ul>
        //                                    </li>
        //                                    <li><a href = 'index-1.html' > Acerca De</a>
        //                                      <ul>
        //                                        <li><a href = '#' > Lorem ipsum dolor</a></li>
        //                                        <li><a href = '#' > Conse ctetur adipisicing</a></li>
        //                                        <li><a href = '#' > Elit sed do eiusmod
        //                                          <ul>
        //                                            <li><a href = '#' > Lorem ipsum</a></li>
        //                                            <li><a href = '#' > Conse adipisicing</a></li>
        //                                            <li><a href = '#' > Sit amet dolore</a></li>
        //                                          </ul></a>
        //                                        </li>
        //                                        <li><a href = '#' > Incididunt ut labore</a></li>
        //                                        <li><a href = '#' > Et dolore magna</a></li>
        //                                        <li><a href = '#' > Ut enim ad minim</a></li>
        //                                      </ul>
        //                                    </li>
        //                                    <li><a href = 'index-4.html' > Contactos </ a >
        //                                    </li>
        //                                  </ul>   
        //                                </nav>
        //                                ");
        //    this.ltMenu.Text = menu;
        //}
    }
}