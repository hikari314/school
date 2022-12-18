use master
drop database Teste

create database Teste
go

use Teste
go

create table Contatos 
(
	id int primary key identity,
	nome varchar(80),
	fone varchar(20)
)
go

insert INTO Contatos values 
('ETESP', '111'),
('Aluno1', '222'),
('Aluno2', '333')

select * from Contatos
--dataset = fundo e tabela