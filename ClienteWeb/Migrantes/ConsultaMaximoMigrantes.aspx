<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaMaximoMigrantes.aspx.cs" Inherits="ClienteWeb.Consulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Consulta del País Destino con Mayor Cantidad de Migrantes</h2>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <p><asp:DropDownList ID="cboPais" runat="server" AutoPostBack="True" Height="25px" OnSelectedIndexChanged="cboPais_SelectedIndexChanged" Width="275px">
            </asp:DropDownList></p>
            <p></p>
            <asp:DetailsView ID="dtvPais" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                <EditRowStyle BackColor="#999999" />
                <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:DetailsView>
            <p><asp:Label ID="lblError" runat="server"></asp:Label></p>
            <p>
                &nbsp;</p>
        </ContentTemplate>
    </asp:UpdatePanel>
    
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
