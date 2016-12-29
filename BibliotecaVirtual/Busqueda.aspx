<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="BibliotecaVirtual.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
<%--<form id="form" runat="server">
</form>--%>
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
                <asp:DropDownList ID="ddlCategoria" DataValueField="TipoLibroId" DataTextField="Clasificacion" runat="server" CssClass="form-control"></asp:DropDownList>
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
    <div class="col-xs-3"></div>
    <div class="col-xs-6">
        <div class="form-inline">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" Style="margin-bottom:-30px"/>
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click"/>
        </div>
    </div>
</div>
    <br />
    <br />
<div class="table-responsive">
  <asp:GridView ID="grvLibros" runat="server" AutoGenerateColumns="False" GridLines="None"  
    AllowPaging="false" CssClass="table table-bordered table-hover" PagerStyle-CssClass="" AlternatingRowStyle-CssClass="alt"  
    PageSize="7" DataKeyNames="LibroId,Estado" OnRowDataBound="grvLibros_RowDataBound">
            <Columns>
                <asp:BoundField DataField="LibroId" HeaderText="ID" HeaderStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Titulo" HeaderText="Título" HeaderStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Autor" HeaderText="Autor" HeaderStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Edicion" HeaderText="Edición" HeaderStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Editorial" HeaderText="Editorial" HeaderStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" HeaderStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Clasificacion" HeaderText="Clasificación" HeaderStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Estado" HeaderText="Status" HeaderStyle-HorizontalAlign="Center" ControlStyle-CssClass="alert-success"/>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Apartar / Prestar
                    </HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkApartar" runat="server" OnClick="lnkApartar_Click" Text="Apartar" ToolTip="Apartar" ></asp:LinkButton>                      
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
