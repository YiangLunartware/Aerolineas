<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ClienteWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1, .auto-style2, .auto-style3, .auto-style4 {
            width: 25% !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Aerolineas Service
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Bienvenid@s. En esta página encontrarán el detalle de todos los servicios que brindamos
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Parrafo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Contenido" runat="server">

    <table style="background-color:white; max-width:100%; left:0px" class="mdl-shadow--2dp">
        <tr>
            <th rowspan="2" colspan="2" style="border-bottom: 1px solid #DDD">Métodos</th>
            <th colspan="4" style="border-bottom: 1px solid #DDD">Servcios</th>
        </tr>
        <tr style="border-bottom: 1px solid #DDD">
            <th style="border-bottom: 1px solid #DDD; " class="auto-style1">Vuelos</th>
            <th style="border-bottom: 1px solid #DDD; " class="auto-style2">Visitas</th>
            <th style="border-bottom: 1px solid #DDD; " class="auto-style3">Historial Pasajero</th>
            <th style="border-bottom: 1px solid #DDD; " class="auto-style4">Migrantes</th>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">1</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaVueloPorDescripcion</td>
            <td class="auto-style2">GetVisitas_X_Fecha</td>
            <td class="auto-style3">GetAllHistorialPasajero</td>
            <td class="auto-style4">ConsultaMaximoMigrantesNacionalidad</td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de lo vuelos segun la descripcion que se elija</td>
            <td class="auto-style2">En este método puedo obtener las reservaciones de vuelos que ya se realizaron durante estos rangos de fechas, es decir los visitantes que vienen de otros países extranjeros  y su destino es  cualquier parte del Perú.</td>
            <td class="auto-style3">En este método obtengo todos los pasajeros que ya hayan viajado en nuestra aerolínea sin tomar en cuenta el lugar donde realizó el vuelo.</td>
            <td class="auto-style4">Muestra una el Países destino al que las personas de cierta nacionalidad han migrado más y la cantidad de dichos vuelos</td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">Descripcion</td>
            <td class="auto-style2">Fecha Inicial y Fecha Final</td>
            <td class="auto-style3">No aplica</td>
            <td class="auto-style4">Codigo Pais</td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Código de vuelo, Descripcion de vuelo, Fecha de despegue, Fecha de llegada, Estado Vuelo, Precio de Vuelo</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2">Nombre del Pasajero, Nombre de la Ruta, FechaDespeque y FechaLlegada</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3">Nombre del Pasajero, Lugar de origen, Lugar de destino, FechaDespeque, FechaLlegada, DNI, email, telefono</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4">CodPais, NomPais, Idioma, Moneda y CantidadVuelos</td>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">2</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaVueloPorEstado</td>
            <td class="auto-style2">GetVisitas_X_LugarOrigen</td>
            <td class="auto-style3">Get_HistorialPasajero_X_Nombre_Pasajero</td>
            <td class="auto-style4">ListaMigrantesInternacionales</td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de lo vuelos según la estado que se elija durante un rango de fechas</td>
            <td class="auto-style2">En este método puedo obtener las reservaciones de vuelos que ya se realizaron durante estos rangos de fechas por un específico lugar de origen, es decir visitantes de un respectivo país extranjero que llegaron al Perú.</td>
            <td class="auto-style3">En este método obtengo todos los pasajeros que ya hayan viajado en nuestra aerolínea por nombre del pasajero en un determinado rango de  fecha.</td>
            <td class="auto-style4">Obtiene una lista de los migrantes internaciones que han llegado a cierto país y devuelve los datos del migrante con el país</td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">Estado, Fecha Inicial y Fecha Final</td>
            <td class="auto-style2">Lugar Origen, Fecha Inicial y Fecha Final</td>
            <td class="auto-style3">Nombre del Pasajero, Fecha Inicial, Fecha Final</td>
            <td class="auto-style4">CodPaisNacimiento, Fecha Inicial y Fecha Final</td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Código de vuelo, Descripcion de vuelo, Fecha de despegue, Fecha de llegada, Estado Vuelo y Precio de Vuelo</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2">Nombre del Pasajero, Nombre de la Ruta, FechaDespeque y FechaLlegada</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3">Lugar de origen, Lugar de destino, FechaDespeque, FechaLlegada, DNI, email, telefono</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4">Lista de Migrantes: Codigo, Nombre, Apellido, Dni, Genero, NumTelefono, Email, FecNac, PaisDestino</td>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">3</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaVueloPorFecha</td>
            <td class="auto-style2">AllVisitas</td>
            <td class="auto-style3">Get_HistorialPasajero_X_DNI</td>
            <td class="auto-style4">ListaMigrantesNacionales</td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de lo vuelos según un rango de fechas</td>
            <td class="auto-style2">En este método puedo obtener las reservaciones de vuelos que ya se realizaron, es decir todos los  visitantes que llegaron al Perú.</td>
            <td class="auto-style3">En este método obtengo todos los pasajeros que ya hayan viajado en nuestra aerolínea por su DNI en un determinado rango de  fecha.</td>
            <td class="auto-style4">Obtiene una lista de los migrantes que han realizado viajes nacionales en cierto país y devuelve los datos del migrante con el país.</td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">Fecha Inicial y Fecha Final</td>
            <td class="auto-style2">No aplica</td>
            <td class="auto-style3">DNI, Fecha Inicial y Fecha Final</td>
            <td class="auto-style4">codPaisNacimiento, Fecha Inicial y Fecha Final</td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Código de vuelo, Descripcion de vuelo, Fecha de despegue, Fecha de llegada, Estado Vuelo, Precio de Vuelo</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2">Nombre del Pasajero, Nombre de la Ruta</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3">Nombre del Pasajero, Lugar de origen, Lugar de destino, FechaDespeque, FechaLlegada, DNI, email, telefono</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4">Lista de Migrantes: Codigo, Nombre, Apellido, Dni, Genero, NumTelefono, Email, FecNac, LugarDestino</td>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">4</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaVueloPorPrecio</td>
            <td class="auto-style2">RankingVisitasDestinosPeruanos</td>
            <td class="auto-style3">Get_Cantidad_Vuelos_X_Pasajero</td>
            <td class="auto-style4">ListaMigrantesPaisesFechas</td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de lo vuelos según un rango de fechas</td>
            <td class="auto-style2">En este método puedo obtener la cantidad de reservaciones de vuelos que ya se realizaron por determinado lugar de destino, es decir el ranking de visitas que se realizaron por destino peruano en una  determinada fecha.</td>
            <td class="auto-style3">En este método obtenemos la cantidad de vuelos por pasajero en un rango de fecha.</td>
            <td class="auto-style4">Muestra un listado de migrantes entre ciertos países y ciertas fechas</td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">Precio, Fecha Inicial y Fecha Final</td>
            <td class="auto-style2">Fecha de LLegada</td>
            <td class="auto-style3">Nombre del Pasajero, Fecha Inicial y Fecha Final</td>
            <td class="auto-style4">codPaisOrigen, codPaisDestino, Fecha Inicial y Fecha Final</td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Código de vuelo, Descripcion de vuelo, Fecha de despegue, Fecha de llegada, Precio de Vuelo</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2">Cantidad de Visitas de Destinos Peruanos, Nombre del Lugar (destino peruano), Código del Destino</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3">Cantidad de Vuelos del Pasajero</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4">Lista de Migrantes: Codigo, Nombre, Apellido, Dni, Genero, NumTelefono, Email, FecNac</td>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">5</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaVuelosPorCapacidad</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4">ListaPaises</td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de lo vuelos según la capacidad que tiene el avión en un rango de fechas</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4">Lista el código y nombre de todos los países registrados</td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">Capacidad, Fecha Inicial y Fecha Final</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4">no aplica</td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Código de vuelo, Descripcion de vuelo, Fecha de despegue, Fecha de llegada, Capacidad</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4">Lista de PaisBE: codigo y nombre</td>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">6</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaCantidadVuelosFechas</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4">ListaPaisesMigrantes</td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de lo vuelos según la capacidad que tiene el avión en un rango de fechas</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4">Muestra una lista de Países destino a los que han migrado las personas de cierta nacionalidad y la cantidad de dichos vuelos</td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">Fecha Inicial y Fecha Fina</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4">codPais, Fecha Inicial y Fecha Fina</td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Código de vuelo, Descripcion de vuelo, Fecha de despegue, Fecha de llegada y Demanda</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4">Lista de PaisBE: CodPais, NomPais, Idioma, Moneda y CantidadVuelos</td>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">7</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaVueloXDescipcion</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de la descripción de vuelos</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">No Aplica</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Descripción de vuelo</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4"></td>
        </tr>
        <tr>
            <th rowspan="4" style="border-bottom: 1px solid #DDD; border-right: 1px solid #DDD">8</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaPrecios</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de precios de vuelos</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">No Aplica</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th style="border-bottom: 1px solid #DDD">Output</th>
            <td style="border-bottom: 1px solid #DDD" class="auto-style1">Precio de vuelo</td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style2"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style3"></td>
            <td style="border-bottom: 1px solid #DDD" class="auto-style4"></td>
        </tr>
        <tr>
            <th rowspan="4" style="border-right: 1px solid #DDD">9</th>
            <th>Nombre</th>
            <td class="auto-style1">ListaAvionCapacidad</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th>Descripción</th>
            <td class="auto-style1">Muestra una lista de la capacidad de cada avión</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th>Inputs</th>
            <td class="auto-style1">No aplica</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <th>Output</th>
            <td class="auto-style1">Capacidad de vuelo</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
    </table>
    <p>&nbsp;</p>
</asp:Content>
