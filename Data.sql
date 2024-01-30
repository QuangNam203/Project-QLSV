use [72DCTM22]

------------------------------------- --------------TABLE SINH VIEN ------------------------------------------------
create sequence stt -- stt tự động
	start with 1
	increment by 1

create sequence msv -- msv tự động
	start with 1001
	increment by 1

create sequence lasts -- last tự động
	start with 10
	increment by 1

drop sequence msv

create table SinhVien
(
	STT			int,
	tenlop		nvarchar(50),
	maSV		nvarchar(50),
	ho			nvarchar(10),
	tendem		nvarchar(20),
	ten			nvarchar(10),
	ngaysinh	date,
	gioitinh	tinyint,
	SĐT			nvarchar(50),
	Email		nvarchar(50),
	Addres		nvarchar(50),
	CMND		int,
	tencha		nvarchar(20),
	tenme		nvarchar(20),
	dantoc		nvarchar(10),
	tennganh	nvarchar(50),
	statuss		tinyint,
	khoa		nvarchar(10)
	primary key(maSV,CMND)
)



----------------------------------tạo procedure để lấy all sinh viên
CREATE PROCEDURE SelectAllSinhVien 
	@keys nvarchar(50)
AS begin
	select 
		tenlop,
		maSV,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten,
		convert(varchar(10),ngaysinh,103) as ngaysinh , -- định dạng lại ngày-tháng-năm
		case
			when gioitinh = 1 then 'nam'
			else N'nữ'
		end as gioitinh,
		SĐT,Email,Addres,CMND,tencha,tenme,dantoc,tennganh
	from SinhVien
	where
		LOWER (ho) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (tendem) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (ten) like'%' +LOWER(trim(@keys))+'%'
		or SĐT like'%' +LOWER(trim(@keys))+'%'
		or Email like'%' +LOWER(trim(@keys))+'%'
	end
-- END PROCE SelectAll
exec SelectAllSinhVien '';
drop PROCEDURE SelectAllSinhVien

----------------------------proce AddSinhVien
CREATE PROCEDURE AddSinhVien
(	
	@tenlop		nvarchar(50),
	@malop		nvarchar(10),
	@ho			nvarchar(50),
	@tendem		nvarchar(50),
	@ten		nvarchar(50),
	@ngaysinh	date,
	@gioitinh	tinyint,
	@SĐT		nvarchar(50),
	@Email		nvarchar(50),
	@Addres		nvarchar(50),
	@CMND		nvarchar(50),
	@tencha		nvarchar(20),
	@tenme		nvarchar(20),
	@dantoc		nvarchar(10),
	@tennganh	nvarchar(50),
	@khoa		nvarchar(10)
	)
AS begin
	insert into SinhVien(STT,tenlop,maSV,ho,tendem,ten,ngaysinh,gioitinh,SĐT,Email,Addres,CMND,tencha,tenme,dantoc,tennganh,khoa)
	values(CAST(next value for stt as char(30)),
	@tenlop,@malop + CAST(next value for msv as char(30)),
	@ho,@tendem,@ten,
	@ngaysinh,
	@gioitinh,
	@SĐT,
	@Email,
	@Addres,@CMND,@tencha,@tenme,@dantoc,@tennganh,@khoa)
	-- KT xem ADD có thành công không
	IF @@ROWCOUNT > 0 begin RETURN 1 END
	else begin return 0 end;
	end

exec AddSinhVien '72DCTM22','72DCTM',N'Tạ',N'Quang',N'Nam','2003-02-02',1,'0366467777','nam@gmail.com','HA Noi',214567891,'Nguyen van A','Le thi A','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM22','72DCTM',N'Phạm',N'Văn',N'Quân','2001-01-06',1,'0366464444','Quan@gmail.com','HA Noi',12765432,'Nguyen van B','Le thi B','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM22','72DCTM',N'Phạm',N'Minh',N'Sơn','2003-08-03',1,'0366468888','son@gmail.com','HA Noi',12123456,'Nguyen van C','Le thi C','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM22','72DCTM',N'Phạm',N'Hồng',N'Sơn','2003-01-13',1,'0366469999','hongson@gmail.com','HA Noi',12123451,'Nguyen van D','Le thi D','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM22','72DCTM',N'Dư',N'Hoàng',N'Thái','2003-01-03',1,'0366463333','thai@gmail.com','HA Noi',12123421,'Nguyen van E','Le thi E','kinh',N'TRUYỀN THÔNG MANG','72';

exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'A','2003-01-01',1,'0366460001','A@gmail.com','HA Noi',0123450001,'Nguyen van A','Le thi A','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'B','2003-01-02',1,'0366460002','B@gmail.com','HA Noi',0123450002,'Nguyen van B','Le thi B','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'C','2003-01-03',1,'0366460003','C@gmail.com','HA Noi',0123450003,'Nguyen van C','Le thi C','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'D','2003-01-04',1,'0366460004','D@gmail.com','HA Noi',0123450004,'Nguyen van D','Le thi D','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'E','2003-01-05',1,'0366460005','E@gmail.com','HA Noi',0123450005,'Nguyen van E','Le thi E','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'G','2003-01-06',1,'0366460006','G@gmail.com','HA Noi',0123450006,'Nguyen van G','Le thi G','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'H','2003-01-07',1,'0366460007','H@gmail.com','HA Noi',0123450007,'Nguyen van H','Le thi H','kinh',N'TRUYỀN THÔNG MANG','72';
exec AddSinhVien '72DCTM21','72DCTM',N'Nguyễn',N'Văn',N'I','2003-01-08',1,'0366460008','I@gmail.com','HA Noi',0123450008,'Nguyen van I','Le thi I','kinh',N'TRUYỀN THÔNG MANG','72';

exec AddSinhVien '72DCKT21','72DCKT',N'Lê',N'Thị',N'A','2003-01-01',0,'0366460009','A@gmail.com','HA Noi',0123450009,'Nguyen van A','Le thi A',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT21','72DCKT',N'Lê',N'Thị',N'B','2003-01-02',0,'0366460010','B@gmail.com','HA Noi',0123450010,'Nguyen van B','Le thi B',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT21','72DCKT',N'Lê',N'Thị',N'C','2003-01-03',0,'0366460011','C@gmail.com','HA Noi',0123450011,'Nguyen van C','Le thi C',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT21','72DCKT',N'Lê',N'Thị',N'D','2003-01-04',0,'0366460012','D@gmail.com','HA Noi',0123450012,'Nguyen van D','Le thi D',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT21','72DCKT',N'Lê',N'Thị',N'E','2003-01-05',0,'0366460013','E@gmail.com','HA Noi',0123450013,'Nguyen van E','Le thi E',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT21','72DCKT',N'Lê',N'Thị',N'G','2003-01-06',0,'0366460014','G@gmail.com','HA Noi',0123450014,'Nguyen van G','Le thi G',N'kinh','KINH TẾ','72';

exec AddSinhVien '72DCKT22','72DCKT',N'Lê',N'Thị',N'A','2003-01-01',0,'0366460015','A@gmail.com','HA Noi',0123450015,'Nguyen van A','Le thi A',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT22','72DCKT',N'Lê',N'Thị',N'B','2003-01-02',0,'0366460016','B@gmail.com','HA Noi',0123450016,'Nguyen van B','Le thi B',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT22','72DCKT',N'Lê',N'Thị',N'C','2003-01-03',0,'0366460017','C@gmail.com','HA Noi',0123450017,'Nguyen van C','Le thi C',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT22','72DCKT',N'Lê',N'Thị',N'D','2003-01-04',0,'0366460018','D@gmail.com','HA Noi',0123450018,'Nguyen van D','Le thi D',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT22','72DCKT',N'Lê',N'Thị',N'E','2003-01-05',0,'0366460019','E@gmail.com','HA Noi',0123450019,'Nguyen van E','Le thi E',N'kinh','KINH TẾ','72';
exec AddSinhVien '72DCKT22','72DCKT',N'Nguyễn',N'Văn',N'G','2003-01-06',1,'0366460020','G@gmail.com','HA Noi',0123450020,'Nguyen van G','Le thi G','kinh',N'KINH TẾ','72';

exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'A','2003-01-01',1,'0366460021','A@gmail.com','HA Noi',0123450020,'Nguyen van A','Le thi A','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'B','2003-01-02',1,'0366460022','B@gmail.com','HA Noi',0123450021,'Nguyen van B','Le thi B','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'C','2003-01-03',1,'0366460023','C@gmail.com','HA Noi',0123450022,'Nguyen van C','Le thi C','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'D','2003-01-04',1,'0366460024','D@gmail.com','HA Noi',0123450023,'Nguyen van D','Le thi D','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'E','2003-01-05',1,'0366460025','E@gmail.com','HA Noi',0123450024,'Nguyen van E','Le thi E','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'G','2003-01-06',1,'0366460026','G@gmail.com','HA Noi',0123450025,'Nguyen van G','Le thi G','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'H','2003-01-07',1,'0366460027','H@gmail.com','HA Noi',0123450026,'Nguyen van H','Le thi H','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO21','72DCCO',N'Nguyễn',N'Văn',N'I','2003-01-08',1,'0366460028','I@gmail.com','HA Noi',0123450027,'Nguyen van I','Le thi I','kinh',N'CÔNG NGHỆ OTO','72';

exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'A','2003-01-01',1,'0366460028','A@gmail.com','HA Noi',0123450028,'Nguyen van A','Le thi A','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'B','2003-01-02',1,'0366460029','B@gmail.com','HA Noi',0123450029,'Nguyen van B','Le thi B','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'C','2003-01-03',1,'0366460030','C@gmail.com','HA Noi',0366460030,'Nguyen van C','Le thi C','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'D','2003-01-04',1,'0366460031','D@gmail.com','HA Noi',0366460031,'Nguyen van D','Le thi D','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'E','2003-01-05',1,'0366460032','E@gmail.com','HA Noi',0366460032,'Nguyen van E','Le thi E','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'G','2003-01-06',1,'0366460033','G@gmail.com','HA Noi',0366460033,'Nguyen van G','Le thi G','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'H','2003-01-07',1,'0366460034','H@gmail.com','HA Noi',0366460034,'Nguyen van H','Le thi H','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCCO22','72DCCO',N'Nguyễn',N'Văn',N'I','2003-01-08',1,'0366460035','I@gmail.com','HA Noi',0366460035,'Nguyen van I','Le thi I','kinh',N'CÔNG NGHỆ OTO','72';

exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'A','2003-01-01',1,'0366460035','A@gmail.com','HA Noi',0366460035,'Nguyen van A','Le thi A','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'B','2003-01-02',1,'0366460036','B@gmail.com','HA Noi',0366460036,'Nguyen van B','Le thi B','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'C','2003-01-03',1,'0366460037','C@gmail.com','HA Noi',0366460037,'Nguyen van C','Le thi C','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'D','2003-01-04',1,'0366460038','D@gmail.com','HA Noi',0366460038,'Nguyen van D','Le thi D','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'E','2003-01-05',1,'0366460039','E@gmail.com','HA Noi',0366460039,'Nguyen van E','Le thi E','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'G','2003-01-06',1,'0366460040','G@gmail.com','HA Noi',0366460040,'Nguyen van G','Le thi G','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'H','2003-01-07',1,'0366460041','H@gmail.com','HA Noi',0366460041,'Nguyen van H','Le thi H','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT22','72DCTT',N'Nguyễn',N'Văn',N'I','2003-01-08',1,'0366460042','I@gmail.com','HA Noi',0366460042,'Nguyen van I','Le thi I','kinh',N'CÔNG NGHỆ OTO','72';

exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'A','2003-01-01',1,'0366460043','A@gmail.com','HA Noi',0366460043,'Nguyen van A','Le thi A','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'B','2003-01-02',1,'0366460044','B@gmail.com','HA Noi',0366460044,'Nguyen van B','Le thi B','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'C','2003-01-03',1,'0366460045','C@gmail.com','HA Noi',0366460045,'Nguyen van C','Le thi C','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'D','2003-01-04',1,'0366460046','D@gmail.com','HA Noi',0366460046,'Nguyen van D','Le thi D','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'E','2003-01-05',1,'0366460047','E@gmail.com','HA Noi',0366460047,'Nguyen van E','Le thi E','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'G','2003-01-06',1,'0366460048','G@gmail.com','HA Noi',0366460048,'Nguyen van G','Le thi G','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'H','2003-01-07',1,'0366460049','H@gmail.com','HA Noi',0366460049,'Nguyen van H','Le thi H','kinh',N'CÔNG NGHỆ OTO','72';
exec AddSinhVien '72DCTT21','72DCTT',N'Nguyễn',N'Văn',N'I','2003-01-08',1,'0366460050','I@gmail.com','HA Noi',0366460050,'Nguyen van I','Le thi I','kinh',N'CÔNG NGHỆ OTO','72';

-------------------END PROCE ADD------------------------


------------------------------proce update sinh vien
CREATE PROCEDURE UpdateSinhVien
(
	@maSV		nvarchar(50),
	@ho			nvarchar(50),
	@tendem		nvarchar(50),
	@ten		nvarchar(50),
	@ngaysinh	date,
	@gioitinh	tinyint,
	@SĐT		nvarchar(50),
	@Email		nvarchar(50),
	@Addres		nvarchar(50),
	@CMND		nvarchar(50),
	@tencha		nvarchar(20),
	@tenme		nvarchar(20),
	@dantoc		nvarchar(10),
	@tennganh	nvarchar(50))
AS BEGIN
	Update SinhVien
	set
		ho		=	@ho,
		tendem	=	@tendem, 
		ten		=	@ten,
		ngaysinh=	@ngaysinh, 
		gioitinh=	@gioitinh,
		SĐT		=	@SĐT,
		Email	=	@Email, 
		Addres	=	@Addres,
		CMND	=	@CMND,
		tencha  =	@tencha,
		tenme   =	@tenme,
		dantoc  =	@dantoc,
		tennganh	=	@tennganh
	Where maSV = @maSV;
	IF @@ROWCOUNT > 0 begin RETURN 1 END
	else begin return 0 end;
	END
