Delete From Product
Delete From Category
go

Set Identity_Insert Category On
go
-- top level categories
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (1, 'Clothing', 1, Null)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (2, 'Furniture', 2, Null)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (3, 'Food', 3, Null)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (4, 'Stationery', 4, Null)
-- subcategories of Clothing
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (5, 'Men', 1, 1)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (6, 'Women', 2, 1)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (7, 'Children', 3, 1)

Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (8, 'Casual', 1, 5)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (9, 'Formal', 2, 5)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (10, 'Sports', 3, 5)

Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (11, 'Party', 1, 6)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (12, 'Casual', 2, 6)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (13, 'Wedding', 3, 6)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (14, 'Sports', 4, 6)

Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (15, 'Infants', 1, 7)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (16, 'Toddler Boys', 2, 7)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (17, 'Toddler Girls', 3, 7)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (18, 'Boys', 4, 7)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (19, 'Girls', 5, 7)

Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (20, 'Bedroom', 1, 2)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (21, 'Kitchen', 2, 2)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (22, 'Sofas', 3, 2)

Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (23, 'Sets', 1, 20)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (24, 'Bed', 2, 20)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (25, 'Wardrobe', 3, 20)

Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (26, 'Frozen', 1, 3)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (27, 'Dairy', 2, 3)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (28, 'Snacks', 3, 3)

Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (29, 'Office', 1, 4)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (30, 'School', 2, 4)
Insert Into Category (CategoryId, CategoryName, SeqNo, ParentCategoryId) Values (31, 'Bundles', 3, 4)

Set Identity_Insert Category Off
go
