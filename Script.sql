use master
go
	create database Tienda
go
	use tienda
go
	create table Producto(
		CodigoProducto varchar(50),
		Existencias int,
		Precio money,
		PrecioKilometro money
		)
go
	--drop database Tienda
	insert into Producto
	select '1WPE14302'	,'175',	'117.5500571', 2.5
	union
	select '1WPY14303'	,'822',	'129.6100000', 2.7
	union
	select '1WPY14304'	,'225',	'129.6100000', 2.8
	union
	select '20121445'	,'420',	'89.6600000', 2.9
	union
	select '20121446'	,'110',	'603.4500000', 3.1
	union
	select '20121447'   ,'27',	'465.5100000', 3.6
	union
	select '20121448'  ,'1330',	'50.0000000', 3.8
go

	select *from producto