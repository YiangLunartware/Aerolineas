<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVisitasPorLugar.aspx.cs" Inherits="ClienteASP.Visitas.ListaVisitasPorLugar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Titulo" runat="server">
    Listado de Visitas por Lugar
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
                    <td>Descripción: </td>
                    <td>
                        <asp:DropDownList ID="cboDescripcion" runat="server" Height="25px" Width="325px">
                        </asp:DropDownList>
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
                <asp:GridView ID="dgvVisitasL" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp">
                    <Columns>
                        <asp:BoundField DataField="NomRuta" HeaderText="Ruta" />
                        <asp:BoundField DataField="NombrePasajero" HeaderText="Nombre de Pasajero" />
                        <asp:BoundField DataField="FechaDespeque" DataFormatString="{0:d}" HeaderText="Fecha Despegue" />
                        <asp:BoundField DataField="FechaLlegada" DataFormatString="{0:d}" HeaderText="Fecha Llegada" />
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
