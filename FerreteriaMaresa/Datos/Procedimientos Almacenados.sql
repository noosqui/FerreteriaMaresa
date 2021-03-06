use Ferreteria_Maresa

-------------------------PROCEDIMIENTOS ALMACENADOS-------------------------
----EMPLEADO----

Create procedure VerificarUsuario
@usuario nvarchar(20),
@contrasenia nvarchar(80)
as 
    select * from Empleados inner join
	Usuarios as u on @usuario=u.id_empleado and u.contrasenia=@contrasenia and @usuario=dbo.Empleados.id_empleado

go

--Insertar Empleado
create procedure insertar_Empleado
	@idEmpleado as nvarchar(20),
	@nombreEmpleado as nvarchar(80),
	@apellidoEmpleado as nvarchar(80),
	@correoEmpleado as nvarchar(80),
	@telEmpleado as nvarchar(30),
	@direccion as nvarchar(80),
	@ciudad as nvarchar(80),
	@region as nvarchar(80),
	@codigo_postal as nvarchar(80),
	@pais as nvarchar(80),
	@id_rol_empleado as int,
	@fnacimiento_empleado as date,
	@estado as varchar(20)  
	as begin
		insert into Empleados values(@idEmpleado, @nombreEmpleado, @apellidoEmpleado, @correoEmpleado, @telEmpleado, @direccion, @ciudad, @region,  @codigo_postal, @pais, @id_rol_empleado, @fnacimiento_empleado, @estado) 
end
go

--Editar Empleado
create procedure editar_Empleado
	@idEmpleado as nvarchar(20),
	@nombreEmpleado as nvarchar(80),
	@apellidoEmpleado as nvarchar(80),
	@correoEmpleado as nvarchar(80),
	@telEmpleado as nvarchar(30),
	@direccion as nvarchar(80),
	@ciudad as nvarchar(80),
	@region as nvarchar(80),
	@codigo_postal as nvarchar(80),
	@pais as nvarchar(80),
	@id_rol_empleado as int,
	@fnacimiento_empleado as date,
	@estado as varchar(20)    
	as 
	   update Empleados set id_empleado=@idEmpleado, nom_empleado=@nombreEmpleado, apellido_empleado=@apellidoEmpleado, correo_empleado=@correoEmpleado, telefono_empleado=@telEmpleado, direccion=@direccion, ciudad=@ciudad, region=@region, codigo_postal=@codigo_postal, pais=@pais, id_rol_empleado=@id_rol_empleado, fnacimiento_empleado=@fnacimiento_empleado, Estado=@estado
	   where id_empleado=@idEmpleado
go


--Despedir Empleado
 create procedure Despedir_Empleado
@idEmpleado as nvarchar(13)
as
	   update Empleados set Estado = 'Despedido'
	   where id_empleado = @idEmpleado

go

 create procedure ReContratar_Empleado
@idEmpleado as nvarchar(13)
as
	   update Empleados set Estado = 'Activo'
	   where id_empleado = @idEmpleado

go

create PROCEDURE Mostrar_Empleados
as
SELECT        dbo.Empleados.id_empleado 'Identidad', dbo.Empleados.nom_empleado +' '+ dbo.Empleados.apellido_empleado as 'Nombre Empleado', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.telefono_empleado as 'Teléfono', dbo.Empleados.direccion as 'Dirección', dbo.Empleados.ciudad as 'Ciudad', 
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
order by dbo.Empleados.id_empleado ASC

create procedure buscar_Empleado
@idempleado nvarchar(20)
as
select dbo.Empleados.id_empleado as 'Identidad', dbo.Empleados.nom_empleado +' '+ dbo.Empleados.apellido_empleado as 'Nombre Empleado', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.telefono_empleado as 'Teléfono', dbo.Empleados.direccion as 'Dirección', dbo.Empleados.ciudad as 'Ciudad', 
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
	  FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
	where dbo.Empleados.id_empleado like '%' +@idempleado+ '%'

	go

create procedure buscar_Usuario
@idempleado nvarchar(20)
as
SELECT        dbo.Usuarios.id_usuario AS [Id Usuario], dbo.Usuarios.id_empleado AS [Id Empleado], dbo.Usuarios.contrasenia AS Contrasenia, dbo.Usuarios.id_rol AS [Id Rol]
FROM            dbo.Usuarios INNER JOIN
                         dbo.Roles ON dbo.Usuarios.id_rol = dbo.Roles.id_rol INNER JOIN
                         dbo.Empleados ON dbo.Usuarios.id_empleado = dbo.Empleados.id_empleado AND dbo.Roles.id_rol = dbo.Empleados.id_rol_empleado
	where dbo.Usuarios.id_empleado like '%' +@idempleado+ '%'

	go
	select * from Empleados
Exec VerificarUsuario '0318199802010','12345'
EXEC buscar_Usuario 0318199802010
EXEC buscar_Empleado 0318199877441 
EXEC Mostrar_Empleados
EXEC Despedir_Empleado '0318199877441'
EXEC ReContratar_Empleado '0318199877441'
EXEC insertar_Empleado '0318199855221', 'Mario Ignacio', 'Manueles Guerrero', 'nachoman@hotmail.com', '44551122', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras','2', '1998-05-25', 'Activo'
