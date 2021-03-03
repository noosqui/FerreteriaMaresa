
/*///////////////////////////////////////////////////-*/
/*solo almacena inventario */
Create procedure SP_Inventario
As
SELECT   dbo.Inventario.id_producto, dbo.Inventario.nom_producto, dbo.Marcas.id_marca, dbo.Marcas.descripcion, dbo.Categorias.descripcion AS Expr1, dbo.Categorias.id_categoria, 
                         dbo.Inventario.Cantidad_por_Unidad, dbo.Inventario.Costo_producto, dbo.Inventario.precio_actual, dbo.Inventario.stock, dbo.Inventario.Estado
FROM         dbo.Inventario INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca INNER JOIN
                         dbo.Categorias ON dbo.Inventario.id_categoria = dbo.Categorias.id_categoria
go
/*////////////////////////////////////-*/
--almacena detalle de venta
Create procedure SP_Venta
As
SELECT   dbo.DetalleVenta.id_detalle_venta, dbo.Inventario.id_producto, dbo.Inventario.nom_producto, dbo.FacturaVenta.id_venta, dbo.FacturaVenta.fecha, dbo.FacturaVenta.id_cliente, 
                         dbo.FacturaVenta.id_empleado, dbo.FacturaVenta.id_tipo_pago, dbo.DetalleVenta.precio, dbo.DetalleVenta.cantidad, dbo.FacturaVenta.descuento, dbo.FacturaVenta.subtotal, 
                         dbo.DetalleVenta.isv
FROM         dbo.DetalleVenta INNER JOIN
                         dbo.Inventario ON dbo.DetalleVenta.id_producto = dbo.Inventario.id_producto INNER JOIN
                         dbo.FacturaVenta ON dbo.DetalleVenta.id_venta = dbo.FacturaVenta.id_venta
go
/*/////////////////////////////////////-*/
-- disminulle el stock
CREATE TRIGGER SP_Dis_stock
on DetalleVenta for insert
as
set nocount on
update Inventario set stock = I.stock - DT.cantidad
from Inventario as I inner join DetalleVenta as DT on I.id_producto = DT.id_producto
go 
/*/////////////////////////////////-*/
--almacena detalle de compra
Create procedure SP_Compra
As
SELECT   dbo.DetalleCompra.id_detalle_compra, dbo.Inventario.id_producto, dbo.Inventario.nom_producto, dbo.Inventario.id_marca, dbo.FacturaCompra.id_compra, dbo.FacturaCompra.fecha, 
                         dbo.FacturaCompra.id_proveedor, dbo.FacturaCompra.id_empleado, dbo.FacturaCompra.id_tipo_pago, dbo.DetalleCompra.cantidad, dbo.DetalleCompra.precio, 
                         dbo.FacturaCompra.descuento, dbo.FacturaCompra.subtotal, dbo.DetalleCompra.isv, dbo.Categorias.descripcion
FROM         dbo.DetalleCompra INNER JOIN
                         dbo.FacturaCompra ON dbo.DetalleCompra.id_compra = dbo.FacturaCompra.id_compra INNER JOIN
                         dbo.Inventario ON dbo.DetalleCompra.id_producto = dbo.Inventario.id_producto INNER JOIN
                         dbo.Categorias ON dbo.DetalleCompra.id_categoria = dbo.Categorias.id_categoria AND dbo.Inventario.id_categoria = dbo.Categorias.id_categoria
go
/*////////////////////////////////-*/
--aumenta stock
CREATE TRIGGER SP_Aumen_stock
on DetalleCompra for insert
as
set nocount on
update Inventario set stock = I.stock + DT.cantidad
from Inventario as I inner join DetalleCompra as DT on I.id_producto = DT.id_producto
go 