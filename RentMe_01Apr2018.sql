USE [master]
GO
/****** Object:  Database [RentMe]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 4/1/2018 12:58:30 PM ******/
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
	[City] [varchar](15) NULL,
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
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Gender]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 4/1/2018 12:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[loginID] [int] NOT NULL,
	[userID] [varchar](30) NOT NULL,
	[password] [varchar](45) NOT NULL,
	[employeeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[loginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 4/1/2018 12:58:30 PM ******/
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
	[homePhone] [varchar](14) NULL,
	[Address1] [varchar](60) NULL,
	[Address2] [varchar](60) NULL,
	[City] [varchar](15) NULL,
	[State] [varchar](2) NULL,
	[PostalCode] [varchar](10) NULL,
	[gender] [varchar](14) NULL,
PRIMARY KEY CLUSTERED 
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Rental_return_transaction]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Rental_transaction]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[States]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Store_item]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Streets]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Style]    Script Date: 4/1/2018 12:58:30 PM ******/
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
/****** Object:  Table [dbo].[Transactions]    Script Date: 4/1/2018 12:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[transactionID] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime2](0) NOT NULL,
	[amount] [varchar](45) NOT NULL,
	[comment] [varchar](45) NULL,
	[employeeID] [int] NOT NULL,
	[fines] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([employeeID], [fname], [middleInitial], [lname], [dateOfBirth], [homePhone], [Address1], [Address2], [City], [State], [PostalCode], [gender], [admin]) VALUES (1, N'Diane', N'L', N'Ela', CAST(N'1971-12-06T00:00:00.0000000' AS DateTime2), N'4049329551', N'215 Lake Pines Pointe', NULL, N'Alpharetta', N'GA', N'30005', N'F', N'Y')
SET IDENTITY_INSERT [dbo].[Employee] OFF
INSERT [dbo].[Gender] ([genderID], [gender], [description]) VALUES (1, N'M', N'MALE')
INSERT [dbo].[Gender] ([genderID], [gender], [description]) VALUES (2, N'F', N'FEMALE')
INSERT [dbo].[Gender] ([genderID], [gender], [description]) VALUES (3, N'NA', N'NOT PROVIDED')
INSERT [dbo].[Login] ([loginID], [userID], [password], [employeeID]) VALUES (1, N'orcandelf', N'Cher0kee!', 1)
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (1, N'ALABAMA', N'UNITED STATES', N'AL')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (2, N'ALASKA', N'UNITED STATES', N'AK')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (3, N'ARIZONA', N'UNITED STATES', N'AZ')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (4, N'ARKANSAS', N'UNITED STATES', N'AR')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (5, N'ARMED FORCES AMERICA', N'UNITED STATES', N'AA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (6, N'ARMED FORCES EUROPE', N'UNITED STATES', N'AE')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (7, N'ARMED FORCES PACIFIC', N'UNITED STATES', N'AP')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (8, N'CALIFORNIA', N'UNITED STATES', N'CA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (9, N'COLORADO', N'UNITED STATES', N'CO')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (10, N'CONNECTICUT', N'UNITED STATES', N'CT')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (11, N'DELAWARE', N'UNITED STATES', N'DE')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (12, N'DISTRICT OF COLUMBIA', N'UNITED STATES', N'DC')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (13, N'FLORIDA', N'UNITED STATES', N'FL')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (14, N'GEORGIA', N'UNITED STATES', N'GA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (15, N'HAWAII', N'UNITED STATES', N'HI')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (16, N'IDAHO', N'UNITED STATES', N'ID')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (17, N'ILLINOIS', N'UNITED STATES', N'IL')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (18, N'INDIANA', N'UNITED STATES', N'IN')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (19, N'IOWA', N'UNITED STATES', N'IA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (20, N'KANSAS', N'UNITED STATES', N'KS')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (21, N'KENTUCKY', N'UNITED STATES', N'KY')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (22, N'LOUISIANA', N'UNITED STATES', N'LA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (23, N'MAINE', N'UNITED STATES', N'ME')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (24, N'MARYLAND', N'UNITED STATES', N'MD')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (25, N'MASSACHUSETTS', N'UNITED STATES', N'MA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (26, N'MICHIGAN', N'UNITED STATES', N'MI')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (27, N'MINNESOTA', N'UNITED STATES', N'MN')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (28, N'MISSISSIPPI', N'UNITED STATES', N'MS')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (29, N'MISSOURI', N'UNITED STATES', N'MO')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (30, N'MONTANA', N'UNITED STATES', N'MT')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (31, N'NEBRASKA', N'UNITED STATES', N'NE')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (32, N'NEVADA', N'UNITED STATES', N'NV')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (33, N'NEW HAMPSHIRE', N'UNITED STATES', N'NH')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (34, N'NEW JERSEY', N'UNITED STATES', N'NJ')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (35, N'NEW MEXICO', N'UNITED STATES', N'NM')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (36, N'NEW YORK', N'UNITED STATES', N'NY')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (37, N'NORTH CAROLINA', N'UNITED STATES', N'NC')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (38, N'NORTH DAKOTA', N'UNITED STATES', N'ND')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (39, N'OHIO', N'UNITED STATES', N'OH')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (40, N'OKLAHOMA', N'UNITED STATES', N'OK')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (41, N'OREGON', N'UNITED STATES', N'OR')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (42, N'PENNSYLVANIA', N'UNITED STATES', N'PA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (43, N'RHODE ISLAND', N'UNITED STATES', N'RI')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (44, N'SOUTH CAROLINA', N'UNITED STATES', N'SC')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (45, N'SOUTH DAKOTA', N'UNITED STATES', N'SD')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (46, N'TENNESSEE', N'UNITED STATES', N'TN')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (47, N'TEXAS', N'UNITED STATES', N'TX')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (48, N'UTAH', N'UNITED STATES', N'UT')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (49, N'VERMONT', N'UNITED STATES', N'VT')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (50, N'VIRGINIA', N'UNITED STATES', N'VA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (51, N'WASHINGTON', N'UNITED STATES', N'WA')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (52, N'WEST VIRGINIA', N'UNITED STATES', N'WV')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (53, N'WISCONSIN', N'UNITED STATES', N'WI')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (54, N'WYOMING', N'UNITED STATES', N'WY')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (55, N'ALBERTA', N'CANADA', N'AB')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (56, N'BRITISH COLUMBIA', N'CANADA', N'BC')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (57, N'MANITOBA', N'CANADA', N'MB')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (58, N'NEW BRUNSWICK', N'CANADA', N'NB')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (59, N'NEWFOUNDLAND AND LABRADOR', N'CANADA', N'NL')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (60, N'NORTHWEST TERRITORIES', N'CANADA', N'NT')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (61, N'NOVA SCOTIA', N'CANADA', N'NS')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (62, N'NUNAVUT', N'CANADA', N'NU')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (63, N'ONTARIO', N'CANADA', N'ON')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (64, N'PRINCE EDWARD ISLAND', N'CANADA', N'PE')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (65, N'QUEBEC', N'CANADA', N'QC')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (66, N'SASKATCHEWAN', N'CANADA', N'SK')
INSERT [dbo].[States] ([stateID], [name], [country], [abbreviation]) VALUES (67, N'YUKON', N'CANADA', N'YT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (1, N'ALLEY', N'ALY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (2, N'ANEX', N'ANX')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (3, N'ARCADE', N'ARC')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (4, N'AVENUE', N'AVE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (5, N'BAYOU', N'BYU')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (6, N'BEACH', N'BCH')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (7, N'BEND', N'BND')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (8, N'BLUFF', N'BLF')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (9, N'BLUFFS', N'BLFS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (10, N'BOTTOM', N'BTM')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (11, N'BOULEVARD', N'BLVD')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (12, N'BRANCH', N'BR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (13, N'BRIDGE', N'BRG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (14, N'BROOK', N'BRK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (15, N'BROOKS', N'BRKS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (16, N'BURG', N'BG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (17, N'BURGS', N'BGS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (18, N'BYPASS', N'BYP')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (19, N'CAMP', N'CP')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (20, N'CANYON', N'CYN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (21, N'CAPE', N'CPE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (22, N'CAUSEWAY', N'CSWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (23, N'CENTER', N'CTR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (24, N'CENTERS', N'CTRS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (25, N'CIRCLE', N'CIR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (26, N'CIRCLES', N'CIRS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (27, N'CLIFF', N'CLF')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (28, N'CLIFFS', N'CLFS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (29, N'CLUB', N'CLB')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (30, N'COMMON', N'CMN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (31, N'COMMONS', N'CMNS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (32, N'CORNER', N'COR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (33, N'CORNERS', N'CORS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (34, N'COURSE', N'CRSE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (35, N'COURT', N'CT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (36, N'COURTS', N'CTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (37, N'COVE', N'CV')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (38, N'COVES', N'CVS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (39, N'CREEK', N'CRK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (40, N'CRESCENT', N'CRES')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (41, N'CREST', N'CRST')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (42, N'CROSSING', N'XING')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (43, N'CROSSROAD', N'XRD')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (44, N'CROSSROADS', N'XRDS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (45, N'CURVE ', N'CURV')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (46, N'DALE', N'DL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (47, N'DAM', N'DM')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (48, N'DIVIDE', N'DV')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (49, N'DRIVE', N'DR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (50, N'DRIVES ', N'DRS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (51, N'ESTATE', N'EST')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (52, N'ESTATES', N'ESTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (53, N'EXPRESSWAY', N'EXPY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (54, N'EXTENSION', N'EXT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (55, N'EXTENSIONS', N'EXTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (56, N'FALL', N'FALL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (57, N'FALLS', N'FLS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (58, N'FERRY', N'FRY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (59, N'FIELD', N'FLD')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (60, N'FIELDS', N'FLDS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (61, N'FLAT', N'FLT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (62, N'FLATS', N'FLTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (63, N'FORD', N'FRD')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (64, N'FORDS', N'FRDS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (65, N'FOREST', N'FRST')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (66, N'FORGE', N'FRG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (67, N'FORGES', N'FRGS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (68, N'FORK', N'FRK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (69, N'FORKS', N'FRKS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (70, N'FORT', N'FT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (71, N'FREEWAY', N'FWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (72, N'GARDEN', N'GDN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (73, N'GARDENS', N'GDNS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (74, N'GATEWAY', N'GTWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (75, N'GLEN', N'GLN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (76, N'GLENS', N'GLNS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (77, N'GREEN', N'GRN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (78, N'GREENS', N'GRNS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (79, N'GROVE', N'GRV')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (80, N'GROVES', N'GRVS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (81, N'HARBOR', N'HBR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (82, N'HARBORS', N'HBRS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (83, N'HAVEN', N'HVN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (84, N'HEIGHTS', N'HTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (85, N'HIGHWAY', N'HWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (86, N'HILL', N'HL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (87, N'HILLS', N'HLS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (88, N'HOLLOW', N'HOLW')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (89, N'INLET', N'INLT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (90, N'ISLAND', N'IS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (91, N'ISLANDS', N'ISS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (92, N'ISLE', N'ISLE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (93, N'JUNCTION', N'JCT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (94, N'JUNCTIONS', N'JCTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (95, N'KEY', N'KY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (96, N'KEYS', N'KYS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (97, N'KNOLL', N'KNL ')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (98, N'KNOLLS', N'KNLS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (99, N'LAKE', N'LK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (100, N'LAKES', N'LKS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (101, N'LAND', N'LAND')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (102, N'LANDING', N'LNDG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (103, N'LANE', N'LN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (104, N'LIGHT', N'LGT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (105, N'LIGHTS', N'LGTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (106, N'LOAF', N'LF')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (107, N'LOCK', N'LCK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (108, N'LOCKS', N'LCKS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (109, N'LODGE', N'LDG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (110, N'LOOP', N'LOOP')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (111, N'MALL', N'MALL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (112, N'MANOR', N'MNR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (113, N'MANORS', N'MNRS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (114, N'MEADOW', N'MDW')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (115, N'MEADOWS', N'MDWS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (116, N'MEWS', N'MEWS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (117, N'MILL', N'ML')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (118, N'MILLS', N'MLS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (119, N'MISSION', N'MSN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (120, N'MOTORWAY', N'MTWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (121, N'MOUNT', N'MT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (122, N'MOUNTAIN', N'MTN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (123, N'MOUNTAINS', N'MTNS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (124, N'NECK', N'NCK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (125, N'ORCHARD', N'ORCH')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (126, N'OVAL', N'OVAL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (127, N'OVERPASS', N'OPAS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (128, N'PARK/PARKS', N'PARK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (129, N'PARKWAY/PARKWAYS', N'PKWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (130, N'PASS', N'PASS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (131, N'PASSAGE', N'PSGE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (132, N'PATH', N'PATH')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (133, N'PIKE', N'PIKE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (134, N'PINE', N'PNE ')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (135, N'PINES', N'PNES')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (136, N'PLACE', N'PL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (137, N'PLAIN', N'PLN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (138, N'PLAINS', N'PLNS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (139, N'PLAZA', N'PLZ')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (140, N'POINT/POINTE', N'PT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (141, N'POINTS', N'PTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (142, N'PORT', N'PRT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (143, N'PORTS', N'PRTS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (144, N'PRAIRIE', N'PR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (145, N'RADIAL', N'RADL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (146, N'RAMP', N'RAMP')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (147, N'RANCH', N'RNCH')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (148, N'RAPID', N'RPD')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (149, N'RAPIDS', N'RPDS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (150, N'REST', N'RST')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (151, N'RIDGE', N'RDG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (152, N'RIDGES', N'RDGS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (153, N'RIVER', N'RIV')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (154, N'ROAD', N'RD')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (155, N'ROADS', N'RDS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (156, N'ROUTE', N'RTE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (157, N'ROW', N'ROW')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (158, N'RUE', N'RUE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (159, N'RUN', N'RUN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (160, N'SHOAL', N'SHL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (161, N'SHOALS', N'SHLS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (162, N'SHORE', N'SHR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (163, N'SHORES', N'SHRS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (164, N'SKYWAY', N'SKWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (165, N'SPRING', N'SPG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (166, N'SPRINGS', N'SPGS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (167, N'SPUR/SPURS', N'SPUR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (168, N'SQUARE', N'SQ')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (169, N'SQUARES', N'SQS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (170, N'STATION', N'STA')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (171, N'STRAVENUE', N'STRA')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (172, N'STREAM', N'STRM')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (173, N'Street', N'ST')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (174, N'Street', N'STS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (175, N'SUMMIT', N'SMT')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (176, N'TERRACE', N'TER')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (177, N'THROUGHWAY', N'TRWY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (178, N'TRACE', N'TRCE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (179, N'TRACK', N'TRAK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (180, N'TRAFFICWAY', N'TRFY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (181, N'TRAIL', N'TRL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (182, N'TRAILER', N'TRLR')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (183, N'TUNNEL', N'TUNL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (184, N'TURNPIKE', N'TPKE')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (185, N'UNDERPASS', N'UPAS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (186, N'UNION', N'UN')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (187, N'UNIONS', N'UNS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (188, N'VALLEY', N'VLY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (189, N'VALLEYS', N'VLYS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (190, N'VIADUCT', N'VIA')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (191, N'VIEW', N'VW')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (192, N'VIEWS', N'VWS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (193, N'VILLAGE', N'VLG')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (194, N'VILLAGES', N'VLGS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (195, N'VILLE', N'VL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (196, N'VISTA', N'VIS')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (197, N'WALK/WALKS', N'WALK')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (198, N'WALL', N'WALL')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (199, N'WAY', N'WAY')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (200, N'WAYS', N'WAYS')
GO
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (201, N'WELL', N'WL ')
INSERT [dbo].[Streets] ([streetID], [name], [abbreviation]) VALUES (202, N'WELLS', N'WLS')
/****** Object:  Index [fk_Furniture_Category1_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Furniture_Category1_idx] ON [dbo].[Furniture]
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Furniture_Style_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Furniture_Style_idx] ON [dbo].[Furniture]
(
	[styleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Login_Employee1_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Login_Employee1_idx] ON [dbo].[Login]
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_Member_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_Member_idx] ON [dbo].[Rental]
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_Store_item_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_Store_item_idx] ON [dbo].[Rental]
(
	[itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_return_transaction_Rental_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_return_transaction_Rental_idx] ON [dbo].[Rental_return_transaction]
(
	[rentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_return_transaction_Transacation_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_return_transaction_Transacation_idx] ON [dbo].[Rental_return_transaction]
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_transaction_Rental_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_transaction_Rental_idx] ON [dbo].[Rental_transaction]
(
	[rentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Rental_transaction_Transacation_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Rental_transaction_Transacation_idx] ON [dbo].[Rental_transaction]
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Inventory_Furniture1_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Inventory_Furniture1_idx] ON [dbo].[Store_item]
(
	[furnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Transactions_Employee_idx]    Script Date: 4/1/2018 12:58:30 PM ******/
CREATE NONCLUSTERED INDEX [fk_Transactions_Employee_idx] ON [dbo].[Transactions]
(
	[employeeID] ASC
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
