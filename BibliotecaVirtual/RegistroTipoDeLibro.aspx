<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="RegistroTipoDeLibro.aspx.cs" Inherits="BibliotecaVirtual.RegistroTipoDeLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
    <form id="form1" runat="server">
        <div class="containert text-center">
            <h1>Registro de Clasificación de libros</h1>
            <br />
            <div class="row">
                <div class="col-xs-12 col-md-12 col-lg-12">
                    <div class="form-inline">
                        <label>Clasificación: </label>
                        <asp:TextBox ID="txtClasificacion" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Button ID="btnGuardar" runat="server" Text="Agregar" CssClass="btn btn-primary" Style="margin-top:auto"/>     
                                      
                    </div>
                </div>
            </div>
                <div class="table-responsive">
                    <asp:GridView ID="grvClasificacion" runat="server" AutoGenerateColumns="False" GridLines="None"  
                AllowPaging="true" CssClass="table table-bordered table-hover" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"  
                PageSize="7" DataKeyNames="UsuarioId">
                        <Columns>
                            <asp:BoundField DataField="" HeaderText="Clasificación" />
<%--                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Edad" HeaderText="Edad" />
                            <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" />
                            <asp:BoundField DataField="Matricula" HeaderText="Matricula" />
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="Activo" HeaderText="Activo" /> --%>                         
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
