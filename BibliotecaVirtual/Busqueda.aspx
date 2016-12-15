<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="BibliotecaVirtual.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
<form id="form" runat="server">
        <div class="container text-center">
            <h1>Busqueda</h1>
        <div class="row">
            <div class="form-group">
                <div class="col-xs-6">
                    <div class="form-inline">
                        <label for="label1">Título: </label>
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xs-6">
                    <div class="form-inline">
                        <label for="label1">Categoria: </label>
                        <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6">
                <div class="form-inline">
                    <label for="label1">Autor: </label>
                    <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6"></div>
            <div class="col-xs-3">
                <div class="form-inline">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn-success"/>
                    <asp:Button ID="btnVerHistorial" runat="server" Text="Ver Historial" CssClass="btn-primary"/>
                </div>
            </div>
        </div>
        <div class="table-responsive">
             <asp:GridView ID="grvBusqueda" runat="server" AutoGenerateColumns="False" GridLines="None"  
                AllowPaging="true" CssClass="table table-bordered table-hover" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"  
                PageSize="7" DataKeyNames="Id">
                        <Columns>
                            <asp:BoundField DataField="UsuarioId" HeaderText="Título" />
                            <asp:BoundField DataField="Nombre" HeaderText="Autor" />
                            <asp:BoundField DataField="Apellidos" HeaderText="Categoria" />
                            <asp:BoundField DataField="Edad" HeaderText="Fecha de Publicación" />
                            <asp:BoundField DataField="FechaNacimiento" HeaderText="En Existencia" />                         
                        </Columns>
                    <%--<RowStyle CssClass="cursor-pointer"/>
                        <AlternatingRowStyle BackColor="#FFFFFF" />
                        <SelectedRowStyle BackColor="DimGray" ForeColor="White" Font-Bold="true" />--%>
                        <HeaderStyle CssClass="gridHeader" BorderWidth="1px" BorderColor="#0F0501" Font-Bold="true"  BorderStyle="Solid" Height="30px" />                                       
                </asp:GridView>
        </div>
    </div>
</form>
</asp:Content>
