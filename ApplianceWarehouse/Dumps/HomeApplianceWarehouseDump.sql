USE [HomeApllianceWarehouse]
GO
/****** Object:  Table [dbo].[applianceType]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[applianceType](
	[appTypeID] [int] IDENTITY(10000,10) NOT NULL,
	[appTypeName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appliance]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appliance](
	[appID] [int] IDENTITY(0,1) NOT NULL,
	[appType] [int] NOT NULL,
	[appName] [nvarchar](100) NOT NULL,
	[appWholesalePrice] [float] NOT NULL,
	[appRetailPrice] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[applianceView]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[applianceView] AS
SELECT appTypeName AS 'Тип бытовой техники', appName AS 'Наименование товара', 
appWholesalePrice AS 'Оптовая цена', appRetailPrice AS 'Розничная цена'
FROM applianceType, appliance
WHERE appType = appTypeID
GO
/****** Object:  Table [dbo].[vendors]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendors](
	[vendorID] [int] IDENTITY(5000,1) NOT NULL,
	[vendorName] [nvarchar](100) NOT NULL,
	[vendorPhoneNumber] [nvarchar](11) NOT NULL,
	[vendorEmailAddress] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[vendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[deliveries]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deliveries](
	[delID] [int] IDENTITY(0,1) NOT NULL,
	[delAppliance] [int] NOT NULL,
	[delVendor] [int] NOT NULL,
	[delDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[delID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[deliveriesView]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[deliveriesView] AS
SELECT appName AS 'Наименование товара', vendorName AS 'Поставщик', delDate AS 'Дата последней поставки'
FROM appliance, deliveries, vendors
WHERE appID = delAppliance AND delVendor = vendorID
GO
/****** Object:  View [dbo].[applianceTypeView]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[applianceTypeView] AS
SELECT appTypeName AS 'Наименование типа'
FROM applianceType
GO
/****** Object:  View [dbo].[vendorView]    Script Date: 25.04.2023 15:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vendorView] AS
SELECT vendorName AS 'Производитель', vendorPhoneNumber AS 'Номер телефона производителя', vendorEmailAddress AS 'Адрес электроной почты производителя'
FROM vendors
GO
SET IDENTITY_INSERT [dbo].[appliance] ON 

INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (0, 10000, N'Электрическая варочная поверхность Samsung NZ32R1506BK/WT', 8999, 13999)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (1, 10000, N'Индукционная варочная поверхность Samsung NZ64F3NM1AB', 13999, 22999)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (2, 10010, N'Электрический духовой шкаф Bosch Serie 6 HBG517EW1R белый', 22999, 37499)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (3, 10010, N'Электрический духовой шкаф Bosch Serie 6 HBJN10YB2R черный', 41999, 51799)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (5, 10090, N'Медленноварка Kitfort КТ-205 серебристый', 799, 1699)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (6, 10090, N'Мультиварка Hyundai HYMC-1615 серебристый', 2699, 3299)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (7, 10090, N'Мультиварка Centek CT-1498 серебристый', 1999, 3499)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (8, 10090, N'Мультиварка Redmond RMC-M22 черный', 2599, 4399)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (9, 10090, N'Мультиварка Bosch MUC11W12RU белый', 7999, 10999)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (10, 10140, N'Пылесос Dyson V8 Motherhead серый', 28999, 34499)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (11, 10140, N'Пылесос Dyson V8 Absolute+ желтый', 30199, 39999)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (12, 10140, N'Пылесос Dyson V12 Detect Slim Absolute серый', 42999, 59999)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (13, 10140, N'Пылесос Dyson V15 Detect Absolute серый', 60999, 79999)
INSERT [dbo].[appliance] ([appID], [appType], [appName], [appWholesalePrice], [appRetailPrice]) VALUES (14, 10110, N'Вакуумер 3000', 10000, 20000)
SET IDENTITY_INSERT [dbo].[appliance] OFF
GO
SET IDENTITY_INSERT [dbo].[applianceType] ON 

INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10000, N'Варочные панели')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10010, N'Духовые шкафы')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10020, N'Вытяжки')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10030, N'Встраиваемые холодильники')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10040, N'Встраиваемые стиральные машины')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10050, N'Встраиваемые посудомоечные машины')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10060, N'Холодильное оборудование')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10070, N'Посудомоечные машины')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10080, N'Нарезка и смешивание')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10090, N'Мультиварки и техника для варки')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10100, N'Измерения')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10110, N'Вакуумная упаковка')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10120, N'Прочая техника для кухни')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10130, N'Глаженье')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10140, N'Уборка')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10150, N'Стирка и сушка')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10160, N'Контроль и управление климатом')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10170, N'Умный дом')
INSERT [dbo].[applianceType] ([appTypeID], [appTypeName]) VALUES (10180, N'Шитье, вышивание и уход за одеждой')
SET IDENTITY_INSERT [dbo].[applianceType] OFF
GO
SET IDENTITY_INSERT [dbo].[deliveries] ON 

INSERT [dbo].[deliveries] ([delID], [delAppliance], [delVendor], [delDate]) VALUES (0, 14, 5003, CAST(N'2023-12-12' AS Date))
INSERT [dbo].[deliveries] ([delID], [delAppliance], [delVendor], [delDate]) VALUES (1, 1, 5003, CAST(N'2023-04-24' AS Date))
INSERT [dbo].[deliveries] ([delID], [delAppliance], [delVendor], [delDate]) VALUES (2, 2, 5001, CAST(N'2023-04-21' AS Date))
INSERT [dbo].[deliveries] ([delID], [delAppliance], [delVendor], [delDate]) VALUES (4, 3, 5001, CAST(N'2023-04-21' AS Date))
SET IDENTITY_INSERT [dbo].[deliveries] OFF
GO
SET IDENTITY_INSERT [dbo].[vendors] ON 

INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5001, N'Группа Bosch в России', N'84955609560', N'info.powertools@ru.bosch.com')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5002, N'ЛГ Электроникс Рус', N'84957851313', N'marina.rovnina@lge.com')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5003, N'САМСУНГ ЭЛЕКТРОНИКС РУС КАЛУГА', N'84843867000', N'kondi-kaluga@mail.ru')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5004, N'ООО «ИЛОТ» REDMOND', N'89219361320', N'Andrey.Gribulya@ilot.ru')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5005, N'Cuori Electrical Appliances (Zhejiang)  KITFORT', N'84995043297', N'info@kitfort-repair.ru')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5006, N'ООО "БОРК-Импорт"', N'88005008899', N'info@bork.ru')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5008, N'MERLION HYUNDAI', N'74959818484', N'info@merlion.ru')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5009, N'Guangdong Textiles Import&Export Cotton CENTEK', N'88612600900', N'office@larina-k.ru')
INSERT [dbo].[vendors] ([vendorID], [vendorName], [vendorPhoneNumber], [vendorEmailAddress]) VALUES (5010, N'Dyson РОССИЯ', N'74995043297', N'info@dsn-assist.ru')
SET IDENTITY_INSERT [dbo].[vendors] OFF
GO
ALTER TABLE [dbo].[appliance]  WITH CHECK ADD FOREIGN KEY([appType])
REFERENCES [dbo].[applianceType] ([appTypeID])
GO
ALTER TABLE [dbo].[deliveries]  WITH CHECK ADD FOREIGN KEY([delAppliance])
REFERENCES [dbo].[appliance] ([appID])
GO
ALTER TABLE [dbo].[deliveries]  WITH CHECK ADD FOREIGN KEY([delVendor])
REFERENCES [dbo].[vendors] ([vendorID])
GO
