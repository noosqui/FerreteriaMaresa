USE [master]
GO
/****** Object:  Database [Ferreteria_Maresa]    Script Date: 06/03/2021 10:52:23 ******/
CREATE DATABASE [Ferreteria_Maresa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ferreteria_Maresa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ferreteria_Maresa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ferreteria_Maresa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ferreteria_Maresa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ferreteria_Maresa] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ferreteria_Maresa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ferreteria_Maresa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Ferreteria_Maresa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ferreteria_Maresa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ferreteria_Maresa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ferreteria_Maresa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ferreteria_Maresa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ferreteria_Maresa] SET  MULTI_USER 
GO
ALTER DATABASE [Ferreteria_Maresa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ferreteria_Maresa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ferreteria_Maresa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ferreteria_Maresa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ferreteria_Maresa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ferreteria_Maresa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ferreteria_Maresa', N'ON'
GO
ALTER DATABASE [Ferreteria_Maresa] SET QUERY_STORE = OFF
GO
USE [Ferreteria_Maresa]
GO
/****** Object:  Table [dbo].[Bancos]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 06/03/2021 10:52:23 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cheques]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 06/03/2021 10:52:23 ******/
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
	[ciudad] [nvarchar](80) NOT NULL,
	[region] [nvarchar](80) NOT NULL,
	[codigo_postal] [nvarchar](80) NOT NULL,
	[pais] [nvarchar](80) NOT NULL,
	[tel_cliente] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaCompra]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaCompra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[id_empleado] [nvarchar](20) NOT NULL,
	[id_tipo_pago] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[isv] [float] NOT NULL,
 CONSTRAINT [PK__FacturaC__C4BAA60441121C89] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaVenta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_cliente] [nvarchar](20) NOT NULL,
	[id_empleado] [nvarchar](20) NOT NULL,
	[id_tipo_pago] [int] NOT NULL,
	[descuento] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[isv] [float] NOT NULL,
 CONSTRAINT [PK__FacturaV__459533BF7D9FE543] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 06/03/2021 10:52:23 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK__Roles__6ABCB5E057D528D9] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPago]    Script Date: 06/03/2021 10:52:23 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [nvarchar](20) NOT NULL,
	[contrasenia] [nvarchar](80) NOT NULL,
	[id_rol] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [fk_DetalleCompra_id_compra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[FacturaCompra] ([id_compra])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [fk_DetalleCompra_id_compra]
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
/****** Object:  StoredProcedure [dbo].[buscar_Empleado]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscar_Empleado]
@idempleado nvarchar(20)
as
select dbo.Empleados.id_empleado as 'Identidad', dbo.Empleados.nom_empleado +' '+ dbo.Empleados.apellido_empleado as 'Nombre Empleado', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.telefono_empleado as 'Teléfono', dbo.Empleados.direccion as 'Dirección', dbo.Empleados.ciudad as 'Ciudad', 
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
	  FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
	where dbo.Empleados.id_empleado like '%' +@idempleado+ '%'

GO
/****** Object:  StoredProcedure [dbo].[buscar_Usuario]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscar_Usuario]
@idempleado nvarchar(20)
as
SELECT        dbo.Usuarios.id_usuario AS [Id Usuario], dbo.Usuarios.id_empleado AS [Id Empleado], dbo.Usuarios.contrasenia AS Contrasenia, dbo.Usuarios.id_rol AS [Id Rol]
FROM            dbo.Usuarios INNER JOIN
                         dbo.Roles ON dbo.Usuarios.id_rol = dbo.Roles.id_rol INNER JOIN
                         dbo.Empleados ON dbo.Usuarios.id_empleado = dbo.Empleados.id_empleado AND dbo.Roles.id_rol = dbo.Empleados.id_rol_empleado
	where dbo.Usuarios.id_empleado like '%' +@idempleado+ '%'

GO
/****** Object:  StoredProcedure [dbo].[Despedir_Empleado]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[Despedir_Empleado]
@idEmpleado as nvarchar(13)
as
	   update Empleados set Estado = 'Despedido'
	   where id_empleado = @idEmpleado

GO
/****** Object:  StoredProcedure [dbo].[editar_Empleado]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Editar Empleado
create procedure [dbo].[editar_Empleado]
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
GO
/****** Object:  StoredProcedure [dbo].[insertar_Empleado]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Insertar Empleado
create procedure [dbo].[insertar_Empleado]
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
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Empleados]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Mostrar_Empleados]
as
SELECT        dbo.Empleados.id_empleado 'Identidad', dbo.Empleados.nom_empleado +' '+ dbo.Empleados.apellido_empleado as 'Nombre Empleado', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.telefono_empleado as 'Teléfono', dbo.Empleados.direccion as 'Dirección', dbo.Empleados.ciudad as 'Ciudad', 
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
order by dbo.Empleados.id_empleado ASC
GO
/****** Object:  StoredProcedure [dbo].[ReContratar_Empleado]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[ReContratar_Empleado]
@idEmpleado as nvarchar(13)
as
	   update Empleados set Estado = 'Activo'
	   where id_empleado = @idEmpleado

GO
/****** Object:  StoredProcedure [dbo].[SP_Banco]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[SP_Banco]
As
SELECT        id_banco, descripcion, direccion
FROM            dbo.Bancos
GO
/****** Object:  StoredProcedure [dbo].[SP_Compra]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*/////////////////////////////////////////////-*/
/*compra*/
Create procedure [dbo].[SP_Compra]
As
SELECT        id_compra, fecha, id_producto, id_proveedor, id_empleado, id_tipo_pago, descuento, subtotal
FROM            dbo.FacturaCompra
GO
/****** Object:  StoredProcedure [dbo].[SP_Detalle_Compra]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[SP_Detalle_Compra]
As
SELECT        id_detalle_compra, id_producto, id_compra, id_categoria, precio, cantidad, isv
FROM            dbo.DetalleCompra
GO
/****** Object:  StoredProcedure [dbo].[SP_Detalle_Venta]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[SP_Detalle_Venta]
As
SELECT        id_detalle_venta, id_producto, id_venta, precio, cantidad, isv
FROM            dbo.DetalleVenta
GO
/****** Object:  StoredProcedure [dbo].[SP_Inventario]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_Inventario]
As
SELECT        id_producto, nom_producto, id_marca, Cantidad_por_Unidad, Costo_producto, precio_actual, stock, Estado, id_categoria
FROM            dbo.Inventario
GO
/****** Object:  StoredProcedure [dbo].[SP_Pago_Cheque]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*//////////////////////////////////-*/
/*pago*/
Create procedure [dbo].[SP_Pago_Cheque]
As
SELECT        dbo.TipoPago.id_tipo_pago, dbo.TipoPago.descripcion, dbo.Cheques.numero_cuenta, dbo.Cheques.fecha, dbo.Cheques.id_cliente, dbo.Cheques.ruta_bancaria, dbo.Cheques.numero_cheque, dbo.Cheques.monto, 
                         dbo.Cheques.id_banco
FROM            dbo.TipoPago INNER JOIN
                         dbo.Cheques ON dbo.TipoPago.id_tipo_pago = dbo.Cheques.id_tipo_pago
GO
/****** Object:  StoredProcedure [dbo].[SP_Venta]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_Venta]
As
SELECT        id_venta, fecha, id_producto, id_cliente, id_empleado, id_tipo_pago, descuento, subtotal
FROM            dbo.FacturaVenta
GO
/****** Object:  StoredProcedure [dbo].[VerificarUsuario]    Script Date: 06/03/2021 10:52:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[VerificarUsuario]
@usuario nvarchar(20),
@contrasenia nvarchar(80)
as 
    select * from Empleados inner join
	Usuarios as u on @usuario=u.id_empleado and u.contrasenia=@contrasenia and @usuario=dbo.Empleados.id_empleado

GO
USE [master]
GO
ALTER DATABASE [Ferreteria_Maresa] SET  READ_WRITE 
GO
