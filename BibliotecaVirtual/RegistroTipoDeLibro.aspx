<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="RegistroTipoDeLibro.aspx.cs" Inherits="BibliotecaVirtual.RegistroTipoDeLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
<%--    <form id="form1" runat="server">
    </form>--%>
    <div class="containert text-center">
        <h1>Registro de Clasificación de libros</h1>
        <br />
        <div class="row">
            <div class="col-xs-12 col-md-12 col-lg-12" id="div1" runat="server">
                <asp:Label ID="lblError" runat="server" Text="" Style="font-weight:bold"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12 col-md-12 col-lg-12" id="divclasificacion" runat="server">
                <div class="form-inline">
                    <label>Clasificación: </label>
                    <asp:TextBox ID="txtClasificacion" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnGuardar" runat="server" Text="Agregar" CssClass="btn btn-primary" Style="margin-top:auto" OnClick="btnGuardar_Click"/>     
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" Style="margin-top:auto" OnClick="btnCancelar_Click"/>     
                                                           
                </div>
            </div>
        </div>
        <asp:HiddenField ID="hdTipoLibroId" runat="server" />
        <br />
        <br />
            <div class="table-responsive">
                <asp:GridView ID="grvClasificacion" runat="server" AutoGenerateColumns="False" GridLines="None"  
            AllowPaging="false" CssClass="table table-bordered table-hover" PagerStyle-CssClass="" AlternatingRowStyle-CssClass="alt"  
            PageSize="7" DataKeyNames="TipoLibroId" OnRowDeleting="grvClasificacion_RowDeleting" >
                    <Columns>
                        <asp:BoundField DataField="TipoLibroId" HeaderText="ID" HeaderStyle-HorizontalAlign="Center"/>
                        <asp:BoundField DataField="Clasificacion" HeaderText="Clasificación" HeaderStyle-HorizontalAlign="Center"/>
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
