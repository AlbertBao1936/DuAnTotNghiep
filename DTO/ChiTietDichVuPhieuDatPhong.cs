//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDichVuPhieuDatPhong
    {
        public string MaPDP { get; set; }
        public string MaPhong { get; set; }
        public string MaDV { get; set; }
        public int SoLuongDV { get; set; }
        public double TongGiaTri { get; set; }
    
        public virtual DichVu DichVu { get; set; }
        public virtual ChiTietPhieuDatPhong ChiTietPhieuDatPhong { get; set; }
    }
}
