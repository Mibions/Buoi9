Create database QL_Coffee

create table Category
(
	ID INT PRIMARY KEY,
	Name_Catalogue NVARCHAR(30)
);

create table Menu
(
	Name NVARCHAR(50),
	Details NVARCHAR(100),
	Price INT,
	Image VARCHAR(100),
	ID_Catalogue INT FOREIGN KEY REFERENCES Category(ID)
);
----------------------- IMPORT DATA ------------------------------------------------
--File excel
--Microsoft.ACE.OLEDB.16.0
--Import data to table Category
INSERT INTO Category(ID, Name_Catalogue) 
SELECT ID, Name_Catalogue
FROM OPENROWSET( 
'Microsoft.ACE.OLEDB.16.0', -- PROVIDER (dành cho microsoft office)
'Excel 12.0; Database=E:\ASP.NET MVC\Buoi4\Import data SQL\Bai_1_2.xlsx', -- Đường dẫn đến tệp Excel
'SELECT * FROM [Catalogue$]' -- Tên sheet trong tệp Excel
);
-----------------------------------------------------------------------
--Import data to table Menu
INSERT INTO Menu(Name, Details, Price, ID_Catalogue, Image) 
SELECT Name, Details, Price, ID_Catalogue, Image
FROM OPENROWSET( 
'Microsoft.ACE.OLEDB.16.0', -- PROVIDER (dành cho microsoft office)
'Excel 12.0; Database=E:\ASP.NET MVC\Buoi4\Import data SQL\Bai_1_2.xlsx', -- Đường dẫn đến tệp Excel
'SELECT * FROM [Coffee$]' -- Tên sheet trong tệp Excel
);

INSERT INTO Menu(Name, Details, Price, ID_Catalogue, Image) 
SELECT Name, Details, Price, ID_Catalogue, Image
FROM OPENROWSET( 
'Microsoft.ACE.OLEDB.16.0',
'Excel 12.0; Database=E:\ASP.NET MVC\Buoi4\Import data SQL\Bai_1_2.xlsx', 
'SELECT * FROM [Tea & Milk Tea$]'
);

INSERT INTO Menu(Name, Details, Price, ID_Catalogue, Image) 
SELECT Name, Details, Price, ID_Catalogue, Image
FROM OPENROWSET( 
'Microsoft.ACE.OLEDB.16.0',
'Excel 12.0; Database=E:\ASP.NET MVC\Buoi4\Import data SQL\Bai_1_2.xlsx', 
'SELECT * FROM [Smoothie$]'
);

INSERT INTO Menu(Name, Details, Price, ID_Catalogue, Image) 
SELECT Name, Details, Price, ID_Catalogue, Image
FROM OPENROWSET( 
'Microsoft.ACE.OLEDB.16.0',
'Excel 12.0; Database=E:\ASP.NET MVC\Buoi4\Import data SQL\Bai_1_2.xlsx', 
'SELECT * FROM [Cookies$]'
);

INSERT INTO Menu(Name, Details, Price, ID_Catalogue, Image) 
SELECT Name, Details, Price, ID_Catalogue, Image
FROM OPENROWSET( 
'Microsoft.ACE.OLEDB.16.0',
'Excel 12.0; Database=E:\ASP.NET MVC\Buoi4\Import data SQL\Bai_1_2.xlsx', 
'SELECT * FROM [Macarons$]'
);

INSERT INTO Menu(Name, Details, Price, ID_Catalogue, Image) 
SELECT Name, Details, Price, ID_Catalogue, Image
FROM OPENROWSET( 
'Microsoft.ACE.OLEDB.16.0',
'Excel 12.0; Database=E:\ASP.NET MVC\Buoi4\Import data SQL\Bai_1_2.xlsx', 
'SELECT * FROM [Donuts$]'
);
------------------------------------------------------------------------------------------
select * from Menu
select * from Category

delete menu 
------------------------------------------------------------------------------------------
--configure
	EXEC sp_configure
		'show advanced options', 1;
	RECONFIGURE;
	EXEC sp_configure
		'ad hoc distributed queries', 1;
	RECONFIGURE;
	EXEC sp_MSset_oledb_prop
	   N'Microsoft.ACE.OLEDB.16.0', N'AllowInProcess', 1