﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AirlineServices
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;


public partial class AerolineaEntities : DbContext
{
    public AerolineaEntities()
        : base("name=AerolineaEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<AVION> AVION { get; set; }

    public DbSet<CONTINENTE> CONTINENTE { get; set; }

    public DbSet<LUGAR> LUGAR { get; set; }

    public DbSet<MARCA> MARCA { get; set; }

    public DbSet<PAIS> PAIS { get; set; }

    public DbSet<PASAJERO> PASAJERO { get; set; }

    public DbSet<PILOTO> PILOTO { get; set; }

    public DbSet<RESERVACION> RESERVACION { get; set; }

    public DbSet<RUTA> RUTA { get; set; }

    public DbSet<VUELO> VUELO { get; set; }

    public DbSet<vw_MigrantesPaisLugar> vw_MigrantesPaisLugar { get; set; }

    public DbSet<VW_VISITAS> VW_VISITAS { get; set; }

    public DbSet<sysdiagrams> sysdiagrams { get; set; }


    public virtual ObjectResult<AllVisitas_Result> AllVisitas()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllVisitas_Result>("AllVisitas");
    }


    public virtual ObjectResult<GetVisitas_X_LugarOrigen_Result> GetVisitas_X_LugarOrigen(string lUGAR_ORIGEN, Nullable<System.DateTime> fECHA_INICIAL, Nullable<System.DateTime> fECHA_FINAL)
    {

        var lUGAR_ORIGENParameter = lUGAR_ORIGEN != null ?
            new ObjectParameter("LUGAR_ORIGEN", lUGAR_ORIGEN) :
            new ObjectParameter("LUGAR_ORIGEN", typeof(string));


        var fECHA_INICIALParameter = fECHA_INICIAL.HasValue ?
            new ObjectParameter("FECHA_INICIAL", fECHA_INICIAL) :
            new ObjectParameter("FECHA_INICIAL", typeof(System.DateTime));


        var fECHA_FINALParameter = fECHA_FINAL.HasValue ?
            new ObjectParameter("FECHA_FINAL", fECHA_FINAL) :
            new ObjectParameter("FECHA_FINAL", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetVisitas_X_LugarOrigen_Result>("GetVisitas_X_LugarOrigen", lUGAR_ORIGENParameter, fECHA_INICIALParameter, fECHA_FINALParameter);
    }


    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }


