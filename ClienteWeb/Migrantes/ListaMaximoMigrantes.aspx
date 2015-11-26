<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMaximoMigrantes.aspx.cs" Inherits="ClienteWeb.ListaMaximoMigrantes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Estadística de cantidad de inmigrantes extranjeros
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Parrafo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Contenido" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="mdl-grid">
                <div class="mdl-cell mdl-cell--3-col mdl-cell--1-col-tablet mdl-cell--hide-phone"></div>
                <div class="mdl-cell mdl-cell--2-col ">Seleccionar país</div>
                <div class="mdl-cell mdl-cell--4-col mdl-cell--2-col-phone">
                    <div class="mdl-selectfield">
                        <asp:DropDownList ID="cboPais" runat="server" Height="25px" Width="200px">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="mdl-cell mdl-cell--3-col mdl-cell--1-col-tablet mdl-cell--hide-phone"></div>
                <div class="mdl-cell mdl-cell--3-col mdl-cell--1-col-tablet mdl-cell--hide-phone"></div>
                <div class="mdl-cell mdl-cell--2-col ">Fecha inicio</div>
                <div class="mdl-cell mdl-cell--4-col mdl-cell--2-col-phone">
                    <div class="mdl-textfield mdl-js-textfield">
                        <asp:TextBox ID="txtFecIni" runat="server" CssClass="mdl-textfield__input" TextMode="Date"></asp:TextBox>
                    </div>
                </div>
                <div class="mdl-cell mdl-cell--3-col mdl-cell--1-col-tablet mdl-cell--hide-phone"></div>
                <div class="mdl-cell mdl-cell--3-col mdl-cell--1-col-tablet mdl-cell--hide-phone"></div>
                <div class="mdl-cell mdl-cell--2-col ">Fecha fin</div>
                <div class="mdl-cell mdl-cell--4-col mdl-cell--2-col-phone">
                    <div class="mdl-textfield mdl-js-textfield">
                        <asp:TextBox ID="txtFecFin" runat="server" CssClass="mdl-textfield__input" TextMode="Date"></asp:TextBox>
                    </div>
                </div>
                <div class="mdl-cell mdl-cell--3-col mdl-cell--1-col-tablet mdl-cell--hide-phone"></div>
            </div>
            <div class="mdl-typography--text-center">
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent" OnClick="btnConsultar_Click" />
            </div>
            <asp:Chart ID="chtPaisesOrigen" runat="server" BackColor="Transparent" BorderlineColor="Transparent" Palette="SeaGreen" Width="765px">
                <Series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <p>
                <asp:Label ID="lblError" runat="server" CssClass="mdl-textfield__error"></asp:Label>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
