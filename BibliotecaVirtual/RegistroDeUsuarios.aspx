<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="RegistroDeUsuarios.aspx.cs" Inherits="BibliotecaVirtual.RegistroDeUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
    <form id="form" runat="server">
        <div class="container text-center">
            <h1>Registro De Usuarios</h1>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <div class="row">
                <div class="form-group">
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <div class="form-inline">
                            <label for="label">Nombre: 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Ingresar Nombre" ControlToValidate="txtName" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </label>
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <div class="form-inline">
                            <label for="label">Edad: <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese Edad" ControlToValidate="txtAge" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </label>
                            <asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                    <div class="form-inline">
                        <div class="col-xs-12 col-md-6 col-lg-6">
                            <label for="label">Apellido: <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingresar Apellido" ControlToValidate="txtSurname" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </label>
                            <asp:TextBox ID="txtSurname" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-inline">
                        <div class="col-xs-12 col-md-6 col-lg-6">
                            <label for="label">Matricula: <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Ingrese Matricula" ControlToValidate="txtEnrollment" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </label>
                            <asp:TextBox ID="txtEnrollment" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-inline">
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <label for="label">Direccion: <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Ingrese Direccion" ControlToValidate="txtAddress" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </label>
                        <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <label for="label">Telefono: <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Ingrese Telefono" ControlToValidate="txtPhone" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </label>
                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                   <div class="form-inline">
                    <div class="col-xs-12 col-md-6 col-lg-6">
                        <label for="label">Fecha De nacimiento: <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Ingrese Fecha De Nacimiento" ControlToValidate="txtFechaNacimiento" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                    </div>
                    </div>
                    <div class="col-xs-2"></div>
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
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn-primary" OnClick="btnGuardar_Click"/>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn-danger"/>
                    </div>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</asp:Content>
