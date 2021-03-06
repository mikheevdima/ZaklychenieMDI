USE [master]
GO

/****** Object:  Database [ZakluchenieMDI]    Script Date: 23.11.2016 1:45:01 ******/
DROP DATABASE [ZakluchenieMDI]
GO

/****** Object:  Database [ZakluchenieMDI]    Script Date: 23.11.2016 1:45:01 ******/
CREATE DATABASE [ZakluchenieMDI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZakluchenieMDI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ZakluchenieMDI.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ZakluchenieMDI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ZakluchenieMDI_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ZakluchenieMDI] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZakluchenieMDI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ZakluchenieMDI] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET ARITHABORT OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ZakluchenieMDI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ZakluchenieMDI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ZakluchenieMDI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ZakluchenieMDI] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ZakluchenieMDI] SET  MULTI_USER 
GO

ALTER DATABASE [ZakluchenieMDI] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ZakluchenieMDI] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ZakluchenieMDI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ZakluchenieMDI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ZakluchenieMDI] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ZakluchenieMDI] SET  READ_WRITE 
GO

