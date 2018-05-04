USE [datamodel]
GO
SET IDENTITY_INSERT [dbo].[Accessory] ON 

GO
INSERT [dbo].[Accessory] ([Id], [Type]) VALUES (1, N'Rodas')
GO
INSERT [dbo].[Accessory] ([Id], [Type]) VALUES (2, N'Airbag')
GO
INSERT [dbo].[Accessory] ([Id], [Type]) VALUES (3, N'Som')
GO
INSERT [dbo].[Accessory] ([Id], [Type]) VALUES (4, N'Ar Condicionado')
GO
SET IDENTITY_INSERT [dbo].[Accessory] OFF
GO
SET IDENTITY_INSERT [dbo].[Car] ON 

GO
INSERT [dbo].[Car] ([Id], [Brand]) VALUES (1, N'Honda Civic')
GO
INSERT [dbo].[Car] ([Id], [Brand]) VALUES (2, N'Fiat Siena')
GO
INSERT [dbo].[Car] ([Id], [Brand]) VALUES (3, N'Honda New Civic')
GO
INSERT [dbo].[Car] ([Id], [Brand]) VALUES (4, N'Polo')
GO
SET IDENTITY_INSERT [dbo].[Car] OFF
GO
INSERT [dbo].[CarAccessoryNN] ([CarId], [AccessoryId]) VALUES (1, 1)
GO
INSERT [dbo].[CarAccessoryNN] ([CarId], [AccessoryId]) VALUES (2, 1)
GO
INSERT [dbo].[CarAccessoryNN] ([CarId], [AccessoryId]) VALUES (3, 1)
GO
INSERT [dbo].[CarAccessoryNN] ([CarId], [AccessoryId]) VALUES (1, 2)
GO
INSERT [dbo].[CarAccessoryNN] ([CarId], [AccessoryId]) VALUES (2, 3)
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

GO
INSERT [dbo].[Person] ([Id], [Name]) VALUES (1, N'Adler Pagliarini')
GO
INSERT [dbo].[Person] ([Id], [Name]) VALUES (2, N'Fabio Pagliarini')
GO
INSERT [dbo].[Person] ([Id], [Name]) VALUES (3, N'Test 3')
GO
INSERT [dbo].[Person] ([Id], [Name]) VALUES (4, N'Test 4')
GO
INSERT [dbo].[Person] ([Id], [Name]) VALUES (5, N'Test 5')
GO
INSERT [dbo].[Person] ([Id], [Name]) VALUES (6, N'Test 6')
GO
INSERT [dbo].[Person] ([Id], [Name]) VALUES (7, N'Test 7')
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
INSERT [dbo].[PersonCarNN] ([PersonId], [CarId]) VALUES (1, 1)
GO
INSERT [dbo].[PersonCarNN] ([PersonId], [CarId]) VALUES (2, 2)
GO
INSERT [dbo].[PersonCarNN] ([PersonId], [CarId]) VALUES (2, 3)
GO
INSERT [dbo].[PersonCarNN] ([PersonId], [CarId]) VALUES (1, 4)
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (2, N'Sao Paulo', 123, 1)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (3, N'Sorocaba', 456, 1)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (4, N'End 4', 789, 2)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (5, N'End 5', 456, 3)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (6, N'End 6', 456, 3)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (7, N'End 7', 456, 4)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (8, N'End 8', 456, 4)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (9, N'End 9', 456, 7)
GO
INSERT [dbo].[Address] ([Id], [Street], [Number], [PersonId]) VALUES (10, N'End 10', 456, 7)
GO
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
