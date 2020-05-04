CREATE DATABASE Cake

CREATE TABLE [User]
(
	[ID User] int identity(1,1) primary key,
	[Name] varchar(16),
	Surname varchar(16),
	Phone NUMERIC(12),

	[Login] varchar (18),
	[Password] varbinary(20)
)

CREATE TABLE [Promotional code]
(
	[ID Promotional Code] int identity(1,1) primary key,
	[Code] int,
	[Sale] int
)


CREATE TABLE [Order status]
(
	[ID Order status] int identity(1,1) primary key,
	Vaue varchar(20)
)


CREATE TABLE Category
(
	[ID category] int identity(1,1) primary key,
	[ID Custom cake] int foreign key references [Custom cake]([ID custom cake]),
	[ID Catalog] int foreign key references [Catalog]([ID catalog]),
	[Is cust] int check([Is cust]=0 or [Is cust]=1)
)

CREATE TABLE [Catalog]
(
	[ID catalog] int identity(1,1) primary key,
	[Name] varchar (20),
	[Price] money,
	[Weight] float,
	[Inform] varchar,
	[Type] varchar,
	[Photo] varbinary(max)
)



CREATE TABLE [Order cake]
(
	[ID Order cake] int identity(1,1) primary key,
	[ID category] int foreign key references [Catalog]([ID catalog]),
	[Quantity] int

)

CREATE TABLE [Order]
(
	[ID Order] int identity(1,1) primary key,
	[ID User] int foreign key references [User]([ID User]),
	[ID Promotional Code] int foreign key references [Promotional Code]([ID Promotional Code]),
	Price money,
	[ID order status] int foreign key references [Order status]([ID order status]),
	[ID Order Cake] int foreign key references [Order cake]([ID Order cake])

)

CREATE TABLE [Custom cake]
(
	[ID custom cake] int identity(1,1) primary key,
	[ID biscuit] int foreign key references [Biscuit]([ID biscuit]),
	[ID cream] int foreign key references [Cream]([ID cream]),
	[ID decoration] int foreign key references [Decoration]([ID decoration]),
	[Weight] float
)

CREATE TABLE [Biscuit]
(
	[ID biscuit] int identity(1,1) primary key,
	[Name] varchar
)

CREATE TABLE [Cream]
(
	[ID cream] int identity(1,1) primary key,
	[Name] varchar
)

CREATE TABLE [Decoration]
(
	[ID decoration] int identity(1,1) primary key,
	[ID nuts] int foreign key references [Nuts]([ID nuts]),
	[ID berries] int foreign key references [Berries]([ID berries])
)
CREATE TABLE Nuts
(
	[ID nuts] int identity(1,1) primary key,
	[Name] varchar
)
CREATE TABLE Berries
(
	[ID berries] int identity(1,1) primary key,
	[Name] varchar
)