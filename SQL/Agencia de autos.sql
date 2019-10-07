USE [AgenciaDeAutos]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 10/01/2019 10:41:52 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/01/2019 10:41:52 ******/
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
/****** Object:  Table [dbo].[Fabricantes]    Script Date: 10/01/2019 10:41:52 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/01/2019 10:41:52 ******/
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
/****** Object:  Table [dbo].[Series]    Script Date: 10/01/2019 10:41:52 ******/
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
/****** Object:  StoredProcedure [dbo].[getUsuarioValidado]    Script Date: 10/01/2019 10:41:51 ******/
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
/****** Object:  StoredProcedure [dbo].[getUsuarios]    Script Date: 10/01/2019 10:41:51 ******/
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
/****** Object:  Table [dbo].[Generaciones]    Script Date: 10/01/2019 10:41:52 ******/
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
/****** Object:  StoredProcedure [dbo].[editarUsuario]    Script Date: 10/01/2019 10:41:51 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarUsuarioPorID]    Script Date: 10/01/2019 10:41:51 ******/
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
/****** Object:  StoredProcedure [dbo].[borrarUsuario]    Script Date: 10/01/2019 10:41:51 ******/
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
/****** Object:  StoredProcedure [dbo].[nuevoUsuario]    Script Date: 10/01/2019 10:41:51 ******/
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
/****** Object:  Table [dbo].[Modelos]    Script Date: 10/01/2019 10:41:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelos](
	[codFabricante] [int] NOT NULL,
	[codGeneracion] [int] NOT NULL,
	[codSerie] [int] NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[carroceria] [varchar](20) NULL,
	[descripcion] [varchar](20) NULL,
	[potencia] [int] NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [pk_modelos] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC,
	[codGeneracion] ASC,
	[codSerie] ASC,
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [fk_series]    Script Date: 10/01/2019 10:41:52 ******/
ALTER TABLE [dbo].[Generaciones]  WITH CHECK ADD  CONSTRAINT [fk_series] FOREIGN KEY([idSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Generaciones] CHECK CONSTRAINT [fk_series]
GO
/****** Object:  ForeignKey [fk_fabricante]    Script Date: 10/01/2019 10:41:52 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_fabricante] FOREIGN KEY([codFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_fabricante]
GO
/****** Object:  ForeignKey [fk_generacio]    Script Date: 10/01/2019 10:41:52 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_generacio] FOREIGN KEY([codGeneracion])
REFERENCES [dbo].[Generaciones] ([idGeneracion])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_generacio]
GO
/****** Object:  ForeignKey [fk_serie]    Script Date: 10/01/2019 10:41:52 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [fk_serie] FOREIGN KEY([codSerie])
REFERENCES [dbo].[Series] ([idSerie])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [fk_serie]
GO
/****** Object:  ForeignKey [fk_fabricantes]    Script Date: 10/01/2019 10:41:52 ******/
ALTER TABLE [dbo].[Series]  WITH CHECK ADD  CONSTRAINT [fk_fabricantes] FOREIGN KEY([idFabricante])
REFERENCES [dbo].[Fabricantes] ([idFabricante])
GO
ALTER TABLE [dbo].[Series] CHECK CONSTRAINT [fk_fabricantes]
GO
/****** Object:  ForeignKey [fk_perfil]    Script Date: 10/01/2019 10:41:52 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_perfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[Perfiles] ([idPerfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_perfil]
GO
