<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMigrantesTipoRutaPais.aspx.cs" Inherits="ClienteWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Titulo" runat="server">
    Listado de Migrantes Extranjeros y Nacionales según el Tipo de Ruta
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Subtitulo" runat="server">
    Si los viajes son a nivel Internacional, se mostrará de a qué país viajaron<br />
    Si los viajes son a nivel nacional, se mostrará a qué lugar viajaron en el mismo país
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Parrafo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
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
                <asp:GridView ID="dgvMigrantesNacionales" runat="server" AllowPaging="True" AllowSorting="True" CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp" AutoGenerateColumns="False" OnPageIndexChanging="dgvMigrantesNacionales_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="LugarDestino" HeaderText="Lugar Destino" />
                        <asp:BoundField DataField="CodMigrante" HeaderText="Código" />
                        <asp:BoundField DataField="NomMigrante" HeaderText="Nombres" />
                        <asp:BoundField DataField="ApeMigrante" HeaderText="Apellidos" />
                        <asp:BoundField DataField="Dni" HeaderText="DNI" />
                        <asp:BoundField DataField="Genero" HeaderText="Genero" />
                        <asp:BoundField DataField="NumTelefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="FecNac" HeaderText="Fec. Nacimiento" DataFormatString="{0:MM/dd/yyyy}" />
                    </Columns>
                </asp:GridView>
            </p>

            <p>
                <asp:GridView ID="dgvMigrantesInternac" runat="server" AllowPaging="True" AllowSorting="True" CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp" AutoGenerateColumns="False" OnPageIndexChanging="dgvMigrantesInternac_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="PaisDestino" HeaderText="Pais Destino" />
                        <asp:BoundField DataField="CodMigrante" HeaderText="Código" />
                        <asp:BoundField DataField="NomMigrante" HeaderText="Nombres" />
                        <asp:BoundField DataField="ApeMigrante" HeaderText="Apellidos" />
                        <asp:BoundField DataField="Dni" HeaderText="DNI" />
                        <asp:BoundField DataField="Genero" HeaderText="Genero" />
                        <asp:BoundField DataField="NumTelefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="FecNac" HeaderText="Fec. Nacimiento" DataFormatString="{0:MM/dd/yyyy}" />
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
