<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMigrantesTipoRutaPais.aspx.cs" Inherits="ClienteWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Listado de Migrantes Extranjeros y Nacionales según el Tipo de Ruta</h2>
    <blockquote>Si los viajes son a nivel Internacional, se mostrará de a qué país viajaron<br />
        Si los viajes son a nivel nacional, se mostrará a qué lugar viajaron en el mismo país</blockquote>
    <p>
        &nbsp;</p>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <p>
        </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <table>
        <tr>
            <td>País: </td>
            <td>
    <asp:DropDownList ID="cboPais" runat="server" Height="25px" Width="275px">
    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Tipo de ruta: </td>
            <td>
        <asp:RadioButtonList ID="rbnTipoRuta" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem Value="NACIONAL">Nacional</asp:ListItem>
        <asp:ListItem Value="INTERNACIONAL" Selected="True">Internacional</asp:ListItem>
        </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                Fecha inicio</td>
            <td>
                <asp:TextBox ID="txtFecIni" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Fecha fin</td>
            <td>
                <asp:TextBox ID="txtFecFin" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
            </td>
        </tr>
    </table>

    <p>
        <asp:GridView ID="dgvMigrantes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="dgvMigrantes_RowDataBound" AllowPaging="True" AllowSorting="True">
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
    <p>&nbsp;</p>
    <p>
    <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
