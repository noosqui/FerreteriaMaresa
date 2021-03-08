use Ferreteria_Maresa
go

--Mostrar Detalle Venta
Create procedure SP_Detalle_Venta
As
SELECT        id_detalle_venta, id_producto, id_venta, precio, cantidad
FROM            dbo.DetalleVenta
go

--Mostrar Detalle Compra
Create procedure SP_Detalle_Compra
As
SELECT        id_detalle_compra, id_producto, id_compra, precio, cantidad
FROM            dbo.DetalleCompra
go


--Insertar Detalle Compra
create procedure insertar_DetalleCompra
	@Id_DetalleCompra as int,
	@IdProducto as int,
	@IdCompra as int,
	@Precio as money,
	@Cantidad as money

	as begin
		insert into FacturaVenta values(@Id_DetalleCompra, @IdProducto, @IdCompra, @Precio, @Cantidad) 
end
go

--Insertar Detalle Venta
create procedure insertar_DetalleVenta
	@Id_Detalleventa as int,
	@IdProducto as int,
	@IdVenta as int,
	@Precio as money,
	@Cantidad as money

	as begin
		insert into FacturaVenta values(@Id_Detalleventa, @IdProducto, @IdVenta, @Precio, @Cantidad) 
end
go