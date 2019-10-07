USE [AgenciaDeAutos]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[idPerfil] [int] IDENTITY(0,1) NOT NULL,
	[nombre] [varchar](30) NULL,
 CONSTRAINT [pk_perfil] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (0, N'Admin')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (1, N'Gerente')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (2, N'Supervisor')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (3, N'Vendedor')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (4, N'Vendedor empresas')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (5, N'Admin')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (6, N'Gerente')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (7, N'Supervisor')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (8, N'Vendedor')
INSERT [dbo].[Perfiles] ([idPerfil], [nombre]) VALUES (9, N'Vendedor empresas')
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[Fabricantes]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fabricantes](
	[idFabricante] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_fabricante] PRIMARY KEY CLUSTERED 
(
	[idFabricante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Fabricantes] ON
INSERT [dbo].[Fabricantes] ([idFabricante], [nombre], [borrado]) VALUES (1, N'Audi', 0)
INSERT [dbo].[Fabricantes] ([idFabricante], [nombre], [borrado]) VALUES (2, N'BMW', 0)
INSERT [dbo].[Fabricantes] ([idFabricante], [nombre], [borrado]) VALUES (3, N'Ferrari', 0)
INSERT [dbo].[Fabricantes] ([idFabricante], [nombre], [borrado]) VALUES (4, N'Lamborghini', 0)
INSERT [dbo].[Fabricantes] ([idFabricante], [nombre], [borrado]) VALUES (5, N'Mercedes Benz', 0)
INSERT [dbo].[Fabricantes] ([idFabricante], [nombre], [borrado]) VALUES (6, N'Porsche', 0)
SET IDENTITY_INSERT [dbo].[Fabricantes] OFF
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[calle] [varchar](50) NULL,
	[nroCalle] [int] NULL,
	[telefono] [varchar](11) NULL,
	[celular] [varchar](11) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON
INSERT [dbo].[Clientes] ([idCliente], [dni], [nombre], [apellido], [calle], [nroCalle], [telefono], [celular], [borrado]) VALUES (1, 35251914, N'Franco', N'Torres', N'Malvar y pinto', 1725, N'4787488', N'3513638272', 0)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[contraseña] [varchar](50) NULL,
	[borrado] [bit] NULL,
	[bloqueado] [bit] NULL,
	[idPerfil] [int] NULL,
 CONSTRAINT [pk_usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (1, N'franco', N'franco@1725', 0, 0, 0)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (2, N'Gerente', N'123', 0, 0, 1)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (3, N'Supervisor', N'123', 0, 0, 2)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (4, N'Pedro', N'1725', 0, 0, 3)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (5, N'Juan', N'65456', 0, 0, 3)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (6, N'Santiago', N'54546', 0, 0, 4)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (13, N'testproced', N'testproced', 1, 0, 0)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (14, N'probando', N'probando', 1, 0, 0)
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (15, N'new', N'new22', 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Series]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Series](
	[idSerie] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[idFabricante] [int] NOT NULL,
 CONSTRAINT [pk_series] PRIMARY KEY CLUSTERED 
(
	[idSerie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Series] ON
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (1, N'Serie 1', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (2, N'Serie 2', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (3, N'Serie 3', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (4, N'Serie 4', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (5, N'Serie 5', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (6, N'Serie 6', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (7, N'Serie 7', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (8, N'Serie 8', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (11, N'Serie Z', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (12, N'Serie X1', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (13, N'Serie X3', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (14, N'Serie X4', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (15, N'Serie X5', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (16, N'Serie X6', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (17, N'Serie X7', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (18, N'i', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (19, N'Serie X2', 2)
SET IDENTITY_INSERT [dbo].[Series] OFF
/****** Object:  StoredProcedure [dbo].[buscarUsuarioPorID]    Script Date: 10/06/2019 21:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscarUsuarioPorID]
@id int
 as
select u.idUsuario, u.nombre,u.contraseña,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0 and u.idUsuario = @id
GO
/****** Object:  StoredProcedure [dbo].[borrarUsuario]    Script Date: 10/06/2019 21:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[borrarUsuario]
@id int
 as
update Usuarios 
set borrado = 1 
where idUsuario = @id
GO
/****** Object:  StoredProcedure [dbo].[getUsuarioValidado]    Script Date: 10/06/2019 21:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUsuarioValidado]
@nombre varchar(30),
@contraseña varchar(50)
 as
select u.idUsuario, u.nombre,u.contraseña,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0 and u.nombre like @nombre and u.contraseña like @contraseña
GO
/****** Object:  StoredProcedure [dbo].[getUsuarios]    Script Date: 10/06/2019 21:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUsuarios]
 as
select u.idUsuario, u.nombre,u.contraseña,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0
GO
/****** Object:  Table [dbo].[Generaciones]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Generaciones](
	[idGeneracion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[idSerie] [int] NOT NULL,
 CONSTRAINT [pk_generacion] PRIMARY KEY CLUSTERED 
(
	[idGeneracion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Generaciones] ON
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (1, N'E81', 1)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (2, N'E82', 1)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (3, N'E87', 1)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (4, N'E88', 1)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (5, N'F20', 1)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (6, N'F22', 2)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (7, N'F23', 2)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (8, N'E21', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (9, N'E30', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (10, N'E36', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (11, N'E46', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (12, N'E90', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (13, N'E91', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (14, N'E92', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (15, N'E93', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (16, N'F30', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (17, N'F31', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (18, N'F34', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (19, N'F35', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (20, N'F80', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (21, N'G20', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (22, N'G21', 3)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (23, N'F32', 4)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (24, N'F33', 4)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (25, N'F36', 4)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (26, N'F82', 4)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (27, N'F83', 4)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (28, N'E12', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (29, N'E28', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (30, N'E34', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (31, N'E39', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (32, N'E60', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (33, N'E61', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (34, N'F10', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (35, N'F11', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (36, N'F07', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (37, N'F18', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (38, N'F90', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (39, N'G30', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (40, N'G31', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (41, N'G38', 5)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (42, N'E24', 6)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (43, N'E63', 6)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (44, N'E64', 6)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (45, N'F12', 6)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (46, N'F13', 6)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (47, N'F06', 6)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (48, N'G32', 6)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (49, N'E23', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (50, N'E32', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (51, N'E38', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (52, N'E65', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (53, N'E66', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (54, N'E67', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (55, N'E68', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (56, N'F01', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (57, N'F02', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (58, N'F03', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (59, N'F04', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (60, N'G11', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (61, N'G12', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (62, N'E23', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (63, N'E32', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (64, N'E38', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (65, N'E65', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (66, N'E66', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (67, N'E67', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (68, N'E68', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (69, N'F01', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (70, N'F02', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (71, N'F03', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (72, N'F04', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (73, N'G11', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (74, N'G12', 7)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (75, N'E21', 8)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (76, N'G14', 8)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (77, N'G15', 8)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (78, N'G16', 8)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (79, N'E84', 12)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (80, N'F48', 12)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (81, N'F39', 19)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (82, N'E83', 13)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (83, N'F25', 13)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (84, N'G01', 13)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (85, N'F26', 14)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (86, N'G02', 14)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (87, N'E53', 15)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (88, N'E70', 15)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (89, N'F15', 15)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (90, N'G05', 15)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (91, N'E71', 16)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (92, N'E72', 16)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (93, N'F16', 16)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (94, N'G06', 16)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (95, N'G07', 17)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (96, N'E36-7', 11)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (97, N'E36-8', 11)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (98, N'E52', 11)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (99, N'E85', 11)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (100, N'E86', 11)
GO
print 'Processed 100 total records'
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (101, N'E86', 11)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (102, N'G29', 11)
SET IDENTITY_INSERT [dbo].[Generaciones] OFF
/****** Object:  StoredProcedure [dbo].[editarUsuario]    Script Date: 10/06/2019 21:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editarUsuario]
@nombre varchar(30),
@contraseña varchar(50),
@idUsuario int,
@idPerfil int
as
update Usuarios
set nombre = @nombre, contraseña = @contraseña, idPerfil = @idPerfil
where idUsuario = @idUsuario and idPerfil > 0
GO
/****** Object:  StoredProcedure [dbo].[nuevoUsuario]    Script Date: 10/06/2019 21:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[nuevoUsuario]
@nombre varchar(30),
@contraseña varchar(50),
@idPerfil int
as
insert into Usuarios(nombre,contraseña,borrado,bloqueado,idPerfil)
values(@nombre,@contraseña,0,0,@idPerfil)
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelos](
	[codFabricante] [int] NOT NULL,
	[codSerie] [int] NOT NULL,
	[codGeneracion] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](200) NULL,
	[precioFabrica] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_modelo] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC,
	[codSerie] ASC,
	[codGeneracion] ASC,
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockUnidades]    Script Date: 10/06/2019 21:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockUnidades](
	[codUnidad] [int] IDENTITY(1,1) NOT NULL,
	[idFabricante] [int] NULL,
	[idSerie] [int] NULL,
	[idGeneracion] [int] NULL,
	[nombre] [varchar](20) NULL,
	[precioCompra] [int] NULL,
	[añoModelo] [int] NULL,
	[kilometraje] [int] NOT NULL,
	[potencia] [int] NULL,
	[descripcion] [varchar](200) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [pk_unidades] PRIMARY KEY CLUSTERED 
(
	[codUnidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__Modelos__precioF__571DF1D5]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Modelos] ADD  DEFAULT ((0)) FOR [precioFabrica]
GO
/****** Object:  Default [DF__Modelos__borrado__5812160E]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Modelos] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__StockUnid__preci__5DD5DC5C]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [precioCompra]
GO
/****** Object:  Default [DF__StockUnid__añoMo__5ECA0095]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((1990)) FOR [añoModelo]
GO
/****** Object:  Default [DF__StockUnid__kilom__5FBE24CE]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [kilometraje]
GO
/****** Object:  Default [DF__StockUnid__poten__60B24907]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((-99)) FOR [potencia]
GO
/****** Object:  Default [DF__StockUnid__borra__61A66D40]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  ForeignKey [fk_series]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Generaciones]  WITH CHECK ADD  CONSTRAINT [fk_series] FOREIGN KEY([idSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Generaciones] CHECK CONSTRAINT [fk_series]
GO
/****** Object:  ForeignKey [fk_fabricante]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_fabricante] FOREIGN KEY([codFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_fabricante]
GO
/****** Object:  ForeignKey [fk_generacion]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_generacion] FOREIGN KEY([codGeneracion])
REFERENCES [dbo].[Generaciones] ([idGeneracion])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_generacion]
GO
/****** Object:  ForeignKey [fk_serie]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_serie] FOREIGN KEY([codSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_serie]
GO
/****** Object:  ForeignKey [fk_fabricantes]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Series]  WITH CHECK ADD  CONSTRAINT [fk_fabricantes] FOREIGN KEY([idFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Series] CHECK CONSTRAINT [fk_fabricantes]
GO
/****** Object:  ForeignKey [fk_fabricanteUnidad]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[StockUnidades]  WITH CHECK ADD  CONSTRAINT [fk_fabricanteUnidad] FOREIGN KEY([idFabricante], [idSerie], [idGeneracion], [nombre])
REFERENCES [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre])
GO
ALTER TABLE [dbo].[StockUnidades] CHECK CONSTRAINT [fk_fabricanteUnidad]
GO
/****** Object:  ForeignKey [fk_perfil]    Script Date: 10/06/2019 21:42:52 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_perfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[Perfiles] ([idPerfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_perfil]
GO
