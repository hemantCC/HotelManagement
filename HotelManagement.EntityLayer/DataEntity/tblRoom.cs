//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.EntityLayer.DataEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRoom()
        {
            this.tblBookings = new HashSet<tblBooking>();
        }
    
        public int RoomId { get; set; }
        public Nullable<int> HotelId { get; set; }
        public string Name { get; set; }
        public Nullable<int> RoomCategoryId { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBooking> tblBookings { get; set; }
        public virtual tblHotel tblHotel { get; set; }
        public virtual tblRoomCategory tblRoomCategory { get; set; }
    }
}
