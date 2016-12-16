<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="RegistroDeUsuarios.aspx.cs" Inherits="BibliotecaVirtual.RegistroDeUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
    <form id="form" runat="server">
        <div class="container text-center">
            <h1>Registro De Usuarios</h1>
            <div class="row">
                <div class="form-group">
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <div class="form-inline">
                            <label for="label">Nombre: </label>
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <div class="form-inline">
                            <label for="label">Edad: </label>
                            <asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                    <div class="form-inline">
                        <div class="col-xs-12 col-md-6 col-lg-6">
                            <label for="label">Apellido: </label>
                            <asp:TextBox ID="txtSurname" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-inline">
                        <div class="col-xs-12 col-md-6 col-lg-6">
                            <label for="label">Matricula: </label>
                            <asp:TextBox ID="txtEnrollment" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-inline">
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <label for="label">Direccion: </label>
                        <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <label for="label">Telefono: </label>
                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                   <div class="form-inline">
                    <div class="col-xs-12 col-md-8 col-lg-8">
                        <label for="label">Fecha De nacimiento: </label>
                        <asp:TextBox ID="txtDateB" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    </div>
                    <div class="form-inline">
                        <div class="col-xs-12 col-md-4 col-lg-4 text-left">
                            <label for="label">Activo: </label>
                            <asp:CheckBox ID="chkActive" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <div class="form-inline">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                    </div>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</asp:Content>
