//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SemesterProject_WPF_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class addressTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public addressTable()
        {
            this.customer = new HashSet<customer>();
        }
    
        public int address_id { get; set; }
        public string address_city { get; set; }
        public string address_street { get; set; }
        public int address_home_no { get; set; }
        public Nullable<int> address_flat_no { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customer { get; set; }
    }
}
