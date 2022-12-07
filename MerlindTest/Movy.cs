//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerlindTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movy()
        {
            this.Actors = new HashSet<Actor>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int MovieCategory { get; set; }
        public Nullable<int> CinemaId { get; set; }
        public Nullable<int> ProducerId { get; set; }
        public string Description { get; set; }
    
        public virtual Cinema Cinema { get; set; }
        public virtual Producer Producer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
