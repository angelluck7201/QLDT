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
    
    public partial class DonHang : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.CongNoes = new HashSet<CongNo>();
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
    
        private long _id;
    	public long Id 
    	{ 
    		get { return _id; } 
    		set
    		{
    			if (value != _id) {
    				_id = value;
    				 OnPropertyChanged("Id");
    			}
    		} 
    	}
    
        private long _authorId;
    	public long AuthorId 
    	{ 
    		get { return _authorId; } 
    		set
    		{
    			if (value != _authorId) {
    				_authorId = value;
    				 OnPropertyChanged("AuthorId");
    			}
    		} 
    	}
    
        private Nullable<long> _createdDate;
    	public Nullable<long> CreatedDate 
    	{ 
    		get { return _createdDate; } 
    		set
    		{
    			if (value != _createdDate) {
    				_createdDate = value;
    				 OnPropertyChanged("CreatedDate");
    			}
    		} 
    	}
    
        private Nullable<long> _modifiedDate;
    	public Nullable<long> ModifiedDate 
    	{ 
    		get { return _modifiedDate; } 
    		set
    		{
    			if (value != _modifiedDate) {
    				_modifiedDate = value;
    				 OnPropertyChanged("ModifiedDate");
    			}
    		} 
    	}
    
        private bool _isActived;
    	public bool IsActived 
    	{ 
    		get { return _isActived; } 
    		set
    		{
    			if (value != _isActived) {
    				_isActived = value;
    				 OnPropertyChanged("IsActived");
    			}
    		} 
    	}
    
        private string _maDH;
    	public string MaDH 
    	{ 
    		get { return _maDH; } 
    		set
    		{
    			if (value != _maDH) {
    				_maDH = value;
    				 OnPropertyChanged("MaDH");
    			}
    		} 
    	}
    
        private string _loaiDonHang;
    	public string LoaiDonHang 
    	{ 
    		get { return _loaiDonHang; } 
    		set
    		{
    			if (value != _loaiDonHang) {
    				_loaiDonHang = value;
    				 OnPropertyChanged("LoaiDonHang");
    			}
    		} 
    	}
    
        private System.DateTime _ngayLap;
    	public System.DateTime NgayLap 
    	{ 
    		get { return _ngayLap; } 
    		set
    		{
    			if (value != _ngayLap) {
    				_ngayLap = value;
    				 OnPropertyChanged("NgayLap");
    			}
    		} 
    	}
    
        private long _khachHangId;
    	public long KhachHangId 
    	{ 
    		get { return _khachHangId; } 
    		set
    		{
    			if (value != _khachHangId) {
    				_khachHangId = value;
    				 OnPropertyChanged("KhachHangId");
    			}
    		} 
    	}
    
        private string _ten;
    	public string Ten 
    	{ 
    		get { return _ten; } 
    		set
    		{
    			if (value != _ten) {
    				_ten = value;
    				 OnPropertyChanged("Ten");
    			}
    		} 
    	}
    
        private string _dienthoai;
    	public string Dienthoai 
    	{ 
    		get { return _dienthoai; } 
    		set
    		{
    			if (value != _dienthoai) {
    				_dienthoai = value;
    				 OnPropertyChanged("Dienthoai");
    			}
    		} 
    	}
    
        private string _diaChi;
    	public string DiaChi 
    	{ 
    		get { return _diaChi; } 
    		set
    		{
    			if (value != _diaChi) {
    				_diaChi = value;
    				 OnPropertyChanged("DiaChi");
    			}
    		} 
    	}
    
        private long _thanhTien;
    	public long ThanhTien 
    	{ 
    		get { return _thanhTien; } 
    		set
    		{
    			if (value != _thanhTien) {
    				_thanhTien = value;
    				 OnPropertyChanged("ThanhTien");
    			}
    		} 
    	}
    
        private long _thue;
    	public long Thue 
    	{ 
    		get { return _thue; } 
    		set
    		{
    			if (value != _thue) {
    				_thue = value;
    				 OnPropertyChanged("Thue");
    			}
    		} 
    	}
    
        private long _chietKhau;
    	public long ChietKhau 
    	{ 
    		get { return _chietKhau; } 
    		set
    		{
    			if (value != _chietKhau) {
    				_chietKhau = value;
    				 OnPropertyChanged("ChietKhau");
    			}
    		} 
    	}
    
        private long _tongCong;
    	public long TongCong 
    	{ 
    		get { return _tongCong; } 
    		set
    		{
    			if (value != _tongCong) {
    				_tongCong = value;
    				 OnPropertyChanged("TongCong");
    			}
    		} 
    	}
    
        private long _thanhToan;
    	public long ThanhToan 
    	{ 
    		get { return _thanhToan; } 
    		set
    		{
    			if (value != _thanhToan) {
    				_thanhToan = value;
    				 OnPropertyChanged("ThanhToan");
    			}
    		} 
    	}
    
        private string _ghiChu;
    	public string GhiChu 
    	{ 
    		get { return _ghiChu; } 
    		set
    		{
    			if (value != _ghiChu) {
    				_ghiChu = value;
    				 OnPropertyChanged("GhiChu");
    			}
    		} 
    	}
    
        private string _trangThai;
    	public string TrangThai 
    	{ 
    		get { return _trangThai; } 
    		set
    		{
    			if (value != _trangThai) {
    				_trangThai = value;
    				 OnPropertyChanged("TrangThai");
    			}
    		} 
    	}
    
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongNo> CongNoes { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
