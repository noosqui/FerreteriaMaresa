USE [Ferreteria_Maresa]
GO
/****** Object:  Table [dbo].[Bancos]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bancos](
	[id_banco] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Cheques]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cheques](
	[numero_cuenta] [varchar](40) NOT NULL,
	[fecha] [date] NULL,
	[id_cliente] [nvarchar](20) NULL,
	[ruta_bancaria] [nvarchar](40) NOT NULL,
	[numero_cheque] [nvarchar](40) NOT NULL,
	[monto] [money] NOT NULL,
	[id_banco] [int] NULL,
	[id_tipo_pago] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [nvarchar](20) NOT NULL,
	[nom_cliente] [nvarchar](80) NOT NULL,
	[apellido_cliente] [nvarchar](80) NOT NULL,
	[RTN] [nvarchar](80) NOT NULL,
	[direccion] [nvarchar](80) NOT NULL,
	[tel_cliente] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[id_detalle_compra] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[cantidad] [int] NOT NULL,
	[isv] [float] NULL,
	[id_categoria] [int] NULL,
 CONSTRAINT [pk_DetalleCompra] PRIMARY KEY CLUSTERED 
(
	[id_detalle_compra] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_venta] [int] NULL,
	[precio] [money] NOT NULL,
	[cantidad] [int] NOT NULL,
	[isv] [float] NULL,
 CONSTRAINT [pk_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[id_empleado] [nvarchar](20) NOT NULL,
	[nom_empleado] [nvarchar](80) NOT NULL,
	[apellido_empleado] [nvarchar](80) NOT NULL,
	[correo_empleado] [nvarchar](80) NOT NULL,
	[telefono_empleado] [nvarchar](30) NOT NULL,
	[direccion_empleado] [nvarchar](80) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
	[id_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturaCompra]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaCompra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_proveedor] [int] NULL,
	[id_empleado] [nvarchar](20) NULL,
	[id_tipo_pago] [int] NULL,
	[descuento] [float] NULL,
	[subtotal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaVenta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[id_cliente] [nvarchar](20) NULL,
	[id_empleado] [nvarchar](20) NULL,
	[id_tipo_pago] [int] NULL,
	[descuento] [float] NULL,
	[subtotal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventario](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nom_producto] [nvarchar](80) NOT NULL,
	[id_marca] [int] NULL,
	[Cantidad_por_Unidad] [varchar](60) NULL,
	[Costo_producto] [money] NOT NULL,
	[precio_actual] [money] NOT NULL,
	[stock] [int] NOT NULL,
	[Estado] [varchar](20) NOT NULL,
	[id_categoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nom_proveedor] [nvarchar](80) NOT NULL,
	[apellido_proveedor] [nvarchar](80) NOT NULL,
	[telefono] [nvarchar](30) NOT NULL,
	[correo] [nvarchar](80) NOT NULL,
	[direccion] [nvarchar](80) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](40) NULL,
	[id_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoPago]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[contrasenia] [nvarchar](80) NULL,
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
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [fk_DetalleCompra_id_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [fk_DetalleCompra_id_categoria]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [fk_DetalleCompra_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Inventario] ([id_producto])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [fk_DetalleCompra_id_producto]
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
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [fk_Empleados_id_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [fk_Empleados_id_usuario]
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
ALTER TABLE [dbo].[Roles]  WITH CHECK ADD  CONSTRAINT [fk_Roles_id_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Roles] CHECK CONSTRAINT [fk_Roles_id_usuario]
GO
/****** Object:  StoredProcedure [dbo].[eliminar_proveedor]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_proveedor]
@id_proveedor int
as
begin
delete from Proveedores where id_proveedor=@id_proveedor
end
GO
/****** Object:  StoredProcedure [dbo].[modificar_Proveedrores]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[modificar_Proveedrores]
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion nvarchar(80),
 @Estado varchar(20)
  as
 begin
update Proveedores set nom_proveedor=@nom_proveedor,apellido_proveedor=@apellido_proveedor,telefono=@telefono,correo=@correo,direccion=@direccion,Estado=@Estado
where id_proveedor=@id_proveedor
end

GO
/****** Object:  StoredProcedure [dbo].[pro_insertar]    Script Date: 26/2/2021 02:18:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_insertar]
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
 @apellido_proveedor nvarchar(80),
 @telefono nvarchar(30),
 @correo nvarchar(80),
 @direccion nvarchar(80),
 @Estado varchar(20)
 as
 begin
 insert into Proveedores values
 (@nom_proveedor, @apellido_proveedor, @telefono, @correo, @direccion, @Estado)
 end

GO
