<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="ApartadoDeLibros.aspx.cs" Inherits="BibliotecaVirtual.ApartadoDeLibros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
<%-- <form id="for1" runat="server">
 </form>--%>
     <div class="container text-center">
         <h1>Apartado de Libros</h1>
         <br />
         <div class="row">
             <div id="divMessage" runat="server">
                 <asp:Label ID="lblMessage" runat="server" Text="" Style="font-weight:bold"></asp:Label>
             </div>
         </div>
         <div class="row">
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Nombre: </label>
                     <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>--%>
                 </div>
             </div>
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Matricula: </label>
                     <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
         </div>
         <div class="row">
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Telefono: </label>
                     <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Direccion: </label>
                     <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
         </div>
         <div class="row">
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                    <div id="divTitulo" runat="server">
                         <label for="label">Titulo: </label>
                         <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                 </div>
             </div>
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <div id="divAutor" runat="server">
                         <label for="label">Autor: </label>
                         <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
                 </div>
             </div>
         </div>
         <div class="row">
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <div id="divddlClasificacion" runat="server">
                         <label for="label">Clasificación: </label>
                         <asp:DropDownList ID="ddlClasificacion" DataTextField="Clasificacion" DataValueField="TipoLibroId" runat="server" CssClass="form-control"></asp:DropDownList>
                     </div>
                 </div>
             </div>
         </div>
         <div class="row">
             <div class="col-xs-12 col-md-12 col-lg-12">
                <div class="form-inline">
                     <asp:Button ID="btnBusqueda" runat="server" Text="Ir a Busqueda" CssClass="btn btn-primary btn-sm" OnClick="btnBusqueda_Click"/>                 
                     <asp:Button ID="btnAgregar" runat="server" Text="Agregar a la Lista" CssClass="btn btn-success btn-sm" OnClick="btnAgregar_Click" Style="margin-top:auto"/>
                    <%-- <asp:Button ID="btnHistorial" runat="server" Text="Ver Historial" CssClass="btn btn-primary btn-sm" OnClick="btnHistorial_Click" Style="margin-top:auto" data-toggle="modal" data-target="#myModal"/>
                   --%> <button type="button" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#myModalHistorial" Style="margin-top:auto">Historial</button>
                 </div>
             </div>
         </div>
         <br />
         <asp:HiddenField ID="hdLibroId" runat="server" />
         <br />
         <div class="table-responsive">
            <asp:GridView ID="grvLibros" runat="server" AutoGenerateColumns="False" GridLines="None"  
                AllowPaging="false" CssClass="table table-bordered table-hover" PagerStyle-CssClass="" AlternatingRowStyle-CssClass="alt"  
                PageSize="7" DataKeyNames="LibroId" OnRowDeleting="grvLibros_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="LibroId" HeaderText="ID" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Titulo" HeaderText="Título" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Autor" HeaderText="Autor" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Edicion" HeaderText="Edición" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Editorial" HeaderText="Editorial" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Clasificacion" HeaderText="Clasificación" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    Quitar de la Lista
                                </HeaderTemplate>
                                 <ItemTemplate>
                                     <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete" OnClientClick="javascript:return confirm('¿Confirma que desea quitar el registro?');" Text="<img src='../images/icons/eliminar.png' />" ToolTip="Eliminar"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>                                               
                        </Columns>
                        <HeaderStyle CssClass="gridHeader" BorderWidth="1px" BorderColor="#0F0501" Font-Bold="true"  BorderStyle="Solid" Height="30px" />                                       
           </asp:GridView>
        </div>
        <!-- Modal -->
        <div id="myModalHistorial" class="modal fade" role="dialog">
          <div class="modal-dialog" Style="margin:250px auto">

            <!-- Modal content-->
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h3 class="modal-title"><strong>Historial</strong></h3>
              </div>
              <div class="modal-body">
                  <div class="table-responsive">
                    <asp:GridView ID="grvHistorial" runat="server" AutoGenerateColumns="False" GridLines="None"  
                        AllowPaging="false" CssClass="table table-bordered table-hover" PagerStyle-CssClass="" AlternatingRowStyle-CssClass="alt"  
                        PageSize="7" DataKeyNames="LibroId">
                                <Columns>
                                    <asp:BoundField DataField="LibroId" HeaderText="ID" HeaderStyle-HorizontalAlign="Center"/>
                                    <asp:BoundField DataField="Titulo" HeaderText="Título" HeaderStyle-HorizontalAlign="Center"/>
                                    <asp:BoundField DataField="Autor" HeaderText="Autor" HeaderStyle-HorizontalAlign="Center"/>
                                    <asp:BoundField DataField="Edicion" HeaderText="Edición" HeaderStyle-HorizontalAlign="Center"/>
                                    <asp:BoundField DataField="Editorial" HeaderText="Editorial" HeaderStyle-HorizontalAlign="Center"/>
                                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" HeaderStyle-HorizontalAlign="Center"/>
                                    <asp:BoundField DataField="Clasificacion" HeaderText="Clasificación" HeaderStyle-HorizontalAlign="Center"/>                                              
                                </Columns>
                                <HeaderStyle CssClass="gridHeader" BorderWidth="1px" BorderColor="#0F0501" Font-Bold="true"  BorderStyle="Solid" Height="30px" />                                       
                   </asp:GridView>
                </div>               
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-primary" data-dismiss="modal">Cerrar</button>
              </div>
            </div>
          </div>
        </div>
     </div>
</asp:Content>
