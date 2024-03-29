USE [SmallBusiness]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/27/2019 6:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/27/2019 6:24:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Loyality] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/27/2019 6:24:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[Product_Id] [int] NULL,
 CONSTRAINT [PK__Orders__C3905BAF3A6551B6] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/27/2019 6:24:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[RecordLevel] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 10/27/2019 6:24:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date1] [date] NULL,
	[InvoiceNo] [varchar](20) NULL,
	[Supplier_id] [int] NULL,
	[category_id] [int] NULL,
	[Product_id] [int] NULL,
	[Manufacture_Date] [date] NULL,
	[Expire_Date] [date] NULL,
	[Quantity] [int] NULL,
	[Unit_Price] [float] NULL,
	[MRP] [float] NULL,
	[Remarks] [varchar](50) NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase_Details]    Script Date: 10/27/2019 6:24:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Purchase_Id] [int] NULL,
	[Product_Id] [int] NULL,
	[Manufacture_Date] [date] NULL,
	[Expired_Date] [date] NULL,
	[Quantity] [int] NULL,
	[Unit_Price] [float] NULL,
	[MRP] [float] NULL,
	[Remarks] [varchar](50) NULL,
 CONSTRAINT [PK_Purchase_Details] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales_Details]    Script Date: 10/27/2019 6:24:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sales.Id] [int] NULL,
	[Product_Id] [int] NULL,
	[Manufacture_Date] [date] NULL,
	[Expired_Date] [date] NULL,
	[Quantity] [int] NULL,
	[Unit_Price] [float] NULL,
	[MRP] [float] NULL,
	[Remarks] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/27/2019 6:24:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[ContactPerson] [varchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [Code], [Name]) VALUES (1, 1001, N'Laptop')
INSERT [dbo].[Categories] ([ID], [Code], [Name]) VALUES (2, 1002, N'Mobile')
INSERT [dbo].[Categories] ([ID], [Code], [Name]) VALUES (3, 1003, N'Monitor')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Email], [Contact], [Loyality]) VALUES (1, 3123, N'Ariful Islam', N'Uttara', N'ariful.funny@gmail.com', N'01773611681', 10)
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Email], [Contact], [Loyality]) VALUES (2, 4324, N'Arif Hasan', N'Dhaka', N'abc@gmail.com', N'01957884309', 15)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [CategoryId], [Code], [Name], [RecordLevel], [Description]) VALUES (1, 1, 1001, N'Asus', N'15', N'Good')
INSERT [dbo].[Products] ([Id], [CategoryId], [Code], [Name], [RecordLevel], [Description]) VALUES (2, 2, 1002, N'Xiaomi', N'20', N'Good')
INSERT [dbo].[Products] ([Id], [CategoryId], [Code], [Name], [RecordLevel], [Description]) VALUES (4, 3, 1003, N'Acer', N'25', N'Good')
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Purchase] ON 

INSERT [dbo].[Purchase] ([Id], [Date1], [InvoiceNo], [Supplier_id], [category_id], [Product_id], [Manufacture_Date], [Expire_Date], [Quantity], [Unit_Price], [MRP], [Remarks]) VALUES (3, CAST(N'2019-10-18' AS Date), N'12345', 1, 1, 1, CAST(N'2019-10-18' AS Date), CAST(N'2028-11-11' AS Date), 5, 20000, 100000, N'Good')
SET IDENTITY_INSERT [dbo].[Purchase] OFF
SET IDENTITY_INSERT [dbo].[Purchase_Details] ON 

INSERT [dbo].[Purchase_Details] ([Id], [Purchase_Id], [Product_Id], [Manufacture_Date], [Expired_Date], [Quantity], [Unit_Price], [MRP], [Remarks]) VALUES (1, 3, 1, CAST(N'2019-10-18' AS Date), CAST(N'2028-11-11' AS Date), 5, 20000, 100000, N'100000')
INSERT [dbo].[Purchase_Details] ([Id], [Purchase_Id], [Product_Id], [Manufacture_Date], [Expired_Date], [Quantity], [Unit_Price], [MRP], [Remarks]) VALUES (2, 3, 1, CAST(N'2019-10-15' AS Date), CAST(N'2019-10-31' AS Date), 2, 23000, 57500, N'Good')
INSERT [dbo].[Purchase_Details] ([Id], [Purchase_Id], [Product_Id], [Manufacture_Date], [Expired_Date], [Quantity], [Unit_Price], [MRP], [Remarks]) VALUES (3, 3, 2, CAST(N'2019-08-06' AS Date), CAST(N'2023-01-13' AS Date), 10, 25000, 312500, N'Good at All')
INSERT [dbo].[Purchase_Details] ([Id], [Purchase_Id], [Product_Id], [Manufacture_Date], [Expired_Date], [Quantity], [Unit_Price], [MRP], [Remarks]) VALUES (4, 3, 4, CAST(N'2014-10-21' AS Date), CAST(N'2024-10-22' AS Date), 20, 334, 8350, N'Good')
INSERT [dbo].[Purchase_Details] ([Id], [Purchase_Id], [Product_Id], [Manufacture_Date], [Expired_Date], [Quantity], [Unit_Price], [MRP], [Remarks]) VALUES (5, 3, 2, CAST(N'2019-10-01' AS Date), CAST(N'2019-10-17' AS Date), 2, 4500, 11250, N'Good')
SET IDENTITY_INSERT [dbo].[Purchase_Details] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (1, 1231, N'Amin Group', N'Dhaka', N'amin@gmail.com', N'019578843309', N'Rakib01773611681')
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (2, 1233, N'Rakib  Group', N'Dhaka', N'rakib@gmail.com', N'019578843388', N'Salam01773611681')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__Product___49C3F6B7] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__Product___49C3F6B7]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK__Purchase__catego__44FF419A] FOREIGN KEY([category_id])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK__Purchase__catego__44FF419A]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD FOREIGN KEY([Product_id])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD FOREIGN KEY([Supplier_id])
REFERENCES [dbo].[Suppliers] ([Id])
GO
ALTER TABLE [dbo].[Purchase_Details]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Details_Products] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Purchase_Details] CHECK CONSTRAINT [FK_Purchase_Details_Products]
GO
ALTER TABLE [dbo].[Purchase_Details]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Details_Purchase] FOREIGN KEY([Purchase_Id])
REFERENCES [dbo].[Purchase] ([Id])
GO
ALTER TABLE [dbo].[Purchase_Details] CHECK CONSTRAINT [FK_Purchase_Details_Purchase]
GO
