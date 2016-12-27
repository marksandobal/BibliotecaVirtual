<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="RegistroDeUsuarios.aspx.cs" Inherits="BibliotecaVirtual.RegistroDeUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
<%--    <form id="form" runat="server">
    </form>--%>
<div class="container text-center">
    <h1>Registro De Usuarios</h1>
    <br />
    <div class="col-xs-12 col-md-12 col-lg-12" id="divError" runat="server">
        <asp:Label ID="lblError" runat="server" Text="" Style="font-weight:bold"></asp:Label>
        <asp:HiddenField ID="hdUsuarioId" runat="server" />
    </div>
    <div class="row">
        <div class="form-group">
            <div class="col-xs-12 col-md-6 col-lg-6">
                <div class="form-inline">
                    <div id="divNombre" runat="server">
                        <label for="label">Nombre: </label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div> 
                </div>
            </div>
            <div class="col-xs-12 col-md-6 col-lg-6">
                <div class="form-inline">
                    <div id="divEdad" runat="server">
                        <label for="label">Edad: </label>
                        <asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="form-group">
            <div class="form-inline">
                <div class="col-xs-12 col-md-6 col-lg-6">
                    <div id="divApellido" runat="server">
                        <label for="label">Apellido: </label>
                        <asp:TextBox ID="txtSurname" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-inline">
                <div class="col-xs-12 col-md-6 col-lg-6">
                   <div id="divMatricula" runat="server">
                        <label for="label">Matricula: </label>
                        <asp:TextBox ID="txtEnrollment" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="form-inline">
            <div class="col-xs-12 col-md-6 col-lg-6">
                <div id="divDireccion" runat="server">
                    <label for="label">Direccion: </label>
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-xs-12 col-md-6 col-lg-6">
                <div id="divTelefono" runat="server">
                    <label for="label">Telefono: </label>
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="form-group">
            <div class="form-inline">
                <div class="col-xs-12 col-md-6 col-lg-6">
                    <div id="divFechaNacimiento" runat="server">
                        <label for="label">Fecha De nacimiento: </label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-xs-2"></div>
            <div class="form-inline">
                <div class="col-xs-12 col-md-4 col-lg-4 text-left">
                    <div id="divActivo" runat="server">
                        <label for="label">Activo: </label>
                        <asp:CheckBox ID="chkActive" runat="server" />
                    </div>
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
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn-default" OnClick="btnActualizar_Click"/>
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
            <br />
            <br />							
                <div class="table-responsive">
                    <asp:GridView ID="grvUsuarios" runat="server" AutoGenerateColumns="False" GridLines="None"  
                AllowPaging="false" CssClass="table table-bordered table-hover" PagerStyle-CssClass="" AlternatingRowStyle-CssClass="alt"  
                PageSize="7" DataKeyNames="UsuarioId" OnRowDeleting="grvUsuarios_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="UsuarioId" HeaderText="ID" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Edad" HeaderText="Edad" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha De Nacimiento" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Matricula" HeaderText="Matricula" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Activo" HeaderText="Activo" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                   Editar
                                </HeaderTemplate>
                                 <ItemTemplate>
                                     <asp:LinkButton ID="lnkEdit" runat="server" Text="<img src='../images/icons/edit.png' />" ToolTip="Editar" OnClick="lnkEdit_Click"></asp:LinkButton>
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
