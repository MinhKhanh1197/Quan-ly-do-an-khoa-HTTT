//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQLDAKhoaHTTT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DANGKYDOAN
    {
        public int MaDK { get; set; }
        public string TrangThai { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<int> MaNhom { get; set; }
        public Nullable<int> MaGV { get; set; }
    
        public virtual CHITIETDKDOAN CHITIETDKDOAN { get; set; }
        public virtual GIANGVIEN GIANGVIEN { get; set; }
        public virtual NHOM NHOM { get; set; }
    }
}
