//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerce_V1.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Nullable<int> StateId { get; set; }
    
        public virtual tbl_State tbl_State { get; set; }
    }
}
