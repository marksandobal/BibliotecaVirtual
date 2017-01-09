<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="BibliotecaVirtual.Inicio" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <title>Home</title>
    <meta charset="utf-8">
    <meta name="format-detection" content="telephone=no">
    <link rel="icon" href="images/favicon.ico" type="image/x-icon">
    <link rel="stylesheet" href="css/grid.css">
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/camera.css">
    <link rel="stylesheet" href="css/owl-carousel.css">
    <%--<link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">--%>
    <script src="js/jquery.js"></script>
    <script src="js/jquery-migrate-1.2.1.js"></script><!--[if lt IE 9]>
    <html class="lt-ie9">
      <div style="clear: both; text-align:center; position: relative;"><a href="http://windows.microsoft.com/en-US/internet-explorer/.."><img src="images/ie8-panel/warning_bar_0000_us.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today."></a></div>
    </html>
    <script src="js/html5shiv.js"></script><![endif]-->
    <script src="js/device.min.js"></script>
  </head>
  <body>
    <div class="page">
      <!--
      ========================================================
      							HEADER
      ========================================================
      
      
      -->
      <header>
        <div class="container">
          <div class="brand">
            <h1 class="brand_name"><a href="./">Business</a></h1>
            <p class="brand_slogan">Company</p>
          </div><a href="callto:#" class="fa-phone">800-2345-6789</a>
          <p>One of our representatives will happily contact you within 24 hours. For urgent needs call us at</p>
            <%--<p>
            <!-- Trigger the modal with a button -->
            <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Open Modal</button>
            </p>--%>
        </div>
        <div id="stuck_container" class="stuck_container">
          <div class="container">
            <nav class="nav">
              <ul data-type="navbar" class="sf-menu">
                <li><a href="Inicio.aspx">Inicio</a>
                </li>
                <li runat="server" id="liMenuRegistros"><a href="#">Registros</a>
                  <ul>
                    <li><a href="RegistroDeLibros.aspx">Registro De Libros </a></li>
                    <li><a href="RegistroDeUsuarios.aspx">Registro De Usuarios</a></li>
                    <li><a href="RegistroTipoDeLibro.aspx">Registro Clasificación Libros</a></li>
                  </ul>
                </li>
                <li runat="server" id="liMenuServicios"><a href="#">Serviciós</a>
                    <ul>
                        <li><a href="ApartadoDeLibros.aspx">Apartado de Libros</a></li>
                        <li><a href="Busqueda.aspx">Busqueda de Libros</a></li>
                        <li><a href="Prestamos.aspx">Prestamos de Libros</a></li>
                    <li><a href="#">Reportes
                        <ul>
                          <li><a href="ReportePrestamos.aspx">Reporte Prestamos</a></li>
                          <li><a href="#">Reporte Apartado de Libros</a></li>
                          <li><a href="#">Reporte Cantidad de libros</a></li>
                        </ul></a>
                    </li>
                    </ul>
                </li>
                <li><a href="#">Acerca De</a>
                  <ul>
                    <li><a href="#">Lorem ipsum dolor</a></li>
                    <li><a href="#">Conse ctetur adipisicing</a></li>
                    <li><a href="#">Elit sed do eiusmod
                        <ul>
                          <li><a href="#">Lorem ipsum</a></li>
                          <li><a href="#">Conse adipisicing</a></li>
                          <li><a href="#">Sit amet dolore</a></li>
                        </ul></a>
                    </li>
                    <li><a href="#">Incididunt ut labore</a></li>
                    <li><a href="#">Et dolore magna</a></li>
                    <li><a href="#">Ut enim ad minim</a></li>
                  </ul>
                </li>
                <li><a href="#">Contactos</a>
                </li>
              </ul>
            </nav>
          </div>
        </div>
		<div class="stuck_container">
		
		</div>
      </header>
      <!--
      ========================================================
                                  CONTENT
      ========================================================
      -->
      <main>
        <section class="camera_container">
          <div id="camera" class="camera_wrap">
            <div data-src="images/page-1_slide01.jpg">
              <div class="camera_caption fadeIn">
                <div class="container">
                  <div class="row">
                    <div class="preffix_6 grid_6">Helping with any of your business needs!</div>
                  </div>
                </div>
              </div>
            </div>
            <div data-src="images/page-1_slide02.jpg">
              <div class="camera_caption fadeIn">
                <div class="container">
                  <div class="row">
                    <div class="preffix_6 grid_6">The best strategies to attract new business</div>
                  </div>
                </div>
              </div>
            </div>
            <div data-src="images/page-1_slide03.jpg">
              <div class="camera_caption fadeIn">
                <div class="container">
                  <div class="row">
                    <div class="preffix_6 grid_6">A wide range of global business information</div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>
        <section>
          <div class="container banner_wr">
            <ul class="banner">
              <li>
                <div class="fa-globe"></div>
                <h3>Global<br/>research</h3>
                <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud.</p><a href="#"></a>
              </li>
              <li>
                <div class="fa-lightbulb-o"></div>
                <h3>Creative<br/>ideas</h3>
                <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud.</p><a href="#"></a>
              </li>
              <li>
                <div class="fa-cog"></div>
                <h3>New<br/>services</h3>
                <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud.</p><a href="#"></a>
              </li>
              <li>
                <div class="fa-briefcase"></div>
                <h3>Pro<br/>management</h3>
                <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud.</p><a href="#"></a>
              </li>
            </ul>
          </div>
        </section>
        <section class="well ins1">
          <div class="container hr">
            <ul class="row product-list">
              <li class="grid_6">
                <div class="box wow fadeInRight">
                  <div class="box_aside">
                    <div class="icon fa-comments"></div>
                  </div>
                  <div class="box_cnt__no-flow">
                    <h3><a href="#">Incididunt ut labore et dolore</a></h3>
                    <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolor.</p>
                  </div>
                </div>
                <hr>
                <div data-wow-delay="0.2s" class="box wow fadeInRight">
                  <div class="box_aside">
                    <div class="icon fa-calendar-o"></div>
                  </div>
                  <div class="box_cnt__no-flow">
                    <h3><a href="#">Incididunt ut labore et dolore</a></h3>
                    <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolor.</p>
                  </div>
                </div>
              </li>
              <li class="grid_6">
                <div data-wow-delay="0.3s" class="box wow fadeInRight">
                  <div class="box_aside">
                    <div class="icon fa-group"></div>
                  </div>
                  <div class="box_cnt__no-flow">
                    <h3><a href="#">Incididunt ut labore et dolore</a></h3>
                    <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolor.</p>
                  </div>
                </div>
                <hr>
                <div data-wow-delay="0.4s" class="box wow fadeInRight">
                  <div class="box_aside">
                    <div class="icon fa-thumbs-up"></div>
                  </div>
                  <div class="box_cnt__no-flow">
                    <h3><a href="#">Incididunt ut labore et dolore</a></h3>
                    <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolor.</p>
                  </div>
                </div>
              </li>
            </ul>
          </div>
        </section>
        <section class="well1">
          <div class="container">
            <div class="row">
              <div class="grid_4">
                <h2>About</h2><img src="images/page-1_img01.jpg" alt="">
                <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatu. Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt. Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna.</p><a href="#" class="btn">Read more</a>
              </div>
              <div class="grid_4">
                <h2>Services</h2>
                <p>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                <ul class="marked-list">
                  <li><a href="#">Lorem ipsum dolor sit amet </a></li>
                  <li><a href="#">Conse ctetur adipisicing</a></li>
                  <li><a href="#">Elit sed do eiusmod tempor</a></li>
                  <li><a href="#">Incididunt ut labore</a></li>
                  <li><a href="#">Et dolore magna aliqua</a></li>
                  <li><a href="#">Ut enim ad minim veniam</a></li>
                  <li><a href="#">Quis nostrud exercitation</a></li>
                  <li><a href="#">Incididunt ut labore</a></li>
                  <li><a href="#">Et dolore magna aliqua</a></li>
                </ul><a href="#" class="btn">Read more</a>
              </div>
              <div class="grid_4">
                <div class="info-box">
                  <h2 class="fa-comment">Help center</h2>
                  <hr>
                  <h3>Ask professionals:</h3>
                  <dl>
                    <dt>Monday - Friday:</dt>
                    <dd>8am-7pm</dd>
                  </dl>
                  <dl>
                    <dt>Saturday:</dt>
                    <dd>8am-5pm</dd>
                  </dl>
                  <dl>
                    <dt>Sunday:</dt>
                    <dd>1pm-5pm</dd>
                  </dl>
                  <hr>
                  <h3>24/7 Online Support:</h3>
                  <dl>
                    <dt>800-2345-6789</dt>
                  </dl>
                </div>
                <div class="owl-carousel">
                  <div class="item">
                    <blockquote class="box">
                      <div class="box_aside"><img src="images/page-1_img02.jpg" alt=""></div>
                      <div class="box_cnt__no-flow">
                        <p>
                          <q>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</q>
                        </p>
                        <cite><a href="#">Incididunt ut labor</a></cite>
                      </div>
                    </blockquote>
                  </div>
                  <div class="item">
                    <blockquote class="box">
                      <div class="box_aside"><img src="images/page-1_img03.jpg" alt=""></div>
                      <div class="box_cnt__no-flow">
                        <p>
                          <q>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</q>
                        </p>
                        <cite><a href="#">Incididunt ut labor</a></cite>
                      </div>
                    </blockquote>
                  </div>
                  <div class="item">
                    <blockquote class="box">
                      <div class="box_aside"><img src="images/page-1_img04.jpg" alt=""></div>
                      <div class="box_cnt__no-flow">
                        <p>
                          <q>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</q>
                        </p>
                        <cite><a href="#">Incididunt ut labor</a></cite>
                      </div>
                    </blockquote>
                  </div>
                  <div class="item">
                    <blockquote class="box">
                      <div class="box_aside"><img src="images/page-1_img05.jpg" alt=""></div>
                      <div class="box_cnt__no-flow">
                        <p>
                          <q>Lorem ipsum dolor sit amet conse ctetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</q>
                        </p>
                        <cite><a href="#">Incididunt ut labor</a></cite>
                      </div>
                    </blockquote>
                  </div>
                </div>
              </div>
            </div>
          </div>
