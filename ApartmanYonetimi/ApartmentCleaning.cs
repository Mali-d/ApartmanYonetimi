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
    
    public partial class ApartmentCleaning
    {
        public int Id { get; set; }
        public int ApartmentCleaningTypeId { get; set; }
        public int CreatePersonId { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifyUserName { get; set; }
    
        public virtual ApartmentCleaningType ApartmentCleaningType { get; set; }
        public virtual Person Person { get; set; }
    }
}