//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GII.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }
    
        public int CountryId { get; set; }
        public string Name { get; set; }
        public Nullable<int> CapitalCityId { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
        public virtual City City { get; set; }
    }
}
