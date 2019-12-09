create database herramientas

create table usuarios(usuario varchar(20), contra varchar(20))

insert into usuarios values ('admin','admin')
insert into usuarios values ('cliente','123')
select * from usuarios where usuario = 'admin' and contra = 'admin'
select * from usuarios