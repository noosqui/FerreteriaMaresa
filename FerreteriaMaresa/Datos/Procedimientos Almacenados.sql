use Ferreteria_Maresa

-------------------------PROCEDIMIENTOS ALMACENADOS-------------------------
----EMPLEADO----

create procedure VerificarUsuario
@usuario nvarchar(20),
@contrasenia nvarchar(80)
as 
    select * from Empleados inner join
	Usuarios as u on @usuario=u.id_usuario and u.contrasenia=@contrasenia and u.id_usuario=id_empleado;

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
	@estado as varchar(20),
	@contrasenia as nvarchar(80)    
	as begin
		insert into Empleados values(@idEmpleado, @nombreEmpleado, @apellidoEmpleado, @correoEmpleado, @telEmpleado, @direccion, @ciudad, @region,  @codigo_postal, @pais, @id_rol_empleado, @fnacimiento_empleado, @estado, @contrasenia) 
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
	@estado as varchar(20),
	@contrasenia as nvarchar(80)      
	as 
	   update Empleados set id_empleado=@idEmpleado, nom_empleado=@nombreEmpleado, apellido_empleado=@apellidoEmpleado, correo_empleado=@correoEmpleado, telefono_empleado=@telEmpleado, direccion=@direccion, ciudad=@ciudad, region=@region, codigo_postal=@codigo_postal, pais=@pais, id_rol_empleado=@id_rol_empleado, fnacimiento_empleado=@fnacimiento_empleado, Estado=@estado, contrasenia=@contrasenia
	   where id_empleado=@idEmpleado
go


--Despedir Empleado
 create procedure Despedir_Empleado
@idEmpleado as nvarchar(13)
as
	   update Empleados set Estado = 'Despedido'
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
