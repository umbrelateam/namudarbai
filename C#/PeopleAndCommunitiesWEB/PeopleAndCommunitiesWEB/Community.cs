//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeopleAndCommunitiesWEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Community
    {
        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public Nullable<int> manager_id { get; set; }
        public Nullable<int> city_id { get; set; }
        public string regNo { get; set; }
        public Nullable<decimal> priceForSquareMeter { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
