USE [master]
GO
/****** Object:  Database [LoginRegistro]    Script Date: 3/10/2023 12:11:17 ******/
CREATE DATABASE [LoginRegistro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoginRegistro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LoginRegistro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LoginRegistro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LoginRegistro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LoginRegistro] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoginRegistro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoginRegistro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoginRegistro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoginRegistro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoginRegistro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoginRegistro] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoginRegistro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LoginRegistro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoginRegistro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoginRegistro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoginRegistro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoginRegistro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoginRegistro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoginRegistro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoginRegistro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoginRegistro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LoginRegistro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoginRegistro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoginRegistro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoginRegistro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoginRegistro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoginRegistro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LoginRegistro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoginRegistro] SET RECOVERY FULL 
GO
ALTER DATABASE [LoginRegistro] SET  MULTI_USER 
GO
ALTER DATABASE [LoginRegistro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoginRegistro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoginRegistro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoginRegistro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LoginRegistro] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LoginRegistro', N'ON'
GO
ALTER DATABASE [LoginRegistro] SET QUERY_STORE = OFF
GO
USE [LoginRegistro]
GO
/****** Object:  User [alumno]    Script Date: 3/10/2023 12:11:17 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/10/2023 12:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[username] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Usuario] ([username], [contrasenia], [nombre], [apellido], [mail]) VALUES (N'chinardo', N'megustanlaspijas', N'chinocapo111', N'Lantern', N'yellow@chino.com')
INSERT [dbo].[Usuario] ([username], [contrasenia], [nombre], [apellido], [mail]) VALUES (N'maxisher', N'maxi', N'maxi', N'maxi', N'maxi@maxi')
GO
USE [master]
GO
ALTER DATABASE [LoginRegistro] SET  READ_WRITE 
GO
