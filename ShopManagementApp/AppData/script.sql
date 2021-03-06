USE [master]
GO
/****** Object:  Database [shop_management_db]    Script Date: 4/15/2021 1:52:55 AM ******/
CREATE DATABASE [shop_management_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shop_management_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\shop_management_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'shop_management_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\shop_management_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [shop_management_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shop_management_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [shop_management_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [shop_management_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [shop_management_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [shop_management_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [shop_management_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [shop_management_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [shop_management_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [shop_management_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [shop_management_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [shop_management_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [shop_management_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [shop_management_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [shop_management_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [shop_management_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [shop_management_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [shop_management_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [shop_management_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [shop_management_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [shop_management_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [shop_management_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [shop_management_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [shop_management_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [shop_management_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [shop_management_db] SET  MULTI_USER 
GO
ALTER DATABASE [shop_management_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [shop_management_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [shop_management_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [shop_management_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [shop_management_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [shop_management_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [shop_management_db] SET QUERY_STORE = OFF
GO
USE [shop_management_db]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 4/15/2021 1:52:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone_number] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NULL,
	[type] [nvarchar](50) NOT NULL,
	[orders_number] [int] NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer_orders]    Script Date: 4/15/2021 1:52:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer_orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
 CONSTRAINT [PK_customer_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_products]    Script Date: 4/15/2021 1:52:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[product_id] [nvarchar](50) NOT NULL,
	[product_amount] [int] NOT NULL,
 CONSTRAINT [PK_order_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 4/15/2021 1:52:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[price] [float] NOT NULL,
	[created] [datetime] NOT NULL,
	[status] [nchar](10) NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 4/15/2021 1:52:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[brand] [nvarchar](50) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[subtype] [nvarchar](50) NOT NULL,
	[color] [nvarchar](50) NOT NULL,
	[size] [nchar](10) NOT NULL,
	[price] [float] NOT NULL,
	[discount] [int] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT (' ') FOR [name]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT (' ') FOR [surname]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT (' ') FOR [address]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT (' ') FOR [phone_number]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT (' ') FOR [email]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT (' ') FOR [type]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT ((0)) FOR [orders_number]
GO
USE [master]
GO
ALTER DATABASE [shop_management_db] SET  READ_WRITE 
GO
