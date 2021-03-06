USE [University]
GO
/****** Object:  Table [dbo].[department_tbl]    Script Date: 12-Sep-18 2:03:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[department_tbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[depCode] [varchar](50) NOT NULL,
	[depName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_department_tbl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[department_tbl] ON 

INSERT [dbo].[department_tbl] ([id], [depCode], [depName]) VALUES (1, N'Testing', N'150')
INSERT [dbo].[department_tbl] ([id], [depCode], [depName]) VALUES (2, N'CSE101', N'CSE')
SET IDENTITY_INSERT [dbo].[department_tbl] OFF
