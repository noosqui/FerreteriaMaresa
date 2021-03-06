use Ferreteria_Maresa
go

-----------Modificar
create proc modificar_Proveedrores
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion nvarchar(80),
 @ciudad nvarchar(80),
 @region nvarchar(80),
 @codigo_postal nvarchar(80),
 @pais nvarchar(80),
 @Estado varchar(20)
  as
 begin
update Proveedores set nom_proveedor=@nom_proveedor,apellido_proveedor=@apellido_proveedor,telefono=@telefono,correo=@correo,direccion=@direccion,ciudad=@ciudad,region=@region,codigo_postal=@codigo_postal,pais=@pais,Estado=@Estado
where id_proveedor=@id_proveedor
end
go

-------------Eliminar
create proc eliminar_proveedor
@id_proveedor int
as
begin
update Proveedores set Estado = 'Inactivo' 
where id_proveedor=@id_proveedor
end
go

-------------------------Reactivar
create proc Reactivar_proveedor
@id_proveedor int
as
begin
update Proveedores set Estado = 'activo' 
where id_proveedor=@id_proveedor
end
go

-------------------------insertar
create proc pro_insertar
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion nvarchar(80),
 @ciudad nvarchar(80),
 @region nvarchar(80),
 @codigo_postal nvarchar(80),
 @pais nvarchar(80),
 @Estado varchar(20)
 as
 begin
 insert into Proveedores values
 (@nom_proveedor, @apellido_proveedor, @telefono, @correo, @direccion, @ciudad,@region,@codigo_postal, @pais,@Estado)
 end
 go

 create PROCEDURE Mostrar_Proveedores
as
SELECT        nom_proveedor + ' ' +apellido_proveedor as 'Nombre Proveedor', telefono as Teléfono, correo as Correo, direccion as Dirección, ciudad as Ciudad, region as Región, codigo_postal as 'Codigo Postal' , pais as País, Estado
FROM            dbo.Proveedores
go

create procedure buscar_Proveedores
@nombre nvarchar(20)
as
SELECT        nom_proveedor + ' ' +apellido_proveedor as 'Nombre Proveedor', telefono as Teléfono, correo as Correo, direccion as Dirección, ciudad as Ciudad, region as Región, codigo_postal as 'Codigo Postal' , pais as País, Estado
FROM            dbo.Proveedores
	where dbo.Proveedores.nom_proveedor +' '+ dbo.Proveedores.apellido_proveedor like '%' +@nombre+ '%'

exec Mostrar_Proveedores
exec buscar_Proveedores 'Denis Noe'