    public virtual int sp_upgraddiagrams()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }


    public virtual ObjectResult<usp_CantidaDeVuelosFechas_Result> usp_CantidaDeVuelosFechas(Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_CantidaDeVuelosFechas_Result>("usp_CantidaDeVuelosFechas", feciniParameter, fecfinParameter);
    }


    public virtual ObjectResult<usp_ConsultaMaximoMigrantesNacionalidad_Result> usp_ConsultaMaximoMigrantesNacionalidad(string paisNacimiento)
    {

        var paisNacimientoParameter = paisNacimiento != null ?
            new ObjectParameter("paisNacimiento", paisNacimiento) :
            new ObjectParameter("paisNacimiento", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultaMaximoMigrantesNacionalidad_Result>("usp_ConsultaMaximoMigrantesNacionalidad", paisNacimientoParameter);
    }


    public virtual ObjectResult<USP_GetVisitas_X_Fecha_Result> USP_GetVisitas_X_Fecha(Nullable<System.DateTime> fECHA_INICIAL, Nullable<System.DateTime> fECHA_FINAL)
    {

        var fECHA_INICIALParameter = fECHA_INICIAL.HasValue ?
            new ObjectParameter("FECHA_INICIAL", fECHA_INICIAL) :
            new ObjectParameter("FECHA_INICIAL", typeof(System.DateTime));


        var fECHA_FINALParameter = fECHA_FINAL.HasValue ?
            new ObjectParameter("FECHA_FINAL", fECHA_FINAL) :
            new ObjectParameter("FECHA_FINAL", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetVisitas_X_Fecha_Result>("USP_GetVisitas_X_Fecha", fECHA_INICIALParameter, fECHA_FINALParameter);
    }


    public virtual ObjectResult<Nullable<int>> usp_ListaAvionCapacidad()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_ListaAvionCapacidad");
    }


    public virtual ObjectResult<usp_ListaVueloPorDescripcion_Result> usp_ListaVueloPorDescripcion(string descrip)
    {

        var descripParameter = descrip != null ?
            new ObjectParameter("descrip", descrip) :
            new ObjectParameter("descrip", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaVueloPorDescripcion_Result>("usp_ListaVueloPorDescripcion", descripParameter);
    }


    public virtual ObjectResult<usp_ListaVueloPorEstadoFechas_Result> usp_ListaVueloPorEstadoFechas(Nullable<bool> estado, Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var estadoParameter = estado.HasValue ?
            new ObjectParameter("estado", estado) :
            new ObjectParameter("estado", typeof(bool));


        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaVueloPorEstadoFechas_Result>("usp_ListaVueloPorEstadoFechas", estadoParameter, feciniParameter, fecfinParameter);
    }


    public virtual ObjectResult<usp_ListaVueloPorFecha_Result> usp_ListaVueloPorFecha(Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaVueloPorFecha_Result>("usp_ListaVueloPorFecha", feciniParameter, fecfinParameter);
    }


    public virtual ObjectResult<usp_ListaVueloPorPrecioFechas_Result> usp_ListaVueloPorPrecioFechas(Nullable<decimal> precio, Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var precioParameter = precio.HasValue ?
            new ObjectParameter("precio", precio) :
            new ObjectParameter("precio", typeof(decimal));


        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaVueloPorPrecioFechas_Result>("usp_ListaVueloPorPrecioFechas", precioParameter, feciniParameter, fecfinParameter);
    }


    public virtual ObjectResult<Nullable<decimal>> usp_ListaVueloPrecios()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("usp_ListaVueloPrecios");
    }


    public virtual ObjectResult<usp_ListaVuelosPorCapacidadFechas_Result> usp_ListaVuelosPorCapacidadFechas(Nullable<int> capacidad, Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var capacidadParameter = capacidad.HasValue ?
            new ObjectParameter("capacidad", capacidad) :
            new ObjectParameter("capacidad", typeof(int));


        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaVuelosPorCapacidadFechas_Result>("usp_ListaVuelosPorCapacidadFechas", capacidadParameter, feciniParameter, fecfinParameter);
    }


    public virtual ObjectResult<string> usp_ListaVueloXDescripcion()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_ListaVueloXDescripcion");
    }


    public virtual ObjectResult<string> USP_NOMBRE_RUTA()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("USP_NOMBRE_RUTA");
    }


    public virtual int USP_RANKING_VISITA(string fECHA_LLEGADA)
    {

        var fECHA_LLEGADAParameter = fECHA_LLEGADA != null ?
            new ObjectParameter("FECHA_LLEGADA", fECHA_LLEGADA) :
            new ObjectParameter("FECHA_LLEGADA", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_RANKING_VISITA", fECHA_LLEGADAParameter);
    }


    public virtual ObjectResult<USP_RANKING_VISITAS_Result> USP_RANKING_VISITAS(Nullable<System.DateTime> fECHA_LLEGADA)
    {

        var fECHA_LLEGADAParameter = fECHA_LLEGADA.HasValue ?
            new ObjectParameter("FECHA_LLEGADA", fECHA_LLEGADA) :
            new ObjectParameter("FECHA_LLEGADA", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_RANKING_VISITAS_Result>("USP_RANKING_VISITAS", fECHA_LLEGADAParameter);
    }


    public virtual ObjectResult<usp_RankingDestinosPeruanosDemandaFechas_Result> usp_RankingDestinosPeruanosDemandaFechas(string nom_des, Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var nom_desParameter = nom_des != null ?
            new ObjectParameter("nom_des", nom_des) :
            new ObjectParameter("nom_des", typeof(string));


        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_RankingDestinosPeruanosDemandaFechas_Result>("usp_RankingDestinosPeruanosDemandaFechas", nom_desParameter, feciniParameter, fecfinParameter);
    }


    public virtual ObjectResult<usp_RankingPaisDemandaFechas_Result> usp_RankingPaisDemandaFechas(string descrip, Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var descripParameter = descrip != null ?
            new ObjectParameter("descrip", descrip) :
            new ObjectParameter("descrip", typeof(string));


        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_RankingPaisDemandaFechas_Result>("usp_RankingPaisDemandaFechas", descripParameter, feciniParameter, fecfinParameter);
    }


    public virtual ObjectResult<usp_RankingVuelosPrecioFechas_Result> usp_RankingVuelosPrecioFechas(string nom_ruta, Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
    {

        var nom_rutaParameter = nom_ruta != null ?
            new ObjectParameter("nom_ruta", nom_ruta) :
            new ObjectParameter("nom_ruta", typeof(string));


        var feciniParameter = fecini.HasValue ?
            new ObjectParameter("fecini", fecini) :
            new ObjectParameter("fecini", typeof(System.DateTime));


        var fecfinParameter = fecfin.HasValue ?
            new ObjectParameter("fecfin", fecfin) :
            new ObjectParameter("fecfin", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_RankingVuelosPrecioFechas_Result>("usp_RankingVuelosPrecioFechas", nom_rutaParameter, feciniParameter, fecfinParameter);
    }

}

}

