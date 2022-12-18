/*SUBQUERY
Permitem que seja feita uma pesquisa nos dados de uma tabela com base na existência ou não nos dados de outra tabela.

Regras das subqueries:
	Toda subquery deve ser escrita entre parênteses;
	Só poderá retornar uma coluna. */

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
(5, 'João Silva', 4500.00, '24.985.858'),
(5, 'Fábio', 4500.00, '45.256.652'),
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
(5, 'Lucas Júnior'),
(5, 'Fernando')
go

--insert--


--1) Para obter todos os cargos que estão sem funcionários ?
select * from tblCargo
	where cod_cargo not in 
		(select cod_cargo from tblFuncionario)

--2) Para obter os cargos que tenham funcionários cadastradosselect * from tblCargo	where cod_cargo in 		(select cod_cargo from tblFuncionario)--3) Para obter os cargos dos funcionários que tem dependenteselect * from tblCargo	where cod_cargo in		(select cod_cargo from tblFuncionario			where cod_func in				(select cod_func from tblDependente))--4) Para obter os cargos dos funcionários que não tem dependenteselect * from tblCargo	where cod_cargo in 		(select cod_cargo from tblFuncionario			where cod_func not in				(select cod_func from tblDependente))--5) Para saber todos os dados do funcionário que tem o maior salárioselect * from tblFuncionario 	where sal_func = 		(select max(sal_func) from tblFuncionario)select * from tblFuncionario	where sal_func = 		(select min(sal_func) from tblFuncionario)--6) Para obtermos os dados dos funcionários que possuem dependentes e o menor salárioselect * from tblFuncionario	where sal_func = 		(select min(sal_func) from tblFuncionario			where cod_func in 				(select cod_func from tblDependente))--7) Para exibir todos os dados de cada funcionário e quantidade de dependentes que cada um possuiselect *,	(select count(*) from tblDependente		where cod_func_fk = tblFuncionario.cod_func) as Qtde_dep			from tblFuncionario--8) Para obtermos o código e o nome dos cargos e quantidade de funcionários que cadacargo possuiselect *,	(select count(*) from tblFuncionario		where cod_cargo_fk = tblCargo.cod_cargo) as 			Qtde_func from tblCargo--UPDATE = Para aplicar 10% de aumento para todos os funcionários que não tenham dependentesupdate tblFuncionario	set sal_func = sal_func * 1.1		where cod_func not in 			(select cod_func from tblDependente)--DELETE = Excluir todos os funcionários que não tenham dependentesdelete from tblFuncionario	where cod_func not in 		(select cod_func_fk from tblDependente)