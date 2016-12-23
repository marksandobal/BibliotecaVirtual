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
                     <label for="label">Direccion: </label>
                     <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
         </div>
     </div>
</asp:Content>
