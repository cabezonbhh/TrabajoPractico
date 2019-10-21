USE [AgenciaDeAutos]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[fechaVenta] [datetime] NOT NULL,
 CONSTRAINT [pk_ventas] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC,
	[fechaVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajos]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Trabajos](
	[idTrabajo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](500) NULL,
 CONSTRAINT [pk_trabajos] PRIMARY KEY CLUSTERED 
(
	[idTrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Trabajos] ON
INSERT [dbo].[Trabajos] ([idTrabajo], [nombre], [descripcion]) VALUES (1, N'Revision Inicial basica ', N' Chequeo visual de llantas y cubiertas / Chequeo de Aceite / Cheque de daños visuales / Pulido y limpieza general ')
INSERT [dbo].[Trabajos] ([idTrabajo], [nombre], [descripcion]) VALUES (2, N'Revision Inicial exhautiva ', N' Chequeo de llantas y cubiertas / Cambio de Aceite / 
		Chequeo de daños visuales / Pulido y limpieza general / Cambio de filtros / Vaciado y limpieza de deposito de combustible /
		Limpieza de motor ')
INSERT [dbo].[Trabajos] ([idTrabajo], [nombre], [descripcion]) VALUES (3, N'Reparacion Detalles visuales ', N' Abolladuras / Rayas / Pintura desgastada / Exterior - Interior')
INSERT [dbo].[Trabajos] ([idTrabajo], [nombre], [descripcion]) VALUES (4, N'Reparaciones Mecanicas ', N' Fallas Motor / Fallas Suspension / Fallas Direccion / 
		Fallas Electricas-Electronicas / Fallas Caja de cambio / Fallas sistema transmision /
		Otras fallas ')
INSERT [dbo].[Trabajos] ([idTrabajo], [nombre], [descripcion]) VALUES (5, N'Revision rutina', N'Revision general del vehiculo + conexion a computadora')
SET IDENTITY_INSERT [dbo].[Trabajos] OFF
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[dni] [numeric](18, 0) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[calle] [varchar](50) NULL,
	[nroCalle] [int] NULL,
	[telefono] [numeric](18, 0) NOT NULL,
	[celular] [numeric](18, 0) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON
INSERT [dbo].[Clientes] ([idCliente], [dni], [nombre], [apellido], [calle], [nroCalle], [telefono], [celular], [borrado]) VALUES (1, CAST(35251914 AS Numeric(18, 0)), N'Franco', N'Torres', N'Malvar y pinto', 1725, CAST(4787488 AS Numeric(18, 0)), CAST(3513638272 AS Numeric(18, 0)), 0)
INSERT [dbo].[Clientes] ([idCliente], [dni], [nombre], [apellido], [calle], [nroCalle], [telefono], [celular], [borrado]) VALUES (2, CAST(1725 AS Numeric(18, 0)), N'test', N'test', N'test', 1234, CAST(1234 AS Numeric(18, 0)), CAST(1234 AS Numeric(18, 0)), 0)
INSERT [dbo].[Clientes] ([idCliente], [dni], [nombre], [apellido], [calle], [nroCalle], [telefono], [celular], [borrado]) VALUES (3, CAST(1111 AS Numeric(18, 0)), N'cliente prueba', N'cliente prueba', N'direccion prueba', 1111, CAST(1111 AS Numeric(18, 0)), CAST(1111 AS Numeric(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
/****** Object:  Table [dbo].[Fabricantes]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  StoredProcedure [dbo].[nuevoCliente]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[nuevoCliente]
@dni numeric(18,0),
@nombre varchar(30),
@apellido varchar(30),
@calle varchar(50),
@nroCalle int,
@telefono numeric(18, 0),
@celular numeric(18, 0)
as
insert into Clientes(dni,nombre,apellido,calle,nroCalle,telefono,celular)
values (@dni,@nombre,@apellido,@calle,@nroCalle,@telefono,@celular)
GO
/****** Object:  StoredProcedure [dbo].[buscarClientePorID]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscarClientePorID]
@id int
as
select *
from Clientes
where idCliente = @id
GO
/****** Object:  StoredProcedure [dbo].[buscarClientePorDNI]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscarClientePorDNI]
@dni int
as
select * 
from Clientes c
where c.dni = @dni
GO
/****** Object:  StoredProcedure [dbo].[actualizarCliente]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizarCliente]
@id int,
@dni numeric(18,0),
@nombre varchar(30),
@apellido varchar(30),
@calle varchar(50),
@nroCalle int,
@telefono numeric(18,0),
@celular numeric(18,0)
as
update Clientes
set dni = @dni, nombre = @nombre, apellido = @apellido, calle = @calle, nroCalle = @nroCalle, telefono = @telefono, celular = @celular
where idCliente = @id
GO
/****** Object:  StoredProcedure [dbo].[getClientesActivos]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getClientesActivos]
as
select *
from Clientes c
where c.borrado = 0
GO
/****** Object:  Table [dbo].[Series]    Script Date: 10/20/2019 22:13:40 ******/
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
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (18, N'Serie i', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (19, N'Serie X2', 2)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (20, N'Periodo 1940', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (21, N'Periodo 1950', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (22, N'Periodo 1960', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (23, N'Periodo 1970', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (24, N'Periodo 1980', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (25, N'Periodo 1990', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (26, N'Periodo 2000', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (27, N'Periodo 2010', 3)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (28, N'Periodo 2020', 3)
SET IDENTITY_INSERT [dbo].[Series] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/20/2019 22:13:40 ******/
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
INSERT [dbo].[Usuarios] ([idUsuario], [nombre], [contraseña], [borrado], [bloqueado], [idPerfil]) VALUES (15, N'admin', N'admin', 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  StoredProcedure [dbo].[nuevoUsuario]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  Table [dbo].[Generaciones]    Script Date: 10/20/2019 22:13:40 ******/
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
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (75, N'E31', 8)
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
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (101, N'E89', 11)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (102, N'G29', 11)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (103, N'F21', 1)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (104, N'Unica serie', 20)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (113, N'Unica serie', 21)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (114, N'Unica serie', 22)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (115, N'Unica serie', 23)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (116, N'Unica serie', 24)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (117, N'Unica serie', 25)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (118, N'Unica serie', 26)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (119, N'Unica serie', 27)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (120, N'Unica serie', 28)
SET IDENTITY_INSERT [dbo].[Generaciones] OFF
/****** Object:  StoredProcedure [dbo].[buscarUsuarioPorID]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  StoredProcedure [dbo].[borrarUsuario]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  StoredProcedure [dbo].[getUsuarioValidado]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  StoredProcedure [dbo].[getUsuarios]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  StoredProcedure [dbo].[editarUsuario]    Script Date: 10/20/2019 22:13:40 ******/
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
/****** Object:  StoredProcedure [dbo].[cargarComboSerie]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargarComboSerie]
@idFabricante int
as
select *
from Series
where Series.idFabricante = @idFabricante
GO
/****** Object:  StoredProcedure [dbo].[cargarComboGeneracion]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargarComboGeneracion]
@idSerie int
as
select *
from Generaciones
where Generaciones.idSerie = @idSerie
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 10/20/2019 22:13:40 ******/
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
	[precioFabrica] [numeric](18, 0) NULL,
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
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 1, 2, N'125i', N'N/D', CAST(30000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 1, 2, N'135i', N'N/D', CAST(40000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 1, 2, N'M1', N'N/D', CAST(80000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 1, 5, N'125i', N'N/D', CAST(35000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 1, 5, N'135i', N'N/D', CAST(45000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 2, 6, N'M2', N'N/D', CAST(75000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 2, 6, N'M2 Competition', N'N/D', CAST(80000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 2, 6, N'M235i', N'N/D', CAST(35500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 2, 6, N'M240i', N'N/D', CAST(38000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 9, N'M3', N'N/D', CAST(40000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 10, N'330i', N'N/D', CAST(35500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 10, N'M3', N'N/D', CAST(80000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 11, N'M3', N'N/D', CAST(103600 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 12, N'330i', N'N/D', CAST(45500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 12, N'335i', N'N/D', CAST(55500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 14, N'M3', N'N/D', CAST(120600 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 16, N'330i', N'N/D', CAST(55500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 16, N'335i', N'N/D', CAST(75500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 20, N'M3', N'N/D', CAST(105500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 3, 21, N'M340i', N'N/D', CAST(95500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 4, 23, N'435i', N'N/D', CAST(65500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 4, 23, N'440i', N'N/D', CAST(72500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 4, 26, N'M4', N'N/D', CAST(120500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 30, N'540 ', N'N/D', CAST(62500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 30, N'M5', N'N/D', CAST(72500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 31, N'540i ', N'N/D', CAST(75500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 31, N'M5', N'N/D', CAST(80500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 32, N'540i ', N'N/D', CAST(78500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 32, N'550 i', N'N/D', CAST(100000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 32, N'550i ', N'N/D', CAST(84500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 32, N'M5', N'N/D', CAST(125000 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 34, N'550i ', N'N/D', CAST(89500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 34, N'M5', N'N/D', CAST(85500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 39, N'540i ', N'N/D', CAST(105500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 39, N'550i ', N'N/D', CAST(125500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 39, N'M5', N'N/D', CAST(155500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 6, 42, N'M635 CSi ', N'N/D', CAST(62500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 6, 43, N'M6 ', N'N/D', CAST(79500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 6, 43, N'M650i ', N'N/D', CAST(62500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 6, 45, N'M6 ', N'N/D', CAST(99500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 6, 45, N'M650i ', N'N/D', CAST(82500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 6, 48, N'640i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 51, N'740i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 51, N'750i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 53, N'740i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 53, N'750i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 53, N'760i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 56, N'740i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 56, N'750i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 56, N'760i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 73, N'740i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 73, N'750i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 73, N'760i ', N'N/D', CAST(42500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 7, 81, N'X2', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 8, 75, N'850 CSi ', N'N/D', CAST(82500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 8, 77, N'M850i ', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 11, 9, N'Z1', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 11, 96, N'Z3', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 11, 98, N'Z8', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 11, 99, N'Z4', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 11, 101, N'Z4', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 11, 102, N'Z4', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 12, 79, N'X1', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 12, 80, N'X1', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 13, 82, N'X3', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 13, 83, N'X3', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 13, 84, N'X3', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 14, 85, N'X4', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 14, 86, N'X4', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 15, 87, N'X5', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 15, 88, N'X5', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 15, 89, N'X5', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 15, 90, N'X5', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 16, 91, N'X6', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 16, 93, N'X6', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 16, 94, N'X6', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 17, 95, N'X7', N'N/D', CAST(132500 AS Numeric(18, 0)), 0)
/****** Object:  StoredProcedure [dbo].[getModelosConNumero]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getModelosConNumero]
@fabricante int,
@serie int,
@generacion int
as
select	ROW_NUMBER()OVER(ORDER BY codFabricante ASC),
		m.codFabricante,m.codSerie,m.codGeneracion,m.nombre,m.descripcion,m.precioFabrica
from Modelos m	join Generaciones g on m.codGeneracion = g.idGeneracion
				join Series s on g.idSerie = s.idSerie
				join Fabricantes f on f.idFabricante = s.idFabricante				
where m.codFabricante = @fabricante and m.codSerie = @serie and m.codGeneracion = @generacion
GO
/****** Object:  StoredProcedure [dbo].[getModelos]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getModelos]
@fabricante int,
@serie int,
@generacion int
as
select m.codFabricante,m.codSerie,m.codGeneracion,m.nombre,m.descripcion,m.precioFabrica
from Modelos m	join Generaciones g on m.codGeneracion = g.idGeneracion
				join Series s on g.idSerie = s.idSerie
				join Fabricantes f on f.idFabricante = s.idFabricante				
where m.codFabricante = @fabricante and m.codSerie = @serie and m.codGeneracion = @generacion
GO
/****** Object:  Table [dbo].[StockUnidades]    Script Date: 10/20/2019 22:13:40 ******/
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
	[precioVenta] [numeric](18, 0) NULL,
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
SET IDENTITY_INSERT [dbo].[StockUnidades] ON
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado]) VALUES (1, 2, 5, 32, N'M5', CAST(100000 AS Numeric(18, 0)), 2009, 0, 500, N'Unidad obtenida de un excedente de stock, proviene de Munich, Alemania. Nunca se utilizo, se mantuvo almacenado en los depositos', 0)
SET IDENTITY_INSERT [dbo].[StockUnidades] OFF
/****** Object:  Table [dbo].[Service]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[codService] [int] IDENTITY(1,1) NOT NULL,
	[codUnidad] [int] NOT NULL,
	[fechaService] [datetime] NULL,
	[kmLimite] [numeric](18, 0) NULL,
 CONSTRAINT [pk_Services] PRIMARY KEY CLUSTERED 
(
	[codService] ASC,
	[codUnidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Service] ON
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (1, 1, CAST(0x0000AAE6014B8ECD AS DateTime), CAST(60000 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Service] OFF
/****** Object:  Table [dbo].[DetallesVentas]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesVentas](
	[idVenta] [int] NOT NULL,
	[fechaVenta] [datetime] NOT NULL,
	[idUnidad] [int] NOT NULL,
	[precioVenta] [numeric](18, 0) NULL,
 CONSTRAINT [pk_detalleVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC,
	[fechaVenta] ASC,
	[idUnidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleService]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleService](
	[codService] [int] NOT NULL,
	[codUnidad] [int] NOT NULL,
	[idtrabajo] [int] NOT NULL,
	[precios] [numeric](18, 0) NULL,
	[descripcion] [varchar](500) NULL,
 CONSTRAINT [pk_detalleService] PRIMARY KEY CLUSTERED 
(
	[codService] ASC,
	[codUnidad] ASC,
	[idtrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (1, 1, 1, CAST(5000 AS Numeric(18, 0)), NULL)
/****** Object:  StoredProcedure [dbo].[registrarUnidadUsada]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrarUnidadUsada]
@fabricante int,
@serie int,
@generacion int,
@nombre varchar(20),
@precioCompra numeric(18,0),
@añoModelo int,
@kilometraje int,
@potencia int,
@descripcion varchar(200) 
as
insert into StockUnidades(idFabricante,idSerie,idGeneracion,nombre,precioCompra,añoModelo,kilometraje,potencia,descripcion)
values (@fabricante,@serie,@generacion,@nombre,@precioCompra,@añoModelo,@kilometraje,@potencia,@descripcion);
insert into Service(codUnidad,fechaService,kmLimite) values(IDENT_CURRENT('StockUnidades'),GETDATE(),(@kilometraje+60000)); 
insert into DetalleService(codService,codUnidad,idtrabajo,precios)
values(@@IDENTITY,IDENT_CURRENT('StockUnidades'),1,5000)
GO
/****** Object:  StoredProcedure [dbo].[registrarUnidadCeroKM]    Script Date: 10/20/2019 22:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrarUnidadCeroKM]
@fabricante int,
@serie int,
@generacion int,
@nombre varchar(20),
@precioCompra numeric(18,0),
@añoModelo int,
@kilometraje int,
@potencia int,
@descripcion varchar(200) 
as
insert into StockUnidades(idFabricante,idSerie,idGeneracion,nombre,precioCompra,añoModelo,kilometraje,potencia,descripcion)
values (@fabricante,@serie,@generacion,@nombre,@precioCompra,@añoModelo,@kilometraje,@potencia,@descripcion);
insert into Service(codUnidad,fechaService) values(IDENT_CURRENT('StockUnidades'),GETDATE()); 
insert into DetalleService(codService,codUnidad,idtrabajo,precios)
values(@@IDENTITY,IDENT_CURRENT('StockUnidades'),1,5000)
GO
/****** Object:  Default [DF__Clientes__calle__276EDEB3]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ('sin datos') FOR [calle]
GO
/****** Object:  Default [DF__Clientes__nroCal__286302EC]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((-99)) FOR [nroCalle]
GO
/****** Object:  Default [DF__Clientes__borrad__29572725]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Modelos__precioF__2A4B4B5E]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Modelos] ADD  DEFAULT ((0)) FOR [precioFabrica]
GO
/****** Object:  Default [DF__Modelos__borrado__2B3F6F97]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Modelos] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Service__kmLimit__2C3393D0]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Service] ADD  DEFAULT ((60000)) FOR [kmLimite]
GO
/****** Object:  Default [DF__StockUnid__preci__2D27B809]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [precioVenta]
GO
/****** Object:  Default [DF__StockUnid__añoMo__2E1BDC42]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((1990)) FOR [añoModelo]
GO
/****** Object:  Default [DF__StockUnid__kilom__2F10007B]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [kilometraje]
GO
/****** Object:  Default [DF__StockUnid__poten__300424B4]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((-99)) FOR [potencia]
GO
/****** Object:  Default [DF__StockUnid__borra__30F848ED]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Check [valorMinimo]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[DetallesVentas]  WITH CHECK ADD  CONSTRAINT [valorMinimo] CHECK  (([precioVenta]>(-1)))
GO
ALTER TABLE [dbo].[DetallesVentas] CHECK CONSTRAINT [valorMinimo]
GO
/****** Object:  ForeignKey [fk_detallesServices]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[DetalleService]  WITH CHECK ADD  CONSTRAINT [fk_detallesServices] FOREIGN KEY([codService], [codUnidad])
REFERENCES [dbo].[Service] ([codService], [codUnidad])
GO
ALTER TABLE [dbo].[DetalleService] CHECK CONSTRAINT [fk_detallesServices]
GO
/****** Object:  ForeignKey [fk_detalletrabajo]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[DetalleService]  WITH CHECK ADD  CONSTRAINT [fk_detalletrabajo] FOREIGN KEY([idtrabajo])
REFERENCES [dbo].[Trabajos] ([idTrabajo])
GO
ALTER TABLE [dbo].[DetalleService] CHECK CONSTRAINT [fk_detalletrabajo]
GO
/****** Object:  ForeignKey [fk_detalleVenta]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[DetallesVentas]  WITH CHECK ADD  CONSTRAINT [fk_detalleVenta] FOREIGN KEY([idVenta], [fechaVenta])
REFERENCES [dbo].[Ventas] ([idVenta], [fechaVenta])
GO
ALTER TABLE [dbo].[DetallesVentas] CHECK CONSTRAINT [fk_detalleVenta]
GO
/****** Object:  ForeignKey [fk_unidad]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[DetallesVentas]  WITH CHECK ADD  CONSTRAINT [fk_unidad] FOREIGN KEY([idUnidad])
REFERENCES [dbo].[StockUnidades] ([codUnidad])
GO
ALTER TABLE [dbo].[DetallesVentas] CHECK CONSTRAINT [fk_unidad]
GO
/****** Object:  ForeignKey [fk_series]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Generaciones]  WITH CHECK ADD  CONSTRAINT [fk_series] FOREIGN KEY([idSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Generaciones] CHECK CONSTRAINT [fk_series]
GO
/****** Object:  ForeignKey [fk_fabricante]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_fabricante] FOREIGN KEY([codFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_fabricante]
GO
/****** Object:  ForeignKey [fk_generacion]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_generacion] FOREIGN KEY([codGeneracion])
REFERENCES [dbo].[Generaciones] ([idGeneracion])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_generacion]
GO
/****** Object:  ForeignKey [fk_serie]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_serie] FOREIGN KEY([codSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_serie]
GO
/****** Object:  ForeignKey [fk_fabricantes]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Series]  WITH CHECK ADD  CONSTRAINT [fk_fabricantes] FOREIGN KEY([idFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Series] CHECK CONSTRAINT [fk_fabricantes]
GO
/****** Object:  ForeignKey [fk_services]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [fk_services] FOREIGN KEY([codUnidad])
REFERENCES [dbo].[StockUnidades] ([codUnidad])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [fk_services]
GO
/****** Object:  ForeignKey [fk_fabricanteUnidad]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[StockUnidades]  WITH CHECK ADD  CONSTRAINT [fk_fabricanteUnidad] FOREIGN KEY([idFabricante], [idSerie], [idGeneracion], [nombre])
REFERENCES [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre])
GO
ALTER TABLE [dbo].[StockUnidades] CHECK CONSTRAINT [fk_fabricanteUnidad]
GO
/****** Object:  ForeignKey [fk_perfil]    Script Date: 10/20/2019 22:13:40 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_perfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[Perfiles] ([idPerfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_perfil]
GO
