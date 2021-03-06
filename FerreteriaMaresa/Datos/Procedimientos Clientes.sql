--Mostrar Clientes
create procedure Mostrar_Clientes
as
SELECT        id_cliente AS 'Id Cliente', nom_cliente +''+ apellido_cliente as 'Nombre del Cliente', RTN, direccion AS Dirección, ciudad AS Ciudad, region AS Región, codigo_postal AS 'Codigo Postal', pais AS País, tel_cliente AS Telefono
FROM            dbo.Clientes
order by dbo.Clientes.id_cliente ASC

--Insertar Empleado
create procedure insertar_Cliente
	@idcliente as nvarchar(20),
	@nombrecliente as nvarchar(80),
	@apellidocliente as nvarchar(80),
	@RTN as nvarchar(80),
	@direccion as nvarchar(80),
	@ciudad as nvarchar(80),
	@region as nvarchar(80),
	@codigo_postal as nvarchar(80),
	@pais as nvarchar(80),
	@telefono as nvarchar(30)
	as begin
		insert into Clientes values(@idcliente, @nombrecliente, @apellidocliente, @RTN, @direccion, @ciudad, @region, @codigo_postal, @pais, @telefono) 
end
go

--Editar Clientes
create procedure editar_Cliente
	@idcliente as nvarchar(20),
	@nombrecliente as nvarchar(80),
	@apellidocliente as nvarchar(80),
	@RTN as nvarchar(80),
	@direccion as nvarchar(80),
	@ciudad as nvarchar(80),
	@region as nvarchar(80),
	@codigo_postal as nvarchar(80),
	@pais as nvarchar(80),
	@telefono as nvarchar(30)
	as begin
			   update Clientes set id_cliente=@idcliente, nom_cliente=@nombrecliente, apellido_cliente=@apellidocliente, RTN=@RTN, direccion=@direccion, direccion=@direccion, ciudad=@ciudad, region=@region, codigo_postal=@codigo_postal, pais=@pais, tel_cliente=@telefono
	   where id_cliente=@idcliente
end
go

--Buscar Cliente
create procedure buscar_Clientes
@idcliente nvarchar(20)
as
SELECT        id_cliente AS 'Id Cliente', nom_cliente +''+ apellido_cliente as 'Nombre del Cliente', RTN, direccion AS Dirección, ciudad AS Ciudad, region AS Región, codigo_postal AS 'Codigo Postal', pais AS País, tel_cliente AS Telefono
FROM            dbo.Clientes
where dbo.Clientes.id_cliente like '%' +@idcliente+ '%'


exec buscar_Clientes 0312197866522

--Eliminar Cliente
 create procedure Eliminar_Cliente
@idcliente as nvarchar(13)
as
	  delete from Clientes
	   where id_cliente = @idcliente

go