Use Ferreteria_Maresa
Go

--Mostrar Inventario
Create procedure [dbo].[SP_Inventario]
As
SELECT        dbo.Inventario.id_producto AS [Id Producto], dbo.Inventario.nom_producto AS [Nombre de Producto], dbo.Categorias.descripcion AS Categoría, dbo.Marcas.descripcion AS Marca, 
                         dbo.Inventario.Cantidad_por_Unidad AS [Cantidad por Unidad], dbo.Inventario.Costo_producto AS [Costo de Producto], dbo.Inventario.precio_actual AS [Precio Actual], dbo.Inventario.stock AS Stock, dbo.Inventario.Estado
FROM            dbo.Categorias INNER JOIN
                         dbo.Inventario ON dbo.Categorias.id_categoria = dbo.Inventario.id_categoria INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca
GO

--Buscar Inventario
Create procedure Buscar_Inventario
@nom_producto nvarchar(80)
As
SELECT        dbo.Inventario.id_producto AS [Id Producto], dbo.Inventario.nom_producto AS [Nombre de Producto], dbo.Categorias.descripcion AS Categoría, dbo.Marcas.descripcion AS Marca, 
                         dbo.Inventario.Cantidad_por_Unidad AS [Cantidad por Unidad], dbo.Inventario.Costo_producto AS [Costo de Producto], dbo.Inventario.precio_actual AS [Precio Actual], dbo.Inventario.stock AS Stock, dbo.Inventario.Estado
FROM            dbo.Categorias INNER JOIN
                         dbo.Inventario ON dbo.Categorias.id_categoria = dbo.Inventario.id_categoria INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca
						 where dbo.Inventario.nom_producto like '%' +@nom_producto+ '%'
GO

--Inventario no disponible
 create procedure Inventario_NoDisponible
@idproducto as int
as
	   update Inventario set Estado = 'No disponible'
	   where id_producto = @idproducto

go

--Inventario Activo
 create procedure Inventario_Activo
@idproducto as int
as
	   update Inventario set Estado = 'Activo'
	   where id_producto = @idproducto

go

--Mostrar Marcas
Create Procedure Mostrar_Marcas
As
SELECT        id_marca as 'Id Marca', descripcion AS Marca
FROM            dbo.Marcas
GO

--Buscar Marcas
Create Procedure Buscar_Marcas
@Marca nvarchar(50)
As
SELECT        id_marca as 'Id Marca', descripcion AS Marca
FROM            dbo.Marcas
	where dbo.Marcas.descripcion like '%' +@Marca+ '%'
GO


--Mostrar Categorias
Create Procedure Mostrar_Categorias
As
SELECT        id_categoria AS [Id Categoria], descripcion AS Marca
FROM            dbo.Categorias
GO

--Buscar Categoria
Create Procedure Buscar_Categorias
@categoria nvarchar(50)
As
SELECT        id_categoria AS [Id Categoria], descripcion AS Marca
FROM            dbo.Categorias
	where dbo.Categorias.descripcion like '%' +@categoria+ '%'
GO

EXEC Buscar_Categorias 'Herramientas de Trabajo'
Exec SP_Inventario
EXEC Mostrar_Marcas
EXEC Mostrar_Categorias
EXEC Buscar_Inventario 'Clavos'
EXEC Buscar_Marcas 'Stanley'
EXEC Inventario_NoDisponible '1'
EXEC Inventario_Activo '1'

