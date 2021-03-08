Create procedure [dbo].[SP_Inventario]
As
SELECT        id_producto, nom_producto, id_marca, Cantidad_por_Unidad, Costo_producto, precio_actual, stock, Estado, id_categoria
FROM            dbo.Inventario