<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVueloPorEstado.aspx.cs" Inherits="ClienteWeb.ListaVueloPorEstado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Listado de Vuelos por Estado</h2>
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
            <td>Estado: </td>
            <td>
        <asp:RadioButtonList ID="rbnEstado" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem Value="true">Disponible</asp:ListItem>
        <asp:ListItem Value="false" Selected="True">No Disponible</asp:ListItem>
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
        <asp:GridView ID="dgvVueloE" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" OnRowDataBound="dgvVueloE_RowDataBound">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns> 
                <asp:BoundField DataField="CodVuelo" HeaderText="Código" /> 
                <asp:BoundField DataField="DescVuelo" HeaderText="Descripción" />
                <asp:BoundField DataField="FecDespegue" DataFormatString="{0:d}" HeaderText="Fecha Despegue" />
                <asp:BoundField DataField="FecLlegada" DataFormatString="{0:d}" HeaderText="Fecha Llegada" />
                <asp:BoundField DataField="EstadoVuelo" HeaderText="Estado"/>
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
    <p>&nbsp;</p>
    <p>
    <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>

