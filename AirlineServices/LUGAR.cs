
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
    using System.Collections.Generic;
    
public partial class LUGAR
{

    public LUGAR()
    {

        this.RUTA = new HashSet<RUTA>();

        this.RUTA1 = new HashSet<RUTA>();

    }


    public string COD_LUGAR { get; set; }

    public string NOMBRE_LUGAR { get; set; }

    public Nullable<double> LATITUD { get; set; }

    public Nullable<double> LONGITUD { get; set; }

    public string NOM_AEROPUERTO { get; set; }

    public string COD_PAIS { get; set; }



    public virtual ICollection<RUTA> RUTA { get; set; }

    public virtual PAIS PAIS { get; set; }

    public virtual ICollection<RUTA> RUTA1 { get; set; }

}

}
