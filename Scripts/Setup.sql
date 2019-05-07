
-- Function delete constraint
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'DROP_DEFAULT_CONSTRAINT')
DROP PROCEDURE DROP_DEFAULT_CONSTRAINT
GO

CREATE PROCEDURE DROP_DEFAULT_CONSTRAINT
			@table_name nvarchar(256),
			@col_name nvarchar(256)
AS
BEGIN

	declare @schema_name nvarchar(256)
	declare @Command  nvarchar(1000)
	
	set @schema_name = N'dbo'
	
	select @Command = 'ALTER TABLE ' + @schema_name + '.[' + @table_name + '] DROP CONSTRAINT ' + d.name
	 from sys.tables t
	  join sys.default_constraints d on d.parent_object_id = t.object_id
	  join sys.columns c on c.object_id = t.object_id and c.column_id = d.parent_column_id
	 where t.name = @table_name
	  and t.schema_id = schema_id(@schema_name)
	  and c.name = @col_name
	
	print @Command
	execute (@Command)
END
GO

-- Function Add constraint
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ADD_DEFAULT_CONSTRAINT')
DROP PROCEDURE ADD_DEFAULT_CONSTRAINT
GO

CREATE PROCEDURE ADD_DEFAULT_CONSTRAINT
			@table_name nvarchar(256),
			@col_name nvarchar(256),
			@default_value nvarchar(256),
			@data_type nvarchar(256)
