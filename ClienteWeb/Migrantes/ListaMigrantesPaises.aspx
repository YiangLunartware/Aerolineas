<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMigrantesPaises.aspx.cs" Inherits="ClienteASP.Migrantes.ListaMigrantesPaisFechas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Titulo" runat="server">
    Listado de Migrantes según País de origen a País destino entre Fechas
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
                    <td>País origen</td>
                    <td>
                        <asp:DropDownList ID="cboPaisOrigen" runat="server">
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
                        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" CssClass="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent" />
                    </td>
                </tr>
            </table>
            <p></p>

            <asp:GridView ID="dgvMigrantes" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp" OnPageIndexChanging="dgvMigrantes_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="CodMigrante" HeaderText="Codigo" />
                    <asp:BoundField DataField="NomMigrante" HeaderText="Nombres" />
                    <asp:BoundField DataField="ApeMigrante" HeaderText="Apellidos" />
                    <asp:BoundField DataField="Dni" HeaderText="DNI" />
                    <asp:BoundField DataField="Genero" HeaderText="Genero" />
                    <asp:BoundField DataField="NumTelefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="FecNac" HeaderText="Fec. Nacimiento" DataFormatString="{0:MM/dd/yyyy}" />
                </Columns>
            </asp:GridView>

            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

