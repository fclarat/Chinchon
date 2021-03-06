USE [master]
GO
/****** Object:  Database [chinchon]    Script Date: 21-Oct-18 7:55:54 PM ******/
CREATE DATABASE [chinchon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'chinchon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\chinchon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'chinchon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\chinchon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [chinchon] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [chinchon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [chinchon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [chinchon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [chinchon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [chinchon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [chinchon] SET ARITHABORT OFF 
GO
ALTER DATABASE [chinchon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [chinchon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [chinchon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [chinchon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [chinchon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [chinchon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [chinchon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [chinchon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [chinchon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [chinchon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [chinchon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [chinchon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [chinchon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [chinchon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [chinchon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [chinchon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [chinchon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [chinchon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [chinchon] SET  MULTI_USER 
GO
ALTER DATABASE [chinchon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [chinchon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [chinchon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [chinchon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [chinchon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [chinchon] SET QUERY_STORE = OFF
GO
USE [chinchon]
GO
/****** Object:  Table [dbo].[carta]    Script Date: 21-Oct-18 7:55:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NOT NULL,
	[palo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_carta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 21-Oct-18 7:55:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_user] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[puntos] [int] NOT NULL,
	[partidas_jugadas] [int] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarCartas]    Script Date: 21-Oct-18 7:55:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ConsultarCartas]
AS
SELECT id, numero, palo FROM carta
GO;

GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 21-Oct-18 7:55:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_usuario]
@usuario varchar(50),@pass varchar(50)
as
begin

declare @id int

set @id = ISNULL((select max(id_user) from usuario),0) +1 

insert into usuario  (id_user,pass, usuario,puntos,partidas_jugadas) 
values (@id, @usuario,@pass,0,0)
end

GO
/****** Object:  StoredProcedure [dbo].[loguear_usuario]    Script Date: 21-Oct-18 7:55:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loguear_usuario]
@usuario varchar(50),@pass varchar(50)
as
begin
select id_user , usuario,puntos,partidas_jugadas 
from usuario
where usuario=@usuario and pass=@pass
end
GO
USE [master]
GO
ALTER DATABASE [chinchon] SET  READ_WRITE 
GO
