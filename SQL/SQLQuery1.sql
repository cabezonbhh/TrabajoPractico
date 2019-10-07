use AgenciaDeAutos

go
create procedure getUsuarios
 as
select u.idUsuario, u.nombre,u.contraseņa,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0
go

go
create procedure buscarUsuarioPorID
@id int
 as
select u.idUsuario, u.nombre,u.contraseņa,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0 and u.idUsuario = @id 
go

go
create procedure getUsuarioValidado
@nombre varchar(30),
@contraseņa varchar(50)
 as
select u.idUsuario, u.nombre,u.contraseņa,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0 and u.nombre like @nombre and u.contraseņa like @contraseņa 
go

go
create procedure borrarUsuario
@id int
 as
update Usuarios 
set borrado = 1 
where idUsuario = @id 
go

go
create procedure nuevoUsuario
@nombre varchar(30),
@contraseņa varchar(50),
@idPerfil int
as
insert into Usuarios(nombre,contraseņa,borrado,bloqueado,idPerfil)
values(@nombre,@contraseņa,0,0,@idPerfil)
go

go
create procedure editarUsuario
@nombre varchar(30),
@contraseņa varchar(50),
@idUsuario int,
@idPerfil int
as
update Usuarios
set nombre = @nombre, contraseņa = @contraseņa, idPerfil = @idPerfil
where idUsuario = @idUsuario and idPerfil > 0
go

exec editarUsuario


