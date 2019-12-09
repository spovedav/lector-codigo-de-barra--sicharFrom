create database herramientas
use herramientas

create table usuarios(usuario varchar(20), contra varchar(20))

insert into usuarios values ('admin','admin')
insert into usuarios values ('cliente','123')
select * from usuarios where usuario = 'admin' and contra = 'admin'
select * from usuarios

/*
codigo
marca
categoria
nombre de producto
descripcion
stock
precio
imagen
*/
create table producto(codigo varchar(5),marca varchar(20),categoria varchar(20),nom_producto varchar(20), descripcion varchar(50),stock int,precio float, imagen bit)
insert into producto values ('A001','MARCA_PRODUCTO','CATEGORIA_PRODUCTO','NOMBRE_PRODUCTO','DESCRIPCION_PORDUCTO',12,10.20,NULL)
select * from producto where codigo = 'A001'

delete from producto where codigo = 'A001'

insert into producto values ()

