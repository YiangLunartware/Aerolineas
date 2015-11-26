<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVisitas.aspx.cs" Inherits="ClienteWeb.ListaVisitas" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Titulo" runat="server">
    Lista de Visitas
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
                    <td></td>
                    <td>
                        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" CssClass="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent" />
                    </td>
                </tr>
            </table>

            <p>
                <asp:GridView ID="dgvVisitas" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp">
                    <Columns>
                        <asp:BoundField DataField="NomRuta" HeaderText="Ruta" />
                        <asp:BoundField DataField="NombrePasajero" HeaderText="Nombre de Pasajero" />
                        <asp:BoundField DataField="FechaDespeque" DataFormatString="{0:d}" HeaderText="Fecha Despegue" />
                        <asp:BoundField DataField="FechaLlegada" DataFormatString="{0:d}" HeaderText="Fecha Llegada" />
                    </Columns>
                </asp:GridView>
            </p>
            <p>
                &nbsp;
            </p>
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
