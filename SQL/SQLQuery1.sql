use AgenciaDeAutos

go
create procedure getUsuarios
 as
select u.idUsuario, u.nombre,u.contrase�a,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0
go

go
create procedure buscarUsuarioPorID
@id int
 as
select u.idUsuario, u.nombre,u.contrase�a,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0 and u.idUsuario = @id 
go

go
create procedure getUsuarioValidado
@nombre varchar(30),
@contrase�a varchar(50)
 as
select u.idUsuario, u.nombre,u.contrase�a,u.idPerfil,p.nombre 
from Usuarios u join Perfiles p on u.idPerfil = p.idPerfil 
where u.borrado = 0 and u.nombre like @nombre and u.contrase�a like @contrase�a 
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
@contrase�a varchar(50),
@idPerfil int
as
insert into Usuarios(nombre,contrase�a,borrado,bloqueado,idPerfil)
values(@nombre,@contrase�a,0,0,@idPerfil)
go

go
create procedure editarUsuario
@nombre varchar(30),
@contrase�a varchar(50),
@idUsuario int,
@idPerfil int
as
update Usuarios
set nombre = @nombre, contrase�a = @contrase�a, idPerfil = @idPerfil
where idUsuario = @idUsuario and idPerfil > 0
go

exec editarUsuario


