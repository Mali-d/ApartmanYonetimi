//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmanYonetimi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Revenues
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Revenues()
        {
            this.RenevuesCollecting_RS = new HashSet<RenevuesCollecting_RS>();
        }
    
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public int SiteId { get; set; }
        public int RevenuesTypeId { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Money { get; set; }
        public bool IsRender { get; set; }
        public Nullable<byte> CollectingStatus { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifyUserName { get; set; }
    
        public virtual Apartment Apartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RenevuesCollecting_RS> RenevuesCollecting_RS { get; set; }
        public virtual RevenuesType RevenuesType { get; set; }
        public virtual Site Site { get; set; }
    }
}
