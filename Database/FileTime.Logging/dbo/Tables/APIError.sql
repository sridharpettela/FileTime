CREATE TABLE [dbo].[APIError](
	[APIErrorId] [uniqueidentifier] NOT NULL,
	[RequestMethod] [varchar](100) NULL,
	[RequestUri] [varchar](100) NULL,
	[TimeUtc] [datetime] NULL,
	[Message] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_API_Error] PRIMARY KEY CLUSTERED 
(
	[APIErrorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[APIError] ADD  CONSTRAINT [DF_API_Error_APIErrorId]  DEFAULT (newid()) FOR [APIErrorId]
GO
