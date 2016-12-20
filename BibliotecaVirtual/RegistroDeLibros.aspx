<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="RegistroDeLibros.aspx.cs" Inherits="BibliotecaVirtual.RegistroDeLibros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
    <form id="form" runat="server">
        <div class="container text-center">
            <h1>Registro De Libros</h1>
            <br />
            <div class="row">
                <div class="col-xs-12 col-md-12 col-lg-12" id="divError" runat="server">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="row">
            <div class="col-xs-12 col-md-6 col-md-6">
                <div class="form-inline">
                    <div id="divTitulo" runat="server">
                    <label for="label">Titulo: </label>
                    <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-xs-12 col-md-6 col-lg-6">
                <div class="form-inline">
                    <div id="divEdicion" runat="server">
                        <label for="label">Edicion: </label>
                        <asp:TextBox ID="txtEdicion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
            </div>
            </div>
            <div class="row">              
                <div class="col-xs-12 col-md-6 col-lg-6">
                    <div class="form-inline">
                        <div id="divAutor" runat="server">
                            <label for="label">Autor: </label>
                            <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
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
                        <div id="divEditorial" runat="server">
                        <label for="label">Editorial: </label>
                        <asp:TextBox ID="txtEditorial" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-xs-12 col-md-12 col-lg-6">
                        <div id="div1" runat="server">
                        <label for="label">Clasificación: </label>
                            <asp:DropDownList ID="ddlClasificación" runat="server" CssClass="form-control" DataTextField="Clasificacion" DataValueField="TipoLibroId"></asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12 col-md-6 col-lg-6">
                    <div class="form-inline">
                        <div id="divDescripcion" runat="server">
                            <label for="label">Descripcion: </label>
                            <asp:TextBox ID="txtArea" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <div class="form-inline">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click"/>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Style="margin-top: auto;" CssClass="btn btn-danger" OnClick="btnCancelar_Click"/>
                    </div>
                </div>
                <div class="col-md-4">
                    <asp:HiddenField ID="hdLibroId" runat="server" />
                </div>
            </div>
            <br />
            <br />							
                <div class="table-responsive">
                    <asp:GridView ID="grvLibros" runat="server" AutoGenerateColumns="False" GridLines="None"  
                AllowPaging="false" CssClass="table table-bordered table-hover" PagerStyle-CssClass="" AlternatingRowStyle-CssClass="alt"  
                PageSize="7" DataKeyNames="LibroId" OnRowDeleting="grvLibros_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="LibroId" HeaderText="ID" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Titulo" HeaderText="Título" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Autor" HeaderText="Autor" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Edicion" HeaderText="Edición" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Editorial" HeaderText="Editorial" HeaderStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" HeaderStyle-HorizontalAlign="Center"/>
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
    </form>
</asp:Content>
