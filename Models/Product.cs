//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Market1._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Nullable<double> price { get; set; }
        public string image { get; set; }
        public string description { get; set; }

       
        public Nullable<int> category_id { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
