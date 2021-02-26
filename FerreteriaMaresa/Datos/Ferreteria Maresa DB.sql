create database Ferreteria_Maresa
go

use Ferreteria_Maresa
go


create table Roles
(
id_rol int primary key identity(1,1),
descripcion nvarchar(40),
)
go

insert into Roles
values('Empleado'),
	('Gerente');
	go

	create table direcciones(
	cod_direccion int primary key identity(1,1),
nombre_depto varchar(25),
	nombre_municipios varchar(25),
	);
go

insert into direcciones values('Atlántida', 'Tela'),
('Colon', 'Tocoa'),
('Comayagua', 'Siguatepeque'),
('Copán', 'Santa Rosa de Copán'),
('Cortés','Choloma'),
('Choluteca', 'Choluteca'),
('El Paraiso', 'Danlí'),
('Francisco Morazan','La Libertad'),
('Gracias a Dios', 'Puerto Lempira'),
('Intibuca', 'La Esperanza'),
('Islas de la Bahía', 'Roatán'),
('La Paz', 'La Paz'),
('Lempira', 'Gracias'),
('Ocotepeque', 'Mercedes'),
('Olancho', 'Juticalpa'),
('Santa Barbara', 'Santa Bárbara'),
('Valle', 'Nacaome'),
('Yoro', 'El Progreso');
go

select * from direcciones

create table Empleados
(
id_empleado Nvarchar(20) primary key,
nom_empleado nvarchar(80) not null,
apellido_empleado nvarchar(80) not null, 
correo_empleado nvarchar(80) not null,
telefono_empleado nvarchar(30) not null,
cod_direccion int not null,
id_rol_empleado int not null,
fnacimiento_empleado date not null,
Estado varchar(20) not null,
contrasenia nvarchar(80) not null

CONSTRAINT fk_Empleados_id_rol FOREIGN KEY (id_rol_empleado) REFERENCES Roles (id_rol),
CONSTRAINT fk_Empleados_cod_direccion FOREIGN KEY (cod_direccion) REFERENCES direcciones (cod_direccion),
)
go

insert into Empleados values('0318199877441', 'Noe Ignacio', 'Manueles Guerrero', 'nachoman@hotmail.com', '44551122', '1', '2', '1998-05-25', 'Activo', '12345'),
('0318199802010', 'Danny Fernando', 'Martinez Romero', 'danny12345@hotmail.com', '99554477', '1', '1', '1998-02-02', 'Activo', '12345');

select * from Empleados

/*create table Usuarios
(
id_usuario int primary key identity(1,1),
id_empleado nvarchar(20) not null,
contrasenia nvarchar(80) not null

CONSTRAINT fk_Roles_id_usuario FOREIGN KEY (id_empleado) REFERENCES Empleados (id_empleado),
)
go*/


create table Clientes
(
id_cliente Nvarchar(20) primary key,
nom_cliente nvarchar(80) not null,
apellido_cliente nvarchar(80) not null,
RTN nvarchar(80) not null,
direccion nvarchar(80) not null,
tel_cliente nvarchar(30) not null
)
go

create table Proveedores
(
id_proveedor int primary key identity(1,1),
nom_proveedor nvarchar(80)not null,
apellido_proveedor nvarchar(80)not null,
telefono nvarchar(30)not null,
correo nvarchar(80)not null,
cod_direccion int not null,
Estado varchar(20) not null

CONSTRAINT fk_Empleados_cod_direccion_proveedor FOREIGN KEY (cod_direccion) REFERENCES direcciones (cod_direccion)
)
go

Insert into Proveedores values('Sergio', 'Espinoza', '94152236', 'Espinoza41@gamil.com', '2', 'Activo');
go

create table TipoPago
(
id_tipo_pago int primary key identity(1,1),
descripcion nvarchar(80) not null
)
go

create table Categorias
(
id_categoria int primary key identity(1,1),
descripcion nvarchar(50) not null
)
go

create table Marcas(
id_marca int primary key identity(1,1),
descripcion nvarchar(50) not null
)
go

