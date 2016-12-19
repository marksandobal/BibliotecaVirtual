<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="RegistroDeLibros.aspx.cs" Inherits="BibliotecaVirtual.RegistroDeLibros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
    <form id="form" runat="server">
        <div class="container text-center">
            <h1>Registro De Libros</h1>
            <br />
            <div class="row">
                <div class="form-inline">
                    <div class="col-xs-12 col-md-6 col-md-6">
                        <label for="label">Titulo: </label>
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <label for="label">Edicion: </label>
                        <asp:TextBox ID="txtEdicion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">              
                <div class="col-xs-12 col-md-6 col-lg-6">
                    <div class="form-inline">
                    <label for="label">Autor: </label>
                    <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xs-12 col-md-12 col-lg-6">
                    <div class="form-inline">
                        <label for="label">Fecha De Publicacion:</label>
                    <asp:TextBox ID="txtFechaPublicacion" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-inline">
                    <div class="col-xs-12 col-md-12 col-lg-6">
                        <label for="label">Editorial: </label>
                        <asp:TextBox ID="txtEditorial" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12 col-md-6 col-lg-6">
                    <div class="form-inline">
                        <label for="label">Descripcion: </label>
                        <asp:TextBox ID="txtArea" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <div class="form-inline">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn-primary" OnClick="btnGuardar_Click"/>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn-danger"/>
                    </div>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</asp:Content>
