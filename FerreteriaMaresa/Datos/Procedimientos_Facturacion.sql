Use Ferreteria_Maresa
GO

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

--Mostrar Detalle Venta
Create procedure SP_Detalle_Venta
@idventa int
As
SELECT        id_detalle_venta, id_producto, id_venta, precio, cantidad
FROM            dbo.DetalleVenta
where dbo.DetalleVenta.id_venta =  @idventa
go

--Mostrar Detalle Compra
Create procedure SP_Detalle_Compra
@idcompra int
As
SELECT        id_detalle_compra, id_producto, id_compra, precio, cantidad
FROM            dbo.DetalleCompra
where dbo.DetalleCompra.id_compra = @idcompra
go


--Insertar Detalle Compra
create procedure insertar_DetalleCompra
	@Id_DetalleCompra as int,
	@IdProducto as int,
	@IdCompra as int,
	@Precio as money,
	@Cantidad as int

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
	@Cantidad as int

	as begin
		insert into FacturaVenta values(@Id_Detalleventa, @IdProducto, @IdVenta, @Precio, @Cantidad) 
end
go

Create Procedure Reporte_Compras
As
SELECT        dbo.DetalleCompra.id_detalle_compra AS [Id Detalle Compra], dbo.FacturaCompra.id_compra AS [Id Compra], dbo.Inventario.nom_producto AS [Nombre de Producto], 
                         dbo.Inventario.Cantidad_por_Unidad AS [Cantidad Por Unidad], dbo.DetalleCompra.precio AS Precio, dbo.FacturaCompra.descuento AS Descuento, dbo.FacturaCompra.subtotal AS [Sub Total], 
                         dbo.DetalleCompra.cantidad AS Cantidad, dbo.Marcas.descripcion AS Marca, dbo.Categorias.descripcion AS Categoria, dbo.Empleados.nom_empleado +' '+ dbo.Empleados.apellido_empleado as 'Nombre Empleado', dbo.Proveedores.nom_proveedor +' '+ 
                         dbo.Proveedores.apellido_proveedor as 'Nombre Proveedor', dbo.TipoPago.descripcion AS [Tipo Pago], dbo.FacturaCompra.fecha AS Fecha
FROM            dbo.FacturaCompra INNER JOIN
                         dbo.DetalleCompra ON dbo.FacturaCompra.id_compra = dbo.DetalleCompra.id_compra INNER JOIN
                         dbo.Inventario ON dbo.DetalleCompra.id_producto = dbo.Inventario.id_producto INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca INNER JOIN
                         dbo.Proveedores ON dbo.FacturaCompra.id_proveedor = dbo.Proveedores.id_proveedor INNER JOIN
                         dbo.TipoPago ON dbo.FacturaCompra.id_tipo_pago = dbo.TipoPago.id_tipo_pago INNER JOIN
                         dbo.Empleados ON dbo.FacturaCompra.id_empleado = dbo.Empleados.id_empleado INNER JOIN
                         dbo.Categorias ON dbo.Inventario.id_categoria = dbo.Categorias.id_categoria
						 order by dbo.DetalleCompra.id_detalle_compra ASC
GO
Create procedure Reporte_Ventas
As
SELECT        dbo.DetalleVenta.id_detalle_venta AS [Id Detalle Venta], dbo.FacturaVenta.id_venta AS [Id Venta], dbo.Inventario.nom_producto AS [Nombre de Producto], dbo.Inventario.Cantidad_por_Unidad AS [Cantidad Por Unidad], 
                         dbo.DetalleVenta.precio AS Precio, dbo.FacturaVenta.descuento AS Descuento, dbo.FacturaVenta.subtotal AS [Sub Total], dbo.DetalleVenta.cantidad AS Cantidad, dbo.Marcas.descripcion AS Marca, 
                         dbo.Categorias.descripcion AS Categoria, dbo.Empleados.nom_empleado + ' ' + dbo.Empleados.apellido_empleado AS 'Nombre Empleado', dbo.Clientes.nom_cliente + ' ' + dbo.Clientes.apellido_cliente AS 'Nombre Cliente', 
                         dbo.TipoPago.descripcion AS [Tipo Pago], dbo.FacturaVenta.fecha AS Fecha
FROM            dbo.FacturaVenta INNER JOIN
                         dbo.DetalleVenta ON dbo.FacturaVenta.id_venta = dbo.DetalleVenta.id_venta INNER JOIN
                         dbo.Empleados ON dbo.FacturaVenta.id_empleado = dbo.Empleados.id_empleado INNER JOIN
                         dbo.Clientes ON dbo.FacturaVenta.id_cliente = dbo.Clientes.id_cliente INNER JOIN
                         dbo.Inventario ON dbo.DetalleVenta.id_producto = dbo.Inventario.id_producto INNER JOIN
                         dbo.Categorias ON dbo.Inventario.id_categoria = dbo.Categorias.id_categoria INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca INNER JOIN
                         dbo.TipoPago ON dbo.FacturaVenta.id_tipo_pago = dbo.TipoPago.id_tipo_pago


EXEC insertar_FacturaCompra '2021-01-01', '1', '0318199802010', '1', '0', '0'
EXEC SP_Compras
EXEC insertar_FacturaVenta '2021-03-08', '0312197866522', '0318199802010', '1', '0', '0'
EXEC SP_Venta
EXEC SP_Detalle_Compra '1'
EXEC insertar_DetalleCompra '1', '1', '26', '2'
EXEC SP_Detalle_Venta '1'
EXEC insertar_DetalleVenta  '1', '1', '26', '2'
EXEC Reporte_Compras
EXEC Reporte_Ventas
