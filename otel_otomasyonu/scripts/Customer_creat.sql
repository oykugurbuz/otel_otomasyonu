USE [GURBUZHOTEL]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 20.09.2023 16:01:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](50) NULL,
	[identy_number] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[birthdate] [datetime] NULL,
	[room_number] [nvarchar](50) NULL,
	[price] [int] NULL,
	[check_in] [datetime] NULL,
	[check_out] [datetime] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_check_in]  DEFAULT (getdate()) FOR [check_in]
GO

ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_check_out]  DEFAULT (getdate()) FOR [check_out]
GO


