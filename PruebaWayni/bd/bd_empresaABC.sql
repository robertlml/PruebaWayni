
create database EmpresaABC
use EmpresaABC
go

create table TB_trabajador(
codigo int identity(1,1) primary key,
nombre varchar(20) not null,
cargo varchar(20) not null
)