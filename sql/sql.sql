USE [ProjectB]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 15.2.2021 12:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[mus_recno] [int] IDENTITY(1,1) NOT NULL,
	[mus_kod] [nvarchar](36) NOT NULL,
	[mus_ad] [nvarchar](72) NULL,
	[mus_adres1] [nvarchar](144) NULL,
	[mus_adres2] [nvarchar](144) NULL,
	[mus_adres3] [nvarchar](144) NULL,
	[mus_telefon] [nvarchar](36) NULL,
	[mus_email] [nvarchar](144) NULL,
 CONSTRAINT [PK_musteri] PRIMARY KEY CLUSTERED 
(
	[mus_kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 15.2.2021 12:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[sat_recno] [int] IDENTITY(1,1) NOT NULL,
	[sat_musterikodu] [nvarchar](36) NULL,
	[sat_evrakno] [nvarchar](36) NOT NULL,
	[sat_evraktarihi] [datetime] NULL,
	[sat_aciklama] [nvarchar](72) NULL,
 CONSTRAINT [PK_satis] PRIMARY KEY CLUSTERED 
(
	[sat_evrakno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satisdetay]    Script Date: 15.2.2021 12:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satisdetay](
	[sad_recno] [int] IDENTITY(1,1) NOT NULL,
	[sad_satisevrakno] [nvarchar](36) NULL,
	[sad_urunkodu] [nvarchar](36) NULL,
	[sad_miktar] [float] NULL,
	[sad_fiyat] [float] NULL,
	[sad_tutar] [float] NULL,
	[sad_kdvorani] [float] NULL,
	[sad_kdvtutari] [float] NULL,
	[sad_geneltoplam] [float] NULL,
 CONSTRAINT [PK_satisdetay] PRIMARY KEY CLUSTERED 
(
	[sad_recno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satisrapor]    Script Date: 15.2.2021 12:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satisrapor](
	[evrakno] [int] IDENTITY(1,1) NOT NULL,
	[evraktarihi] [datetime] NOT NULL,
	[mus_kod] [nvarchar](50) NULL,
	[mus_ad] [nvarchar](50) NULL,
	[satis_tutar] [int] NULL,
 CONSTRAINT [PK_satisrapor] PRIMARY KEY CLUSTERED 
(
	[evrakno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun]    Script Date: 15.2.2021 12:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun](
	[uru_recno] [int] IDENTITY(1,1) NOT NULL,
	[uru_kod] [nvarchar](36) NOT NULL,
	[uru_ad] [nvarchar](72) NULL,
	[uru_birim] [nvarchar](18) NULL,
	[uru_fiyat] [float] NULL,
	[uru_kdvorani] [float] NULL,
 CONSTRAINT [PK_urun] PRIMARY KEY CLUSTERED 
(
	[uru_kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[musteri] ON 

INSERT [dbo].[musteri] ([mus_recno], [mus_kod], [mus_ad], [mus_adres1], [mus_adres2], [mus_adres3], [mus_telefon], [mus_email]) VALUES (1, N'1', N'musteri', N'adres1', N'adres2', N'adres3', N'0546', N'hs')
INSERT [dbo].[musteri] ([mus_recno], [mus_kod], [mus_ad], [mus_adres1], [mus_adres2], [mus_adres3], [mus_telefon], [mus_email]) VALUES (4, N'2', N'ahmet', N'adres', N'adres', N'adres', N'0546', N'gh')
INSERT [dbo].[musteri] ([mus_recno], [mus_kod], [mus_ad], [mus_adres1], [mus_adres2], [mus_adres3], [mus_telefon], [mus_email]) VALUES (5, N'3', N'hasan', N'adres', N'adres', N'adres', N'0546', N'hj')
SET IDENTITY_INSERT [dbo].[musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[satis] ON 

INSERT [dbo].[satis] ([sat_recno], [sat_musterikodu], [sat_evrakno], [sat_evraktarihi], [sat_aciklama]) VALUES (23, N'2', N'252', CAST(N'2021-02-13T13:08:34.903' AS DateTime), N'uzun')
INSERT [dbo].[satis] ([sat_recno], [sat_musterikodu], [sat_evrakno], [sat_evraktarihi], [sat_aciklama]) VALUES (24, N'2', N'658', CAST(N'2021-02-13T13:17:19.440' AS DateTime), N'uzun')
SET IDENTITY_INSERT [dbo].[satis] OFF
GO
SET IDENTITY_INSERT [dbo].[satisdetay] ON 

INSERT [dbo].[satisdetay] ([sad_recno], [sad_satisevrakno], [sad_urunkodu], [sad_miktar], [sad_fiyat], [sad_tutar], [sad_kdvorani], [sad_kdvtutari], [sad_geneltoplam]) VALUES (4, N'252', N'25', 10, 10.100000381469727, 10, 10.100000381469727, 10, 10)
INSERT [dbo].[satisdetay] ([sad_recno], [sad_satisevrakno], [sad_urunkodu], [sad_miktar], [sad_fiyat], [sad_tutar], [sad_kdvorani], [sad_kdvtutari], [sad_geneltoplam]) VALUES (5, N'252', N'32', 10, 10.850000381469727, 10, 10.75, 10, 10)
INSERT [dbo].[satisdetay] ([sad_recno], [sad_satisevrakno], [sad_urunkodu], [sad_miktar], [sad_fiyat], [sad_tutar], [sad_kdvorani], [sad_kdvtutari], [sad_geneltoplam]) VALUES (6, N'252', N'34', 10, 10.149999618530273, 10, 10.25, 10, 10)
INSERT [dbo].[satisdetay] ([sad_recno], [sad_satisevrakno], [sad_urunkodu], [sad_miktar], [sad_fiyat], [sad_tutar], [sad_kdvorani], [sad_kdvtutari], [sad_geneltoplam]) VALUES (7, N'658', N'23', 10, 10, 10, 10, 10, 10)
INSERT [dbo].[satisdetay] ([sad_recno], [sad_satisevrakno], [sad_urunkodu], [sad_miktar], [sad_fiyat], [sad_tutar], [sad_kdvorani], [sad_kdvtutari], [sad_geneltoplam]) VALUES (8, N'658', N'25', 10, 10.100000381469727, 10, 10.100000381469727, 10, 10)
INSERT [dbo].[satisdetay] ([sad_recno], [sad_satisevrakno], [sad_urunkodu], [sad_miktar], [sad_fiyat], [sad_tutar], [sad_kdvorani], [sad_kdvtutari], [sad_geneltoplam]) VALUES (9, N'658', N'34', 10, 10.149999618530273, 10, 10.25, 10, 10)
SET IDENTITY_INSERT [dbo].[satisdetay] OFF
GO
SET IDENTITY_INSERT [dbo].[urun] ON 

INSERT [dbo].[urun] ([uru_recno], [uru_kod], [uru_ad], [uru_birim], [uru_fiyat], [uru_kdvorani]) VALUES (13, N'22', N'peynir', N'10', 10.100000381469727, 10.149999618530273)
INSERT [dbo].[urun] ([uru_recno], [uru_kod], [uru_ad], [uru_birim], [uru_fiyat], [uru_kdvorani]) VALUES (14, N'23', N'zeytin', N'10', 10, 10)
INSERT [dbo].[urun] ([uru_recno], [uru_kod], [uru_ad], [uru_birim], [uru_fiyat], [uru_kdvorani]) VALUES (16, N'25', N'leptop', N'10', 10.100000381469727, 10.100000381469727)
INSERT [dbo].[urun] ([uru_recno], [uru_kod], [uru_ad], [uru_birim], [uru_fiyat], [uru_kdvorani]) VALUES (18, N'27', N'kamera1', N'10', 1025, 1035)
INSERT [dbo].[urun] ([uru_recno], [uru_kod], [uru_ad], [uru_birim], [uru_fiyat], [uru_kdvorani]) VALUES (20, N'32', N'sabun', N'10', 10.850000381469727, 10.75)
INSERT [dbo].[urun] ([uru_recno], [uru_kod], [uru_ad], [uru_birim], [uru_fiyat], [uru_kdvorani]) VALUES (21, N'33', N'oda', N'10', 10.149999618530273, 10.149999618530273)
INSERT [dbo].[urun] ([uru_recno], [uru_kod], [uru_ad], [uru_birim], [uru_fiyat], [uru_kdvorani]) VALUES (22, N'34', N'yemek', N'10', 10.149999618530273, 10.25)
SET IDENTITY_INSERT [dbo].[urun] OFF
GO
ALTER TABLE [dbo].[satis]  WITH CHECK ADD  CONSTRAINT [FK_satis_musteri] FOREIGN KEY([sat_musterikodu])
REFERENCES [dbo].[musteri] ([mus_kod])
GO
ALTER TABLE [dbo].[satis] CHECK CONSTRAINT [FK_satis_musteri]
GO
ALTER TABLE [dbo].[satisdetay]  WITH CHECK ADD  CONSTRAINT [FK_satisdetay_satis] FOREIGN KEY([sad_satisevrakno])
REFERENCES [dbo].[satis] ([sat_evrakno])
GO
ALTER TABLE [dbo].[satisdetay] CHECK CONSTRAINT [FK_satisdetay_satis]
GO
ALTER TABLE [dbo].[satisdetay]  WITH CHECK ADD  CONSTRAINT [FK_satisdetay_urun] FOREIGN KEY([sad_urunkodu])
REFERENCES [dbo].[urun] ([uru_kod])
GO
ALTER TABLE [dbo].[satisdetay] CHECK CONSTRAINT [FK_satisdetay_urun]
GO
