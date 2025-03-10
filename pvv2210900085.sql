USE [pvv2210900085]
GO
/****** Object:  Table [dbo].[PvvCategory]    Script Date: 04/07/2024 10:17:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PvvCategory](
	[PvvID] [int] IDENTITY(1,1) NOT NULL,
	[PvvCateName] [nvarchar](50) NULL,
	[PvvStatus] [bit] NULL,
 CONSTRAINT [PK_PvvCategory] PRIMARY KEY CLUSTERED 
(
	[PvvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PvvProduct]    Script Date: 04/07/2024 10:17:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PvvProduct](
	[Pvvid2210900085] [nvarchar](50) NOT NULL,
	[PvvProName] [nvarchar](50) NULL,
	[PvvQty] [int] NULL,
	[PvvPrice] [float] NULL,
	[PvvCateId] [int] NULL,
	[PvvActive] [bit] NULL,
 CONSTRAINT [PK_PvvProduct] PRIMARY KEY CLUSTERED 
(
	[Pvvid2210900085] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PvvCategory] ON 

INSERT [dbo].[PvvCategory] ([PvvID], [PvvCateName], [PvvStatus]) VALUES (1, N'2210900085', 1)
INSERT [dbo].[PvvCategory] ([PvvID], [PvvCateName], [PvvStatus]) VALUES (2, N'iphone', 0)
SET IDENTITY_INSERT [dbo].[PvvCategory] OFF
GO
INSERT [dbo].[PvvProduct] ([Pvvid2210900085], [PvvProName], [PvvQty], [PvvPrice], [PvvCateId], [PvvActive]) VALUES (N'2210900085', N'phan viet vuong', 10, 1000, 1, 1)
INSERT [dbo].[PvvProduct] ([Pvvid2210900085], [PvvProName], [PvvQty], [PvvPrice], [PvvCateId], [PvvActive]) VALUES (N'p001', N'iphone11', 1, 2000, 1, 1)
GO
