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
    
    public partial class TienNghiPhong
    {
        public string MaLoaiPhong { get; set; }
        public string TenTienNghi { get; set; }
        public int SL { get; set; }
    
        public virtual LoaiPhong LoaiPhong { get; set; }
    }
}
