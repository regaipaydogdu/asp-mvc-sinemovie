//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sinemovie.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class comments
    {
        public int id { get; set; }
        public string username { get; set; }
        public int movie_id { get; set; }
        public System.DateTime date { get; set; }
        public string comment { get; set; }
    
        public virtual movies movies { get; set; }
    }
}
