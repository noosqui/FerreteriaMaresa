/*ALTER PROC SP_Consulta_In
@Id_pro int,
@Nombre nvarchar(80),
@Cantidad varchar(60),
@Costo_p  money,
@Precio_A money,
@STOCK int,
@Estado varchar(20),
@Id_Cate int,
@parametros1 int OUT
As
begin

insert into Inventario([id_producto],[nom_producto],[id_marca],[Cantidad_por_Unidad],[Costo_producto],[precio_actual],[stock],[Estado],[id_categoria])
values (@Id_pro,@Nombre,@Cantidad,@Costo_p,@Precio_A,@STOCK,@Estado,@Id_Cate);
SET @parametros1 = SCOPE_IDENTITY();
end
*/

CREATE PROCEDURE SP_Inventario AS
select [id_producto],[nom_producto],[id_marca],[Cantidad_por_Unidad],[Costo_producto],[precio_actual],[stock],[Estado],[id_categoria]
From [dbo].[Inventario]
 
 EXEC SP_Inventario

 CREATE PROCEDURE SP_Inventario AS
select [id_producto],[nom_producto],[id_marca],[Cantidad_por_Unidad],[Costo_producto],[precio_actual],[stock],[Estado],[id_categoria]
From [dbo].[Inventario]
 
 EXEC SP_Inventario

 CREATE PROCEDURE SP_Inventario AS
select [id_producto],[nom_producto],[id_marca],[Cantidad_por_Unidad],[Costo_producto],[precio_actual],[stock],[Estado],[id_categoria]
From [dbo].[Inventario]
 
 EXEC SP_Inventario