create table Inventario
(
id_producto int primary key identity(1,1),
nom_producto nvarchar(80) not null,
id_marca int,
Cantidad_por_Unidad int not null,
Costo_producto money not null,
precio_actual money not null,
stock int not null,
Estado varchar(20) not null,
id_categoria int,
CONSTRAINT fk_Inventario_id_categoria FOREIGN KEY (id_categoria) REFERENCES Categorias (id_categoria),
CONSTRAINT fk_Inventario_id_marca FOREIGN KEY (id_marca) REFERENCES Marcas (id_marca)
)
go


create table FacturaCompra
(
id_compra int primary key not null identity(1,1),
fecha date not null,
id_proveedor int,
id_empleado nvarchar(20),
id_tipo_pago int,
descuento float,
subtotal float,
CONSTRAINT fk_FacturaCompra_id_proveedor FOREIGN KEY (id_proveedor) REFERENCES Proveedores (id_proveedor),
CONSTRAINT fk_FacturaCompra_empleado FOREIGN KEY (id_empleado) REFERENCES Empleados (id_empleado),
CONSTRAINT fk_FacturaCompra_tipo_pago FOREIGN KEY (id_tipo_pago) REFERENCES TipoPago (id_tipo_pago)
)
go

create table DetalleCompra
(
id_detalle_compra int not null identity(1,1),
id_producto int,
precio money not null,
cantidad int not null,
isv float,
id_categoria int,
CONSTRAINT fk_DetalleCompra_id_categoria FOREIGN KEY (id_categoria) REFERENCES Categorias (id_categoria),
CONSTRAINT fk_DetalleCompra_id_producto FOREIGN KEY (id_producto) REFERENCES Inventario (id_producto),
CONSTRAINT pk_DetalleCompra PRIMARY KEY (id_detalle_compra,id_producto)
)
go

create table FacturaVenta
(
id_venta int primary key not null identity(1,1),
fecha date,
id_cliente nvarchar(20),
id_empleado nvarchar(20),
id_tipo_pago int,
descuento float,
subtotal float,
CONSTRAINT fk_FacturaVenta_cliente FOREIGN KEY (id_cliente) REFERENCES Clientes (id_cliente),
CONSTRAINT fk_FacturaVenta_empleado FOREIGN KEY (id_empleado) REFERENCES Empleados (id_empleado),
CONSTRAINT fk_FacturaVenta_tipo_pago FOREIGN KEY (id_tipo_pago) REFERENCES TipoPago (id_tipo_pago)
)
go

create table DetalleVenta
(
id_detalle_venta int not null identity(1,1),
id_producto int,
id_venta int,
precio money not null,
cantidad int not null,
isv float,
CONSTRAINT fk_DetalleVenta_id_compra FOREIGN KEY (id_venta) REFERENCES FacturaVenta (id_venta),
CONSTRAINT fk_DetalleVenta_id_producto FOREIGN KEY (id_producto) REFERENCES Inventario (id_producto),
CONSTRAINT pk_DetalleVenta PRIMARY KEY (id_detalle_venta,id_producto)
)
go

create table Bancos
(
id_banco int primary key identity(1,1),
descripcion nvarchar(50) not null,
direccion nvarchar(80) not null
)
go

create table Cheques(
numero_cuenta varchar(40) not null primary key,
fecha date,
id_cliente nvarchar(20),
ruta_bancaria nvarchar(40) not null,
numero_cheque nvarchar(40) not null,
monto money not null,
id_banco int,
id_tipo_pago int,
CONSTRAINT fk_Cheques_id_cliente FOREIGN KEY (id_cliente) REFERENCES Clientes (id_cliente),
CONSTRAINT fk_Cheques_id_banco FOREIGN KEY (id_banco) REFERENCES Bancos (id_banco),
CONSTRAINT fk_Cheques_id_tipo_pago FOREIGN KEY (id_tipo_pago) REFERENCES TipoPago (id_tipo_pago)
)
go 

	
































