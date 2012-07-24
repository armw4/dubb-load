USE [DubbLoad]
GO

/****** Object:  Table [FileAuthorization].[Group]    Script Date: 07/24/2012 00:10:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [FileAuthorization].[Group](
	[Name] [varchar](50) NOT NULL,
	[Roles] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_FileAuthorization.Group] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


