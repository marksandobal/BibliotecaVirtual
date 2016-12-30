<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="Prestamos.aspx.cs" Inherits="BibliotecaVirtual.Prestamos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
<%--    <form id="form" runat="server" class="form-horizontal">
    </form>--%>
        <div class="container text-center form-horizontal">
            <h1>Prestamos</h1>
            <br />
                <div class="form-group">
                    <label class="control-label col-xs-3">Título: </label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-xs-3">Autor: </label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
 
                <div class="form-group">
                    <label class="control-label col-xs-3">Categoria: </label>
                    <div class="col-xs-4">
                        <asp:DropDownList ID="txtCategoria" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="col-xs-2"><asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn-success"/></div>
                </div>
                <div class="col-xs-7">
                    <div class="form-inline">
                        <label>Fehca de Prestamo: </label>
                        <asp:TextBox ID="txtFechaPrestamo" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xs-5">
                    <div class="form-inline">
                        <label>Fecha de Vencimiento: </label>
                        <asp:TextBox ID="txtFechaVencimiento" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                    </div>
                </div>
        <div class="table-responsive">
             <asp:GridView ID="grvBusqueda" runat="server" AutoGenerateColumns="False" GridLines="None"  
                AllowPaging="true" CssClass="table table-bordered table-hover" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"  
                PageSize="7" DataKeyNames="Id">
                        <Columns>
                            <asp:BoundField DataField="Titulo" HeaderText="Título" />
                            <asp:BoundField DataField="Nombre" HeaderText="Autor" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                            <asp:BoundField DataField="Publicacion" HeaderText="Fecha de Publicación" />
                            <asp:BoundField DataField="Disponibilidad" HeaderText="En Existencia" />                         
                        </Columns>
                    <%--<RowStyle CssClass="cursor-pointer"/>
                        <AlternatingRowStyle BackColor="#FFFFFF" />
                        <SelectedRowStyle BackColor="DimGray" ForeColor="White" Font-Bold="true" />--%>
                        <HeaderStyle CssClass="gridHeader" BorderWidth="1px" BorderColor="#0F0501" Font-Bold="true"  BorderStyle="Solid" Height="30px" />                                       
                </asp:GridView>
        </div>
            <br />
            <div class="row">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click"/>
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click"/>
            </div>
        </div>
</asp:Content>
