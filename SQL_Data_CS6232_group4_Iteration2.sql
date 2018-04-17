USE [master]
GO
/****** Object:  Database [RentMe]    Script Date: 4/16/2018 7:55:11 PM ******/
CREATE DATABASE [RentMe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentMe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RentMe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentMe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RentMe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RentMe] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentMe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentMe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentMe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentMe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentMe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentMe] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentMe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentMe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentMe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentMe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentMe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentMe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentMe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentMe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentMe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentMe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RentMe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentMe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentMe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentMe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentMe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentMe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentMe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentMe] SET RECOVERY FULL 
GO
ALTER DATABASE [RentMe] SET  MULTI_USER 
GO
ALTER DATABASE [RentMe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentMe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentMe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentMe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentMe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentMe] SET QUERY_STORE = OFF
GO
USE [RentMe]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [RentMe]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/16/2018 7:55:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[categoryID] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](45) NOT NULL,
	[middleInitial] [varchar](1) NULL,
	[lname] [varchar](45) NOT NULL,
	[dateOfBirth] [datetime2](0) NOT NULL,
	[homePhone] [varchar](14) NULL,
	[Address1] [varchar](60) NULL,
	[Address2] [varchar](60) NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](2) NULL,
	[PostalCode] [varchar](10) NULL,
	[gender] [varchar](14) NULL,
	[admin] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[furnitureID] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](45) NOT NULL,
	[styleID] [int] NOT NULL,
	[categoryID] [int] NOT NULL,
	[fine_Rate] [decimal](10, 2) NOT NULL,
	[daily_Rate] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[furnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[genderID] [int] NOT NULL,
	[gender] [varchar](2) NOT NULL,
	[description] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[loginID] [int] IDENTITY(1,1) NOT NULL,
	[userID] [varchar](30) NOT NULL,
	[password] [varchar](45) NOT NULL,
	[employeeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[loginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[memberID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](45) NOT NULL,
	[middleInitial] [varchar](1) NULL,
	[lname] [varchar](45) NOT NULL,
	[dateOfBirth] [datetime2](0) NOT NULL,
	[homePhone] [varchar](20) NULL,
	[Address1] [varchar](100) NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](100) NULL,
	[State] [varchar](10) NULL,
	[PostalCode] [varchar](10) NULL,
	[gender] [varchar](14) NULL,
PRIMARY KEY CLUSTERED 
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental](
	[rentalID] [int] IDENTITY(1,1) NOT NULL,
	[memberID] [int] NOT NULL,
	[expected_return] [datetime2](0) NOT NULL,
	[itemID] [int] NOT NULL,
	[return_date] [datetime2](0) NULL,
	[rental_date] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental_return_transaction]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental_return_transaction](
	[returnID] [int] IDENTITY(1,1) NOT NULL,
	[rentalID] [int] NOT NULL,
	[transactionID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[returnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental_transaction]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental_transaction](
	[rentalTransacationID] [int] IDENTITY(1,1) NOT NULL,
	[rentalID] [int] NOT NULL,
	[transactionID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rentalTransacationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[stateID] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[country] [varchar](50) NOT NULL,
	[abbreviation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[stateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store_item]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store_item](
	[itemID] [int] IDENTITY(1,1) NOT NULL,
	[furnitureID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Streets]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Streets](
	[streetID] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[abbreviation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Streets] PRIMARY KEY CLUSTERED 
(
	[streetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Style]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Style](
	[styleID] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[styleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 4/16/2018 7:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[transactionID] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime2](0) NOT NULL,
	[amount] [decimal](10, 2) NOT NULL,
	[comment] [varchar](300) NULL,
	[employeeID] [int] NOT NULL,
	[fines] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (1, N'bed')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (2, N'desk')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (3, N'chair')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (4, N'dining table')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (5, N'recliner')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (6, N'bookcase')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (7, N'ottoman')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (8, N'love seat')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (9, N'stool')
GO
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (10, N'bench')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (1, N'Diane', N'L', N'Ela', CAST(N'1971-12-06T17:19:19.0000000' AS DateTime2), N'4049329551', N'215 Lake Pines Pointe', N'', N'Alpharetta', N'GA', N'30005', N'F', N'Y')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (2, N'Louis ', N'K', N'Szekely', CAST(N'1970-05-22T00:00:00.0000000' AS DateTime2), N'7185623145', N'222 Jet Upper Lane', N'', N'New York City', N'NY', N'10006', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (3, N'Josie', N'F', N'Rizal', CAST(N'1990-01-30T00:00:00.0000000' AS DateTime2), N'3102535698', N'154 Butterfly Drive', N'', N'Los Angeles', N'CA', N'90004', N'F', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (4, N'Terry', N'L', N'Bogard', CAST(N'1971-03-15T00:00:00.0000000' AS DateTime2), N'5014678951', N'55 Buster Drive', N'', N'Little Rock', N'AR', N'72201', N'M', N'Y')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (5, N'Leandra', N'E', N'Lo', CAST(N'1982-06-22T00:00:00.0000000' AS DateTime2), N'3146469552', N'1243 Snake Edge', N'APT 201', N'St. Louis', N'MO', N'63101', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (6, N'Lisa', N'M', N'Trevor', CAST(N'1953-07-03T00:00:00.0000000' AS DateTime2), N'7736898522', N'989 Arklay Place', N'', N'Chicago', N'IL', N'60601', N'F', N'Y')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (7, N'David', N'A', N'Hayter', CAST(N'1969-02-06T00:00:00.0000000' AS DateTime2), N'3108521465', N'77 Solid Drive', N'', N'Santa Monica', N'CA', N'90291', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (8, N'Richard', N'J', N'Grayson', CAST(N'1940-09-28T00:00:00.0000000' AS DateTime2), N'9077854563', N'5233 Robin Court', N'BLDG 3', N'Juneau', N'AK', N'99802', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (9, N'Walter', N'C', N'Kovacs', CAST(N'1940-03-21T00:00:00.0000000' AS DateTime2), N'7185236644', N'14 Rorschach Way', N'APT 18', N'New York City', N'NY', N'10002', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (10, N'Harry', N'R', N'Mason', CAST(N'1983-12-24T00:00:00.0000000' AS DateTime2), N'3042187899', N'23 Toluca Lane', N'', N'Huntington', N'WV', N'25025', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (11, N'Steve', N'K', N'Ela', CAST(N'1967-08-29T00:21:04.0000000' AS DateTime2), N'4049187638', N'215 Lake Pines Pointe', N'', N'Alpharetta', N'GA', N'30005', N'M', N'Y')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (12, N'Adam', N'', N'West', CAST(N'1989-03-23T15:08:17.0000000' AS DateTime2), N'4044443333', N'123 Anywhere Street', N'', N'Hometown', N'GA', N'30001', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (14, N'Wally', N'', N'West', CAST(N'1996-04-12T16:53:44.0000000' AS DateTime2), N'1111111111', N'123 Anywhere', N'', N'Anytown', N'CA', N'11111', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (15, N'Barry', N'', N'Allen', CAST(N'1974-04-12T17:19:19.0000000' AS DateTime2), N'1234556789', N'333 Anystreet', N'', N'Anytown', N'LA', N'12345', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (16, N'George', N'', N'Jungle', CAST(N'1948-04-12T17:23:39.0000000' AS DateTime2), N'5551114444', N'511 Avenue of the Trees', N'', N'Walla Walla', N'WA', N'44444', N'NA', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (17, N'William', N'', N'Wallace', CAST(N'1983-04-09T17:28:33.0000000' AS DateTime2), N'3331225555', N'622 Scotland Ave', N'', N'Dover', N'DE', N'51515', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (18, N'Diane', N'', N'Rawls', CAST(N'1971-12-06T00:00:00.0000000' AS DateTime2), N'4049187638', N'3250 Hunterdon Way', N'', N'Marietta', N'GA', N'30067', N'F', N'Y')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (19, N'Janet', N'', N'Smith', CAST(N'1971-04-14T18:24:39.0000000' AS DateTime2), N'4044448888', N'622 Anywhere Road', N'', N'Cumming', N'GA', N'30011', N'F', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (20, N'Joyce', N'', N'Mattous', CAST(N'1958-04-14T19:04:12.0000000' AS DateTime2), N'6641353212', N'155 Testing Street', N'', N'Walkegan', N'OK', N'52555', N'F', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (21, N'Thomas', N'', N'Drake', CAST(N'2000-06-02T19:06:18.0000000' AS DateTime2), N'6466545875', N'1512 Chock Street', N'', N'New York', N'GA', N'14111', N'M', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (22, N'Jennifer', N'', N'Garner', CAST(N'1972-04-14T19:12:57.0000000' AS DateTime2), N'', N'', N'', N'Atlanta', N'GA', N'12345', N'F', N'N')
GO
INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (23, N'Bob', N'', N'Marley', CAST(N'2018-04-14T19:27:06.0000000' AS DateTime2), N'4044445555', N'', N'', N'Alpharetta', N'GA', N'11111', N'M', N'N')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Furniture] ON 
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (1, N'modern desk', 1, 2, CAST(5.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (2, N'modern dining table', 1, 4, CAST(4.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (3, N'contemporary desk', 3, 2, CAST(6.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (4, N'traditional bed', 2, 1, CAST(10.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (5, N'victorian stool', 5, 9, CAST(4.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (6, N'rustic chair', 8, 3, CAST(6.50 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (7, N'retro dining table', 9, 4, CAST(7.00 AS Decimal(10, 2)), CAST(14.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (8, N'vintage dining table', 7, 4, CAST(8.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (9, N'art deco recliner', 10, 5, CAST(7.50 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Furniture] ([furnitureID], [description], [styleID], [categoryID], [fine_Rate], [daily_Rate]) VALUES (10, N'classic ottoman', 4, 7, CAST(4.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Furniture] OFF
GO
INSERT [dbo].[Gender] ([genderID], [gender], [description]) VALUES (1, N'M', N'MALE')
GO
INSERT [dbo].[Gender] ([genderID], [gender], [description]) VALUES (2, N'F', N'FEMALE')
GO
INSERT [dbo].[Gender] ([genderID], [gender], [description]) VALUES (3, N'NA', N'NOT PROVIDED')
GO
SET IDENTITY_INSERT [dbo].[Login] ON 
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (1, N'dEla', N'sDHZ9qmknlswDrAbgTKSVw==', 1)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (2, N'lSzekely', N's14y3r11', 2)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (3, N'jRizal', N'sh1ll111', 3)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (4, N'tBogard', N'r0b07111', 4)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (5, N'lLo', N'4l13n111', 5)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (6, N'lTrevor', N'n1gh7111', 6)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (7, N'dHayter', N'd13h4r61', 7)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (8, N'rGrayson', N'iws11111', 8)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (9, N'wKovacs', N'uf34lr1111', 9)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (10, N'hMason', N'wss421111', 10)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (13, N'aWest', N's0k2rD03qWQs38zhTMQ/Ng==', 12)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (14, N'wWest', N'hElpMxnqixRV4hftioFOFw==', 14)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (15, N'bAllen', N'sDHZ9qmknlswDrAbgTKSVw==', 15)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (16, N'gJungle', N'sDHZ9qmknlswDrAbgTKSVw==', 16)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (17, N'wWallace', N'LbvWtM5HYrwElkIuazlJuw==', 17)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (18, N'jSmith', N'sDHZ9qmknlswDrAbgTKSVw==', 19)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (19, N'jMattous', N'sDHZ9qmknlswDrAbgTKSVw==', 20)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (20, N'tDrake', N'sDHZ9qmknlswDrAbgTKSVw==', 21)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (21, N'jGarner', N'sDHZ9qmknlswDrAbgTKSVw==', 22)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (22, N'bMarley', N'sDHZ9qmknlswDrAbgTKSVw==', 23)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (24, N'dRawls', N'sDHZ9qmknlswDrAbgTKSVw==', 18)
GO
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (25, N'sEla', N'sDHZ9qmknlswDrAbgTKSVw==', 11)
GO
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (1, N'Ryu', N'T', N'Hayabusa', CAST(N'1980-06-15T00:00:00.0000000' AS DateTime2), N'(775) 895-4621', N'63 Gaiden Court', N'Suite 100', N'Reno', N'NV', N'89501', N'M')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (2, N'Simon', N'M', N'Belmont', CAST(N'1988-09-12T00:00:00.0000000' AS DateTime2), N'9861347778', N'11 Castle Court', N'', N'Boise', N'ID', N'83703', N'M')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (3, N'Dahlia', N'L', N'Gillespie', CAST(N'1976-04-30T00:00:00.0000000' AS DateTime2), N'6178956442', N'243 Silent Way', N'', N'Jackson', N'TN', N'37014', N'F')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (4, N'Alisa', N'K', N'Bosconovitch', CAST(N'1993-01-01T00:00:00.0000000' AS DateTime2), N'2079441325', N'1313 N. Main Street', N'APT 34', N'Bar Harbor', N'ME', N'4005', N'F')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (5, N'Ellen', N'C', N'Ripley', CAST(N'1949-10-08T00:00:00.0000000' AS DateTime2), N'7186459822', N'23 Nostromo Way', N'', N'Manhattan', N'NY', N'10008', N'F')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (6, N'Jack', N'E', N'Skellington', CAST(N'1988-11-11T00:00:00.0000000' AS DateTime2), N'8025564511', N'1555 Hollow Place', N'', N'Essex', N'VT', N'5001', N'F')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (7, N'Holly', N'P', N'Gennaro', CAST(N'1948-03-25T00:00:00.0000000' AS DateTime2), N'9477897855', N'21 Nakatomi Plaza', N'BLDG 5', N'Allenton', N'MI', N'48002', N'F')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (8, N'Nina', N'R', N'Williams', CAST(N'1989-06-19T00:00:00.0000000' AS DateTime2), N'9475213122', N'132 Ivory Lane', N'', N'Lansing', N'MI', N'48002', N'F')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (9, N'Julia', N'F', N'Chang', CAST(N'1991-01-22T00:00:00.0000000' AS DateTime2), N'3076452235', N'188 Lutador Lane', N'APT 101', N'Cheyenne', N'WY', N'82001', N'F')
GO
INSERT [dbo].[Member] ([memberID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender]) VALUES (10, N'Kazumi ', N'T', N'Mishima', CAST(N'1972-07-30T00:00:00.0000000' AS DateTime2), N'3033366453', N'1021 Tiger Drive', N'', N'Aurora', N'CO', N'80019', N'F')
GO
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Rental] ON 
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (1, 1, CAST(N'2017-03-27T00:00:00.0000000' AS DateTime2), 1, CAST(N'2017-03-25T00:00:00.0000000' AS DateTime2), CAST(N'2017-01-20T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (2, 1, CAST(N'2018-01-29T00:00:00.0000000' AS DateTime2), 5, NULL, CAST(N'2017-12-28T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (3, 3, CAST(N'2017-09-02T00:00:00.0000000' AS DateTime2), 3, CAST(N'2017-09-07T00:00:00.0000000' AS DateTime2), CAST(N'2017-08-16T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (4, 4, CAST(N'2017-05-21T00:00:00.0000000' AS DateTime2), 4, CAST(N'2017-05-25T00:00:00.0000000' AS DateTime2), CAST(N'2017-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (5, 7, CAST(N'2018-04-02T00:00:00.0000000' AS DateTime2), 19, NULL, CAST(N'2018-02-03T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (6, 7, CAST(N'2017-02-07T00:00:00.0000000' AS DateTime2), 8, CAST(N'2017-02-05T00:00:00.0000000' AS DateTime2), CAST(N'2017-01-03T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (7, 7, CAST(N'2017-08-03T00:00:00.0000000' AS DateTime2), 31, CAST(N'2017-07-25T00:00:00.0000000' AS DateTime2), CAST(N'2017-06-21T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (8, 8, CAST(N'2017-11-15T00:00:00.0000000' AS DateTime2), 17, CAST(N'2017-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2017-10-19T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (9, 8, CAST(N'2017-07-08T00:00:00.0000000' AS DateTime2), 21, CAST(N'2017-07-08T00:00:00.0000000' AS DateTime2), CAST(N'2017-05-11T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (10, 9, CAST(N'2017-03-24T00:00:00.0000000' AS DateTime2), 27, CAST(N'2017-03-23T00:00:00.0000000' AS DateTime2), CAST(N'2017-03-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (11, 10, CAST(N'2017-12-03T00:00:00.0000000' AS DateTime2), 11, CAST(N'2017-11-26T00:00:00.0000000' AS DateTime2), CAST(N'2017-09-15T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (12, 10, CAST(N'2017-10-26T00:00:00.0000000' AS DateTime2), 25, CAST(N'2017-10-17T00:00:00.0000000' AS DateTime2), CAST(N'2017-09-11T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Rental] ([rentalID], [memberID], [expected_return], [itemID], [return_date], [rental_date]) VALUES (13, 10, CAST(N'2017-10-10T00:00:00.0000000' AS DateTime2), 24, CAST(N'2017-10-12T00:00:00.0000000' AS DateTime2), CAST(N'2017-09-30T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Rental] OFF
GO
SET IDENTITY_INSERT [dbo].[Rental_return_transaction] ON 
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (1, 1, 14)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (3, 3, 16)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (4, 4, 17)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (6, 6, 19)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (7, 7, 20)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (8, 8, 21)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (9, 9, 22)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (10, 10, 23)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (11, 11, 24)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (12, 12, 25)
GO
INSERT [dbo].[Rental_return_transaction] ([returnID], [rentalID], [transactionID]) VALUES (13, 13, 26)
GO
SET IDENTITY_INSERT [dbo].[Rental_return_transaction] OFF
GO
SET IDENTITY_INSERT [dbo].[Rental_transaction] ON 
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (1, 1, 1)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (2, 2, 2)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (3, 3, 3)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (4, 4, 4)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (5, 5, 5)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (6, 6, 6)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (7, 7, 7)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (8, 8, 8)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (9, 9, 9)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (10, 10, 10)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (11, 11, 11)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (12, 12, 12)
GO
INSERT [dbo].[Rental_transaction] ([rentalTransacationID], [rentalID], [transactionID]) VALUES (13, 13, 13)
GO
SET IDENTITY_INSERT [dbo].[Rental_transaction] OFF
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (1, N'ALABAMA', N'UNITED STATES', N'AL')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (2, N'ALASKA', N'UNITED STATES', N'AK')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (3, N'ARIZONA', N'UNITED STATES', N'AZ')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (4, N'ARKANSAS', N'UNITED STATES', N'AR')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (5, N'ARMED FORCES AMERICA', N'UNITED STATES', N'AA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (6, N'ARMED FORCES EUROPE', N'UNITED STATES', N'AE')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (7, N'ARMED FORCES PACIFIC', N'UNITED STATES', N'AP')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (8, N'CALIFORNIA', N'UNITED STATES', N'CA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (9, N'COLORADO', N'UNITED STATES', N'CO')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (10, N'CONNECTICUT', N'UNITED STATES', N'CT')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (11, N'DELAWARE', N'UNITED STATES', N'DE')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (12, N'DISTRICT OF COLUMBIA', N'UNITED STATES', N'DC')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (13, N'FLORIDA', N'UNITED STATES', N'FL')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (14, N'GEORGIA', N'UNITED STATES', N'GA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (15, N'HAWAII', N'UNITED STATES', N'HI')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (16, N'IDAHO', N'UNITED STATES', N'ID')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (17, N'ILLINOIS', N'UNITED STATES', N'IL')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (18, N'INDIANA', N'UNITED STATES', N'IN')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (19, N'IOWA', N'UNITED STATES', N'IA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (20, N'KANSAS', N'UNITED STATES', N'KS')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (21, N'KENTUCKY', N'UNITED STATES', N'KY')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (22, N'LOUISIANA', N'UNITED STATES', N'LA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (23, N'MAINE', N'UNITED STATES', N'ME')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (24, N'MARYLAND', N'UNITED STATES', N'MD')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (25, N'MASSACHUSETTS', N'UNITED STATES', N'MA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (26, N'MICHIGAN', N'UNITED STATES', N'MI')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (27, N'MINNESOTA', N'UNITED STATES', N'MN')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (28, N'MISSISSIPPI', N'UNITED STATES', N'MS')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (29, N'MISSOURI', N'UNITED STATES', N'MO')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (30, N'MONTANA', N'UNITED STATES', N'MT')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (31, N'NEBRASKA', N'UNITED STATES', N'NE')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (32, N'NEVADA', N'UNITED STATES', N'NV')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (33, N'NEW HAMPSHIRE', N'UNITED STATES', N'NH')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (34, N'NEW JERSEY', N'UNITED STATES', N'NJ')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (35, N'NEW MEXICO', N'UNITED STATES', N'NM')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (36, N'NEW YORK', N'UNITED STATES', N'NY')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (37, N'NORTH CAROLINA', N'UNITED STATES', N'NC')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (38, N'NORTH DAKOTA', N'UNITED STATES', N'ND')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (39, N'OHIO', N'UNITED STATES', N'OH')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (40, N'OKLAHOMA', N'UNITED STATES', N'OK')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (41, N'OREGON', N'UNITED STATES', N'OR')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (42, N'PENNSYLVANIA', N'UNITED STATES', N'PA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (43, N'RHODE ISLAND', N'UNITED STATES', N'RI')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (44, N'SOUTH CAROLINA', N'UNITED STATES', N'SC')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (45, N'SOUTH DAKOTA', N'UNITED STATES', N'SD')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (46, N'TENNESSEE', N'UNITED STATES', N'TN')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (47, N'TEXAS', N'UNITED STATES', N'TX')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (48, N'UTAH', N'UNITED STATES', N'UT')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (49, N'VERMONT', N'UNITED STATES', N'VT')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (50, N'VIRGINIA', N'UNITED STATES', N'VA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (51, N'WASHINGTON', N'UNITED STATES', N'WA')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (52, N'WEST VIRGINIA', N'UNITED STATES', N'WV')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (53, N'WISCONSIN', N'UNITED STATES', N'WI')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (54, N'WYOMING', N'UNITED STATES', N'WY')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (55, N'ALBERTA', N'CANADA', N'AB')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (56, N'BRITISH COLUMBIA', N'CANADA', N'BC')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (57, N'MANITOBA', N'CANADA', N'MB')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (58, N'NEW BRUNSWICK', N'CANADA', N'NB')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (59, N'NEWFOUNDLAND AND LABRADOR', N'CANADA', N'NL')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (60, N'NORTHWEST TERRITORIES', N'CANADA', N'NT')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (61, N'NOVA SCOTIA', N'CANADA', N'NS')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (62, N'NUNAVUT', N'CANADA', N'NU')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (63, N'ONTARIO', N'CANADA', N'ON')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (64, N'PRINCE EDWARD ISLAND', N'CANADA', N'PE')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (65, N'QUEBEC', N'CANADA', N'QC')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (66, N'SASKATCHEWAN', N'CANADA', N'SK')
GO
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (67, N'YUKON', N'CANADA', N'YT')
GO
SET IDENTITY_INSERT [dbo].[Store_item] ON 
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (1, 1)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (2, 1)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (3, 2)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (4, 2)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (5, 3)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (6, 3)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (7, 3)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (8, 3)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (9, 4)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (10, 4)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (11, 4)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (12, 5)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (13, 5)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (14, 5)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (15, 6)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (16, 6)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (17, 7)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (18, 7)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (19, 7)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (20, 8)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (21, 8)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (22, 8)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (23, 8)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (24, 9)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (25, 9)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (26, 9)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (27, 9)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (28, 10)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (29, 10)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (30, 10)
GO
INSERT [dbo].[Store_item] ([itemID], [furnitureID]) VALUES (31, 10)
GO
SET IDENTITY_INSERT [dbo].[Store_item] OFF
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (1, N'ALLEY', N'ALY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (2, N'ANEX', N'ANX')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (3, N'ARCADE', N'ARC')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (4, N'AVENUE', N'AVE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (5, N'BAYOU', N'BYU')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (6, N'BEACH', N'BCH')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (7, N'BEND', N'BND')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (8, N'BLUFF', N'BLF')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (9, N'BLUFFS', N'BLFS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (10, N'BOTTOM', N'BTM')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (11, N'BOULEVARD', N'BLVD')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (12, N'BRANCH', N'BR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (13, N'BRIDGE', N'BRG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (14, N'BROOK', N'BRK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (15, N'BROOKS', N'BRKS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (16, N'BURG', N'BG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (17, N'BURGS', N'BGS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (18, N'BYPASS', N'BYP')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (19, N'CAMP', N'CP')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (20, N'CANYON', N'CYN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (21, N'CAPE', N'CPE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (22, N'CAUSEWAY', N'CSWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (23, N'CENTER', N'CTR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (24, N'CENTERS', N'CTRS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (25, N'CIRCLE', N'CIR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (26, N'CIRCLES', N'CIRS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (27, N'CLIFF', N'CLF')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (28, N'CLIFFS', N'CLFS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (29, N'CLUB', N'CLB')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (30, N'COMMON', N'CMN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (31, N'COMMONS', N'CMNS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (32, N'CORNER', N'COR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (33, N'CORNERS', N'CORS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (34, N'COURSE', N'CRSE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (35, N'COURT', N'CT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (36, N'COURTS', N'CTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (37, N'COVE', N'CV')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (38, N'COVES', N'CVS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (39, N'CREEK', N'CRK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (40, N'CRESCENT', N'CRES')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (41, N'CREST', N'CRST')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (42, N'CROSSING', N'XING')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (43, N'CROSSROAD', N'XRD')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (44, N'CROSSROADS', N'XRDS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (45, N'CURVE ', N'CURV')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (46, N'DALE', N'DL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (47, N'DAM', N'DM')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (48, N'DIVIDE', N'DV')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (49, N'DRIVE', N'DR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (50, N'DRIVES ', N'DRS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (51, N'ESTATE', N'EST')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (52, N'ESTATES', N'ESTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (53, N'EXPRESSWAY', N'EXPY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (54, N'EXTENSION', N'EXT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (55, N'EXTENSIONS', N'EXTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (56, N'FALL', N'FALL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (57, N'FALLS', N'FLS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (58, N'FERRY', N'FRY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (59, N'FIELD', N'FLD')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (60, N'FIELDS', N'FLDS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (61, N'FLAT', N'FLT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (62, N'FLATS', N'FLTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (63, N'FORD', N'FRD')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (64, N'FORDS', N'FRDS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (65, N'FOREST', N'FRST')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (66, N'FORGE', N'FRG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (67, N'FORGES', N'FRGS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (68, N'FORK', N'FRK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (69, N'FORKS', N'FRKS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (70, N'FORT', N'FT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (71, N'FREEWAY', N'FWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (72, N'GARDEN', N'GDN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (73, N'GARDENS', N'GDNS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (74, N'GATEWAY', N'GTWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (75, N'GLEN', N'GLN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (76, N'GLENS', N'GLNS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (77, N'GREEN', N'GRN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (78, N'GREENS', N'GRNS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (79, N'GROVE', N'GRV')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (80, N'GROVES', N'GRVS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (81, N'HARBOR', N'HBR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (82, N'HARBORS', N'HBRS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (83, N'HAVEN', N'HVN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (84, N'HEIGHTS', N'HTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (85, N'HIGHWAY', N'HWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (86, N'HILL', N'HL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (87, N'HILLS', N'HLS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (88, N'HOLLOW', N'HOLW')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (89, N'INLET', N'INLT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (90, N'ISLAND', N'IS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (91, N'ISLANDS', N'ISS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (92, N'ISLE', N'ISLE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (93, N'JUNCTION', N'JCT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (94, N'JUNCTIONS', N'JCTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (95, N'KEY', N'KY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (96, N'KEYS', N'KYS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (97, N'KNOLL', N'KNL ')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (98, N'KNOLLS', N'KNLS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (99, N'LAKE', N'LK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (100, N'LAKES', N'LKS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (101, N'LAND', N'LAND')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (102, N'LANDING', N'LNDG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (103, N'LANE', N'LN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (104, N'LIGHT', N'LGT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (105, N'LIGHTS', N'LGTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (106, N'LOAF', N'LF')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (107, N'LOCK', N'LCK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (108, N'LOCKS', N'LCKS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (109, N'LODGE', N'LDG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (110, N'LOOP', N'LOOP')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (111, N'MALL', N'MALL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (112, N'MANOR', N'MNR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (113, N'MANORS', N'MNRS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (114, N'MEADOW', N'MDW')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (115, N'MEADOWS', N'MDWS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (116, N'MEWS', N'MEWS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (117, N'MILL', N'ML')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (118, N'MILLS', N'MLS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (119, N'MISSION', N'MSN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (120, N'MOTORWAY', N'MTWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (121, N'MOUNT', N'MT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (122, N'MOUNTAIN', N'MTN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (123, N'MOUNTAINS', N'MTNS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (124, N'NECK', N'NCK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (125, N'ORCHARD', N'ORCH')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (126, N'OVAL', N'OVAL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (127, N'OVERPASS', N'OPAS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (128, N'PARK/PARKS', N'PARK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (129, N'PARKWAY/PARKWAYS', N'PKWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (130, N'PASS', N'PASS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (131, N'PASSAGE', N'PSGE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (132, N'PATH', N'PATH')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (133, N'PIKE', N'PIKE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (134, N'PINE', N'PNE ')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (135, N'PINES', N'PNES')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (136, N'PLACE', N'PL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (137, N'PLAIN', N'PLN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (138, N'PLAINS', N'PLNS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (139, N'PLAZA', N'PLZ')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (140, N'POINT/POINTE', N'PT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (141, N'POINTS', N'PTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (142, N'PORT', N'PRT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (143, N'PORTS', N'PRTS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (144, N'PRAIRIE', N'PR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (145, N'RADIAL', N'RADL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (146, N'RAMP', N'RAMP')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (147, N'RANCH', N'RNCH')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (148, N'RAPID', N'RPD')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (149, N'RAPIDS', N'RPDS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (150, N'REST', N'RST')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (151, N'RIDGE', N'RDG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (152, N'RIDGES', N'RDGS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (153, N'RIVER', N'RIV')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (154, N'ROAD', N'RD')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (155, N'ROADS', N'RDS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (156, N'ROUTE', N'RTE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (157, N'ROW', N'ROW')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (158, N'RUE', N'RUE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (159, N'RUN', N'RUN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (160, N'SHOAL', N'SHL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (161, N'SHOALS', N'SHLS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (162, N'SHORE', N'SHR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (163, N'SHORES', N'SHRS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (164, N'SKYWAY', N'SKWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (165, N'SPRING', N'SPG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (166, N'SPRINGS', N'SPGS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (167, N'SPUR/SPURS', N'SPUR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (168, N'SQUARE', N'SQ')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (169, N'SQUARES', N'SQS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (170, N'STATION', N'STA')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (171, N'STRAVENUE', N'STRA')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (172, N'STREAM', N'STRM')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (173, N'Street', N'ST')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (174, N'Street', N'STS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (175, N'SUMMIT', N'SMT')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (176, N'TERRACE', N'TER')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (177, N'THROUGHWAY', N'TRWY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (178, N'TRACE', N'TRCE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (179, N'TRACK', N'TRAK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (180, N'TRAFFICWAY', N'TRFY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (181, N'TRAIL', N'TRL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (182, N'TRAILER', N'TRLR')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (183, N'TUNNEL', N'TUNL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (184, N'TURNPIKE', N'TPKE')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (185, N'UNDERPASS', N'UPAS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (186, N'UNION', N'UN')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (187, N'UNIONS', N'UNS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (188, N'VALLEY', N'VLY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (189, N'VALLEYS', N'VLYS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (190, N'VIADUCT', N'VIA')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (191, N'VIEW', N'VW')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (192, N'VIEWS', N'VWS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (193, N'VILLAGE', N'VLG')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (194, N'VILLAGES', N'VLGS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (195, N'VILLE', N'VL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (196, N'VISTA', N'VIS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (197, N'WALK/WALKS', N'WALK')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (198, N'WALL', N'WALL')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (199, N'WAY', N'WAY')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (200, N'WAYS', N'WAYS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (201, N'WELL', N'WL ')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (202, N'WELLS', N'WLS')
GO
SET IDENTITY_INSERT [dbo].[Style] ON 
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (1, N'modern')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (2, N'traditional')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (3, N'contemporary')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (4, N'classic')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (5, N'victorian')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (6, N'antique')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (7, N'vintage')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (8, N'rustic')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (9, N'retro')
GO
INSERT [dbo].[Style] ([styleID], [description]) VALUES (10, N'art deco')
GO
SET IDENTITY_INSERT [dbo].[Style] OFF
GO
SET IDENTITY_INSERT [dbo].[Transactions] ON 
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (1, CAST(N'2017-01-20T00:00:00.0000000' AS DateTime2), CAST(160.00 AS Decimal(10, 2)), N'', 16, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (2, CAST(N'2017-12-28T00:00:00.0000000' AS DateTime2), CAST(102.00 AS Decimal(10, 2)), N'', 15, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (3, CAST(N'2017-08-16T00:00:00.0000000' AS DateTime2), CAST(44.00 AS Decimal(10, 2)), N'', 5, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (4, CAST(N'2017-05-07T00:00:00.0000000' AS DateTime2), CAST(36.00 AS Decimal(10, 2)), N'', 20, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (5, CAST(N'2018-02-03T00:00:00.0000000' AS DateTime2), CAST(178.50 AS Decimal(10, 2)), N'', 21, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (6, CAST(N'2017-01-03T00:00:00.0000000' AS DateTime2), CAST(99.00 AS Decimal(10, 2)), N'', 19, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (7, CAST(N'2017-06-21T00:00:00.0000000' AS DateTime2), CAST(68.00 AS Decimal(10, 2)), N'', 15, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (8, CAST(N'2017-10-19T00:00:00.0000000' AS DateTime2), CAST(98.00 AS Decimal(10, 2)), N'', 17, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (9, CAST(N'2017-05-11T00:00:00.0000000' AS DateTime2), CAST(232.00 AS Decimal(10, 2)), N'', 7, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (10, CAST(N'2017-03-01T00:00:00.0000000' AS DateTime2), CAST(82.50 AS Decimal(10, 2)), N'', 12, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (11, CAST(N'2017-09-15T00:00:00.0000000' AS DateTime2), CAST(360.00 AS Decimal(10, 2)), N'', 6, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (12, CAST(N'2017-09-11T00:00:00.0000000' AS DateTime2), CAST(135.00 AS Decimal(10, 2)), N'', 10, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (13, CAST(N'2017-09-30T00:00:00.0000000' AS DateTime2), CAST(45.00 AS Decimal(10, 2)), N'', 2, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (14, CAST(N'2017-03-25T00:00:00.0000000' AS DateTime2), CAST(490.00 AS Decimal(10, 2)), N'Late', 2, CAST(10.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (16, CAST(N'2017-09-07T00:00:00.0000000' AS DateTime2), CAST(132.00 AS Decimal(10, 2)), N'', 9, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (17, CAST(N'2017-05-25T00:00:00.0000000' AS DateTime2), CAST(108.00 AS Decimal(10, 2)), N'', 10, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (19, CAST(N'2017-02-05T00:00:00.0000000' AS DateTime2), CAST(309.00 AS Decimal(10, 2)), N'Late', 4, CAST(12.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (20, CAST(N'2017-07-25T00:00:00.0000000' AS DateTime2), CAST(240.00 AS Decimal(10, 2)), N'Late', 12, CAST(36.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (21, CAST(N'2017-11-16T00:00:00.0000000' AS DateTime2), CAST(294.00 AS Decimal(10, 2)), N'', 12, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (22, CAST(N'2017-07-08T00:00:00.0000000' AS DateTime2), CAST(696.00 AS Decimal(10, 2)), N'', 1, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (23, CAST(N'2017-03-23T00:00:00.0000000' AS DateTime2), CAST(255.00 AS Decimal(10, 2)), N'Late', 8, CAST(7.50 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (24, CAST(N'2017-11-26T00:00:00.0000000' AS DateTime2), CAST(1150.00 AS Decimal(10, 2)), N'Late', 1, CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (25, CAST(N'2017-10-17T00:00:00.0000000' AS DateTime2), CAST(472.50 AS Decimal(10, 2)), N'Late', 3, CAST(67.50 AS Decimal(10, 2)))
GO
INSERT [dbo].[Transactions] ([transactionID], [date], [amount], [comment], [employeeID], [fines]) VALUES (26, CAST(N'2017-10-12T00:00:00.0000000' AS DateTime2), CAST(135.00 AS Decimal(10, 2)), N'', 1, CAST(0.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Transactions] OFF
GO
/****** Object:  Index [fk_Furniture_Category1_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Furniture_Category1_idx] ON [dbo].[Furniture]
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Furniture_Style_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Furniture_Style_idx] ON [dbo].[Furniture]
(
	[styleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_Member_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_Member_idx] ON [dbo].[Rental]
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_Store_item_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_Store_item_idx] ON [dbo].[Rental]
(
	[itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_return_transaction_Rental_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_return_transaction_Rental_idx] ON [dbo].[Rental_return_transaction]
(
	[rentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_return_transaction_Transacation_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_return_transaction_Transacation_idx] ON [dbo].[Rental_return_transaction]
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_transaction_Rental_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_transaction_Rental_idx] ON [dbo].[Rental_transaction]
(
	[rentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_transaction_Transacation_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_transaction_Transacation_idx] ON [dbo].[Rental_transaction]
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Inventory_Furniture1_idx]    Script Date: 4/16/2018 7:55:12 PM ******/
CREATE NONCLUSTERED INDEX [fk_Inventory_Furniture1_idx] ON [dbo].[Store_item]
(
	[furnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ('N') FOR [admin]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [fk_Furniture_Category] FOREIGN KEY([categoryID])
REFERENCES [dbo].[Category] ([categoryID])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [fk_Furniture_Category]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [fk_Furniture_Style] FOREIGN KEY([styleID])
REFERENCES [dbo].[Style] ([styleID])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [fk_Furniture_Style]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [fk_Login_Employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [fk_Login_Employee]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [fk_Rental_Member] FOREIGN KEY([memberID])
REFERENCES [dbo].[Member] ([memberID])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [fk_Rental_Member]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [fk_Rental_Store_item] FOREIGN KEY([itemID])
REFERENCES [dbo].[Store_item] ([itemID])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [fk_Rental_Store_item]
GO
ALTER TABLE [dbo].[Rental_return_transaction]  WITH CHECK ADD  CONSTRAINT [fk_Rental_return_transaction_Rental] FOREIGN KEY([rentalID])
REFERENCES [dbo].[Rental] ([rentalID])
GO
ALTER TABLE [dbo].[Rental_return_transaction] CHECK CONSTRAINT [fk_Rental_return_transaction_Rental]
GO
ALTER TABLE [dbo].[Rental_return_transaction]  WITH CHECK ADD  CONSTRAINT [fk_Rental_return_transaction_Transacation] FOREIGN KEY([transactionID])
REFERENCES [dbo].[Transactions] ([transactionID])
GO
ALTER TABLE [dbo].[Rental_return_transaction] CHECK CONSTRAINT [fk_Rental_return_transaction_Transacation]
GO
ALTER TABLE [dbo].[Rental_transaction]  WITH CHECK ADD  CONSTRAINT [fk_Rental_transaction_Rental] FOREIGN KEY([rentalID])
REFERENCES [dbo].[Rental] ([rentalID])
GO
ALTER TABLE [dbo].[Rental_transaction] CHECK CONSTRAINT [fk_Rental_transaction_Rental]
GO
ALTER TABLE [dbo].[Rental_transaction]  WITH CHECK ADD  CONSTRAINT [fk_Rental_transaction_Transacation] FOREIGN KEY([transactionID])
REFERENCES [dbo].[Transactions] ([transactionID])
GO
ALTER TABLE [dbo].[Rental_transaction] CHECK CONSTRAINT [fk_Rental_transaction_Transacation]
GO
ALTER TABLE [dbo].[Store_item]  WITH CHECK ADD  CONSTRAINT [fk_Inventory_Furniture] FOREIGN KEY([furnitureID])
REFERENCES [dbo].[Furniture] ([furnitureID])
GO
ALTER TABLE [dbo].[Store_item] CHECK CONSTRAINT [fk_Inventory_Furniture]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [fk_Transactions_Employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [fk_Transactions_Employee]
GO
USE [master]
GO
ALTER DATABASE [RentMe] SET  READ_WRITE 
GO
