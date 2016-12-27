<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="ApartadoDeLibros.aspx.cs" Inherits="BibliotecaVirtual.ApartadoDeLibros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
<%-- <form id="for1" runat="server">
 </form>--%>
     <div class="container text-center">
         <h1>Apartado de Libros</h1>
         <br />
         <div class="row">
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Nombre: </label>
                     <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Titulo: </label>
                     <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
         </div>
         <div class="row">
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Matricula: </label>
                     <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Autor: </label>
                     <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
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
                     <label for="label">Clasificación: </label>
                     <asp:DropDownList ID="ddlClasificacion" DataTextField="Clasificacion" DataValueField="TipoLibroId" runat="server" CssClass="form-control"></asp:DropDownList>
                 </div>
             </div>
         </div>
         <div class="row">
             <div class="col-xs-12 col-md-6 col-lg-6">
                 <div class="form-inline">
                     <label for="label">Direccion: </label>
                     <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
             <div class="col-xs-12 col-md-2 col-lg-2">
                <div class="form-inline">
                     <asp:Button ID="btnAgregar" runat="server" Text="Agregar a la Lista" CssClass="btn btn-primary btn-sm"/>
                 </div>
             </div>
         </div>
         <br />
         <br />
         <div class="table-responsive">
            <asp:GridView ID="grvLibros" runat="server" AutoGenerateColumns="False" GridLines="None"  
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
                            <asp:TemplateField>
                                <HeaderTemplate>
                                   Editar
                                </HeaderTemplate>
                                 <ItemTemplate>
                                     <asp:LinkButton ID="lnkEdit" runat="server" Text="<img src='../images/icons/edit.png' />" ToolTip="Editar"></asp:LinkButton>
                                 </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    Eliminar
                                </HeaderTemplate>
                                 <ItemTemplate>
                                      <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete" OnClientClick="javascript:return confirm('¿Confirma que desea eliminar el registro?');" Text="<img src='../images/icons/delete.png' />" ToolTip="Eliminar"></asp:LinkButton>
                                 </ItemTemplate>
                            </asp:TemplateField>                                               
                        </Columns>
                    <%--<RowStyle CssClass="cursor-pointer"/>
                        <AlternatingRowStyle BackColor="#FFFFFF" />
                        <SelectedRowStyle BackColor="DimGray" ForeColor="White" Font-Bold="true" />--%>
                        <HeaderStyle CssClass="gridHeader" BorderWidth="1px" BorderColor="#0F0501" Font-Bold="true"  BorderStyle="Solid" Height="30px" />                                       
           </asp:GridView>
        </div>
     </div>
</asp:Content>
