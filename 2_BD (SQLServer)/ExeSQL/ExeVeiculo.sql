create database ExeVeiculo
go
use ExeVeiculo
go

create table tblCliente (
	clientepk int not null primary key,
	nome varchar(30))
go

create table tblVeiculo (
	veiculopk int not null primary key,
	clientepk int foreign key
	references tblCliente(clientepk))
go

create table tblPedido(
	pedidopk int not null primary key,
	data2 date,
	clientepk int foreign key
	references tblCliente(clientepk))
go

create table tblProduto(
	produtopk int not null primary key,
	descricao varchar(50),
	quantidade int)
go
create index XtblProduto on tblProduto (descricao, produtopk)
go

create table tblPedido_Produto(
	clientepk int foreign key
	references tblCliente(clientepk),
	pedidopk int foreign key
	references tblPedido (pedidopk),
	produtopk int foreign key
	references tblProduto(produtopk),
	quantidade int)
go
create index XtblPedido_Produto on tblPedido_Produto (clientepk, pedidopk, produtopk, quantidade)
go