<%--        <div class="container">
            <!-- Modal -->
            <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog">    
                <!-- Modal content-->
                <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Modal Header</h4>
                </div>
                <div class="modal-body">
                    <p>Some text in the modal.</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
                </div>     
            </div>
            </div>
        </div>--%>
        </section>
      </main>
      <!--
      ========================================================
                                  FOOTER
      ========================================================
      -->
      <footer>
        <section class="well3">
          <div class="container">
            <ul class="row contact-list">
              <li class="grid_4">
                <div class="box">
                  <div class="box_aside">
                    <div class="icon2 fa-map-marker"></div>
                  </div>
                  <div class="box_cnt__no-flow">
                    <address>4578 Marmora Road,Glasgow<br/> D04 89GR</address>
                  </div>
                </div>
                <div class="box">
                  <div class="box_aside">
                    <div class="icon2 fa-envelope"></div>
                  </div>
                  <div class="box_cnt__no-flow"><a href="mailto:#">info@demolink.org</a></div>
                </div>
              </li>
              <li class="grid_4">
                <div class="box">
                  <div class="box_aside">
                    <div class="icon2 fa-phone"></div>
                  </div>
                  <div class="box_cnt__no-flow"><a href="callto:#">800-2345-6789</a></div>
                </div>
                <div class="box">
                  <div class="box_aside">
                    <div class="icon2 fa-fax"></div>
                  </div>
                  <div class="box_cnt__no-flow"><a href="callto:#">800-2345-6790</a></div>
                </div>
              </li>
              <li class="grid_4">
                <div class="box">
                  <div class="box_aside">
                    <div class="icon2 fa-facebook"></div>
                  </div>
                  <div class="box_cnt__no-flow"><a href="#">Follow on facebook</a></div>
                </div>
                <div class="box">
                  <div class="box_aside">
                    <div class="icon2 fa-twitter"></div>
                  </div>
                  <div class="box_cnt__no-flow"><a href="#">Follow on Twitter</a></div>
                </div>
              </li>
            </ul>
          </div>
        </section>
        <section>
          <div class="container">
            <div class="copyright">Business Company © <span id="copyright-year"></span>.&nbsp;&nbsp;<a href="index-5.html">Privacy Policy</a>More <a rel="nofollow" href="http://www.templatemonster.com/category/business-web-templates/" target="_blank">Business Website Templates at TemplateMonster.com</a>
            </div>
          </div>
        </section>
      </footer>
    </div>
    <script src="js/script.js"></script>
      <script src="bootstrap/js/bootstrap.min.js"></script>
  </body>
</html>