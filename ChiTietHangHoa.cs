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
    
    public partial class ChiTietHangHoa : BaseModel
    {
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
    
        private long _chiTietDonHangId;
    	public long ChiTietDonHangId 
    	{ 
    		get { return _chiTietDonHangId; } 
    		set
    		{
    			if (value != _chiTietDonHangId) {
    				_chiTietDonHangId = value;
    				 OnPropertyChanged("ChiTietDonHangId");
    			}
    		} 
    	}
    
        private string _iMEI;
    	public string IMEI 
    	{ 
    		get { return _iMEI; } 
    		set
    		{
    			if (value != _iMEI) {
    				_iMEI = value;
    				 OnPropertyChanged("IMEI");
    			}
    		} 
    	}
    
    
        public virtual UserAccount UserAccount { get; set; }
        public virtual ChiTietDonHang ChiTietDonHang { get; set; }
    }
}
