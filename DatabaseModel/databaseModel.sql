USE [datamodel]
GO
SET IDENTITY_INSERT [dbo].[Acessorio] ON 

GO
INSERT [dbo].[Acessorio] ([Id], [Tipo]) VALUES (1, N'Rodas')
GO
INSERT [dbo].[Acessorio] ([Id], [Tipo]) VALUES (2, N'Airbag')
GO
INSERT [dbo].[Acessorio] ([Id], [Tipo]) VALUES (3, N'Som')
GO
INSERT [dbo].[Acessorio] ([Id], [Tipo]) VALUES (4, N'Ar Condicionado')
GO
SET IDENTITY_INSERT [dbo].[Acessorio] OFF
GO
SET IDENTITY_INSERT [dbo].[Carro] ON 

GO
INSERT [dbo].[Carro] ([Id], [Marca]) VALUES (1, N'Honda Civic')
GO
INSERT [dbo].[Carro] ([Id], [Marca]) VALUES (2, N'Fiat Siena')
GO
INSERT [dbo].[Carro] ([Id], [Marca]) VALUES (3, N'Honda New Civic')
GO
INSERT [dbo].[Carro] ([Id], [Marca]) VALUES (4, N'Polo')
GO
SET IDENTITY_INSERT [dbo].[Carro] OFF
GO
INSERT [dbo].[CarroAcessorioNN] ([CarroId], [AcessorioId]) VALUES (1, 1)
GO
INSERT [dbo].[CarroAcessorioNN] ([CarroId], [AcessorioId]) VALUES (2, 1)
GO
INSERT [dbo].[CarroAcessorioNN] ([CarroId], [AcessorioId]) VALUES (3, 1)
GO
INSERT [dbo].[CarroAcessorioNN] ([CarroId], [AcessorioId]) VALUES (1, 2)
GO
INSERT [dbo].[CarroAcessorioNN] ([CarroId], [AcessorioId]) VALUES (2, 3)
GO
SET IDENTITY_INSERT [dbo].[Pessoa] ON 

GO
INSERT [dbo].[Pessoa] ([Id], [Nome]) VALUES (1, N'Adler Pagliarini')
GO
INSERT [dbo].[Pessoa] ([Id], [Nome]) VALUES (2, N'Fabio Pagliarini')
GO
SET IDENTITY_INSERT [dbo].[Pessoa] OFF
GO
INSERT [dbo].[PessoaCarroNN] ([PessoaId], [CarroId]) VALUES (1, 1)
GO
INSERT [dbo].[PessoaCarroNN] ([PessoaId], [CarroId]) VALUES (2, 2)
GO
INSERT [dbo].[PessoaCarroNN] ([PessoaId], [CarroId]) VALUES (2, 3)
GO
INSERT [dbo].[PessoaCarroNN] ([PessoaId], [CarroId]) VALUES (1, 4)
GO
SET IDENTITY_INSERT [dbo].[Endereco] ON 

GO
INSERT [dbo].[Endereco] ([Id], [NomeRua], [PessoaId]) VALUES (2, N'Sao Paulo', 1)
GO
INSERT [dbo].[Endereco] ([Id], [NomeRua], [PessoaId]) VALUES (3, N'Sorocaba', 1)
GO
INSERT [dbo].[Endereco] ([Id], [NomeRua], [PessoaId]) VALUES (4, N'Sorocaba', 2)
GO
SET IDENTITY_INSERT [dbo].[Endereco] OFF
GO
