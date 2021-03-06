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
('Credito'),
('Contado');

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
values ('Clavos','1','Libras','25','26','20','Activo','1'),
('Sierras','2','Unidad','3000','3500','10','Activo','3'),
('Laminas para techos','3','unidad','150','200','500','Activo','2'),
('Desarmadores','4','unidad','50','70','300','Activo','1');