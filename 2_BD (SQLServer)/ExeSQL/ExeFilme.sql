create dataBASE ExeFilme
go
use ExeFilme
go

create table tblGenero(
	generopk int not null primary key,
	descricao varchar(30))
go

create table tblCliente(
	clientepk int not null primary key,
	nome varchar(30),
	endereco varchar(40))
go
create index XtblCliente on tblCliente (nome, endereco, clientepk)
go

create table tblCategoria(
	categoriapk int not null primary key,
	descricao varchar(50))
go

create table tblFilme(
	filmepk int not null primary key,
	generopk int foreign key
	references tblGenero(generopk),
	categoriapk int foreign key 
	references tblCategoria (categoriapk),
	nome varchar(20),
	sinopse varchar(100))
go

create table tblLocacao(
	generopk int foreign key
	references tblGenero(generopk),
	categoriapk int foreign key 
	references tblCategoria (categoriapk),
	filmepk int foreign key
	references tblFilme(filmepk),
	clientepk int foreign key
	references tblCliente (clientepk),
	datalocacao date,
	datadevolucao date)
go
create index XtblLocacao on tblLocacao (generopk, datalocacao)
go