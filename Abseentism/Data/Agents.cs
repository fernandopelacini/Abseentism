//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abseentism.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agents()
        {
            this.Abseentisms = new HashSet<Abseentisms>();
        }
    
        public int id { get; set; }
        public string avayaId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Nullable<int> teamId { get; set; }
        public Nullable<int> countryId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abseentisms> Abseentisms { get; set; }
        public virtual Teams Teams { get; set; }
        public virtual Teams Countries { get; set; }
    }
}