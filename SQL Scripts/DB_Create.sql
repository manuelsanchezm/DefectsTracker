﻿USE [master]
GO

/****** Object:  Database [defects_tracker]    Script Date: 2020-10-02 3:31:15 PM ******/
DROP DATABASE [defects_tracker]
GO

/****** Object:  Database [defects_tracker]    Script Date: 2020-10-02 3:31:15 PM ******/
CREATE DATABASE [defects_tracker]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'defects_tracker', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\defects_tracker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DefectsTracker_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DefectsTracker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [defects_tracker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [defects_tracker] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [defects_tracker] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [defects_tracker] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [defects_tracker] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [defects_tracker] SET ARITHABORT OFF 
GO

ALTER DATABASE [defects_tracker] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [defects_tracker] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [defects_tracker] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [defects_tracker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [defects_tracker] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [defects_tracker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [defects_tracker] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [defects_tracker] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [defects_tracker] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [defects_tracker] SET  DISABLE_BROKER 
GO

ALTER DATABASE [defects_tracker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [defects_tracker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [defects_tracker] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [defects_tracker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [defects_tracker] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [defects_tracker] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [defects_tracker] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [defects_tracker] SET RECOVERY FULL 
GO

ALTER DATABASE [defects_tracker] SET  MULTI_USER 
GO

ALTER DATABASE [defects_tracker] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [defects_tracker] SET DB_CHAINING OFF 
GO

ALTER DATABASE [defects_tracker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [defects_tracker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [defects_tracker] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [defects_tracker] SET QUERY_STORE = OFF
GO

ALTER DATABASE [defects_tracker] SET  READ_WRITE 
GO


