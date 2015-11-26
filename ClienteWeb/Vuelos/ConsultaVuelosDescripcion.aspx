<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaVuelosDescripcion.aspx.cs" Inherits="ClienteWeb.ConsultaVuelosDescripcion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Titulo" runat="server">
    Consulta de Vuelos por Descripcion
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
                    <td>Descripcion: </td>
                    <td>
                        <asp:DropDownList ID="cboDescripcion" runat="server" Height="25px" Width="325px" OnSelectedIndexChanged="cboDescripcion_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <br />

            <p>
                <asp:GridView ID="dgvVuelosD" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp">
                    <Columns>
                        <asp:BoundField DataField="CodVuelo" HeaderText="Código" />
                        <asp:BoundField DataField="DescVuelo" HeaderText="Descripción" />
                        <asp:BoundField DataField="PrecioVuelo" HeaderText="Precio" />
                        <asp:BoundField DataField="FecDespegue" DataFormatString="{0:d}" HeaderText="Fecha Despegue" />
                        <asp:BoundField DataField="FecLlegada" DataFormatString="{0:d}" HeaderText="Fecha Llegada" />
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
