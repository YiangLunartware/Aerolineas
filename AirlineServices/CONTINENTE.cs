//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlineServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTINENTE
    {
        public CONTINENTE()
        {
            this.PAIS = new HashSet<PAIS>();
        }
    
        public string COD_CONTINENTE { get; set; }
        public string NOM_CONTINENTE { get; set; }
    
        public virtual ICollection<PAIS> PAIS { get; set; }
    }
}
