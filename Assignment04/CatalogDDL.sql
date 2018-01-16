Drop Table ProductSecondaryCategory
go
Drop Table Product
go
Drop Table Category
go

Create Table Category
	(CategoryId Int Identity(1,1) not null,
	CategoryName varchar(50) not null,
	SeqNo tinyint not null,
	ParentCategoryId Int
	Primary Key (CategoryId),
	Foreign Key (ParentCategoryId) References Category(CategoryId)
	)

go

Create Table Product
	(ProductId Int Identity(1,1) not null,
	ProductName varchar(50) not null,
	PrimaryCategoryId int not null,
    ProductDescription varchar(200) not null,
    Active bit not null,
    ProductPrice money not null, 
    OtherAttributes xml not null
	Primary Key (ProductId),
	Foreign Key (PrimaryCategoryId) References Category(CategoryId)
	)
go


Create Table ProductSecondaryCategory
	(RowId Int Identity(1,1) not null,
     ProductId Int not null,
	 CategoryId Int not null,
     Primary Key (RowId),
 	 Foreign Key (ProductId) References Product(ProductId),
	 Foreign Key (CategoryId) References Category(CategoryId)
	)
go
