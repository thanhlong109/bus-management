USE [master]
GO
/****** Object:  Database [BusDB]    Script Date: 08/06/2023 4:55:11 CH ******/
CREATE DATABASE [BusDB]
 
GO
ALTER DATABASE [BusDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BusDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BusDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusDB] SET  MULTI_USER 
GO
ALTER DATABASE [BusDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BusDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BusDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BusDB] SET QUERY_STORE = OFF
GO
USE [BusDB]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 08/06/2023 4:55:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[account_id] [nvarchar](50) NOT NULL,
	[username] [nvarchar](30) NULL,
	[password] [nvarchar](30) NULL,
	[full_name] [nvarchar](40) NULL,
	[dob] [datetime] NULL,
	[email] [nvarchar](50) NULL,
	[phone_number] [nvarchar](12) NULL,
	[role] [nvarchar](30) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBus]    Script Date: 08/06/2023 4:55:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBus](
	[bus_id] [nvarchar](10) NOT NULL,
	[number_plate] [nvarchar](10) NULL,
	[bus_type] [nvarchar](15) NULL,
	[seat_quantity] [int] NULL,
	[engine_ouput] [int] NULL,
	[manufacturing_date] [datetime] NULL,
	[expiration_date] [datetime] NULL,
	[periodic_maintenance] [int] NULL,
	[routes_id] [nvarchar](10) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblBus] PRIMARY KEY CLUSTERED 
(
	[bus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBusRoutes]    Script Date: 08/06/2023 4:55:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBusRoutes](
	[routes_id] [nvarchar](10) NOT NULL,
	[transport_unit_id] [nvarchar](10) NULL,
	[routes_name] [nvarchar](50) NULL,
	[start_time] [time](7) NULL,
	[end_time] [time](7) NULL,
	[estimated_time] [int] NULL,
	[start_point] [nvarchar](100) NULL,
	[end_point] [nvarchar](100) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblBusRoutes] PRIMARY KEY CLUSTERED 
(
	[routes_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDriver]    Script Date: 08/06/2023 4:55:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDriver](
	[driver_id] [nvarchar](10) NOT NULL,
	[driver_name] [nvarchar](40) NULL,
	[dob] [datetime] NULL,
	[gender] [nvarchar](10) NULL,
	[address] [nvarchar](100) NULL,
	[start_date] [datetime] NULL,
	[salary] [decimal](10, 2) NULL,
	[bus_id] [nvarchar](10) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblDriver] PRIMARY KEY CLUSTERED 
(
	[driver_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTransportUnit]    Script Date: 08/06/2023 4:55:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTransportUnit](
	[transport_unit_id] [nvarchar](10) NOT NULL,
	[transport_unit_name] [nvarchar](50) NULL,
	[address] [nvarchar](100) NULL,
	[phone_number] [nvarchar](12) NULL,
	[email] [nvarchar](50) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblTransportUnit] PRIMARY KEY CLUSTERED 
(
	[transport_unit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role], [is_active]) VALUES (N'test', N'test', N'123', N'long', CAST(N'2000-11-23T00:00:00.000' AS DateTime), N'long@gmail', N'0213135', N'quan ly', 1)
GO
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [expiration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'b01', N'64A-1765', N'co nho', 25, 6400, CAST(N'2019-05-16T00:00:00.000' AS DateTime), CAST(N'2025-06-12T00:00:00.000' AS DateTime), 6, N'r01', 1)
GO
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'r01', N'tu01', N'tan binh - binh tan', CAST(N'07:00:00' AS Time), CAST(N'19:00:00' AS Time), 60, N'tan binh', N'binh tan', 1)
GO
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'd1', N'chien thang', CAST(N'2022-11-23T00:00:00.000' AS DateTime), N'other', N'thu duc', CAST(N'2023-06-06T00:00:00.000' AS DateTime), CAST(6000000.00 AS Decimal(10, 2)), N'b01', 1)
GO
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'tu01', N'binh tan', N'binh tan 123', N'03254656', N'binhtan@jdjdj', 1)
GO
ALTER TABLE [dbo].[tblBus]  WITH CHECK ADD  CONSTRAINT [FK_tblBus_tblBusRoutes] FOREIGN KEY([routes_id])
REFERENCES [dbo].[tblBusRoutes] ([routes_id])
GO
ALTER TABLE [dbo].[tblBus] CHECK CONSTRAINT [FK_tblBus_tblBusRoutes]
GO
ALTER TABLE [dbo].[tblBusRoutes]  WITH CHECK ADD  CONSTRAINT [FK_tblBusRoutes_tblTransportUnit] FOREIGN KEY([transport_unit_id])
REFERENCES [dbo].[tblTransportUnit] ([transport_unit_id])
GO
ALTER TABLE [dbo].[tblBusRoutes] CHECK CONSTRAINT [FK_tblBusRoutes_tblTransportUnit]
GO
ALTER TABLE [dbo].[tblDriver]  WITH CHECK ADD  CONSTRAINT [FK_tblDriver_tblBus] FOREIGN KEY([bus_id])
REFERENCES [dbo].[tblBus] ([bus_id])
GO
ALTER TABLE [dbo].[tblDriver] CHECK CONSTRAINT [FK_tblDriver_tblBus]
GO
USE [master]
GO
ALTER DATABASE [BusDB] SET  READ_WRITE 
GO
