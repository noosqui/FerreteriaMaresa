use Ferreteria_Maresa
GO

CREATE TRIGGER SP_Dis_stock
on DetalleVenta for insert
as
set nocount on
update Inventario set stock = I.stock - DV.cantidad
from Inventario as I inner join DetalleVenta as DV on I.id_producto = DV.id_producto
go

CREATE TRIGGER SP_Aumen_stock
on DetalleCompra for insert
as
set nocount on
update Inventario set stock = I.stock + DC.cantidad
from Inventario as I inner join DetalleCompra as DC on I.id_producto = DC.id_producto
go