-----END-------------------

 -- tạo PROCE đê Select thông tin của 1 SV
 create PROCEDURE SelectSV
	@maSV varchar(50)
AS Begin
	select maSV, ho,tendem,ten,convert(varchar(10),ngaysinh,103) as ngaysinh,
		gioitinh,
		SĐT,Email,Addres,CMND,tencha,tenme,dantoc,tennganh
	from SinhVien
	where maSV = @maSV
	END
--END PROCE in TT 1 sv


---create PROCE Delete
CREATE PROCEDURE DeleteSV
	@maSV nvarchar(50)
AS Begin
	Delete SinhVien 
	where maSV = @maSV
	END

------------------------------------- --------------TABLE lOP ------------------------------------------------
create table DSlop
(
	maLop		nvarchar(50),
	tenlop		nvarchar(50),
	maxsize		nvarchar(50),
	tenNganh	nvarchar(50)
	primary key(tenlop)
)
insert into DSlop
values('72DCTM','72DCTM21','50',N'TRUYỀN THÔNG MẠNG')
insert into DSlop
values('72DCTM','72DCTM22','40',N'TRUYỀN THÔNG MẠNG')
insert into DSlop
values('72DCTT','72DCTT21','50',N'CÔNG NGHỆ THÔNG TIN')
insert into DSlop
values('72DCTT','72DCTT22','50',N'CÔNG NGHỆ THÔNG TIN')
insert into DSlop
values('72DCKT','72DCKT21','40',N'KINH TẾ')
insert into DSlop
values('72DCKT','72DCKT22','40',N'KINH TẾ')
insert into DSlop
values('72DCCO','72DCCO21','30',N'CÔNG NGHỆ OTO')
insert into DSlop
values('72DCCO','72DCCO22','30',N'CÔNG NGHỆ OTO')

-----------------------create table lop
create table lop
(
	maLop		nvarchar(50),
	tenlop		nvarchar(50),
	tenNganh	nvarchar(50)
	primary key(tenlop)
)
insert into Lop
values('72DCTM','72DCTM21',N'TRUYỀN THÔNG MẠNG')
insert into Lop
values('72DCTM','72DCTM22',N'TRUYỀN THÔNG MẠNG')
insert into Lop
values('72DCTT','72DCTT21',N'CÔNG NGHỆ THÔNG TIN')
insert into Lop
values('72DCTT','72DCTT22',N'CÔNG NGHỆ THÔNG TIN')
insert into Lop
values('72DCKT','72DCKT21',N'KINH TẾ')
insert into Lop
values('72DCKT','72DCKT22',N'KINH TẾ')
insert into Lop
values('72DCCO','72DCCO21',N'CÔNG NGHỆ OTO')
insert into Lop
values('72DCCO','72DCCO22',N'CÔNG NGHỆ OTO')

----------------------------Create procedure SelectDSlop
Create procedure SelectDSlop
	@lop  nvarchar(10),
	@keys nvarchar(10)
