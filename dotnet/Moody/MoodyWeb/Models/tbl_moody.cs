//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoodyWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_moody
    {
        public string participant_id { get; set; }
        public int event_id { get; set; }
        public Nullable<int> vote { get; set; }
        public string comment { get; set; }
        public System.DateTime time { get; set; }
        public int id { get; set; }
    }
}