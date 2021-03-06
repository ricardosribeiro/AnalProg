USE [AnalProgDatabase]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [CPF]) VALUES (1, N'Ricardo Ribeiro', N'33987689895')
INSERT [dbo].[User] ([Id], [Name], [CPF]) VALUES (2, N'Enzo Carvalhaes', N'32347689895')
INSERT [dbo].[User] ([Id], [Name], [CPF]) VALUES (3, N'Beatriz Ribeiro', N'26547689895')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[SalesOrder] ON 

INSERT [dbo].[SalesOrder] ([Id], [Title], [Description], [Value], [UserId]) VALUES (1, N'Venda 1', N'Cama box king', CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[SalesOrder] ([Id], [Title], [Description], [Value], [UserId]) VALUES (2, N'Venda 2', N'Geladeira', CAST(1700.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[SalesOrder] ([Id], [Title], [Description], [Value], [UserId]) VALUES (3, N'Venda 3', N'TV LCD', CAST(1700.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[SalesOrder] ([Id], [Title], [Description], [Value], [UserId]) VALUES (1002, N'Venda 4', N'Mesa com 04 cadeiras', CAST(640.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[SalesOrder] OFF
