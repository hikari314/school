/*SUBQUERY
Permitem que seja feita uma pesquisa nos dados de uma tabela com base na exist�ncia ou n�o nos dados de outra tabela.

Regras das subqueries:
	Toda subquery deve ser escrita entre par�nteses;
	S� poder� retornar uma coluna. */

create database Subquery
go

use Subquery
go

create table tblCargo(
	cod_cargo int identity primary key,
	nome_cargo char(50))
go

insert tblCargo values
('Diretor Presidente'),
('Diretor Administrativo'),
('Supervisor'),
('Analista de Sistemas'),
('Analista Comercial')
go

create table tblFuncionario(
	cod_func int identity primary key,
	cod_cargo_fk int foreign key references
		tblCargo (cod_cargo),
	nome_func char(50),
	sal_func dec(7, 2),
	rg_func varchar(10))
go

insert tblFuncionario values
(5, 'Jo�o Silva', 4500.00, '24.985.858'),
(5, 'F�bio', 4500.00, '45.256.652'),
(3, 'Maria', 3700.00, '14.563.365'),
(3, 'Silvia', 5950.00, '87.745.888'),
(2, 'Lucas', 8000.00, '10.569.823'),
(1, 'Rafael', 1200.00, '10.152.325')
go

create table tblDependente(
	cod_dep int identity primary key,
	cod_func_fk int foreign key 
		references tblFuncionario (cod_func),
	nome_dep char(50))
go

insert tblDependente values
(1, 'Rosalina'),
(1, 'Marcela'),
(1, 'Francisco'),
(2, 'Eduardo'),
(3, 'Felipe'),
(5, 'Lucas J�nior'),
(5, 'Fernando')
go

--insert--


--1) Para obter todos os cargos que est�o sem funcion�rios ?
select * from tblCargo
	where cod_cargo not in 
		(select cod_cargo from tblFuncionario)

--2) Para obter os cargos que tenham funcion�rios cadastradosselect * from tblCargo	where cod_cargo in 		(select cod_cargo from tblFuncionario)--3) Para obter os cargos dos funcion�rios que tem dependenteselect * from tblCargo	where cod_cargo in		(select cod_cargo from tblFuncionario			where cod_func in				(select cod_func from tblDependente))--4) Para obter os cargos dos funcion�rios que n�o tem dependenteselect * from tblCargo	where cod_cargo in 		(select cod_cargo from tblFuncionario			where cod_func not in				(select cod_func from tblDependente))--5) Para saber todos os dados do funcion�rio que tem o maior sal�rioselect * from tblFuncionario 	where sal_func = 		(select max(sal_func) from tblFuncionario)select * from tblFuncionario	where sal_func = 		(select min(sal_func) from tblFuncionario)--6) Para obtermos os dados dos funcion�rios que possuem dependentes e o menor sal�rioselect * from tblFuncionario	where sal_func = 		(select min(sal_func) from tblFuncionario			where cod_func in 				(select cod_func from tblDependente))--7) Para exibir todos os dados de cada funcion�rio e quantidade de dependentes que cada um possuiselect *,	(select count(*) from tblDependente		where cod_func_fk = tblFuncionario.cod_func) as Qtde_dep			from tblFuncionario--8) Para obtermos o c�digo e o nome dos cargos e quantidade de funcion�rios que cadacargo possuiselect *,	(select count(*) from tblFuncionario		where cod_cargo_fk = tblCargo.cod_cargo) as 			Qtde_func from tblCargo--UPDATE = Para aplicar 10% de aumento para todos os funcion�rios que n�o tenham dependentesupdate tblFuncionario	set sal_func = sal_func * 1.1		where cod_func not in 			(select cod_func from tblDependente)--DELETE = Excluir todos os funcion�rios que n�o tenham dependentesdelete from tblFuncionario	where cod_func not in 		(select cod_func_fk from tblDependente)