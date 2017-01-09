<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="ReportePrestamos.aspx.cs" Inherits="BibliotecaVirtual.ReportePrestamos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
            <div class="container">
        <div class="row">
            <div class="col-xs-4" Style="width:auto">
                <div class="form-inline">
                    <label>Fecha de Inicio: </label>
                    <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                </div>
            </div>
             <div class="col-xs-4" style="width:auto">
                <div class="form-inline">
                    <label>Fecha Final: </label>
                    <asp:TextBox ID="txtFechaFinal" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                </div>
            </div>
             <div class="col-xs-3">
                <div class="form-inline">
                    <asp:RadioButton ID="rbPorFechaPrestamo" runat="server" CssClass="radio"/>         
                    <label>Por Fecha Prestamo</label>                             
                </div>
                 <div class="form-inline">
                    <asp:RadioButton ID="rbPorFechaVencimiento" runat="server" CssClass="radio"/>
                    <label>Por Fecha Vencimiento</label>                              
                 </div>                
            </div>
            <div class="col-xs-1">
                <asp:Button ID="btnReport" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="btnReport_Click"/>         
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <asp:Literal ID="ltlIframe" runat="server"></asp:Literal>
                <%-- <iframe src="/Files/prueba.pdf" style="width:100%; height:700px;" frameborder="0"></iframe>--%>
            </div>
        </div>
    </div>
</asp:Content>
