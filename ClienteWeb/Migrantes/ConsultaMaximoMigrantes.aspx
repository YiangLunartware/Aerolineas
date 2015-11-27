<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaMaximoMigrantes.aspx.cs" Inherits="ClienteASP.Migrantes.ConsultaMaximoMigrantes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Titulo" runat="server">
    Consulta del País Destino con Mayor Cantidad de Migrantes
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Subtitulo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Parrafo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <p>
                <asp:DropDownList ID="cboPais" runat="server" AutoPostBack="True" Height="25px" OnSelectedIndexChanged="cboPais_SelectedIndexChanged" Width="275px">
                </asp:DropDownList>
            </p>
            <p></p>
            <asp:DetailsView ID="dtvPais" runat="server" Height="50px" Width="125px" CssClass="mdl-data-table mdl-js-data-table mdl-data-table--selectable mdl-shadow--2dp">
            </asp:DetailsView>
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label></p>
            <p>
                &nbsp;
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>

    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
</asp:Content>