as begin
	select t1.tenlop,t1.maSV,
			case 
				when LEN(t1.tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
				CONCAT(t1.ho,' ',t1.tendem,' ',t1.ten) -- thì nối họ +  tên đệm + tên 
				else CONCAT(t1.ho, ' ',t1.ten) --  ngược lại
			end as hoten,
		t1.ngaysinh,
		case
				when t1.gioitinh = 1 then 'nam'
				else N'nữ'
			end as gioitinh,
			t1.SĐT,t1.Email
	from sinhvien as t1
	inner join lop as t2
	on t1.tenlop = t2.tenlop
	where 
		(LOWER (t1.ho) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (t1.tendem) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (t1.ten) like'%' +LOWER(trim(@keys))+'%'
		or t1.SĐT like'%' +LOWER(trim(@keys))+'%'
		or t1.Email like'%' +LOWER(trim(@keys))+'%') AND (t1.tenlop = @lop)
end
---END----------------

-------------------------------create procedure AddKhoaLop
create procedure AddKhoaLop	
	@tenlop		nvarchar(50),
	@malop		nvarchar(50),
	@maxsize	nvarchar(50),
	@tenNganh	nvarchar(50)
as begin
	insert into DSlop(malop,tenlop,maxsize,tenNganh)
	values(@malop,@tenlop,@maxsize,@tenNganh);
	insert into lop(malop,tenlop,tenNganh)
	values(@malop,@tenlop,@tenNganh)
	end
---END-------------------------

---------------------------- tạo procedure để lấy sinh viên
CREATE PROCEDURE LopSV 
AS begin
	select 
		tenlop,
		maSV,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten,
		convert(varchar(10),ngaysinh,103) as ngaysinh , -- định dạng lại ngày-tháng-năm
		case
			when gioitinh = 1 then 'nam'
			else N'nữ'
		end as gioitinh,
		SĐT,Email,tenNganh
	from SinhVien	
end

-------------------------CREATE PROCEDURE counts
CREATE PROCEDURE counts
	@keys nvarchar(50)
As begin
	select count(tenlop) as number
	from sinhvien
	where tenlop  =@keys
	end

------------------create procedure AllLop
create procedure AllLop
	@keys  nvarchar(50)
as begin
	select * from lop 
	where LOWER (tenlop) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (maLop) like'%' +LOWER(trim(@keys))+'%'
end

---- chuyển lớp -----
create procedure chuyenlop
	@maSV	nvarchar(50),
	@lop	nvarchar(10)
as begin
	update sinhvien
	set
		tenlop = @lop
	where maSV = @maSV
	end

------- DELETE Lop---------
create procedure Deletelop
	@lop	nvarchar(10)
as begin
	delete lop
	where tenlop = @lop;
	delete DSlop
	where tenlop = @lop;
END

------------------------------------- --------------TABLE status ----------------------------------------------
create table statuss
(
	maSV		nvarchar(50),
	statuss		tinyint
	primary key(statuss,maSV)
)

drop table statuss

 ---- Create procedure QLstatus
Create procedure QLstatus
	@keys	nvarchar(50)
as begin
	select t1.tenlop,t1.maSV,
			case 
				when LEN(t1.tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
				CONCAT(t1.ho,' ',t1.tendem,' ',t1.ten) -- thì nối họ +  tên đệm + tên 
				else CONCAT(t1.ho, ' ',t1.ten) --  ngược lại
			end as hoten,
		t1.ngaysinh,
		case
				when t1.gioitinh = 1 then 'nam'
				else N'nữ'
			end as gioitinh,
			t1.SĐT,t1.Email,
			case
			when t2.statuss = 1 then N'Bảo Lưu'
			else N'Đã Rút'
		end as status
	from sinhvien as t1
	inner join statuss as t2
	on t1.maSV = t2.maSV
	where t1.maSV = @keys
end
drop procedure QLstatus

--------------- craete update trang thai
Create procedure Upstatus
	@maSV		nvarchar(50),
	@statuss	tinyint
as begin
	update sinhvien
	set	statuss = @statuss
	where maSV = @maSV
end

-------------------------tạo procedure để lấy all status
	@statuss tinyint,
	@keys nvarchar(50)
AS begin
	select 
		tenlop,
		maSV,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten,
		convert(varchar(10),ngaysinh,103) as ngaysinh , -- định dạng lại ngày-tháng-năm
		case
			when gioitinh = 1 then 'nam'
			else N'nữ'
		end as gioitinh,
		SĐT,Email,
		case
			when statuss = 1 then N'Đã Rút'
			else N'Bảo Lưu'
		end as status
	from SinhVien
	where
		(LOWER (ho) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (tendem) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (ten) like'%' +LOWER(trim(@keys))+'%'
		or SĐT like'%' +LOWER(trim(@keys))+'%'
		or Email like'%' +LOWER(trim(@keys))+'%') AND (statuss = @statuss)
	end
-------END-----------------

-------------------------create procedure checkSV
create procedure checkSV
	@keys  nvarchar(50)
as begin
	select 
		maSV,tenlop,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten
	from sinhvien
	where
		(LOWER (ho) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (tendem) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (ten) like'%' +LOWER(trim(@keys))+'%'
		or SĐT like'%' +LOWER(trim(@keys))+'%'
		or Email like'%' +LOWER(trim(@keys))+'%'
		or maSV like'%' +LOWER(trim(@keys))+'%')
END
-- END---

create PROCEDURE SelectStatus
	@maSV varchar(50)
AS Begin
	select maSV,tenlop,ho,tendem,ten,statuss
	from SinhVien
	where maSV = @maSV
END

select * from statuss

CREATE PROCEDURE UpdateStatus
	@maSV	nvarchar(10),
	@status tinyint
AS begin
	update SinhVien
	set	statuss = @status
	where maSV = @maSV
	END

CREATE PROCEDURE DeleteStatus
	@maSV nvarchar(50)
AS Begin
	Delete SinhVien 
	where maSV = @maSV
	END
------------------------------------- --------------TABLE Evaluate ----------------------------------------------
create table Evaluate
(	
	tenlop		nvarchar(50),
	maSV		nvarchar(50),
	ho			nvarchar(10),
	tendem		nvarchar(20),
	ten			nvarchar(10),
	TK1			nvarchar(10),
	TK2			nvarchar(10),
	TK			nvarchar(10),
	loai		nvarchar(10),
	namhoc		nvarchar(10)
)
insert into Evaluate
values('72DCTM22','72DCTT2001','nguyen','van','A','7','8','7.5',N'khá','2022-2023')
insert into Evaluate
values('72DCTM22','72DCTT2002','nguyen','van','B','9','9','9',N'Xuất Sắc','2022-2023')
insert into Evaluate
values('72DCTM22','72DCTT2003','nguyen','van','C','4','4','4',N'Yếu','2022-2023')

	-- Create Pro Điểm
CREATE PROCEDURE SelectAllDiem -- tạo procedure 
	@keys nvarchar(50)
AS begin
	select
		tenlop,
		maSV,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten,
		TK1,TK2,TK,loai,namhoc
	from Evaluate
	where
		LOWER (ho) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (maSV) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (tendem) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (ten) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (loai) like'%' +LOWER(trim(@keys))+'%'
END

-- tạo ADD Evaluate
CREATE PROCEDURE ADDEvaluate
	@tenlop		nvarchar(50),
	@maSV		nvarchar(50),
	@ho			nvarchar(50),
	@tendem		nvarchar(50),
	@ten		nvarchar(50)
AS BEGIN
	INSERT INTO Evaluate(tenlop,maSV,ho,tendem,ten)
	values
	(@tenlop,@maSV,@ho,@tendem,@ten)
	IF @@ROWCOUNT > 0 begin RETURN 1 END
	else begin return 0 end
END

-- END ADDEvaluate

---create PROCE Delete
CREATE PROCEDURE DeleteSVD
	@maSV nvarchar(50)
AS Begin
	Delete Evaluate 
	where maSV = @maSV
	END

-- Create Pro Diem
CREATE PROCEDURE UpdateDIem
	@maSV  nvarchar(50),
	@TK1	nvarchar(10),
	@TK2	nvarchar(10),
	@TK		nvarchar(10),
	@loai	nvarchar(10)
AS BEGIN
	Update Evaluate
	set
		TK1  =	@TK1,
		TK2	=	@TK2,
		TK	= @TK,
		loai = @loai
	Where maSV = @maSV;
	IF @@ROWCOUNT > 0 begin RETURN 1 END
	else begin return 0 end;
	END

-- END

-- tạo PROCE đê Select thông tin của 1 SV
 create PROCEDURE SelectDiem
	@maSV varchar(50)
AS Begin
	select maSV, ho,tendem,ten,TK1,TK2,loai
	from Evaluate
	where maSV = @maSV
	END
------------------------------------- --------------TABLE Nganh ----------------------------------------------
create table Nganh
(
	MaNganh		nvarchar(50),
	tenNganh	nvarchar(50)
	primary key(MaNganh)
)

drop table Nganh

insert into Nganh
values('DCTT',N'CÔNG NGHỆ THÔNG TIN')
insert into Nganh
values('DCKT',N'KINH TẾ')
insert into Nganh
values('DCCO',N'CÔNG NGHỆ OTO')
insert into Nganh
values('DCTM',N'TRUYỀN THÔNG MẠNG')
insert into Nganh
values('DCLG',N'LOGISTICS')
insert into Nganh
values('DCKD',N'KINH DOANH THƯƠNG MẠI')


------------------------------------- --------------TABLE HocBong ----------------------------------------------
create table HocBong
(
	tenlop		nvarchar(50),
	maSV		nvarchar(50),
	ho			nvarchar(50),
	tendem		nvarchar(50),
	ten			nvarchar(50),
	loai		tinyint,
	namHoc		nvarchar(50),
	ghichu		nvarchar(50)
	primary key(maSV)
)

create table LoaiHocBong
(
	loai tinyint,
)
insert into LoaiHocBong
values(1)
insert into LoaiHocBong
values(2)
insert into LoaiHocBong
values(0)

------------------------------PROCEDURE SelectAllHocBong 
CREATE PROCEDURE SelectAllHocBong -- tạo procedure 
	@keys nvarchar(50)
AS begin
	select 
		tenlop,maSV,
		case 
				when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
				CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
				else CONCAT(ho, ' ',ten) --  ngược lại
			end as hoten,
		case
				when loai = 1 then N'Toàn Phần'
				when loai = 2 then N'80%' 
				else N'50%'
			end as loai,
		namhoc,ghichu
	from HocBong
	where
			LOWER (loai) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (maSV) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (tendem) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (ten) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (loai) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (tenlop) like'%' +LOWER(trim(@keys))+'%'
	END
-----------END----------------------------

---------------------------PROCEDURE CheckSVHB
create PROCEDURE CheckSVHB
	@maSV varchar(50)
AS Begin
	select tenlop,maSV,ho,tendem,ten
	from sinhvien 
	where maSV = @maSV;
END
drop PROCEDURE CheckSV

create PROCEDURE ADDHocBong
	@tenlop		nvarchar(50),
	@maSV		nvarchar(50),
	@ho			nvarchar(50),
	@tendem		nvarchar(50),
	@ten		nvarchar(50),
	@loai		tinyint,
	@namhoc		nvarchar(50),
	@ghichu		nvarchar(50)
AS Begin
	insert into HocBong
	values(@tenlop,@maSV,@ho,@tendem,@ten,@loai,@namhoc,@ghichu)
END
----END----------------------

--------------------------------PROCEDURE UpdateHocBong
create PROCEDURE UpdateHocBong
	@maSV		nvarchar(10),
	@loai		tinyint
AS begin
	update HocBong
	set
		loai = @loai
	where maSV = @maSV
	END
----END-----------------------------

-------------------------------PROCEDURE DeleteHocBong
create PROCEDURE DeleteHocBong
	@maSV		nvarchar(10)
AS begin
	Delete HocBong
	where maSV =  @maSV
	END
----END---------------------------------------------

------------------------------------- --------------TABLE TaiKhoan ----------------------------------------------
create table TaiKhoan
(
	users	nvarchar(10),
	pass	nvarchar(10),
	gmail	nvarchar(50),
	SDT		nvarchar(10)
	primary key(users,pass)
)
insert into Taikhoan
values('admin','admin','utt','1')
select * from SinhVien
select * from Taikhoan

drop table TaiKhoan
----CREATE UpdateTK
CREATE PROCEDURE UpdateTK
	@users	nvarchar(10),
	@pass	nvarchar(10)
AS begin
	update Taikhoan
	set
		users	= @users,
		pass	= @pass
	where users	= @users
	END

--- Create lấy ACC
CREATE PROCEDURE ForgotACC
	@users	nvarchar(10),
	@gmail	nvarchar(50),
	@SDT	nvarchar(10)
AS begin
		Select	users,pass
		from TaiKhoan
		where users = @users AND gmail = @gmail AND SDT = @SDT
	END
drop PROCEDURE ForgotACC
----create Add Taikhoan
CREATE PROCEDURE AddTK
	@users	nvarchar(10),
	@pass	nvarchar(10),
	@gmail	nvarchar(50),
	@SDT	nvarchar(10)
AS Begin
	insert into	TaiKhoan
	values(@users,@pass,@gmail,@SDT)
	END

exec ForgotACC 'Admin','utt','1';
--- create show acc
create PROCEDURE ShowACC
	@maSV varchar(50)
AS Begin
	select maSV, ho,tendem,ten,convert(varchar(10),ngaysinh,103) as ngaysinh,
		gioitinh,
		SĐT,Email,Addres,CMND,tennganh
	from SinhVien
	where maSV = @maSV
	END
------------------------------------- --------------TABLE khoahoc ----------------------------------------------
create table khoahoc
(
	khoa	nvarchar(10),
	firstyear	nvarchar(10),
	lastyear	nvarchar(10)
	primary key(khoa)
)

select maSV,firstyear,lastyear from sinhvien,khoahoc where maSV = '72DCTM1021' AND sinhvien.khoa = khoahoc.khoa 
select * from sinhvien
insert into khoahoc
values('71','2021','2022')
insert into khoahoc
values('72','2022','2023')
insert into khoahoc
values('73','2023','2024')

drop table khoahoc
------------------------------------- --------------TABLE khenthuong ----------------------------------------------

create table khenthuong
(
	tenlop		nvarchar(50),
	maSV		nvarchar(50),
	ho			nvarchar(50),
	tendem		nvarchar(50),
	ten			nvarchar(50),
	loai		tinyint,
	namhoc		nvarchar(50),
	ghichu		nvarchar(50)
	primary key(maSV)
)
drop table khenthuong
create table loai
(
	Loai	tinyint,
	thuong	nvarchar(50)
)
insert into loai
values(1,'1.000.000')
insert into loai
values(0,'500.000')


-----------------------PROCEDURE ADDKhen
create PROCEDURE ADDKhen
	@tenlop		nvarchar(50),
	@maSV		nvarchar(50),
	@ho			nvarchar(50),
	@tendem		nvarchar(50),
	@ten		nvarchar(50),
	@loai		tinyint,
	@namhoc		nvarchar(50),
	@ghichu		nvarchar(50)
AS Begin
	insert into khenthuong
	values(@tenlop,@maSV,@ho,@tendem,@ten,@loai,@namhoc,@ghichu)
END
----END------------------------

drop PROCEDURE SelectKhen
-------------------------- Select Khen ----------
create PROCEDURE SelectKhen
	@keys nvarchar(50)
AS begin
	select
		tenlop,maSV,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten,
		case 
			when loai = 1 then '1.000.000' 
			else '500.000' 
		end as loai,
		namhoc,ghichu
		from khenthuong
		where
			LOWER (ho) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (tendem) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (ten) like'%' +LOWER(trim(@keys))+'%'
			or LOWER (namhoc) like'%' +LOWER(trim(@keys))+'%'	
		end
--------END------------------------

---------------------------PROCEDURE UpdateKhen
create PROCEDURE UpdateKhen
	@maSV		nvarchar(10),
	@loai		tinyint
AS begin
	update khenthuong
	set
		loai = @loai
	where maSV = @maSV
	END
-----END---------------------

create PROCEDURE DeleteKhen
	@maSV		nvarchar(10)
AS begin
	Delete khenthuong
	where maSV =  @maSV
	END
drop PROCEDURE DeleteKhen
------------------------------------- --------------TABLE KyLuat ----------------------------------------------
create table KyLuat
(
	tenlop		nvarchar(50),
	maSV		nvarchar(50),
	ho			nvarchar(50),
	tendem		nvarchar(50),
	ten			nvarchar(50),
	number		nvarchar(50),
	namhoc		nvarchar(10),
	ghichu		nvarchar(50)
	primary key(maSV)
)

-------------------------------- Create Pro SelectAllKyluat
CREATE PROCEDURE SelectAllKyluat -- tạo procedure 
	@keys nvarchar(50)
AS begin
	select
		tenlop,
		maSV,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten,
		number,namhoc,ghichu
	from Kyluat
	where
		LOWER (ho) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (maSV) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (tendem) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (ten) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (number) like'%' +LOWER(trim(@keys))+'%'
		or LOWER (tenlop) like'%' +LOWER(trim(@keys))+'%'
	END
	----------------------END-------------------

---------------------------proce insert Ky Luat
CREATE PROCEDURE AddKyluat	
	@tenlop		nvarchar(50),
	@maSV		nvarchar(50),
	@ho			nvarchar(50),
	@tendem		nvarchar(50),
	@ten		nvarchar(50),
	@namhoc		nvarchar(10),
	@ghichu		nvarchar(50)
AS begin
	insert into KyLuat(tenlop,maSV,ho,tendem,ten,number,namhoc,ghichu)
	values(
	@tenlop,@maSV,
	@ho,@tendem,@ten,
	'1',
	@namhoc,
	@ghichu
	)
	-- KT xem ADD có thành công không
	IF @@ROWCOUNT > 0 begin RETURN 1 END
	else begin return 0 end;
	end
---------------------END--------------------------------

-----------------------------proce update Ky Luật
CREATE PROCEDURE UpdateKyLuat
	@maSV		nvarchar(50),
	@number		nvarchar(50),
	@ghichu		nvarchar(50)
AS BEGIN
	Update KyLuat
	set
		number  =	@number,
		ghichu	=	@ghichu
	Where maSV = @maSV;
	IF @@ROWCOUNT > 0 begin RETURN 1 END
	else begin return 0 end;
	END
----------------END Updata Ky Luat

------------------------------tạo PROCE đê Select thông tin của 1 SV
 create PROCEDURE SelectSVKL
	@maSV varchar(50)
AS Begin
	select maSV, ho,tendem,ten,number,namhoc,ghichu
	from KyLuat
	where maSV = @maSV
	END
----------------EJND---------------------

------------------------- check SV KL----------------------------
create PROCEDURE CheckSVKL
	@maSV varchar(50)
AS Begin
	select tenlop,maSV,ho,tendem,ten
	from sinhvien 
	where maSV = @maSV;
END
---------END------------------

--------------------------create PROCE Delete
CREATE PROCEDURE DeleteSVKL
	@maSV nvarchar(50)
AS Begin
	Delete KyLuat 
	where maSV = @maSV
	END
--------------END---------------

-------------------------craete Ky luat number -----
create procedure KLnumber
	@keys  nvarchar(10)
as begin
	select 
		tenlop,
		maSV,
		case 
			when LEN(tendem) > 0 then -- nếu độ dài của tên đệm > 0  tức là có tên đệm
			CONCAT(ho,' ',tendem,' ',ten) -- thì nối họ +  tên đệm + tên 
			else CONCAT(ho, ' ',ten) --  ngược lại
		end as hoten,
		number,namhoc,ghichu from KyLuat
	where number = @keys
end
-----------------END------------------------

------------------------------------- --------------TABLE KyHoc ----------------------------------------------
create table KyHoc
(
	namhoc nvarchar(50)
	primary key(namhoc)
)

insert into Kyhoc
values('2021-2022')
insert into Kyhoc
values('2022-2023')

