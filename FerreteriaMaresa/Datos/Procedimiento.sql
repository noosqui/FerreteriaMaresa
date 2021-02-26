use Ferreteria_Maresa

-------------------------PROCEDIMIENTOS ALMACENADOS-------------------------
----EMPLEADO----

create procedure validarUsuario
@userName nvarchar(13),
@psw varchar(80)
as begin
if exists(select id_empleado, contrasenia from Empleados where id_empleado = @userName and contrasenia = @psw)
          select * from Empleados;
		else
        raiserror('El usuario no existe',16,1)
end

--Insertar Empleado
create procedure insertar_Empleado
	@idEmpleado as nvarchar(20),
	@nombreEmpleado as nvarchar(80),
	@apellidoEmpleado as nvarchar(80),
	@correoEmpleado as nvarchar(80),
	@telEmpleado as nvarchar(30),
	@cod_direccion as int,
	@id_rol_empleado as int,
	@fnacimiento_empleado as date,
	@estado as varchar(20),
	@contrasenia as nvarchar(80)    
	as begin
		insert into Empleados values(@idEmpleado, @nombreEmpleado, @apellidoEmpleado, @correoEmpleado, @telEmpleado, @cod_direccion, @id_rol_empleado, @fnacimiento_empleado, @estado, @contrasenia) 
end
go

--Editar Empleado
create procedure editar_Empleado
	@idEmpleado as nvarchar(20),
	@nombreEmpleado as nvarchar(80),
	@apellidoEmpleado as nvarchar(80),
	@correoEmpleado as nvarchar(80),
	@telEmpleado as nvarchar(30),
	@cod_direccion as int,
	@id_rol_empleado as int,
	@fnacimiento_empleado as date,
	@estado as varchar(20),
	@contrasenia as nvarchar(80)       
	as 
	   update Empleados set id_empleado=@idEmpleado, nom_empleado=@nombreEmpleado, apellido_empleado=@apellidoEmpleado, correo_empleado=@correoEmpleado, telefono_empleado=@telEmpleado, cod_direccion=@cod_direccion, id_rol_empleado=@id_rol_empleado, fnacimiento_empleado=@fnacimiento_empleado, Estado=@estado, contrasenia=@contrasenia
	   where id_empleado=@idEmpleado
go


--Eliminar Empleado
 create PROCEDURE eliminar_empleado
@idempleado INT
AS
BEGIN
  Delete from Empleados
  Where id_empleado = @idempleado
END

go

create PROCEDURE Mostrar_Empleados
as
SELECT        dbo.Empleados.id_empleado as 'Identidad', dbo.Empleados.nom_empleado as 'Nombres', dbo.Empleados.apellido_empleado as 'Apellidos', dbo.Roles.descripcion as 'Rol', dbo.Empleados.Estado, dbo.direcciones.nombre_depto + ', ' + dbo.direcciones.nombre_municipios as 'Dirección', 
                         dbo.Empleados.telefono_empleado as 'Telefono', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.fnacimiento_empleado as 'Fecha Nacimiento'
FROM            dbo.direcciones INNER JOIN
                         dbo.Empleados ON dbo.direcciones.cod_direccion = dbo.Empleados.cod_direccion INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
order by dbo.Empleados.id_empleado ASC

go						


 exec.Mostrar_Empleados
 go


 ----PROVEEDORES----
--Insertar Proveedor
 create proc [dbo].[pro_insertar]
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion int,
 @Estado varchar(20)
 as
 begin
 insert into Proveedores values
 (@nom_proveedor, @apellido_proveedor, @telefono, @correo, @direccion, @Estado)
 end

GO

--Modificar Proveedor
 create proc [dbo].[modificar_Proveedrores]
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion int,
 @Estado varchar(20)
  as
 begin
update Proveedores set nom_proveedor=@nom_proveedor,apellido_proveedor=@apellido_proveedor,telefono=@telefono,correo=@correo,cod_direccion=@direccion,Estado=@Estado
where id_proveedor=@id_proveedor
end
GO

--Eliminar Proveedor
create proc [dbo].[eliminar_proveedor]
@id_proveedor int
as
begin
delete from Proveedores where id_proveedor=@id_proveedor
end
GO

 ----PROVEEDORES----
--Mostrar Proveedor
create PROCEDURE Mostrar_Proveedor
as
SELECT        dbo.Proveedores.id_proveedor AS [Id Proveedor], dbo.Proveedores.nom_proveedor AS Nombres, dbo.Proveedores.apellido_proveedor AS Apellidos, dbo.Proveedores.Estado AS Estado, dbo.Proveedores.telefono AS Telefono, 
                         dbo.Proveedores.correo AS Correo, dbo.direcciones.nombre_depto + ', ' + dbo.direcciones.nombre_municipios as 'Dirección'
FROM            dbo.Proveedores INNER JOIN
                         dbo.direcciones ON dbo.Proveedores.cod_direccion = dbo.direcciones.cod_direccion
order by dbo.Proveedores.id_proveedor ASC

go


----INVENTARIO-----
/*Consulta inverntario*/
Create Procedure SP_Consulta_In
As 
Select * from Inventario

exec SP_Consulta_In

/*Consulta Factura Venta*/

Create Procedure SP_Consulta_Ve
As 
Select * from [dbo].[FacturaVenta]

exec SP_Consulta_Ve

/*Consulta de Factura compra*/
Create Procedure SP_Consulta_Co
As 
Select * from [dbo].[FacturaCompra]

exec SP_Consulta_Co

/*Detalle de compra*/
Create Procedure SP_Consulta_DC
As 
Select * from [dbo].[DetalleCompra]

exec SP_Consulta_DC

/*Detalle De venta*/
Create Procedure SP_Consulta_DV
As 
Select * from [dbo].[DetalleVenta]

exec SP_Consulta_DV

/*Venta*/
Create Procedure SP_Venta
@CodProd As Varchar(7),
@Cantida As Int
As
UPDATE [dbo].[Inventario] SET [stock]=[stock]-@Cantida
WHERE [id_producto]=@CodProd

SELECT * FROM [dbo].[Inventario]

/*Compra*/
Create Procedure SP_Compra
@CodProd As Varchar(7),
@Cantida As Int
As
UPDATE [dbo].[Inventario] SET [stock]=[stock]+@Cantida
WHERE [id_producto]=@CodProd

SELECT * FROM [dbo].[Inventario]

/*Vista Inventario*/
Create procedure Mostar_Inventario
As
SELECT        dbo.Inventario.id_producto, dbo.Inventario.nom_producto, dbo.Marcas.id_marca, dbo.Marcas.descripcion, dbo.Inventario.Cantidad_por_Unidad, dbo.Inventario.Costo_producto, dbo.Inventario.precio_actual, dbo.Inventario.stock, 
                         dbo.Inventario.Estado, dbo.Categorias.id_categoria, dbo.Categorias.descripcion AS Expr1
FROM            dbo.Inventario INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca INNER JOIN
                         dbo.Categorias ON dbo.Inventario.id_categoria = dbo.Categorias.id_categoria


exec Mostar_Inventario



