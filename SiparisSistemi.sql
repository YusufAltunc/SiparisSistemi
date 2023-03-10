USE [master]
GO
/****** Object:  Database [Siparis_Otomasyon]    Script Date: 27.02.2023 00:21:44 ******/
CREATE DATABASE [Siparis_Otomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Siparis_Otomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Siparis_Otomasyon.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Siparis_Otomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Siparis_Otomasyon_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Siparis_Otomasyon] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Siparis_Otomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Siparis_Otomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Siparis_Otomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Siparis_Otomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Siparis_Otomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Siparis_Otomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Siparis_Otomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [Siparis_Otomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Siparis_Otomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Siparis_Otomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Siparis_Otomasyon] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Siparis_Otomasyon] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Siparis_Otomasyon]
GO
/****** Object:  Table [dbo].[Tbl_Admin]    Script Date: 27.02.2023 00:21:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Admin](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[kullaniciadi] [varchar](25) NULL,
	[sifre] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Musteri]    Script Date: 27.02.2023 00:21:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Musteri](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](20) NULL,
	[soyad] [varchar](15) NULL,
	[adres] [varchar](70) NULL,
	[tc] [varchar](15) NULL,
	[kullanıcıadı] [varchar](25) NULL,
	[sifre] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Urun]    Script Date: 27.02.2023 00:21:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Urun](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[urunadi] [varchar](15) NULL,
	[urunfiyat] [int] NULL,
	[uruntoplamkg] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Admin] ON 

INSERT [dbo].[Tbl_Admin] ([ID], [kullaniciadi], [sifre]) VALUES (1, N'yusuf', N'1234')
INSERT [dbo].[Tbl_Admin] ([ID], [kullaniciadi], [sifre]) VALUES (2, N'alper', N'1111')
INSERT [dbo].[Tbl_Admin] ([ID], [kullaniciadi], [sifre]) VALUES (3, N'zilan', N'4444')
INSERT [dbo].[Tbl_Admin] ([ID], [kullaniciadi], [sifre]) VALUES (4, N'mustafa', N'5555')
SET IDENTITY_INSERT [dbo].[Tbl_Admin] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Musteri] ON 

INSERT [dbo].[Tbl_Musteri] ([ID], [ad], [soyad], [adres], [tc], [kullanıcıadı], [sifre]) VALUES (1, N'yusuf', N'altunç', N'Hasan ferdi fakultesi', N'1', NULL, NULL)
INSERT [dbo].[Tbl_Musteri] ([ID], [ad], [soyad], [adres], [tc], [kullanıcıadı], [sifre]) VALUES (2, N'alper', N'polat', N'yılmazlar mahallesi leylak sokak no:39 daire:3 turgutlu manisa', N'22222222222', N'alper', N'3333')
INSERT [dbo].[Tbl_Musteri] ([ID], [ad], [soyad], [adres], [tc], [kullanıcıadı], [sifre]) VALUES (3, N'mustafa', N'ayhan', N'guzlebahce izmir', N'66666666666', N'ayhan', N'7777')
INSERT [dbo].[Tbl_Musteri] ([ID], [ad], [soyad], [adres], [tc], [kullanıcıadı], [sifre]) VALUES (4, N'zilan', N'elektoz', N'manisa trugutlu', N'99999999999', N'elektoz', N'12345')
INSERT [dbo].[Tbl_Musteri] ([ID], [ad], [soyad], [adres], [tc], [kullanıcıadı], [sifre]) VALUES (5, N'Arif', N'Özok', N'batman belde mah.', N'12345678901', N'arif', N'2223')
SET IDENTITY_INSERT [dbo].[Tbl_Musteri] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Urun] ON 

INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (4, N'elma', 5, 100)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (5, N'armut', 7, 50)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (6, N'portakal', 3, 75)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (7, N'ananas', 15, 25)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (13, N'Karpuz', 1, 30)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (9, N'muz', 12, 10)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (10, N'nar', 5, 20)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (11, N'ahududu', 10, 20)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (12, N'dut', 10, 30)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (14, N'kavun', 0, 60)
INSERT [dbo].[Tbl_Urun] ([id], [urunadi], [urunfiyat], [uruntoplamkg]) VALUES (15, N'çilek', 3, 30)
SET IDENTITY_INSERT [dbo].[Tbl_Urun] OFF
USE [master]
GO
ALTER DATABASE [Siparis_Otomasyon] SET  READ_WRITE 
GO
