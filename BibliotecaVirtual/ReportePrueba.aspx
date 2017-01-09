<%@ Page Title="" Language="C#" MasterPageFile="~/MarterPage.Master" AutoEventWireup="true" CodeBehind="ReportePrueba.aspx.cs" Inherits="BibliotecaVirtual.ReportePrueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMasterId" runat="server">
    <div class="container">
        <h1>Report Test</h1>
        <div class="form-control">
            <asp:Button ID="btnReport" runat="server" Text="Aceptar" OnClick="btnReport_Click" />
        </div>
       <%-- <form id="form1" runat="server">
            <div id="dialog" title="Dialog Title" class="text-center">
                <iframe src="/Files/prueba.pdf" style="width:100%; height:700px;" frameborder="0"></iframe>
            </div>
        </form>--%>
        <asp:Literal ID="ltlFrame" runat="server"></asp:Literal>
        
    </div>
    
</asp:Content>
