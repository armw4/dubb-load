USE [DubbLoad]
GO

/****** Object:  Table [FileAuthorization].[Descriminator]    Script Date: 07/24/2012 00:10:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [FileAuthorization].[Descriminator](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FileGroupTopicId] [uniqueidentifier] NOT NULL,
	[Roles] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_FileAuthorization.Descriminator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Name_FileGroupTopicId] UNIQUE NONCLUSTERED 
(
	[Name] ASC,
	[FileGroupTopicId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [FileAuthorization].[Descriminator]  WITH CHECK ADD  CONSTRAINT [FK_Descriminator_Topic] FOREIGN KEY([FileGroupTopicId])
REFERENCES [FileAuthorization].[Topic] ([Id])
GO

ALTER TABLE [FileAuthorization].[Descriminator] CHECK CONSTRAINT [FK_Descriminator_Topic]
GO


