USE [AgenciaDeAutos]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 11/04/2019 02:23:26 ******/
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
/****** Object:  Table [dbo].[Trabajos]    Script Date: 11/04/2019 02:23:26 ******/
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
/****** Object:  Table [dbo].[Fabricantes]    Script Date: 11/04/2019 02:23:26 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/04/2019 02:23:26 ******/
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
/****** Object:  StoredProcedure [dbo].[getClientesActivos]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[nuevoCliente]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarClientePorID]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarClientePorDNI]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizarCliente]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 11/04/2019 02:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[añoVenta] [int] NOT NULL,
	[nroVenta] [int] IDENTITY(1,1) NOT NULL,
	[fechaVenta] [datetime] NULL,
	[fechaEntrega] [datetime] NULL,
	[idCliente] [int] NULL,
 CONSTRAINT [pk_ventas] PRIMARY KEY CLUSTERED 
(
	[añoVenta] ASC,
	[nroVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON
INSERT [dbo].[Ventas] ([añoVenta], [nroVenta], [fechaVenta], [fechaEntrega], [idCliente]) VALUES (2019, 4, CAST(0x0000AAF60010439D AS DateTime), CAST(0x0000AAF600102660 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/04/2019 02:23:26 ******/
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
/****** Object:  Table [dbo].[Series]    Script Date: 11/04/2019 02:23:26 ******/
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
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (33, N'R', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (34, N'e', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (36, N'TT', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (37, N'Periodo 1960', 4)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (38, N'Periodo 1970', 4)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (39, N'Periodo 1980', 4)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (40, N'Periodo 1990', 4)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (41, N'Periodo 2000', 4)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (42, N'Periodo 2010', 4)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (43, N'Periodo 2020', 4)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (46, N'Clase C', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (47, N'Clase E', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (48, N'Clase G', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (49, N'GLE/ML', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (50, N'Clase S', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (51, N'CL', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (52, N'CLK', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (53, N'CLA', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (54, N'CLS', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (55, N'GL/GLS', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (56, N'GLA', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (57, N'GLC/GLK', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (58, N'AMG', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (59, N'SLR', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (60, N'SLS', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (61, N'SLK/SLC', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (62, N'Numeros', 5)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (63, N'Serie 911', 6)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (64, N'Serie Boxster', 6)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (65, N'Serie SUV', 6)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (66, N'Super deportivos', 6)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (67, N'Otros deportivos', 6)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (68, N'A1', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (69, N'A3', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (70, N'A4', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (71, N'A5', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (72, N'A6', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (73, N'A7', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (74, N'A8', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (75, N'Q2', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (76, N'Q3', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (77, N'Q5', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (78, N'Q7', 1)
INSERT [dbo].[Series] ([idSerie], [nombre], [idFabricante]) VALUES (79, N'Q8', 1)
SET IDENTITY_INSERT [dbo].[Series] OFF
/****** Object:  StoredProcedure [dbo].[registrarVenta]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrarVenta]
@cliente int,
@fechaEntrega datetime
as
insert into Ventas(añoVenta,fechaVenta,fechaEntrega,idCliente)
values(YEAR(GETDATE()),GETDATE(),@fechaEntrega,@cliente)
GO
/****** Object:  StoredProcedure [dbo].[nuevoUsuario]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[getUsuarioValidado]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[getUsuarios]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarUsuarioPorID]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[borrarUsuario]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[editarUsuario]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  Table [dbo].[Generaciones]    Script Date: 11/04/2019 02:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Generaciones](
	[idGeneracion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
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
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (144, N'Primera generacion 8X (2010-2017)', 68)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (145, N'Segunda generacion GB (2018-....)', 68)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (146, N'Primera generacion 8L (1996-2003)', 69)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (147, N'Segunda generacion 8P (2003-2013)', 69)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (148, N'Tercera generacion 8V (2013-....)', 69)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (149, N'Primera generacion B5 (1995-2001)', 70)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (150, N'Segunda generacion B6 (2001-2005)', 70)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (151, N'Tercera generacion B7 (2005-2008)', 70)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (152, N'Cuarta generacion B8 (2008-2015)', 70)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (153, N'Quinta generacion B9 (2015-....)', 70)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (154, N'Primera generacion 8T (2007-2016)', 71)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (155, N'Segunda generacion F5 (2016-....)', 71)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (156, N'Primera generacion C4 (1995-1997)', 72)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (157, N'Segunda generacion C5 (1997-2004)', 72)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (158, N'Tercera generacion C6 (2004-2011)', 72)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (159, N'Cuarta generacion C7 (2011-2018)', 72)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (160, N'Quinta generacion C8 (2018-....)', 72)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (161, N'Primera generacion C7 (2010-2018)', 73)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (162, N'Segunda generacion C8 (2018-....)', 73)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (163, N'Primera generacion 4D (1994-2003)', 74)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (164, N'Segunda generacion 4E (2003-2010)', 74)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (165, N'Tercera generacion 4H (2010-2017)', 74)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (166, N'Cuarta generacion 4N (2018-....)', 74)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (167, N'Primera generacion 8N (1998-2006)', 36)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (168, N'Segunda generacion 8J (2007-2014)', 36)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (169, N'Tercera generacion 8S (2014-....)', 36)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (170, N'Primera generacion Typ42 (2006-2015)', 33)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (171, N'Segunda generacion Typ4S (2015-....)', 33)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (172, N'Primera generacion Q2 (2016-....)', 75)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (173, N'Primera generacion 8U (2011-2018)', 76)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (174, N'Segunda generacion F3 (2018-....)', 76)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (175, N'Primera generacion 8R (2008-2017)', 77)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (176, N'Segunda generacion FY (2017-....)', 77)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (177, N'Primera generacion 4L (2006-2015)', 78)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (178, N'Segunda generacion 4M (2015-....)', 78)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (179, N'Primera generacion Q8 (2018-....)', 79)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (180, N'Unica generacion', 37)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (181, N'Unica generacion', 38)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (182, N'Unica generacion', 39)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (183, N'Unica generacion', 40)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (184, N'Unica generacion', 41)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (185, N'Unica generacion', 42)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (186, N'Unica generacion', 43)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (187, N'W202 (1993-2000)', 46)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (188, N'W203 (2000-2007)', 46)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (189, N'W204 (2007-2014)', 46)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (190, N'W205 (2014-....)', 46)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (191, N'C140 (1992-1999)', 51)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (192, N'C215 (1999-2006)', 51)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (193, N'C216 (2006-....)', 51)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (194, N'W176 (2012-2018)', 53)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (195, N'W177 (2018-....)', 53)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (196, N'W219 (2004-2010)', 54)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (197, N'W218 (2010-2018)', 54)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (198, N'W257 (2018-....)', 54)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (199, N'W124 (1984-1995)', 47)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (200, N'W210 (1995-2003)', 47)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (201, N'W211 (2002-2009)', 47)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (202, N'W212 (2009-2017)', 47)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (203, N'W213 (2017-....)', 47)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (204, N'W460 (1979-1991)', 48)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (205, N'W461 (1991-2001)', 48)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (206, N'W463 (1991-....)', 48)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (207, N'X164 (2006-2012)', 55)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (208, N'X166 (2012-....)', 55)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (209, N'X156 (2013-....)', 56)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (210, N'X204 (2008-2015)', 57)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (211, N'X253 (2015-....)', 57)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (212, N'W163 (1997-2005)', 49)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (213, N'W164 (2005-2011)', 49)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (214, N'W166 (2011-....)', 49)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (215, N'W116 (1972-1980)', 50)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (216, N'W126 (1980-1991)', 50)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (217, N'W140 (1991-1998)', 50)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (218, N'W220 (1998-2005)', 50)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (219, N'W221 (2005-2013)', 50)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (220, N'W222 (2013-....)', 50)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (221, N'R170 (1996-2004)', 61)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (222, N'R171 (2005-2011)', 61)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (223, N'R172 (2011-....)', 61)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (224, N'Unica generacion SLS (2010-2014)', 60)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (225, N'C208 (1996-2003)', 52)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (226, N'C209 (2003-2010)', 52)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (227, N'Unica generacion SLR', 59)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (228, N'AMG', 58)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (229, N'Otros', 62)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (230, N'Primera Generacion (1963-1973)', 63)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (231, N'Generacion G (1974-1989)', 63)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (232, N'964 (1989-1993)', 63)
GO
print 'Processed 200 total records'
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (233, N'993 (1993-1999)', 63)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (234, N'996 (1999-2005)', 63)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (235, N'997 (2005-2011)', 63)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (236, N'991 (2011-....)', 63)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (237, N'986 (1996-2004)', 64)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (238, N'987 (2005-2012)', 64)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (239, N'981 (2013-2016)', 64)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (240, N'982 (2016-....)', 64)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (241, N'Unica generacion SUV (2002-....)', 65)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (242, N'Unica Super deportivos (2003-....)', 66)
INSERT [dbo].[Generaciones] ([idGeneracion], [nombre], [idSerie]) VALUES (243, N'Unica Otros deportivos (1948-....)', 67)
SET IDENTITY_INSERT [dbo].[Generaciones] OFF
/****** Object:  StoredProcedure [dbo].[cargarComboSerie]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[cargarComboGeneracion]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  Table [dbo].[Modelos]    Script Date: 11/04/2019 02:23:26 ******/
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
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 33, 170, N'R8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 33, 171, N'R8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 167, N'TT', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 167, N'TT Quattro', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 168, N'TT', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 168, N'TT RS', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 168, N'TT S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 169, N'TT', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 169, N'TT RS', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 36, 169, N'TT S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 68, 144, N'A1', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 68, 144, N'S1', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 68, 145, N'A1', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 68, 145, N'S1', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 146, N'A3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 146, N'S3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 147, N'A3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 147, N'RS3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 147, N'S3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 148, N'A3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 148, N'RS3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 69, 148, N'S3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 149, N'A4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 149, N'RS4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 149, N'S4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 150, N'A4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 150, N'RS4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 150, N'S4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 151, N'A4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 151, N'RS4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 151, N'S4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 152, N'A4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 152, N'RS4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 152, N'S4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 153, N'A4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 153, N'RS4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 70, 153, N'S4', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 71, 154, N'A5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 71, 154, N'RS5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 71, 154, N'S5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 71, 155, N'A5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 71, 155, N'RS5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 71, 155, N'S5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 156, N'A6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 156, N'S6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 157, N'A6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 157, N'RS6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 157, N'S6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 158, N'A6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 158, N'RS6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 158, N'S6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 159, N'A6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 159, N'RS6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 159, N'S6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 160, N'A6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 160, N'RS6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 72, 160, N'S6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 73, 161, N'A7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 73, 161, N'RS7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 73, 161, N'S7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 73, 162, N'A7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 73, 162, N'RS7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 73, 162, N'S7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 163, N'A8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 163, N'S8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 164, N'A8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 164, N'S8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 165, N'A8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 165, N'S8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 166, N'A8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 74, 166, N'S8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 75, 172, N'Q2', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 76, 173, N'Q3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 76, 174, N'Q3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 77, 175, N'Q5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 77, 176, N'Q5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 78, 177, N'Q7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 78, 178, N'Q7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (1, 79, 179, N'Q8', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
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
GO
print 'Processed 100 total records'
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
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (2, 5, 38, N'M5', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
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
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 23, 115, N'308', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 23, 115, N'BB 512', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 23, 115, N'Dino 246 GT/GTS', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 24, 116, N'BB 512', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 24, 116, N'F-40', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 24, 116, N'Testarossa', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 25, 117, N'360', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 25, 117, N'512 TR', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 25, 117, N'550', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 25, 117, N'F355', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 25, 117, N'F-40', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 25, 117, N'F-50', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 25, 117, N'Testarossa', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 26, 118, N'360', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 26, 118, N'550', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 26, 118, N'575', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 26, 118, N'599', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 26, 118, N'Enzo', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 26, 118, N'F430', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 27, 119, N'599', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 27, 119, N'F12', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 27, 119, N'F458', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 27, 119, N'F488', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (3, 27, 119, N'F812', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 37, 180, N'Miura', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 38, 181, N'Countach', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 38, 181, N'Miura', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 39, 182, N'Countach', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 40, 183, N'Countach', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 40, 183, N'Diablo', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 41, 184, N'Diablo', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 41, 184, N'Gallardo', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 41, 184, N'Murciélago', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 41, 184, N'Reventón', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 42, 185, N'Aventador', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 42, 185, N'Gallardo', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 42, 185, N'Huracán', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (4, 42, 185, N'Murciélago', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 187, N'36 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 187, N'43 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 187, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 188, N'32 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 188, N'350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 188, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 189, N'350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
GO
print 'Processed 200 total records'
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 189, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 189, N'63 AMG Black Serie', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 189, N'63 AMG Edition 507', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 190, N'300', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 190, N'350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 190, N'43 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 190, N'450 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 190, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 46, 190, N'63 S AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 199, N'300 E', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 199, N'400 E', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 199, N'E 36 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 199, N'E 500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 199, N'E 60', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 200, N'36 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 200, N'430', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 200, N'50 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 200, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 200, N'60 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 201, N'320', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 201, N'350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 201, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 201, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 201, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 202, N'350 CGI', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 202, N'400', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 202, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 202, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 202, N'63 S AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 203, N'400', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 203, N'43 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 203, N'53 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 203, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 47, 203, N'63 S AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 48, 206, N'G 500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 48, 206, N'G 55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 48, 206, N'G 63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 48, 206, N'G 65 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 212, N'270 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 212, N'400 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 212, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 212, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 213, N'420 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 213, N'450 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 213, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 213, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 214, N'350 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 214, N'350d', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 214, N'43 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 214, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 214, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 49, 214, N'63 S AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 215, N'450 SE', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 215, N'450 SEL 6.9', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 216, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 216, N'560 SE', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 217, N'500 SE', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 217, N'600 SE', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 217, N'S 500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 217, N'S 600', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 218, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 218, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 218, N'600', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 218, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 218, N'65 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 219, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 219, N'600', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 219, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 219, N'65 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 220, N'500e', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 220, N'560', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 220, N'600', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 220, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 50, 220, N'65 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 191, N'CL 500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 191, N'CL 600', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 192, N'CL 55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 192, N'CL 600', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 192, N'CL 63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 192, N'CL 65 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 193, N'CL 63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 51, 193, N'CL 65 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 52, 225, N'320', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 52, 225, N'430', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 52, 225, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 52, 226, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 52, 226, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 52, 226, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 52, 226, N'DTM AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 194, N'CLA 220', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 194, N'CLA 250', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 194, N'CLA 250 SPORT', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 194, N'CLA 45 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 195, N'CLA 250', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 195, N'CLA 35 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 195, N'CLA 45 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 53, 195, N'CLA 45 S AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 196, N'CLS 500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 196, N'CLS 55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 196, N'CLS 63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 197, N'CLS 500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
GO
print 'Processed 300 total records'
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 197, N'CLS 63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 197, N'CLS 63 S AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 198, N'CLS 350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 198, N'CLS 450 4MATIC', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 54, 198, N'CLS 53 4MATIC', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 207, N'420 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 207, N'450', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 207, N'450 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 207, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 208, N'350 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 208, N'350d', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 208, N'450', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 208, N'500', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 55, 208, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 56, 209, N'220 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 56, 209, N'220d', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 56, 209, N'250', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 56, 209, N'45 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 210, N'300', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 210, N'320 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 210, N'350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 210, N'350 CDI', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 211, N'250d', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 211, N'350d', N'Motor diesel', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 211, N'350e', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 211, N'43 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 211, N'63 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 57, 211, N'63 S AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 58, 228, N'GT', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 58, 228, N'GT S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 58, 228, N'GT3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 59, 227, N'SL 500', N'Año 1995', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 59, 227, N'SL 600', N'Año 1998', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 59, 227, N'SLR-McLaren', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 60, 224, N'AMG Black Series', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 60, 224, N'AMG GT', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 60, 224, N'AMG GT Final Edition', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 221, N'230 Kompressor', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 221, N'32 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 221, N'320', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 222, N'350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 222, N'55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 222, N'55 AMG Black Series', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 222, N'SLK 350', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 223, N'SLC 43 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 61, 223, N'SLK 55 AMG', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 62, 229, N'190 E', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 62, 229, N'190 E 2.3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 62, 229, N'190 E 2.5-16 EVO', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 62, 229, N'190 E 2.5-16 EVO II', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (5, 62, 229, N'190 E 2.6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 230, N'911 2.0', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 230, N'911 2.4 ST', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 230, N'911 2.7 Carrera RS', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 231, N'911 2.7', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 231, N'911 Turbo 3.0', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 231, N'911/930-60 Turbo 3.3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 231, N'911/935 Carrera 3.2 ', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 232, N'911/964 Carrera', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 232, N'911/964 Carrera RS/', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 232, N'911/964 Turbo S 3.3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 232, N'911/964 Turbo S 3.6', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 233, N'911/993 Carrera /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 233, N'911/993 GT2', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 233, N'911/993 Targa /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 233, N'911/993 Turbo S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 234, N'911/996 Carrera /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 234, N'911/996 GT2', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 234, N'911/996 GT3', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 234, N'911/996 GT3 RS ', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 234, N'911/996 Turbo /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 235, N'911/997 Carrera /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 235, N'911/997 Carrera GTS', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 235, N'911/997 GT2 /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 235, N'911/997 GT3 /RS ', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 235, N'911/997 GT3 RS 4.0', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 235, N'911/997 Turbo /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 236, N'911/991 Carrera /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 236, N'911/991 GT3 /RS ', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 236, N'911/991 GTS', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 63, 236, N'911/991 Turbo /S', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 64, 237, N'986', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 64, 238, N'987', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 64, 239, N'981', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 64, 240, N'982', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 65, 241, N'Cayenne I', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 65, 241, N'Cayenne II', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 65, 241, N'Macan', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 66, 242, N'918', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 66, 242, N'Carrera GT', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 67, 243, N'356 A', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 67, 243, N'944', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 67, 243, N'959', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 67, 243, N'968', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
INSERT [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre], [descripcion], [precioFabrica], [borrado]) VALUES (6, 67, 243, N'Cayman', N'N/D', CAST(0 AS Numeric(18, 0)), 0)
/****** Object:  StoredProcedure [dbo].[getModelosConNumero]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  StoredProcedure [dbo].[getModelos]    Script Date: 11/04/2019 02:23:24 ******/
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
/****** Object:  Table [dbo].[StockUnidades]    Script Date: 11/04/2019 02:23:26 ******/
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
	[patente] [varchar](7) NULL,
	[idCliente] [int] NULL,
	[rutaFoto] [varchar](300) NULL,
	[precioCompra] [numeric](18, 0) NULL,
 CONSTRAINT [pk_unidades] PRIMARY KEY CLUSTERED 
(
	[codUnidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[StockUnidades] ON
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (1, 2, 5, 32, N'M5', CAST(100000 AS Numeric(18, 0)), 2009, 0, 500, N'Unidad obtenida de un excedente de stock, proviene de Munich, Alemania. Nunca se utilizo, se mantuvo almacenado en los depositos', 0, N'N/D', NULL, NULL, CAST(50000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (2, 2, 5, 32, N'550i ', CAST(25000 AS Numeric(18, 0)), 2008, 5000, 340, N'BMW 550 i, unico dueño, sin mas detalles.', 0, N'HGC550', NULL, NULL, CAST(10000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (3, 2, 3, 14, N'M3', CAST(150000 AS Numeric(18, 0)), 2012, 0, 450, N'- Version GTS.
- Unidad 150 de 150,
- Leves modificaciones visuales, sin aleron trasero.', 1, N'N/D', 1, NULL, CAST(45000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (4, 2, 5, 38, N'M5', CAST(135000 AS Numeric(18, 0)), 2019, 0, 600, N'N/D', 0, N'N/D', NULL, NULL, CAST(85000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (5, 2, 5, 38, N'M5', CAST(135000 AS Numeric(18, 0)), 2019, 0, 600, N'N/D', 0, N'N/D', NULL, NULL, CAST(85000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (6, 2, 5, 38, N'M5', CAST(135000 AS Numeric(18, 0)), 2019, 0, 600, N'N/D', 0, N'N/D', NULL, NULL, CAST(85000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (7, 2, 5, 38, N'M5', CAST(135000 AS Numeric(18, 0)), 2019, 0, 600, N'N/D', 0, N'N/D', NULL, NULL, CAST(85000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (8, 2, 3, 14, N'M3', CAST(95000 AS Numeric(18, 0)), 2008, 25000, 420, N'N/D', 0, N'HKS 730', NULL, NULL, CAST(54000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (9, 2, 3, 14, N'M3', CAST(95000 AS Numeric(18, 0)), 2008, 5000, 420, N'N/D', 0, N'HZF 850', NULL, NULL, CAST(60000 AS Numeric(18, 0)))
INSERT [dbo].[StockUnidades] ([codUnidad], [idFabricante], [idSerie], [idGeneracion], [nombre], [precioVenta], [añoModelo], [kilometraje], [potencia], [descripcion], [borrado], [patente], [idCliente], [rutaFoto], [precioCompra]) VALUES (10, 2, 3, 9, N'M3', CAST(150000 AS Numeric(18, 0)), 1988, 5000, 220, N'Version Evolution', 0, N'n/d', NULL, NULL, CAST(100000 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[StockUnidades] OFF
/****** Object:  Table [dbo].[DetallesVentas]    Script Date: 11/04/2019 02:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesVentas](
	[añoVenta] [int] NOT NULL,
	[nroVenta] [int] NOT NULL,
	[codUnidad] [int] NOT NULL,
	[precioVenta] [numeric](18, 0) NULL,
 CONSTRAINT [pk_detallesVentas] PRIMARY KEY CLUSTERED 
(
	[añoVenta] ASC,
	[nroVenta] ASC,
	[codUnidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DetallesVentas] ([añoVenta], [nroVenta], [codUnidad], [precioVenta]) VALUES (2019, 4, 3, CAST(150000 AS Numeric(18, 0)))
/****** Object:  Table [dbo].[Service]    Script Date: 11/04/2019 02:23:26 ******/
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
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (2, 2, CAST(0x0000AAEF00D8190E AS DateTime), CAST(65000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (3, 3, CAST(0x0000AAF2011FA2DA AS DateTime), CAST(60000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (4, 4, CAST(0x0000AAF4012EEC4C AS DateTime), CAST(60000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (5, 5, CAST(0x0000AAF4012EEF6A AS DateTime), CAST(60000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (6, 6, CAST(0x0000AAF4012EF1E2 AS DateTime), CAST(60000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (7, 7, CAST(0x0000AAF4012EF4AB AS DateTime), CAST(60000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (8, 8, CAST(0x0000AAF4012FC106 AS DateTime), CAST(85000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (9, 9, CAST(0x0000AAF4012FD450 AS DateTime), CAST(65000 AS Numeric(18, 0)))
INSERT [dbo].[Service] ([codService], [codUnidad], [fechaService], [kmLimite]) VALUES (10, 10, CAST(0x0000AAF5018A9BB5 AS DateTime), CAST(65000 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Service] OFF
/****** Object:  StoredProcedure [dbo].[getUnidadPorID]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getUnidadPorID]
@id int
as
select	su.codUnidad, su.idFabricante, su.idSerie, su.idGeneracion, su.nombre, su.precioVenta, su.añoModelo, su.kilometraje,
		su.potencia, su.descripcion, su.patente, s.nombre as NombreSerie, g.nombre as NombreGeneracion, f.nombre as NombreFabricante 
from StockUnidades su	join Generaciones g on su.idGeneracion = g.idGeneracion
						join Series s on su.idSerie = s.idSerie
						join Fabricantes f on su.idFabricante = f.idFabricante 

where su.codUnidad = @id and su.borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[getUnidadParaGrilla]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUnidadParaGrilla] 
@id int
as
select s.codUnidad, s.nombre, s.añoModelo, s.precioVenta, f.nombre, g.nombre
from StockUnidades s join Fabricantes f on s.idFabricante = f.idFabricante join Generaciones g on g.idGeneracion = s.idGeneracion
where s.codUnidad = @id and s.borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[getUnidadesPorNombre]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getUnidadesPorNombre]
@nombre varchar(30)
as
select	su.codUnidad, su.idFabricante, su.idSerie, su.idGeneracion, su.nombre, su.precioVenta, su.añoModelo, su.kilometraje,
		su.potencia, su.descripcion, su.patente, s.nombre as NombreSerie, g.nombre as NombreGeneracion, f.nombre as NombreFabricante 
from StockUnidades su	join Generaciones g on su.idGeneracion = g.idGeneracion
						join Series s on su.idSerie = s.idSerie
						join Fabricantes f on su.idFabricante = f.idFabricante 

where su.nombre like @nombre and su.borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[getUnidadesPorFiltros]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUnidadesPorFiltros]
@fabricante int,
@serie int, 
@generacion int,
@nombre varchar(20)
as
select	su.codUnidad, su.idFabricante, su.idSerie, su.idGeneracion, su.nombre, su.precioVenta, su.añoModelo, su.kilometraje,
		su.potencia, su.descripcion, su.patente, s.nombre as NombreSerie, g.nombre as NombreGeneracion, f.nombre as NombreFabricante 
from StockUnidades su	join Generaciones g on su.idGeneracion = g.idGeneracion
						join Series s on su.idSerie = s.idSerie
						join Fabricantes f on su.idFabricante = f.idFabricante 

where su.nombre like @nombre and su.borrado = 0 and su.idFabricante = @fabricante and su.idSerie = @serie and su.idGeneracion = @generacion
GO
/****** Object:  StoredProcedure [dbo].[getUnidadesPorDNI]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getUnidadesPorDNI]
@dni int
as
select	su.codUnidad, su.idFabricante, su.idSerie, su.idGeneracion, su.nombre, su.precioVenta, su.añoModelo, su.kilometraje,
		su.potencia, su.descripcion, su.patente, s.nombre as NombreSerie, g.nombre as NombreGeneracion, f.nombre as NombreFabricante 
from StockUnidades su	join Generaciones g on su.idGeneracion = g.idGeneracion
						join Series s on su.idSerie = s.idSerie
						join Fabricantes f on su.idFabricante = f.idFabricante
						join Clientes c on su.idCliente = c.idCliente

where c.dni = @dni and su.borrado = 1
GO
/****** Object:  StoredProcedure [dbo].[getServicePorFiltro]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getServicePorFiltro]
@unidad int,
@modelo varchar(20),
@patente varchar(7),
@borrado bit 
as
select s.*
from Service s	join StockUnidades su on s.codUnidad = su.codUnidad
where s.codUnidad = @unidad or su.nombre = @modelo or su.patente = @patente and borrado = @borrado
GO
/****** Object:  Table [dbo].[DetalleService]    Script Date: 11/04/2019 02:23:26 ******/
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
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (1, 1, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (2, 2, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (3, 3, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (4, 4, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (5, 5, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (6, 6, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (7, 7, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (8, 8, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (9, 9, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
INSERT [dbo].[DetalleService] ([codService], [codUnidad], [idtrabajo], [precios], [descripcion]) VALUES (10, 10, 1, CAST(5000 AS Numeric(18, 0)), N'service inicial al momento de comprar la unidad para la posterior venta')
/****** Object:  StoredProcedure [dbo].[registrarDetallesVenta]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrarDetallesVenta]
@cliente int,
@unidad int,
@precioVenta numeric(18,0)
as

BEGIN TRANSACTION 
BEGIN TRY

insert into DetallesVentas(añoVenta,nroVenta,codUnidad,precioVenta)
values(YEAR(GETDATE()),IDENT_CURRENT('Ventas'),@unidad,@precioVenta);

update StockUnidades 
set borrado = 1, idCliente = @cliente
where codUnidad = @unidad

COMMIT TRANSACTION 

END TRY

BEGIN CATCH

/* si hay un error, deshacemos los cambios*/ 
ROLLBACK TRANSACTION
SELECT @@ROWCOUNT

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[getDetallesPorService]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getDetallesPorService]
@codService int,
@codUnidad int
as
select ds.idtrabajo, ds.precios, ds.descripcion as detalleDescripcion, t.*
from DetalleService ds join Trabajos t on ds.idtrabajo = t.idTrabajo
where ds.codService = @codService and ds.codUnidad = @codUnidad
GO
/****** Object:  StoredProcedure [dbo].[registrarUnidadUsada]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrarUnidadUsada]
@fabricante int,
@serie int,
@generacion int,
@nombre varchar(20),
@precioVenta numeric(18,0),
@añoModelo int,
@kilometraje int,
@potencia int,
@descripcion varchar(200),
@precioCompra numeric(18,0)
as

/* inicio de la transaccion */

BEGIN TRANSACTION 
BEGIN TRY

insert into StockUnidades(idFabricante,idSerie,idGeneracion,nombre,precioVenta,añoModelo,kilometraje,potencia,descripcion,patente,precioCompra)
values (@fabricante,@serie,@generacion,@nombre,@precioVenta,@añoModelo,@kilometraje,@potencia,@descripcion,'N/D',@precioCompra);

insert into Service(codUnidad,fechaService,kmLimite) values(IDENT_CURRENT('StockUnidades'),GETDATE(),(@kilometraje+60000)); 

insert into DetalleService(codService,codUnidad,idtrabajo,precios)
values(@@IDENTITY,IDENT_CURRENT('StockUnidades'),1,5000)

COMMIT TRANSACTION 

END TRY

BEGIN CATCH

/* si hay un error, deshacemos los cambios*/ 
ROLLBACK TRANSACTION
SELECT @@ROWCOUNT

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[registrarUnidadCeroKM]    Script Date: 11/04/2019 02:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrarUnidadCeroKM]
@fabricante int,
@serie int,
@generacion int,
@nombre varchar(20),
@precioVenta numeric(18,0),
@añoModelo int,
@kilometraje int,
@potencia int,
@descripcion varchar(200),
@precioCompra numeric(18,0)
as

/* inicio de la transaccion */

BEGIN TRANSACTION 
BEGIN TRY

insert into StockUnidades(idFabricante,idSerie,idGeneracion,nombre,precioVenta,añoModelo,kilometraje,potencia,descripcion,patente,precioCompra)
values (@fabricante,@serie,@generacion,@nombre,@precioCompra,@añoModelo,@kilometraje,@potencia,@descripcion,'N/D',@precioCompra);

insert into Service(codUnidad,fechaService) values(IDENT_CURRENT('StockUnidades'),GETDATE()); 

insert into DetalleService(codService,codUnidad,idtrabajo,precios)
values(@@IDENTITY,IDENT_CURRENT('StockUnidades'),1,5000)

COMMIT TRANSACTION 

END TRY

BEGIN CATCH

/* si hay un error, deshacemos los cambios*/ 
ROLLBACK TRANSACTION
SELECT @@ROWCOUNT

END CATCH
GO
/****** Object:  Default [DF__Clientes__calle__276EDEB3]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ('sin datos') FOR [calle]
GO
/****** Object:  Default [DF__Clientes__nroCal__286302EC]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((-99)) FOR [nroCalle]
GO
/****** Object:  Default [DF__Clientes__borrad__29572725]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Modelos__precioF__2A4B4B5E]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Modelos] ADD  DEFAULT ((0)) FOR [precioFabrica]
GO
/****** Object:  Default [DF__Modelos__borrado__2B3F6F97]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Modelos] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Service__kmLimit__2C3393D0]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Service] ADD  DEFAULT ((60000)) FOR [kmLimite]
GO
/****** Object:  Default [DF__StockUnid__preci__2D27B809]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [precioVenta]
GO
/****** Object:  Default [DF__StockUnid__añoMo__2E1BDC42]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((1990)) FOR [añoModelo]
GO
/****** Object:  Default [DF__StockUnid__kilom__2F10007B]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [kilometraje]
GO
/****** Object:  Default [DF__StockUnid__poten__300424B4]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((-99)) FOR [potencia]
GO
/****** Object:  Default [DF__StockUnid__borra__30F848ED]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[StockUnidades] ADD  DEFAULT ((0)) FOR [borrado]
GO
/****** Object:  Default [DF__Ventas__añoVenta__440B1D61]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT (datepart(year,getdate())) FOR [añoVenta]
GO
/****** Object:  ForeignKey [fk_detallesServices]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[DetalleService]  WITH CHECK ADD  CONSTRAINT [fk_detallesServices] FOREIGN KEY([codService], [codUnidad])
REFERENCES [dbo].[Service] ([codService], [codUnidad])
GO
ALTER TABLE [dbo].[DetalleService] CHECK CONSTRAINT [fk_detallesServices]
GO
/****** Object:  ForeignKey [fk_detalletrabajo]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[DetalleService]  WITH CHECK ADD  CONSTRAINT [fk_detalletrabajo] FOREIGN KEY([idtrabajo])
REFERENCES [dbo].[Trabajos] ([idTrabajo])
GO
ALTER TABLE [dbo].[DetalleService] CHECK CONSTRAINT [fk_detalletrabajo]
GO
/****** Object:  ForeignKey [fk_unidad]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[DetallesVentas]  WITH CHECK ADD  CONSTRAINT [fk_unidad] FOREIGN KEY([codUnidad])
REFERENCES [dbo].[StockUnidades] ([codUnidad])
GO
ALTER TABLE [dbo].[DetallesVentas] CHECK CONSTRAINT [fk_unidad]
GO
/****** Object:  ForeignKey [fk_ventas]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[DetallesVentas]  WITH CHECK ADD  CONSTRAINT [fk_ventas] FOREIGN KEY([añoVenta], [nroVenta])
REFERENCES [dbo].[Ventas] ([añoVenta], [nroVenta])
GO
ALTER TABLE [dbo].[DetallesVentas] CHECK CONSTRAINT [fk_ventas]
GO
/****** Object:  ForeignKey [fk_series]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Generaciones]  WITH CHECK ADD  CONSTRAINT [fk_series] FOREIGN KEY([idSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Generaciones] CHECK CONSTRAINT [fk_series]
GO
/****** Object:  ForeignKey [fk_fabricante]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_fabricante] FOREIGN KEY([codFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_fabricante]
GO
/****** Object:  ForeignKey [fk_generacion]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_generacion] FOREIGN KEY([codGeneracion])
REFERENCES [dbo].[Generaciones] ([idGeneracion])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_generacion]
GO
/****** Object:  ForeignKey [fk_serie]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_serie] FOREIGN KEY([codSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_serie]
GO
/****** Object:  ForeignKey [fk_fabricantes]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Series]  WITH CHECK ADD  CONSTRAINT [fk_fabricantes] FOREIGN KEY([idFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Series] CHECK CONSTRAINT [fk_fabricantes]
GO
/****** Object:  ForeignKey [fk_services]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [fk_services] FOREIGN KEY([codUnidad])
REFERENCES [dbo].[StockUnidades] ([codUnidad])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [fk_services]
GO
/****** Object:  ForeignKey [fk_cliente_unidad]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[StockUnidades]  WITH CHECK ADD  CONSTRAINT [fk_cliente_unidad] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
ALTER TABLE [dbo].[StockUnidades] CHECK CONSTRAINT [fk_cliente_unidad]
GO
/****** Object:  ForeignKey [fk_fabricanteUnidad]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[StockUnidades]  WITH CHECK ADD  CONSTRAINT [fk_fabricanteUnidad] FOREIGN KEY([idFabricante], [idSerie], [idGeneracion], [nombre])
REFERENCES [dbo].[Modelos] ([codFabricante], [codSerie], [codGeneracion], [nombre])
GO
ALTER TABLE [dbo].[StockUnidades] CHECK CONSTRAINT [fk_fabricanteUnidad]
GO
/****** Object:  ForeignKey [fk_perfil]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_perfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[Perfiles] ([idPerfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_perfil]
GO
/****** Object:  ForeignKey [fk_cliente]    Script Date: 11/04/2019 02:23:26 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [fk_cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [fk_cliente]
GO
