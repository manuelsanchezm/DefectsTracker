USE [defects_tracker]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[defect]') AND type in (N'U'))
DROP TABLE [dbo].[defect]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[defect](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[defect_title] [nvarchar](50) NOT NULL,
	[description] [nvarchar](MAX) NULL,
	[defect_type] [tinyint] NOT NULL,
	[defect_priority] [tinyint] NOT NULL,
	[assigned_user] [int] NULL,
	[reported_user] [int] NOT NULL,
	[created_date] [date] NOT NULL,
	[modified_date] [date] NOT NULL,
 CONSTRAINT [defects_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
