<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVueloPorEstado.aspx.cs" Inherits="ClienteWeb.ListaVueloPorEstado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Titulo" runat="server">
    Listado de Vuelos por Estado
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Subtitulo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Parrafo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
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
                    <td>Fecha inicio</td>
                    <td>
                        <asp:TextBox ID="txtFecIni" runat="server" TextMode="Date" CssClass="mdl-textfield__input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Fecha fin</td>
                    <td>
                        <asp:TextBox ID="txtFecFin" runat="server" TextMode="Date" CssClass="mdl-textfield__input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" CssClass="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent" />
                    </td>
                </tr>
            </table>

            <p>
                <asp:GridView ID="dgvVueloE" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" OnRowDataBound="dgvVueloE_RowDataBound" CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp">
                    <Columns>
                        <asp:BoundField DataField="CodVuelo" HeaderText="Código" />
                        <asp:BoundField DataField="DescVuelo" HeaderText="Descripción" />
                        <asp:BoundField DataField="FecDespegue" DataFormatString="{0:d}" HeaderText="Fecha Despegue" />
                        <asp:BoundField DataField="FecLlegada" DataFormatString="{0:d}" HeaderText="Fecha Llegada" />
                        <asp:BoundField DataField="EstadoVuelo" HeaderText="Estado" />
                    </Columns>
                </asp:GridView>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

