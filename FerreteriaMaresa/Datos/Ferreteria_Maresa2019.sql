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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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

CREATE TABLE [dbo].[Proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nom_proveedor] [nvarchar](80) NOT NULL,
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

CREATE TABLE [dbo].[Roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK__Roles__6ABCB5E057D528D9] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
insert into Empleados values('Admin', 'Admin', 'Admin', 'admin@gmail.com', '00000000', 'Null', 'Null', 'Null', '11101', 'Null','2', '2021-01-01', 'Activo'),
('0819200100077', 'Alex David', 'Sandoval', 'alex@gmail.com', '99445566', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras','1', '2001-05-25', 'Activo'),
('0318200200462', 'Amilcar Jafet', 'Reyes', 'amilcar@gmail.com', '33219596', 'Barrio las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras','1', '2002-01-01', 'Activo'),
('1804200703610', 'Andrés Alejandro', 'Martínez', 'andres@gmail.com', '98412566', 'Barrio San Juan', 'El Progreso', 'Yoro', '23201', 'Honduras','1', '2000-06-13', 'Activo'),
('1401200000574', 'Ángel Fernando', 'Hernández', 'angel@gmail.com', '33349521', 'Barrio San José', 'Nueva Ocotepeque', 'Ocotepeque', '43101', 'Honduras','1', '2000-02-01', 'Activo'),
('0318199802010', 'Danny Fernando', 'Martinez Romero', 'danny@gmail.com', '99554477', 'Barrio buena Esperanza', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '1', '1998-02-02', 'Activo'),
('0801200103369', 'David Fernando', 'Chávez', 'david@gmail.com', '36214755', 'Barrio el centro', 'Tegucigalpa', 'Tegucigalpa', '12101', 'Honduras','1', '2001-11-06', 'Activo'),
('1325199800036', 'Jeyson David', 'Mejía', 'jeyson@gmail.com', '94552211', 'Barrio el centro', 'Tomalá', 'Lempira', '42000', 'Honduras','1', '1998-05-01', 'Activo'),
('1523199500601', 'José Carlos', 'Zavala', 'jose@gmail.com', '95221144', 'Barrio buena esperanza', 'Patuca', 'Olancho', '16101', 'Honduras','1', '1995-04-13', 'Activo'),
('1414199900126', 'Lesvin Josué', 'Ardón', 'lesvin@gmail.com', '33349899', 'Barrio San José', 'Santa Fe', 'Ocotepeque', '141401', 'Honduras','1', '1999-10-15', 'Activo'),
('1401200200144', 'María José', 'Ramos', 'maria@gmail.com', '96621458', 'Barrio San José', 'Nueva Ocotepeque', 'Ocotepeque', '43101', 'Honduras', '1', '2002-07-15', 'Activo'),
('1201199900111', 'Noe Ignacio', 'Manueles', 'noe@gmail.com', '33658521', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras','1', '1999-05-25', 'Activo');
go
update Empleados set Estado='ACTIVO'
where Estado = 'Activo'
go
insert into Usuarios values('Admin', '12345', '2'),
('0819200100077', '12345', '1'),
('0318200200462', '12345', '1'),
('1804200703610', '12345', '1'),
('1401200000574', '12345', '1'),
('0318199802010', '12345', '1'),
('0801200103369', '12345', '1'),
('1325199800036', '12345', '1'),
('1523199500601', '12345', '1'),
('1414199900126', '12345', '1'),
('1401200200144', '12345', '1'),
('1201199900111', '12345', '1');
go

insert into Clientes values ('0318199111442','Maria Adaluz', 'Martínez Contreras', '14253211253695', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '95663255'),
('0318198702145','Mate José', 'Medrano Sabillón', '45121236985214', 'Barrio el Centro', 'Comayagua', 'Comayagua', '12101', 'Honduras', '98221433'),
('0315199648552','Mario Daniel', 'Martínez Figueroa', '45210236982255', 'Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '33349588'),
('0312197866522','Toni Rafael', 'Hernandez Caceres', '16520124992214', 'Barrio el Centro', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '94556235'),
('0318198845121','Sandra Maria', 'Caceres Sanchez', '18523644882426', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '97321455'),
('0318198422114','Karla Beatriz', 'Molina Flores', '11442581253695', 'Colonia Mata', 'Siguatepeque', 'Comyagua', '12111', 'Honduras', '30722155'),
('0819198311447','Marlon Jose', 'Medina Sanchez', '14551236985214', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '94512236'),
('1414199015242','Gustavo Rafael', 'Martínez Contreras', '88521433212145', 'Barrio San José', 'Santa Fe', 'Ocotepeque', '141401', 'Honduras', '98445236'),
('0801197866522','Julia Andrea', 'Hernandez Sabillon', '22654134992214', 'Barrio el centro', 'Tegucigalpa', 'Tegucigalpa', '12101', 'Honduras', '93215489'),
('0819200145121','Jorge Alberto', 'Gutierrez Rosa', '98523655210021', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '95412547'),
('0318198233665','Francisco Rafael', 'Alarcon Rosa', '63221452220122', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '33213255'),
('0101198422233','Sara Valeria', 'Caceres Caceres', '01256326985214', 'Barrio el Centro', 'Comayagua', 'Comayagua', '12101', 'Honduras', '33521455'),
('0315199522113','Daniel Alejandro', 'Rosa Martinez', '22551144982255', 'Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '99229588'),
('0312197800021','Isabella Giselle', 'Hernandez Villanueva', '00112255992214', 'Barrio el Centro', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '33665522'),
('0318198802021','Sandra Daniela', 'Medina Cruz', '66332255996235', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '95556233'),
('0318198211245','Jairo Andrea', 'Medina Cruz', '23568941253695', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '95556233'),
('0819198347856','Vivian Melissa', 'Fonseca Turcios', '15223366985214', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '92114236'),
('1414199025142','Carlos Joel', 'Carranza Arauz', '94511223212145', 'Barrio San José', 'Santa Fe', 'Ocotepeque', '141401', 'Honduras', '33335541'),
('0801199506326','Margie Julissa', 'Carcamo Meza', '95135745685232', 'Barrio el centro', 'Tegucigalpa', 'Tegucigalpa', '12101', 'Honduras', '33145236'),
('0819200199552','Alma Francelia', 'Murillo Paredes', '85235745685212', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '99658521'),
('0318199191521','Allan Joel', 'Martínez Suarez', '92114455253695', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '34521422'),
('0318198700002','Critiano Antonio', 'Ronaldo Aveiro', '11224156985214', 'Barrio el Centro', 'Comayagua', 'Comayagua', '12101', 'Honduras', '96665214'),
('0315199600214','Juan Josue', 'Castañeda Mendoza', '32145236982255', 'Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '95214122'),
('0312197802063','Daniela Beatriz', 'Paredes Hernandez', '23565841002123', 'Barrio el Centro', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '96854121'),
('0318198800950','Eduardo Andres', 'Mejia Sanchez', '93251345882426', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '32301422'),
('0318198411122','Abigail Beatriz', 'Flores Franco', '66332255253695', 'Colonia Mata', 'Siguatepeque', 'Comyagua', '12111', 'Honduras', '95952511'),
('0819198388852','Frank Denilson', 'Lampard Martinez', '92221144985214', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '96962142'),
('1414199066321','Xavi Andres', 'Hernandez Iniesta', '33221144212145', 'Barrio San José', 'Santa Fe', 'Ocotepeque', '141401', 'Honduras', '33335236'),
('0801197806062','Carmen Alejandra', 'Hernandez Valladares', '99995522992214', 'Barrio el centro', 'Tegucigalpa', 'Tegucigalpa', '12101', 'Honduras', '95991121'),
('0819200112221','Jorge Alberto', 'Gutierrez Rosa', '98523655210021', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '95412547'),
('0318198221210','Grecia Mariel', 'Alarcon Rosa', '88221155220122', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '98985214'),
('0101198415152','Nelson Naveli', 'Caceres Caceres', '00021189632145', 'Barrio el Centro', 'Comayagua', 'Comayagua', '12101', 'Honduras', '33521455'),
('0315199599552','Miriam Denissa', 'Tinoco Zuniga', '14142123669841', 'Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '96521422'),
('0312197800121','Isabella Giselle', 'Hernandez Villanueva', '00112255992214', 'Barrio el Centro', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', '99521422'),
('0318198811124','Diego Mauricio', 'Hernandez Cruz', '66332921423569', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '34569852'),
('0318198221145','Saul Josue', 'Calix Acosta', '75315985265464', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', '36951214'),
('0819198355215','Oscar Adalid', 'Tulio Martinez', '00021165236589', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '94852211'),
('1414199012221','Jenny Gissele', 'Argueta Oviedo', '22553312102111', 'Barrio San José', 'Santa Fe', 'Ocotepeque', '141401', 'Honduras', '94112258'),
('0801199532145','Juan Ramon', 'Canales Zuniga', '95135792631452', 'Barrio el centro', 'Tegucigalpa', 'Tegucigalpa', '12101', 'Honduras', '99525236'),
('0819200100214','Hector Mauricio', 'Murillo Ayala', '52142125685212', 'Barrio el centro', 'San Ignacio', 'Francisco Morazán', '11101', 'Honduras', '33148521');;
go

Insert into Proveedores values('TRUPER', '94152236', 'Truper41@gmail.com', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras','Activo'),
('DEWALT', '98556621', 'DeWalt7854@gmail.com', 'Barrio Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('URREA', '33215896', 'Urrea_21@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras','Activo'),
('BOSCH', '88552436', 'BOSCH_2@gamil.com', 'Barrio el Parnazo', 'San Salvador', 'San Salvador', '30811', 'Salvador', 'Activo'),
('IUSA', '001256987452', 'IUSA002@gmail.com', 'Tacoma Lake', 'Miami', 'Florida', '32101', 'USA', 'Activo'),
('MAXUPER', '98556621', 'MAXUPER54@gmail.com', 'Barrio Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
( 'ROTOPLAS', '33215896', 'ROTOPLAS_21@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras','Activo'),
('AUSTROMEX', '96552436', 'AUSTROMEX_R@gamil.com', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('STEREN', '10236587455', 'STEREN12@gmail.com', 'Barrio Limonal', 'Mexico', 'Mexico D.F', '32101', 'Mexico', 'Activo'),
( 'DeWalt', '98556621', 'DeWalt7854@gmail.com', 'Barrio Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
( 'LENOX', '33215896', 'LENOX_21@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras','Activo'),
('COFLEX', '96552436', 'COFLEX_R@gamil.com', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('EVANS', '33521699', 'EVANS_78@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', 'Activo'),
( 'DeWalt', '98556621', 'DeWalt7854@gmail.com', 'Barrio Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
( 'JYRSA', '33215896', 'JYRSA_21@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras','Activo'),
('MADEX', '96552436', 'MADEX_R@gamil.com', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('Mejia Hernandez', '33521699', 'abi_hernz@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', 'Activo'),
( 'WALTEX', '98556621', 'WALTEX54@gmail.com', 'Barrio Las Americas', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('DTC', '33215896', 'DTC_21@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras','Activo'),
('FEMEH', '96552436', 'FEMEH_R@gamil.com', 'Barrio el Parnazo', 'Siguatepeque', 'Comayagua', '12111', 'Honduras', 'Activo'),
('PANELREY', '33521699', 'PANELREY@gmail.com', 'Barrio Limonal', 'Trujillo', 'Colón', '32101', 'Honduras', 'Activo');
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
('Banco FICOHSA', 'Barrio el Zarzal', 'Siguatepeque', 'Comayagua', '12111'),
('Banco DAVIVIENDA', 'Barrio la Reforma', 'Siguatepeque', 'Comayagua', '12111'),
('BANPAIS', 'Barrio el centro', 'Siguatepeque', 'Comayagua', '12111');
go

insert into Marcas (descripcion)
values ('SANTUL'),
('TRUPER'),
('CHEVRON'),
('AKSI'),
('ELECLITE'),
('FLYING EAGLE'),
('TESA'),
('STANLEY'),
('RAWPLUG'),
('AMIG'),
('PEGAMIX'),
('ADMIX'),
('ICO'),
('LANCO'),
('KORAZA'),
('FERRETERIA MARESA'),
('BIJAO'),
('NORTE'),
('RHINOCERONTE'),
('ALUM'),
('ASTRA'),
('DREAMLINE'),
('GENEBRE'),
('OPUS');

go

insert into Categorias (descripcion)
values('ABRAZADERA'),
('ACEITES Y LUBRICANTES'),
('HIDRO LAVADORAS'),
('TOLDOS'),
('BICICLETAS'),
('ACCESORIOS DE AUTOMOTRIZ'),
('ACCESORIOS PARA PUERTA'),
('ADHESIVOS Y PEGAMENTOS'),
('TENSORES'),
('PINTURAS, ANTICORROSIVOS'),
('LAMINA DESPLEGADA'),
('CEMENTO'),
('CANALETA'),
('BAÑERAS'),
('SECADOR DE MANO'),
('EQUIPO DE FONTANERÍA');
go

insert into Inventario (nom_producto, id_marca, Cantidad_por_Unidad, Costo_producto, precio_actual, stock, Estado, id_categoria)
values ('Abrazadera aceero inoxidable','1','Caja de 6 abrazaderas','52.00','56.00','500','ACTIVO','1'),

('Aceite Aflojatodo','2','1 dote','50.54','55.54','48','ACTIVO','2'),

('Aceite bote','3','1 dote','100.50','107.50','50','ACTIVO','2'),

('Aceite cubeta','3','1cubeta','3,000.00','3,136.59','50','ACTIVO','2'),

('Limpiador para carburador bote','4','1 dote','48.00','55.00','30','ACTIVO','2'),

('Lavadora a precion de agua','5','1 Maquina','9,002.10','10,002.10','0','INACTIVO','3'),

('Lona-Toldo','4','1 Unidad','100.00','124.00','20','ACTIVO','4'),

('PL-BICI MTB 26 27SP','5','1 Unidad','9,000.00','9,517.20','20','ACTIVO','5'),

('PL-BICI 700C 27SP SST-PLUS','5','1 Unidad','12,00.00','12,557.41','10','ACTIVO','5'),

('Acoplador de arrastre','2','1 Unidad','200.00','251.44','40','ACTIVO','6'),

('Bola de arrastre','2','1 Unidad','130.00','137.68','0','INACTIVO','6'),

('CABLE P/BAT/CARRO #MSB-100A','5','1 Unidad','42.92','52.92','0','INACTIVO','6'),

('CABLE P/BAT/CARRO #MSB-150A','5','1 Unidad','42.92','52.92','20','ACTIVO','6'),

('Cable pasa corriente ','1','1 Unidad','130.00','145.00','15','ACTIVO','6'),

('Cargador de bateria','2','1 Unidad','4,100.00','4,243.38','0','INACTIVO','6'),

('Cinta Automotriz','7','1 Unidad','52.23','62.23','0','INACTIVO','6'),

('EXT. STANLEY 3 PULG.','8','1 Unidad','43.42','53.42','0','INACTIVO','6'),

('Inversor de corriente','2','1 Unidad','767.21','867.21','10','ACTIVO','6'),

('JACK HIDRAULICO','2','1 Unidad','823.85','923.85','15','ACTIVO','6'),

('Burlete para puerta','1','1 Unidad','78.87','88.87','30','ACTIVO','7'),

('Fija puerta','2','1 Unidad','60.42','80.42','20','ACTIVO','7'),

('Gancho','2','1 Unidad','88.59','98.59','35','ACTIVO','7'),

('Mirilla de seguridad','1','1 Unidad','375.00','400.00','40','ACTIVO','7'),

('Braso Cierrapuesta','2','1 Unidad','600.68','684.68','20','ACTIVO','7'),

('Cerradura','9','1 Unidad','100.88','126.88','10','ACTIVO','7'),

('Corredera','9','1 Unidad','30.66','35.66','30','ACTIVO','7'),

('Corredera galvanizada','10','1 Unidad','80.42','84.42','0','INACTIVO','7'),

('Adecivo para pegar ceramica','11','1 Unidad','175.25','185.25','0','INACTIVO','8'),

('Adecivo para pegar porcelanato','11','1 Unidad','380.47','400.47','20','ACTIVO','8'),

('EPOXY BOND','12','1 Unidad','500.59','521.59','10','ACTIVO','8'),

('F-5 GALON','12','1 Unidad','300.59','306.59','20','ACTIVO','8'),

('PAINTER CARTUCHO','12','1 Unidad','40.53','48.53','40','ACTIVO','8'),

('POLY CLEANER BOTE','12','1 Unidad','340.99','350.99','20','ACTIVO','8'),

('POLY FLEX NS BLANCO','12','1 Unidad','108.88','118.88','40','ACTIVO','8'),

('Tensor ajustable','1','1 Unidad','42.07','52.07','50','ACTIVO','9'),

('Anticorrosivo Blaco','13','1 Unidad','252.68','262.68','40','ACTIVO','10'),

('Anticorrosivo negro','14','1 Unidad','83.71','93.71','40','ACTIVO','10'),

('BASE PROTECTO','15','1 Unidad','604.73','664.73','0','INACTIVO','10'),

('LAMINA DESPLEGADA PERFORADA WEAVE PIEZA 4X8','16','1 Unidad','1,951.45','1,971.45','200','ACTIVO','11'),

('LAMINA DESPLEGADA','16','1 Unidad','241.60','261.60','100','ACTIVO','11'),

('Cemento gris','17','1 Unidad','159.49','169.49','2000','ACTIVO','12'),

('CANALETA GALVANIZADA','18','1 Unidad','306.00','346.00','5000','ACTIVO','13'),

('CANALETA HIERRO','18','1 Unidad','310.00','310.00','5000','ACTIVO','13'),

('Aislante termico','19','1 Unidad','1,100.20','1,142.20','100','ACTIVO','14'),

('Bañera','20','1 Unidad','18,606.14','18,646.14','20','ACTIVO','15'),

('Tina','21','1 Unidad','35,000.00','35,523.98','5','ACTIVO','15'),

('Secador de mano','5','1 Unidad','2,622.33','2,822.33','10','ACTIVO','16'),

('Bajante','22','1 Unidad','153.66','173.66','70','ACTIVO','16'),

('Bomba','23','1 Unidad','10,000.00','10,257.38','10','ACTIVO','16'),

('BOCA DE SUCCION','23','1 Unidad','605.56','705.56','10','ACTIVO','16');
go

insert into FacturaVenta values('2021-05-25', '0318199111442', '0819200100077', '1', '0', '0'),
('2021-01-02', '0318198702145', '0318200200462', '2', '0', '0'),
('2021-01-06', '0315199648552', '1804200703610', '2', '0', '0'),
('2021-01-09', '0312197866522', '1401200000574', '2', '0', '0'),
('2021-01-15', '0318198845121', '0318199802010', '2', '0', '0'),
('2021-01-19', '0318198422114', '0801200103369', '2', '0', '0'),
('2021-01-19', '0819198311447', '1325199800036', '2', '0', '0'),
('2021-01-25', '1414199015242', '1523199500601', '2', '0', '0'),
('2021-02-01', '0801197866522', '1414199900126', '2', '0', '0'),
('2021-02-06', '0819200145121', '1401200200144', '2', '0', '0'),
('2021-02-08', '0318198233665', '1201199900111', '2', '0', '0'),
('2021-02-08', '0101198422233', '0819200100077', '2', '0', '0'),
('2021-02-09', '0315199522113', '0318200200462', '2', '0', '0'),
('2021-02-16', '0312197800021', '1804200703610', '2', '0', '0'),
('2021-02-19', '0318198802021', '1401200000574', '2', '0', '0'),
('2021-02-25', '0318198211245', '0318199802010', '2', '0', '0'),
('2021-02-26', '0819198347856', '0801200103369', '2', '0', '0'),
('2021-03-03', '1414199025142', '1325199800036', '2', '0', '0'),
('2021-03-17', '0801199506326', '1523199500601', '2', '0', '0'),
('2021-03-17', '0819200199552', '1414199900126', '2', '0', '0'),
('2021-03-20', '0318199191521', '1401200200144', '2', '0', '0'),
('2021-04-01', '0318198700002', '1201199900111', '2', '0', '0'),
('2021-04-05', '0318199111442', '0819200100077', '1', '0', '0'),
('2021-04-10', '0318198702145', '0318200200462', '1', '0', '0'),
('2021-04-15', '0315199648552', '1804200703610', '1', '0', '0'),
('2021-05-03', '0312197866522', '1401200000574', '1', '0', '0'),
('2021-05-15', '0318198845121', '0318199802010', '1', '0', '0'),
('2021-05-19', '0318198422114', '0801200103369', '1', '0', '0'),
('2021-05-19', '0819198311447', '1325199800036', '1', '0', '0'),
('2021-06-01', '1414199015242', '1523199500601', '1', '0', '0'),
('2021-06-01', '0801197866522', '1414199900126', '1', '0', '0'),
('2021-06-02', '0819200145121', '1401200200144', '1', '0', '0'),
('2021-06-29', '0318198233665', '1201199900111', '1', '0', '0'),
('2021-07-05', '0101198422233', '0819200100077', '1', '0', '0'),
('2021-07-06', '0315199522113', '0318200200462', '1', '0', '0'),
('2021-07-07', '0312197800021', '1804200703610', '1', '0', '0'),
('2021-07-15', '0318198802021', '1401200000574', '1', '0', '0'),
('2021-08-15', '0318198211245', '0318199802010', '1', '0', '0'),
('2021-08-19', '0819198347856', '0801200103369', '1', '0', '0'),
('2021-08-20', '1414199025142', '1325199800036', '1', '0', '0'),
('2021-08-25', '0801199506326', '1523199500601', '1', '0', '0'),
('2021-08-30', '0819200199552', '1414199900126', '1', '0', '0'),
('2021-09-01', '0318199191521', '1401200200144', '1', '0', '0'),
('2021-09-01', '0318198700002', '1201199900111', '1', '0', '0');

insert into Cheques values ('1593284675', '2021-04-05', '0318199111442', '263253659', '0215', '0', '1', '1'),
('1524759885', '2021-04-10', '0318198702145', '953155646', '0326', '0', '2', '1'),
('9536621547', '2021-04-15', '0315199648552', '951324568', '9456', '0', '2', '1'),
('9632156874', '2021-05-03', '0312197866522', '953324566', '0231', '0', '2', '1'),
('8215647982', '2021-05-15', '0318198845121', '332515489', '0002', '0', '2', '1'),
('1475314985', '2021-05-19', '0318198422114', '251469856', '0622', '0', '3', '1'),
('1693287146', '2021-05-19', '0819198311447', '336164658', '0005', '0', '5', '1'),
('0315369563', '2021-06-01', '1414199015242', '123548632', '0006', '0', '8', '1'),
('1115223658', '2021-06-01', '0801197866522', '995621462', '0025', '0', '8', '1'),
('8521456985', '2021-06-02', '0819200145121', '874541565', '0195', '0', '5', '1'),
('2356985474', '2021-06-29', '0318198233665', '551214523', '0157', '0', '4', '1'),
('2363202152', '2021-07-05', '0101198422233', '441517951', '0359', '0', '4', '1'),
('0002325694', '2021-07-06', '0315199522113', '741245698', '0021', '0', '4', '1'),
('1231000021', '2021-07-07', '0312197800021', '662145236', '0001', '0', '3', '1'),
('0003124564', '2021-07-15', '0318198802021', '220212545', '0062', '0', '3', '1'),
('5642316485', '2021-08-15', '0318198211245', '365115478', '0045', '0', '6', '1'),
('2312346545', '2021-08-19', '0819198347856', '321512021', '0025', '0', '6', '1'),
('2456784232', '2021-08-20', '1414199025142', '010121564', '0215', '0', '7', '1'),
('7845612354', '2021-08-25', '0801199506326', '362514326', '0201', '0', '4', '1'),
('1234548912', '2021-08-30', '0819200199552', '514213654', '0081', '0', '1', '1'),
('9123546545', '2021-09-01', '0318199191521', '301021265', '0021', '0', '5', '1'),
('9412645789', '2021-09-01', '0318198700002', '031526598', '0261', '0', '7', '1');
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
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.id_rol as 'Id Rol', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
order by dbo.Empleados.id_empleado ASC
GO

--Buscar Empleado
create procedure buscar_Empleado
@idempleado nvarchar(20)
as
SELECT        dbo.Empleados.id_empleado 'Identidad', dbo.Empleados.nom_empleado as 'Nombres', dbo.Empleados.apellido_empleado as 'Apellidos', dbo.Empleados.correo_empleado as 'Correo', dbo.Empleados.telefono_empleado as 'Teléfono', dbo.Empleados.direccion as 'Dirección', dbo.Empleados.ciudad as 'Ciudad', 
                         dbo.Empleados.region as 'Región', dbo.Empleados.codigo_postal as 'Codigo Postal', dbo.Empleados.pais as 'País', dbo.Roles.id_rol as 'Id Rol', dbo.Roles.descripcion as 'Rol', dbo.Empleados.fnacimiento_empleado 'Fecha de Nacimiento', dbo.Empleados.Estado
FROM            dbo.Empleados INNER JOIN
                         dbo.Roles ON dbo.Empleados.id_rol_empleado = dbo.Roles.id_rol
order by dbo.Empleados.id_empleado ASC
GO

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
 (@nom_proveedor, @telefono, @correo, @direccion, @ciudad,@region,@codigo_postal, @pais,@Estado)
 end
 go

--Editar Proveedor
create proc modificar_Proveedrores
 @id_proveedor int,
 @nom_proveedor nvarchar(80),
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
update Proveedores set nom_proveedor=@nom_proveedor,telefono=@telefono,correo=@correo,direccion=@direccion,ciudad=@ciudad,region=@region,codigo_postal=@codigo_postal,pais=@pais,Estado=@Estado
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
SELECT        id_proveedor as 'Id Proveedor',nom_proveedor as 'Nombre', telefono as Teléfono, correo as Correo, direccion as Dirección, ciudad as Ciudad, region as Región, codigo_postal as 'Codigo Postal' , pais as País, Estado
FROM            dbo.Proveedores
go

--Buscar Proveedor
create procedure buscar_Proveedores
@id_proveedor int
as
SELECT        id_proveedor as 'Id Proveedor', nom_proveedor as 'Nombre', telefono as Teléfono, correo as Correo, direccion as Dirección, ciudad as Ciudad, region as Región, codigo_postal as 'Codigo Postal' , pais as País, Estado
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
SELECT        id_venta, fecha, id_cliente, id_empleado, id_tipo_pago, descuento, subtotal
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
                         dbo.DetalleCompra.cantidad AS Cantidad, dbo.Marcas.descripcion AS Marca, dbo.Categorias.descripcion AS Categoria, dbo.Empleados.nom_empleado as 'Nombre Proveedor', dbo.TipoPago.descripcion AS [Tipo Pago], dbo.FacturaCompra.fecha AS Fecha
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
