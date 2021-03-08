use Ferreteria_Maresa
go

--Insertar Venta
create procedure insertar_FacturaVenta
	@Fecha as date,
	@IdCliente as nvarchar(20),
	@IdEmpleado as nvarchar(20),
	@IdTipoPago as int,
	@Descuento as float,
	@SubTotal as float

	as begin
		insert into FacturaVenta values(@Fecha, @IdCliente, @IdEmpleado, @IdTipoPago, @Descuento, @SubTotal) 
end
go

--Insertar Compras
create procedure insertar_FacturaCompra
	@Fecha as date,
	@IdProveedor as int,
	@IdEmpleado as nvarchar(20),
	@IdTipoPago as int,
	@Descuento as float,
	@SubTotal as float

	as begin
		insert into FacturaCompra values(@Fecha, @IdProveedor, @IdEmpleado, @IdTipoPago, @Descuento, @SubTotal) 
end
go

--Mostrar Ventas
Create procedure SP_Venta
As
SELECT        id_venta, fecha, id_cliente, id_empleado, id_tipo_pago, descuento, subtotal
FROM            dbo.FacturaVenta
go

--Mostrar Compras
Create procedure SP_Compras
As
SELECT        id_compra AS [Id Compra], fecha AS Fecha, id_proveedor AS [Id Proveedor], id_empleado AS [Id Empleado], id_tipo_pago AS [Id Tipo Pago], descuento AS Descuento, subtotal AS [Sub Total]
FROM            dbo.FacturaCompra
go

EXEC insertar_FacturaCompra '2021-01-01', '1', '0318199802010', '1', '0', '0'
EXEC SP_Compras
EXEC insertar_FacturaVenta '2021-03-08', '0312197866522', '0318199802010', '1', '0', '0'
EXEC SP_Venta

