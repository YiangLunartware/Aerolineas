<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMigrantesPaises.aspx.cs" Inherits="ClienteWeb.ListaMigrantesPaisFechas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Listado de Migrantes según País de origen a País destino entre Fechas</h2>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        &nbsp;</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <table>
        <tr>
            <td>País origen
            <td>
                <asp:DropDownList ID="cboPaisOrigen" runat="server" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>País destino</td>
            <td>
                <asp:DropDownList ID="cboPaisDestino" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Fecha inicio</td>
            <td>
                <asp:TextBox ID="txtFecIni" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fecha fin</td>
            <td>
                <asp:TextBox ID="txtFecFin" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            </td>
        </tr>
    </table>
            <p>

                <asp:GridView ID="dgvMigrantes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" OnRowDataBound="dgvMigrantes_RowDataBound">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>

            </p>
            <p><asp:Label ID="lblError" runat="server"></asp:Label></p>
            <p>
                &nbsp;</p>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>

