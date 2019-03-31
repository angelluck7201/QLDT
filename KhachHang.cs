//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDT
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.ThanhToanCongNoes = new HashSet<ThanhToanCongNo>();
            this.CongNoes = new HashSet<CongNo>();
            this.DonHangs = new HashSet<DonHang>();
        }
    
        public long Id { get; set; }
        public long AuthorId { get; set; }
        public Nullable<long> CreatedDate { get; set; }
        public Nullable<long> ModifiedDate { get; set; }
        public Nullable<bool> IsActived { get; set; }
        public string Ten { get; set; }
        public string LoaiKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string Dienthoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string MaSoThue { get; set; }
        public string STK { get; set; }
        public string NganHang { get; set; }
        public string GhiChu { get; set; }
        public string MaKH { get; set; }
    
        public virtual UserAccount UserAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToanCongNo> ThanhToanCongNoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongNo> CongNoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}