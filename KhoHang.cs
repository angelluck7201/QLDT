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
    
    public partial class KhoHang : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoHang()
        {
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
    
        private long _loaiHangId;
    	public long LoaiHangId 
    	{ 
    		get { return _loaiHangId; } 
    		set
    		{
    			if (value != _loaiHangId) {
    				_loaiHangId = value;
    				 OnPropertyChanged("LoaiHangId");
    			}
    		} 
    	}
    
        private string _tenHang;
    	public string TenHang 
    	{ 
    		get { return _tenHang; } 
    		set
    		{
    			if (value != _tenHang) {
    				_tenHang = value;
    				 OnPropertyChanged("TenHang");
    			}
    		} 
    	}
    
        private string _donViTinh;
    	public string DonViTinh 
    	{ 
    		get { return _donViTinh; } 
    		set
    		{
    			if (value != _donViTinh) {
    				_donViTinh = value;
    				 OnPropertyChanged("DonViTinh");
    			}
    		} 
    	}
    
        private long _soLuong;
    	public long SoLuong 
    	{ 
    		get { return _soLuong; } 
    		set
    		{
    			if (value != _soLuong) {
    				_soLuong = value;
    				 OnPropertyChanged("SoLuong");
    			}
    		} 
    	}
    
        private long _giaBan;
    	public long GiaBan 
    	{ 
    		get { return _giaBan; } 
    		set
    		{
    			if (value != _giaBan) {
    				_giaBan = value;
    				 OnPropertyChanged("GiaBan");
    			}
    		} 
    	}
    
        private long _tonLyTuong;
    	public long TonLyTuong 
    	{ 
    		get { return _tonLyTuong; } 
    		set
    		{
    			if (value != _tonLyTuong) {
    				_tonLyTuong = value;
    				 OnPropertyChanged("TonLyTuong");
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
    
    
        public virtual DanhMuc DanhMuc { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
