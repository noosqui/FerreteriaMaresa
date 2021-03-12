Create database [Ferreteria_Maresa]
GO
USE [Ferreteria_Maresa]
GO

CREATE TABLE [dbo].[Bancos](
	[id_banco] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](80) NOT NULL,
	[ciudad] [nvarchar](80) NOT NULL,
	[region] [nvarchar](80) NOT NULL,
	[codigo_postal] [nvarchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[Cheques](
	[numero_cuenta] [varchar](40) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_cliente] [nvarchar](20) NOT NULL,
	[ruta_bancaria] [nvarchar](40) NOT NULL,
	[numero_cheque] [nvarchar](40) NOT NULL,
	[monto] [money] NOT NULL,
	[id_banco] [int] NOT NULL,
	[id_tipo_pago] [int] NOT NULL,
 CONSTRAINT [PK__Cheques__C6B74B89D35CBA1E] PRIMARY KEY CLUSTERED 
(
	[numero_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Clientes](
	[id_cliente] [nvarchar](20) NOT NULL,
	[nom_cliente] [nvarchar](80) NOT NULL,
	[apellido_cliente] [nvarchar](80) NOT NULL,
	[RTN] [nvarchar](80) NOT NULL,
	[direccion] [nvarchar](80) NOT NULL,
	[ciudad] [nvarchar](80) NOT NULL,
	[region] [nvarchar](80) NOT NULL,
	[codigo_postal] [nvarchar](80) NOT NULL,
	[pais] [nvarchar](80) NOT NULL,
	[tel_cliente] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DetalleCompra](
	[id_detalle_compra] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_compra] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_DetalleCompra_1] PRIMARY KEY CLUSTERED 
(
	[id_detalle_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DetalleVenta](
	[id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_venta] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVenta_1] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Empleados](
	[id_empleado] [nvarchar](20) NOT NULL,
	[nom_empleado] [nvarchar](80) NOT NULL,
	[apellido_empleado] [nvarchar](80) NOT NULL,
	[correo_empleado] [nvarchar](80) NOT NULL,
	[telefono_empleado] [nvarchar](30) NOT NULL,
	[direccion] [nvarchar](80) NOT NULL,
	[ciudad] [nvarchar](80) NOT NULL,
	[region] [nvarchar](80) NOT NULL,
	[codigo_postal] [nvarchar](80) NOT NULL,
	[pais] [nvarchar](80) NOT NULL,
	[id_rol_empleado] [int] NOT NULL,
	[fnacimiento_empleado] [date] NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FacturaCompra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[id_empleado] [nvarchar](20) NOT NULL,
	[id_tipo_pago] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [PK__FacturaC__C4BAA60441121C89] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FacturaVenta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_cliente] [nvarchar](20) NOT NULL,
	[id_empleado] [nvarchar](20) NOT NULL,
	[id_tipo_pago] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [PK__FacturaV__459533BF7D9FE543] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Inventario](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nom_producto] [nvarchar](80) NOT NULL,
	[id_marca] [int] NOT NULL,
	[Cantidad_por_Unidad] [nvarchar](50) NOT NULL,
	[Costo_producto] [money] NOT NULL,
	[precio_actual] [money] NOT NULL,
	[stock] [int] NOT NULL,
	[Estado] [varchar](20) NOT NULL,
	[id_categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Marcas](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nom_proveedor] [nvarchar](80) NOT NULL,
	[apellido_proveedor] [nvarchar](80) NOT NULL,
	[telefono] [nvarchar](30) NOT NULL,
	[correo] [nvarchar](80) NOT NULL,
	[direccion] [nvarchar](80) NOT NULL,
	[ciudad] [nvarchar](80) NOT NULL,
	[region] [nvarchar](80) NOT NULL,
	[codigo_postal] [nvarchar](80) NOT NULL,
	[pais] [nvarchar](80) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK__Roles__6ABCB5E057D528D9] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TipoPago](
	[id_tipo_pago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [nvarchar](20) NOT NULL,
	[contrasenia] [nvarchar](80) NOT NULL,
	[id_rol] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cheques]  WITH CHECK ADD  CONSTRAINT [fk_Cheques_id_banco] FOREIGN KEY([id_banco])
REFERENCES [dbo].[Bancos] ([id_banco])
GO
ALTER TABLE [dbo].[Cheques] CHECK CONSTRAINT [fk_Cheques_id_banco]
GO
ALTER TABLE [dbo].[Cheques]  WITH CHECK ADD  CONSTRAINT [fk_Cheques_id_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Cheques] CHECK CONSTRAINT [fk_Cheques_id_cliente]
GO
ALTER TABLE [dbo].[Cheques]  WITH CHECK ADD  CONSTRAINT [fk_Cheques_id_tipo_pago] FOREIGN KEY([id_tipo_pago])
REFERENCES [dbo].[TipoPago] ([id_tipo_pago])
GO
ALTER TABLE [dbo].[Cheques] CHECK CONSTRAINT [fk_Cheques_id_tipo_pago]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [fk_DetalleVenta_id_compra] FOREIGN KEY([id_venta])
REFERENCES [dbo].[FacturaVenta] ([id_venta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [fk_DetalleVenta_id_compra]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [fk_DetalleVenta_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Inventario] ([id_producto])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [fk_DetalleVenta_id_producto]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [fk_Empleados_id_rol] FOREIGN KEY([id_rol_empleado])
REFERENCES [dbo].[Roles] ([id_rol])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [fk_Empleados_id_rol]
GO
ALTER TABLE [dbo].[FacturaCompra]  WITH CHECK ADD  CONSTRAINT [fk_FacturaCompra_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleados] ([id_empleado])
GO
ALTER TABLE [dbo].[FacturaCompra] CHECK CONSTRAINT [fk_FacturaCompra_empleado]
GO
ALTER TABLE [dbo].[FacturaCompra]  WITH CHECK ADD  CONSTRAINT [fk_FacturaCompra_id_proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[FacturaCompra] CHECK CONSTRAINT [fk_FacturaCompra_id_proveedor]
GO
ALTER TABLE [dbo].[FacturaCompra]  WITH CHECK ADD  CONSTRAINT [fk_FacturaCompra_tipo_pago] FOREIGN KEY([id_tipo_pago])
REFERENCES [dbo].[TipoPago] ([id_tipo_pago])
GO
ALTER TABLE [dbo].[FacturaCompra] CHECK CONSTRAINT [fk_FacturaCompra_tipo_pago]
GO
ALTER TABLE [dbo].[FacturaVenta]  WITH CHECK ADD  CONSTRAINT [fk_FacturaVenta_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[FacturaVenta] CHECK CONSTRAINT [fk_FacturaVenta_cliente]
GO
ALTER TABLE [dbo].[FacturaVenta]  WITH CHECK ADD  CONSTRAINT [fk_FacturaVenta_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleados] ([id_empleado])
GO
ALTER TABLE [dbo].[FacturaVenta] CHECK CONSTRAINT [fk_FacturaVenta_empleado]
GO
ALTER TABLE [dbo].[FacturaVenta]  WITH CHECK ADD  CONSTRAINT [fk_FacturaVenta_tipo_pago] FOREIGN KEY([id_tipo_pago])
REFERENCES [dbo].[TipoPago] ([id_tipo_pago])
GO
ALTER TABLE [dbo].[FacturaVenta] CHECK CONSTRAINT [fk_FacturaVenta_tipo_pago]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [fk_Inventario_id_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [fk_Inventario_id_categoria]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [fk_Inventario_id_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marcas] ([id_marca])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [fk_Inventario_id_marca]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_Empleados_id_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleados] ([id_empleado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_Empleados_id_empleado]
GO


-----------------------------------------INSERTS------------------------------------------------
insert into Roles
values('Empleado'),
	('Gerente');
	
go

insert into Empleados values('0318199877441', 'Noe Ignacio', 'Manueles Guerrero', 'nachoman@hotmail.com', '44551122', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras','2', '1998-05-25', 'Activo'),
('0318199802010', 'Danny Fernando', 'Martinez Romero', 'danny12345@hotmail.com', '99554477', 'Barrio buena Esperanza', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '1', '1998-02-02', 'Activo'),
('0318199230254', 'Jose Luis', 'Carranza Oviedo', 'luisjose@hotmail.com', '99554477', 'Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '1', '1992-08-27', 'Despedido');

go

insert into Usuarios values('0318199877441', '12345', '2'),
('0318199802010', '12345', '1');

go

insert into Clientes values ('0318199111442','Maria Adaluz', 'Martínez Contreras', '14253211253695', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '95663255'),
('0318198702145','Mate José', 'Medrano Sabillón', '45121236985214', 'Barrio el Centro', 'Comayagua', 'Comayagua', '12101', 'Honduras', '98221433'),
('0315199648552','Mario Daniel', 'Martínez Figueroa', '45210236982255', 'Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '33349588'),
('0312197866522','Toni Rafael', 'Hernandez Caceres', '16520124992214', 'Barrio el Centro', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '94556235'),
('0318198845121','Sandra Lisbeth', 'Caceres Sanchez', '18523644882426', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '97321455');
go

Insert into Proveedores values('Sergio Gustavo', 'Espinoza Almendarez', '94152236', 'Espinoza41@gmail.com', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras','Activo'),
('Jefferson Daniel', 'Argueta Suazo', '98556621', 'Suazo7854@gmail.com', 'Barrio Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('Doris Michelle', 'Torres Fonseca', '33215896', 'dtorres_21@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras','Activo'),
('Denis Noe', 'Espinoza Reyes', '96552436', 'dnoe_R@gamil.com', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('Giselle Abigail', 'Mejia Hernandez', '33521699', 'abi_hernz@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', 'Activo');
go

insert into TipoPago values
('Cheque'),
('Efectivo');

go
insert into Bancos values ('Banco de Occidente', 'Barrio el centro', 'Siguatepeque', 'Comayagua', '12111'),
('Banco Atlantida', 'Barrio el centro', 'Siguatepeque', 'Comayagua', '12111'),
('BAC Credomatic', 'Barrio el centro', 'Siguatepeque', 'Comayagua', '12111'),
('BANHCAFE', 'Barrio el centro', 'Siguatepeque', 'Comayagua', '12111'),
('Banco los Trabajadores', 'Barrio el centro', 'Siguatepeque', 'Comayagua', '12111'),
('BANPAIS', 'Barrio el centro', 'Siguatepeque', 'Comayagua', '12111');
go

insert into Marcas (descripcion)
values ('B.A.R.C.O'),
('Stanley'),
('Ferromax');

go
insert into Categorias (descripcion)
values('Herramientas Para el hogar'),
('Materiales de construcción'),
('Herramientas de trabajo')

go
insert into Inventario (nom_producto, id_marca, Cantidad_por_Unidad, Costo_producto, precio_actual, stock, Estado, id_categoria)
values ('Clavos','1','Caja de 100 Clavos','25','26','20','Activo','1'),
('Sierras','2','Unidad, Sierra de inglete de 12 pulgadas','3000','3500','10','Activo','3'),
('Laminas para techos','3','Unidad 5 Metro','150','200','500','Activo','2'),
('Desarmadores','2','unidad','50','70','300','Activo','1');
go

--------------------------------------------PROCEDIMIENTOS ALMACENADOS------------------------------------------------
------------------------------------------------------USUARIO------------------------------------------------------
--Verificar Usuario
Create procedure VerificarUsuario
@usuario nvarchar(20),
@contrasenia nvarchar(80)
as 
    select * from Empleados inner join
	Usuarios as u on @usuario=u.id_empleado and u.contrasenia=@contrasenia and @usuario=dbo.Empleados.id_empleado

go

--Buscar Usuario
create procedure buscar_Usuario
@idempleado nvarchar(20)
as
SELECT        dbo.Usuarios.id_usuario AS [Id Usuario], dbo.Usuarios.id_empleado AS [Id Empleado], dbo.Usuarios.contrasenia AS Contrasenia, dbo.Usuarios.id_rol AS [Id Rol]
FROM            dbo.Usuarios INNER JOIN
                         dbo.Roles ON dbo.Usuarios.id_rol = dbo.Roles.id_rol INNER JOIN
                         dbo.Empleados ON dbo.Usuarios.id_empleado = dbo.Empleados.id_empleado AND dbo.Roles.id_rol = dbo.Empleados.id_rol_empleado
	where dbo.Usuarios.id_empleado like '%' +@idempleado+ '%'

	go

------------------------------------------------------EMPLEADO------------------------------------------------------
--Insertar Empleado
create procedure insertar_Empleado
	@idEmpleado as nvarchar(20),
	@nombreEmpleado as nvarchar(80),
	@apellidoEmpleado as nvarchar(80),
	@correoEmpleado as nvarchar(80),
	@telEmpleado as nvarchar(30),
	@direccion as nvarchar(80),
	@ciudad as nvarchar(80),
	@region as nvarchar(80),
	@codigo_postal as nvarchar(80),
	@pais as nvarchar(80),
	@id_rol_empleado as int,
	@fnacimiento_empleado as date,
	@estado as varchar(20)  
	as begin
		insert into Empleados values(@idEmpleado, @nombreEmpleado, @apellidoEmpleado, @correoEmpleado, @telEmpleado, @direccion, @ciudad, @region,  @codigo_postal, @pais, @id_rol_empleado, @fnacimiento_empleado, @estado) 
end
go

--Editar Empleado
create procedure editar_Empleado
	@idEmpleado as nvarchar(20),
	@nombreEmpleado as nvarchar(80),
	@apellidoEmpleado as nvarchar(80),
	@correoEmpleado as nvarchar(80),
	@telEmpleado as nvarchar(30),
	@direccion as nvarchar(80),
	@ciudad as nvarchar(80),
	@region as nvarchar(80),
	@codigo_postal as nvarchar(80),
	@pais as nvarchar(80),
	@id_rol_empleado as int,
	@fnacimiento_empleado as date,
	@estado as varchar(20)    
	as 
	   update Empleados set id_empleado=@idEmpleado, nom_empleado=@nombreEmpleado, apellido_empleado=@apellidoEmpleado, correo_empleado=@correoEmpleado, telefono_empleado=@telEmpleado, direccion=@direccion, ciudad=@ciudad, region=@region, codigo_postal=@codigo_postal, pais=@pais, id_rol_empleado=@id_rol_empleado, fnacimiento_empleado=@fnacimiento_empleado, Estado=@estado
	   where id_empleado=@idEmpleado
go


--Despedir Empleado
 create procedure Despedir_Empleado
@idEmpleado as nvarchar(13)
as
	   update Empleados set Estado = 'Despedido'
	   where id_empleado = @idEmpleado

go

--ReContratar Empleado
 create procedure ReContratar_Empleado
@idEmpleado as nvarchar(13)
as
	   update Empleados set Estado = 'Activo'
	   where id_empleado = @idEmpleado

go

--Mostrar Empleado
create PROCEDURE Mostrar_Empleados
as
SELECT        dbo.Empleados.id_empleado 'Identidad', dbo.Empleados.nom_empleado as 'Nombres', dbo.Empleados.apellido_empleado as 'Apellidos', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.telefono_empleado as 'Teléfono', dbo.Empleados.direccion as 'Dirección', dbo.Empleados.ciudad as 'Ciudad', 
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
order by dbo.Empleados.id_empleado ASC
GO

--Buscar Empleado
create procedure buscar_Empleado
@idempleado nvarchar(20)
as
SELECT        dbo.Empleados.id_empleado 'Identidad', dbo.Empleados.nom_empleado as 'Nombres', dbo.Empleados.apellido_empleado as 'Apellidos', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.telefono_empleado as 'Teléfono', dbo.Empleados.direccion as 'Dirección', dbo.Empleados.ciudad as 'Ciudad', 
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
	where dbo.Empleados.id_empleado like '%' +@idempleado+ '%'

go

------------------------------------------------------Cliente------------------------------------------------------
--Insertar Cliente
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

--Editar Cliente
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
			   update Clientes set id_cliente=@idcliente, nom_cliente=@nombrecliente, apellido_cliente=@apellidocliente, RTN=@RTN, direccion=@direccion, ciudad=@ciudad, region=@region, codigo_postal=@codigo_postal, pais=@pais, tel_cliente=@telefono
	   where id_cliente=@idcliente
end
go

--Eliminar Cliente
 create procedure Eliminar_Cliente
@idcliente as nvarchar(13)
as
	  delete from Clientes
	   where id_cliente = @idcliente

go

--Mostrar Clientes
create procedure Mostrar_Clientes
as
SELECT        id_cliente AS 'Id Cliente', nom_cliente as 'Nombres', apellido_cliente as 'Apellidos', RTN, direccion AS Dirección, ciudad AS Ciudad, region AS Región, codigo_postal AS 'Codigo Postal', pais AS País, tel_cliente AS Telefono
FROM            dbo.Clientes
order by dbo.Clientes.id_cliente ASC
go

--Buscar Cliente
create procedure buscar_Clientes
@idcliente nvarchar(20)
as
SELECT        id_cliente AS 'Id Cliente', nom_cliente as 'Nombres', apellido_cliente as 'Apellidos', RTN, direccion AS Dirección, ciudad AS Ciudad, region AS Región, codigo_postal AS 'Codigo Postal', pais AS País, tel_cliente AS Telefono
FROM            dbo.Clientes
where dbo.Clientes.id_cliente like '%' +@idcliente+ '%'

go 

------------------------------------------------------Proveedores------------------------------------------------------
--Insertar Proveedor
create proc pro_insertar
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion nvarchar(80),
 @ciudad nvarchar(80),
 @region nvarchar(80),
 @codigo_postal nvarchar(80),
 @pais nvarchar(80),
 @Estado varchar(20)
 as
 begin
 insert into Proveedores values
 (@nom_proveedor, @apellido_proveedor, @telefono, @correo, @direccion, @ciudad,@region,@codigo_postal, @pais,@Estado)
 end
 go

--Editar Proveedor
create proc modificar_Proveedrores
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion nvarchar(80),
 @ciudad nvarchar(80),
 @region nvarchar(80),
 @codigo_postal nvarchar(80),
 @pais nvarchar(80),
 @Estado varchar(20)
  as
 begin
update Proveedores set nom_proveedor=@nom_proveedor,apellido_proveedor=@apellido_proveedor,telefono=@telefono,correo=@correo,direccion=@direccion,ciudad=@ciudad,region=@region,codigo_postal=@codigo_postal,pais=@pais,Estado=@Estado
where id_proveedor=@id_proveedor
end
go

--Eliminar Proveedor
create proc eliminar_proveedor
@id_proveedor int
as
begin
update Proveedores set Estado = 'Inactivo' 
where id_proveedor=@id_proveedor
end
go

--Reactivar
create proc Reactivar_proveedor
@id_proveedor int
as
begin
update Proveedores set Estado = 'Activo' 
where id_proveedor=@id_proveedor
end
go

--Mostrar Proveedor
create PROCEDURE Mostrar_Proveedores
as
SELECT        id_proveedor,nom_proveedor as 'Nombres', apellido_proveedor as 'Apellidos', telefono as Teléfono, correo as Correo, direccion as Dirección, ciudad as Ciudad, region as Región, codigo_postal as 'Codigo Postal' , pais as País, Estado
FROM            dbo.Proveedores
go

--Buscar Proveedor
create procedure buscar_Proveedores
@id_proveedor int
as
SELECT        id_proveedor,nom_proveedor as 'Nombres', apellido_proveedor as 'Apellidos', telefono as Teléfono, correo as Correo, direccion as Dirección, ciudad as Ciudad, region as Región, codigo_postal as 'Codigo Postal' , pais as País, Estado
FROM            dbo.Proveedores
	where dbo.Proveedores.id_proveedor=@id_proveedor
GO

------------------------------------------------------Inventario------------------------------------------------------
--Mostrar Inventario
Create procedure [dbo].[SP_Inventario]
As
SELECT        dbo.Inventario.id_producto AS [Id Producto], dbo.Inventario.nom_producto AS [Nombre Producto], dbo.Inventario.id_marca AS [Id Marca], dbo.Marcas.descripcion AS Marca, dbo.Inventario.id_categoria AS [Id Categoria], 
                         dbo.Categorias.descripcion AS Categoría, dbo.Inventario.Cantidad_por_Unidad AS [Cantidad por Unidad], dbo.Inventario.Costo_producto AS [Costo Producto], dbo.Inventario.precio_actual AS [Precio Actual], 
                         dbo.Inventario.stock AS Stock, dbo.Inventario.Estado
FROM            dbo.Inventario INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca INNER JOIN
                         dbo.Categorias ON dbo.Inventario.id_categoria = dbo.Categorias.id_categoria
GO

--Buscar Inventario
Create procedure Buscar_Inventario
@nom_producto nvarchar(80)
As
SELECT        dbo.Inventario.id_producto AS [Id Producto], dbo.Inventario.nom_producto AS [Nombre Producto], dbo.Inventario.id_marca AS [Id Marca], dbo.Marcas.descripcion AS Marca, dbo.Inventario.id_categoria AS [Id Categoria], 
                         dbo.Categorias.descripcion AS Categoría, dbo.Inventario.Cantidad_por_Unidad AS [Cantidad por Unidad], dbo.Inventario.Costo_producto AS [Costo Producto], dbo.Inventario.precio_actual AS [Precio Actual], 
                         dbo.Inventario.stock AS Stock, dbo.Inventario.Estado
FROM            dbo.Inventario INNER JOIN
                         dbo.Marcas ON dbo.Inventario.id_marca = dbo.Marcas.id_marca INNER JOIN
                         dbo.Categorias ON dbo.Inventario.id_categoria = dbo.Categorias.id_categoria
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

------------------------------------------------------Bancos------------------------------------------------------
--Mostrar Bancos
create PROCEDURE Mostrar_Bancos
as
SELECT        id_banco AS 'Id Banco', descripcion AS Nombre, direccion AS Dirección, ciudad AS Ciudad, region AS Región, codigo_postal AS 'Codigo Postal'
FROM            dbo.Bancos
order by dbo.Bancos.id_banco ASC
go

--Buscar Bancos
create PROCEDURE Buscar_Bancos
@id_banco int
as
SELECT        id_banco AS 'Id Banco', descripcion AS Nombre, direccion AS Dirección, ciudad AS Ciudad, region AS Región, codigo_postal AS 'Codigo Postal'
FROM            dbo.Bancos
	where Bancos.id_banco = @id_banco
GO

------------------------------------------------------Cheques------------------------------------------------------
--Mostrar Cheques
Create procedure [dbo].[SP_Pago_Cheque]
As
SELECT        dbo.TipoPago.id_tipo_pago as 'Id Tipo Pago', dbo.TipoPago.descripcion as 'Tipo Pago', dbo.Cheques.numero_cuenta as 'Numero de Cuenta', dbo.Cheques.fecha as Fecha, dbo.Cheques.id_cliente as 'Id Cliente', dbo.Cheques.ruta_bancaria as 'Ruta Bancaría', dbo.Cheques.numero_cheque as 'Numero de Cheque', dbo.Cheques.monto as 'Monto', 
                         dbo.Cheques.id_banco 'Id Banco' 
FROM            dbo.TipoPago INNER JOIN
                         dbo.Cheques ON dbo.TipoPago.id_tipo_pago = dbo.Cheques.id_tipo_pago
GO

--Buscar Cheques
Create procedure [dbo].[Buscar_Cheque]
@id_numerocheque nvarchar(40)
As
SELECT        dbo.TipoPago.id_tipo_pago as 'Id Tipo Pago', dbo.TipoPago.descripcion as 'Tipo Pago', dbo.Cheques.numero_cuenta as 'Numero de Cuenta', dbo.Cheques.fecha as Fecha, dbo.Cheques.id_cliente as 'Id Cliente', dbo.Cheques.ruta_bancaria as 'Ruta Bancaría', dbo.Cheques.numero_cheque as 'Numero de Cheque', dbo.Cheques.monto as 'Monto', 
                         dbo.Cheques.id_banco 'Id Banco' 
FROM            dbo.TipoPago INNER JOIN
                         dbo.Cheques ON dbo.TipoPago.id_tipo_pago = dbo.Cheques.id_tipo_pago
						 where dbo.Cheques.numero_cheque like '%' +@id_numerocheque+ '%'
GO

------------------------------------------------------Facturación------------------------------------------------------
--Insertar Factura Venta
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

--Insertar Factura Compras
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

--Mostrar Factura Ventas
Create procedure SP_Venta
As
SELECT        id_venta as 'Id Venta', fecha as 'Fecha', id_cliente as 'Id Cliente', id_empleado as 'Id Empleado', id_tipo_pago as 'Id Tipo Pago', descuento as 'Descuento', subtotal as 'Sub Total'
FROM            dbo.FacturaVenta
go

--Mostrar Factura Compras
Create procedure SP_Compras
As
SELECT        id_compra AS [Id Compra], fecha AS Fecha, id_proveedor AS [Id Proveedor], id_empleado AS [Id Empleado], id_tipo_pago AS [Id Tipo Pago], descuento AS Descuento, subtotal AS [Sub Total]
FROM            dbo.FacturaCompra
go

--Mostrar Detalle Venta
Create procedure SP_Detalle_Venta
@idventa int
As
SELECT        id_detalle_venta as 'Id Detalle Venta', id_producto as 'Id Producto', id_venta as 'Id Venta', precio as 'Precio', cantidad as 'Cantidad'
FROM            dbo.DetalleVenta
where dbo.DetalleVenta.id_venta = @idventa
go

--Mostrar Detalle Compra
Create procedure SP_Detalle_Compra
@idcompra int
As
SELECT        id_detalle_compra as 'Id Detalle Compra', id_producto as 'Id Producto', id_compra as 'Id Compra', precio as Precio, cantidad as Cantidad
FROM            dbo.DetalleCompra
where dbo.DetalleCompra.id_compra = @idcompra
go

--Insertar Detalle Compra
create procedure insertar_DetalleCompra
	@IdProducto as int,
	@IdCompra as int,
	@Precio as money,
	@Cantidad as int

	as begin
		insert into DetalleCompra values(@IdProducto, @IdCompra, @Precio, @Cantidad) 
end
go

--Insertar Detalle Venta
create procedure insertar_DetalleVenta
	@IdProducto as int,
	@IdVenta as int,
	@Precio as money,
	@Cantidad as int

	as begin
		insert into DetalleVenta values(@IdProducto, @IdVenta, @Precio, @Cantidad) 
end
go

--Reporte Compras
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

--Reporte Ventas
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
GO

------------------------------------------------------TRIGGERS------------------------------------------------------
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