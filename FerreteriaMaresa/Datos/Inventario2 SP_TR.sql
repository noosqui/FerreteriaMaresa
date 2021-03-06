/*////////////////////////////////-*/
/*inventario*/
Create procedure SP_Inventario
As
SELECT        id_producto, nom_producto, id_marca, Cantidad_por_Unidad, Costo_producto, precio_actual, stock, Estado, id_categoria
FROM            dbo.Inventario
go

/*///////////////////////////////////////--*/
/*venta*/
Create procedure SP_Venta
As
SELECT        id_venta, fecha, id_producto, id_cliente, id_empleado, id_tipo_pago, descuento, subtotal
FROM            dbo.FacturaVenta
go

CREATE TRIGGER SP_Dis_stock
on FacturaVenta for insert
as
set nocount on
update Inventario set stock = I.stock - FV.cantidad
from Inventario as I inner join FacturaVenta as FV on I.id_producto = DT.id_producto
go

Create procedure SP_Detalle_Venta
As
SELECT        id_detalle_venta, id_producto, id_venta, precio, cantidad, isv
FROM            dbo.DetalleVenta
go

/*/////////////////////////////////////////////-*/
/*compra*/
Create procedure SP_Compra
As
SELECT        id_compra, fecha, id_producto, id_proveedor, id_empleado, id_tipo_pago, descuento, subtotal
FROM            dbo.FacturaCompra
go

CREATE TRIGGER SP_Aumen_stock
on FacturaCompra for insert
as
set nocount on
update Inventario set stock = I.stock + FC.cantidad
from Inventario as I inner join FacturaCompra as FC on I.id_producto = FC.id_producto
go 

Create procedure SP_Detalle_Compra
As
SELECT        id_detalle_compra, id_producto, id_compra, id_categoria, precio, cantidad, isv
FROM            dbo.DetalleCompra
go

/*//////////////////////////////////-*/
/*pago*/
Create procedure SP_Pago_Cheque
As
SELECT        dbo.TipoPago.id_tipo_pago, dbo.TipoPago.descripcion, dbo.Cheques.numero_cuenta, dbo.Cheques.fecha, dbo.Cheques.id_cliente, dbo.Cheques.ruta_bancaria, dbo.Cheques.numero_cheque, dbo.Cheques.monto, 
                         dbo.Cheques.id_banco
FROM            dbo.TipoPago INNER JOIN
                         dbo.Cheques ON dbo.TipoPago.id_tipo_pago = dbo.Cheques.id_tipo_pago
go

Create procedure SP_Banco
As
SELECT        id_banco, descripcion, direccion
FROM            dbo.Bancos
go