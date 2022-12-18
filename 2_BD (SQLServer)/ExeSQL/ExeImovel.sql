create database ExeImovel
go
use ExeImovel
go

create table tblFaixaImovel(
	faixaImovel int not null primary key,
	descricao varchar(30))
go
create index XtblFaixaImovel on tblFaixaImovel (faixaImovel)
go

create table tblVendedor(
	vendedor int not null primary key)
go

create table tblComprador(
	comprador int not null primary key)
go

create table tblEstado(
	estado int not null primary key,
	descricao varchar(50))
go

create table tblCidade(
	cidade int not null primary key,
	descricao varchar(50),
	estado int foreign key
	references tblEstado (estado))
go
create index XtblCidade on tblCidade (cidade, estado)
go

create table tblBairro(
	bairro int not null primary key,
	descricao varchar(50),
	estado int foreign key
	references tblEstado(estado),
	cidade int foreign key 
	references tblCidade(cidade))
go
create index XtblBairro on tblBairro (bairro, estado, cidade)
go

create table tblImovel(
	imovel int not null primary key,
	nome varchar(50) not null,
	endereco varchar(50),
	estado int foreign key
	references tblEstado(estado),
	cidade int foreign key 
	references tblCidade(cidade),
	bairro int foreign key
	references tblBairro (bairro),
	vendedor int foreign key
	references tblVendedor(vendedor))
go

create table tblOferta(
	estado int foreign key
	references tblEstado(estado),
	cidade int foreign key 
	references tblCidade(cidade),
	bairro int foreign key
	references tblBairro (bairro),
	vendedor int foreign key
	references tblVendedor(vendedor),
	comprador int foreign key
	references tblComprador(comprador),
	imovel int foreign key
	references tblImovel(imovel))
go
