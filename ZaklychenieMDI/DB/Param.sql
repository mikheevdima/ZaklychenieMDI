USE [ZakluchenieMDI]
GO

/****** Object:  Table [dbo].[Parameters]    Script Date: 23.11.2016 1:49:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Parameters](
	[id] [uniqueidentifier] NULL,
	[seti] [nvarchar](50) NOT NULL,
	[tkfrom] [nvarchar](50) NOT NULL,
	[tkto] [nvarchar](50) NOT NULL,
	[shirota] [nvarchar](50) NULL,
	[dolgota] [nvarchar](50) NULL,
	[d] [nvarchar](50) NOT NULL,
	[l] [nvarchar](50) NOT NULL,
	[izolyacia] [nvarchar](50) NOT NULL,
	[pokritie] [nvarchar](50) NOT NULL,
	[prokladka] [nvarchar](50) NOT NULL,
	[allequipment] [nvarchar](500) NOT NULL,
	[priznaki] [nvarchar](100) NOT NULL,
	[pomehi] [nvarchar](100) NOT NULL,
	[stepen] [nvarchar](100) NOT NULL,
	[analiz] [nvarchar](50) NOT NULL,
	[primechanie] [nvarchar](256) NULL,
	[pic] [binary](50) NOT NULL,
	[goal] [nvarchar](100) NOT NULL,
	[ispolnitel] [nvarchar](50) NOT NULL,
	[nachalnik] [nvarchar](50) NOT NULL,
	[date] [nvarchar](50) NOT NULL,
	[results] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

