<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVisitas.aspx.cs" Inherits="ClienteWeb.ListaVisitas" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Lista de Visitas</h2>
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
            <td></td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
            </td>
        </tr>
    </table>

    <p>
        <asp:GridView ID="dgvVisitas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                    <asp:BoundField DataField="NomRuta" HeaderText="Ruta" />
                    <asp:BoundField DataField="NombrePasajero" HeaderText="Nombre de Pasajero" />
                    <asp:BoundField DataField="FechaDespeque" DataFormatString="{0:d}" HeaderText="Fecha Despegue" />
                    <asp:BoundField DataField="FechaLlegada" DataFormatString="{0:d}" HeaderText="Fecha Llegada" />
            </Columns>
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
            <p>
                &nbsp;</p>
    <p>
    <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
