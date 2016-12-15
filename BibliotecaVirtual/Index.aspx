<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BibliotecaVirtual.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
   <form id="form1" runat="server">
         <div class="container text-center">
            <div class ="form-group">
                    <div class="row">
                    <div class="col-xs-6">
                        <div class="form-inline">
                        <label for="exampleInputEmail1" >Nombre: </label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-xs-6">
                        <div class="form-inline">
                        <label for="exampleInputEmail1" >Apellido: </label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>          
                </div>
                <div class="row">
                    <div class="col-xs-2"></div>
                    <div class="col-sx-6">
                        <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn-primary" />
                    </div>
                </div>
                <div class="table-responsive">
                    <asp:GridView ID="grvUsers" runat="server" AutoGenerateColumns="False" GridLines="None"  
                AllowPaging="true" CssClass="table table-bordered table-hover" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"  
                PageSize="7" DataKeyNames="UsuarioId">
                        <Columns>
                            <asp:BoundField DataField="UsuarioId" HeaderText="ID" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Edad" HeaderText="Edad" />
                            <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" />
                            <asp:BoundField DataField="Matricula" HeaderText="Matricula" />
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="Activo" HeaderText="Activo" />                          
                        </Columns>
                    <%--<RowStyle CssClass="cursor-pointer"/>
                        <AlternatingRowStyle BackColor="#FFFFFF" />
                        <SelectedRowStyle BackColor="DimGray" ForeColor="White" Font-Bold="true" />--%>
                        <HeaderStyle CssClass="gridHeader" BorderWidth="1px" BorderColor="#0F0501" Font-Bold="true"  BorderStyle="Solid" Height="30px" />                                       
                    </asp:GridView>
                </div>
            </div>        
        </div>
   </form>
</asp:Content>
