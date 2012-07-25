USE [DubbLoad]
GO

/****** Object:  Table [FileAuthorization].[Topic]    Script Date: 07/24/2012 00:11:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [FileAuthorization].[Topic](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FileGroupId] [varchar](50) NOT NULL,
	[Roles] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_FileAuthorization.Topic] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Name_FileGroupId] UNIQUE NONCLUSTERED 
(
	[Name] ASC,
	[FileGroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [FileAuthorization].[Topic]  WITH CHECK ADD  CONSTRAINT [FK_Topic_Group] FOREIGN KEY([FileGroupId])
REFERENCES [FileAuthorization].[Group] ([Name])
GO

ALTER TABLE [FileAuthorization].[Topic] CHECK CONSTRAINT [FK_Topic_Group]
GO


