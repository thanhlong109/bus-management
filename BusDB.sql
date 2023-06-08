USE [master]
GO
/****** Object:  Database [BusDB]    Script Date: 6/6/2023 9:46:43 PM **/
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
/****** Object:  Table [dbo].[tblAccount]    Script Date: 6/6/2023 9:46:43 PM ******/
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
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBus]    Script Date: 6/6/2023 9:46:44 PM ******/
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
 CONSTRAINT [PK_tblBus] PRIMARY KEY CLUSTERED 
(
	[bus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBusRoutes]    Script Date: 6/6/2023 9:46:44 PM ******/
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
 CONSTRAINT [PK_tblBusRoutes] PRIMARY KEY CLUSTERED 
(
	[routes_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDriver]    Script Date: 6/6/2023 9:46:44 PM ******/
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
 CONSTRAINT [PK_tblDriver] PRIMARY KEY CLUSTERED 
(
	[driver_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTransportUnit]    Script Date: 6/6/2023 9:46:44 PM ******/
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
 CONSTRAINT [PK_tblTransportUnit] PRIMARY KEY CLUSTERED 
(
	[transport_unit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role]) VALUES (N'ACCT001', N'long', N'123', N'Nguyễn Thành Long', CAST(N'2000-11-23T00:00:00.000' AS DateTime), N'long@gmail', N'0213135', N'quan ly')
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role]) VALUES (N'ACCT002', N'dat', N'123', N'Trần Gia Thành Đạt', CAST(N'2002-09-02T00:00:00.000' AS DateTime), N'dat@gmail.com', N'0123123', N'nhan vien')
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role]) VALUES (N'ACCT003', N'an', N'123', N'Lê Hoàng An', CAST(N'2002-01-01T00:00:00.000' AS DateTime), N'anlee@gmail.com', N'0111222', N'nhan vien')
GO
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [expiration_date], [periodic_maintenance], [routes_id]) VALUES (N'B01', N'64A-1765', N'cỡ nhỏ', 25, 6400, CAST(N'2019-05-16T00:00:00.000' AS DateTime), CAST(N'2025-06-12T00:00:00.000' AS DateTime), 6, N'R01')
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [expiration_date], [periodic_maintenance], [routes_id]) VALUES (N'B02', N'51B-123.45', N'cỡ nhỏ', 25, 6400, CAST(N'2019-10-02T00:00:00.000' AS DateTime), CAST(N'2025-10-02T00:00:00.000' AS DateTime), 6, N'R02')
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [expiration_date], [periodic_maintenance], [routes_id]) VALUES (N'B03', N'51B-111.11', N'cỡ trung', 30, 6969, CAST(N'2019-06-05T00:00:00.000' AS DateTime), CAST(N'2025-06-05T00:00:00.000' AS DateTime), 6, N'R03')
GO
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point]) VALUES (N'R01', N'TU01', N'tan binh - binh tan', CAST(N'07:00:00' AS Time), CAST(N'19:00:00' AS Time), 60, N'tan binh', N'binh tan')
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point]) VALUES (N'R02', N'TU02', N'Bến xe An Sương - Tân Quy', CAST(N'05:00:00' AS Time), CAST(N'19:00:00' AS Time), 60, N'Bến xe An Sương', N'Tân Quy')
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point]) VALUES (N'R03', N'TU03', N'Bến Thành- BX Chợ Lớn', CAST(N'05:00:00' AS Time), CAST(N'20:30:00' AS Time), 60, N'Bến Thành', N'BX Chợ Lớn')
GO
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id]) VALUES (N'D01', N'Nguyễn Chiến Thắng', CAST(N'2022-11-23T00:00:00.000' AS DateTime), N'other', N'Thủ Đức', CAST(N'2023-06-06T00:00:00.000' AS DateTime), CAST(6000000.00 AS Decimal(10, 2)), N'B01')
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id]) VALUES (N'D02', N'Võ Ngọc Tấn Dũng', CAST(N'2002-02-02T00:00:00.000' AS DateTime), N'male', N'Thủ Đức', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(6000000.00 AS Decimal(10, 2)), N'B02')
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id]) VALUES (N'D03', N'Bùi Đức Trí', CAST(N'2002-05-05T00:00:00.000' AS DateTime), N'female', N'Đồng Nai', CAST(N'2023-02-02T00:00:00.000' AS DateTime), CAST(10000000.00 AS Decimal(10, 2)), N'B03')
GO
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email]) VALUES (N'TU01', N'binh tan', N'binh tan 123', N'03254656', N'binhtan@jdjdj')
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email]) VALUES (N'TU02', N'an suong', N'BX An Sương', N'01233211', N'ansuong@bxas')
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email]) VALUES (N'TU03', N'ben thanh', N'Bến Thành', N'09876543', N'benthanh@vjppro')
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