AS
BEGIN
BEGIN TRANSACTION
	declare @schema_name nvarchar(256),
			 @Command  nvarchar(1000),
			 @constraint_name nvarchar(256),
			 @parameterDefinition nvarchar(1000)
	
	set @schema_name = N'dbo'
	set @constraint_name = N'DF_'+@table_name+'_'+@col_name

	IF NOT EXISTS (SELECT 1 FROM SYS.default_constraints WHERE NAME = @constraint_name)
	BEGIN	
		exec DROP_DEFAULT_CONSTRAINT @table_name, @col_name

		IF @default_value Is not null
		BEGIN
			set @Command = 'Update ' +@table_name+' Set '+ @col_name+ '='''+ @default_value+ ''' where '+ @col_name + ' IS Null'
			print @Command
			EXECUTE (@Command)
		END

		set @Command = 'ALTER TABLE ' +@table_name+' ALTER COLUMN '+ @col_name+ ' ' +@data_type+ ' NOT NULL'
		print @Command
		EXECUTE (@Command)

		IF @default_value Is not null
		BEGIN
			set @Command = 'ALTER TABLE ' +@table_name+' ADD CONSTRAINT ' +@constraint_name+' DEFAULT('''+@default_value+''') FOR '+ @col_name
			print @Command
			EXECUTE (@Command)
		END
	END
COMMIT
END
GO

-- Function DROP_COLUMN
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'DROP_COLUMN')
DROP PROCEDURE DROP_COLUMN
GO

CREATE PROCEDURE DROP_COLUMN
			@table_name nvarchar(256),
			@col_name nvarchar(256)
AS
BEGIN

	declare @Command  nvarchar(1000)

	IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'DBO' AND TABLE_NAME = @table_name AND COLUMN_NAME = @col_name)
	BEGIN
		EXEC DROP_DEFAULT_CONSTRAINT @table_name, @col_name
		set @Command = 'ALTER TABLE ' +@table_name+' DROP COLUMN '+ @col_name
		print @Command
		EXECUTE (@Command)
	END
	
END
GO


IF OBJECT_ID(N'DonHang_Insert_Update', N'TR') IS NOT NULL
    DROP TRIGGER DonHang_Insert_Update
GO

CREATE TRIGGER DonHang_Insert_Update
ON DonHang
FOR Insert, Update
AS
BEGIN
BEGIN TRANSACTION	
	UPDATE	CTDH
	SET		CTDH.IsActived = I.IsActived
	FROM	ChiTietDonHang CTDH
	JOIN	Inserted I 
		ON	CTDH.DonHangId = I.Id

	UPDATE	CTHH
	SET		CTHH.IsActived = I.IsActived
	FROM	ChiTietDonHang CTDH
	JOIN	Inserted I 
		ON	CTDH.DonHangId = I.Id
	JOIN	ChiTietHangHoa CTHH 
		ON	CTHH.ChiTietDonHangId = CTDH.ID

	UPDATE	CN
	SET		CN.IsActived = I.IsActived
	FROM	CongNo CN
	JOIN	Inserted I 
		ON	CN.DonHangId = I.Id

	UPDATE	TTCN
	SET		TTCN.IsActived = I.IsActived
	FROM	CongNo CN
	JOIN	Inserted I 
		ON	CN.DonHangId = I.Id
	JOIN	ThanhToanCongNo TTCN
		ON	TTCN.CongNoId = CN.Id
COMMIT
END
GO

-- ChiTietDonHang
exec DROP_COLUMN 'ChiTietDonHang', 'LoaiDonHang'
exec ADD_DEFAULT_CONSTRAINT 'ChiTietDonHang', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'ChiTietDonHang', 'DonGia', '0', 'bigint'

-- ChiTietHangHoa
exec ADD_DEFAULT_CONSTRAINT 'ChiTietHangHoa', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'ChiTietHangHoa', 'IMEI', '1', 'nvarchar(50)'

-- CongNo
exec ADD_DEFAULT_CONSTRAINT 'CongNo', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'CongNo', 'No', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'CongNo', 'ThanhToan', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'CongNo', 'KhachHangId', '0', 'bigint'

--DanhMuc
exec ADD_DEFAULT_CONSTRAINT 'DanhMuc', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'DanhMuc', 'Ten', '', 'nvarchar(100)'
exec ADD_DEFAULT_CONSTRAINT 'DanhMuc', 'Loai', '', 'nvarchar(20)'

--DonHang
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'LoaiDonHang', '', 'nvarchar(50)'
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'ThanhTien', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'Thue', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'ChietKhau', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'TongCong', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'ThanhToan', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'DonHang', 'TrangThai', 'Moi', 'nvarchar(10)'

--KhachHang
exec ADD_DEFAULT_CONSTRAINT 'KhachHang', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'KhachHang', 'LoaiKhachHang', '', 'nvarchar(20)'

--KhoHang
exec ADD_DEFAULT_CONSTRAINT 'KhoHang', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'KhoHang', 'DonViTinh', 'Cai', 'nvarchar(20)'
exec ADD_DEFAULT_CONSTRAINT 'KhoHang', 'TenHang', '', 'nvarchar(50)'
exec ADD_DEFAULT_CONSTRAINT 'KhoHang', 'SoLuong', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'KhoHang', 'GiaBan', '0', 'bigint'
exec ADD_DEFAULT_CONSTRAINT 'KhoHang', 'TonLyTuong', '0', 'bigint'

--PhanQuyenNguoiDung
exec ADD_DEFAULT_CONSTRAINT 'PhanQuyenNguoiDung', 'IsActived', '1', 'bit'

--ThanhToanCongNo
exec ADD_DEFAULT_CONSTRAINT 'ThanhToanCongNo', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'ThanhToanCongNo', 'ThanhToan', '0', 'bigint'

--ThuChi
exec ADD_DEFAULT_CONSTRAINT 'ThuChi', 'IsActived', '1', 'bit'
exec ADD_DEFAULT_CONSTRAINT 'ThuChi', 'Loai', '', 'nvarchar(50)'
exec ADD_DEFAULT_CONSTRAINT 'ThuChi', 'SoTien', '0', 'bigint'

--UserAccount
exec ADD_DEFAULT_CONSTRAINT 'UserAccount', 'IsActived', '1', 'bit'

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'DBO' AND TABLE_NAME = 'DonHang' AND COLUMN_NAME = 'LoaiTienTe')
BEGIN	
	ALTER TABLE DBO.DonHang 
	ADD LoaiTienTe NVARCHAR(5) NOT NULL
	CONSTRAINT DF_DonHang_LoaiTienTe DEFAULT('VND') 
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'DBO' AND TABLE_NAME = 'CongNo' AND COLUMN_NAME = 'LoaiTienTe')
BEGIN	
	ALTER TABLE DBO.CongNo 
	ADD LoaiTienTe NVARCHAR(5) NOT NULL
	CONSTRAINT DF_CongNo_LoaiTienTe DEFAULT('VND') 
END

-- Create index on Donhang
CREATE INDEX INDEX_DonHang_NgayLap ON DonHang (NgayLap desc);
CREATE INDEX INDEX_ChiTietDonHang_DonHangId ON ChiTietDonHang (DonHangId);
CREATE INDEX INDEX_ChiTietHangHoa_ChiTietDonHangId ON ChiTietHangHoa (ChiTietDonHangId);

--Update MaDH
UPDATE DonHang
SET MaDH = CONVERT(nvarchar, FORMAT(NgayLap, 'yy'))
	+ CONVERT(nvarchar, FORMAT(NgayLap, 'MM'))
	+ CONVERT(nvarchar, FORMAT(NgayLap, 'dd'))
	+ CONVERT(nvarchar, FORMAT(NgayLap, 'HH'))
	+ CONVERT(nvarchar, FORMAT(NgayLap, 'mm'))
	+ CONVERT(nvarchar, FORMAT(NgayLap, 'ss'))
WHERE MaDH IS NULL

-- Update Hang Ngung Kinh Doanh
UPDATE KhoHang
SET		IsActived = 0
WHERE	LoaiHangId = 45

Update DanhMuc Set IsActived = 0 Where Id = 45 


-- Fix data KhoHang
UPDATE	KhoHang
SET		SoLuong = 0
Where	SoLuong < 0

-- Fix data DonHang

;with UpdateDH as 
(
select	dh.Id,
		dh.TongCong,
		dh.LoaiDonHang,
		sum(ctdh.DonGia * ctdh.SoLuong) TongCongDH
	from DonHang DH
	join ChiTietDonHang ctdh on ctdh.DonHangId = dh.Id  and ctdh.IsActived = 1
	group by dh.Id,
			dh.TongCong,
			dh.LoaiDonHang
	having dh.TongCong <> sum(ctdh.DonGia * ctdh.SoLuong)
)
UPDATE	DH
SET		DH.TongCong = UDP.TongCongDH
FROM	DonHang DH
JOIN	UpdateDH UDP on UDP.Id = DH.Id
	
