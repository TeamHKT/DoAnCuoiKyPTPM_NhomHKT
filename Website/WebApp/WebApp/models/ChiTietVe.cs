//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietVe
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<int> IdNguoiDung { get; set; }
        public Nullable<int> IdVe { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual Ve Ve { get; set; }
    }
}
