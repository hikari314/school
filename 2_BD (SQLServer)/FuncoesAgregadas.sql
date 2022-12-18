create database FA
go
use FA
go

--1--
create table TblAlunos (
	matricula int identity primary key,
	nome char(30) not null,
	idade int,
	sexo char(1) check(upper(sexo) = 'm' or upper(sexo) = 'f'))
go

create index IndexMatricula on TblAlunos(Matricula)
go

--2--
insert TblAlunos (nome, idade, sexo) values
('Marcelo Medeiros', '35', 'M'),
('Ana Paula Berlim', '25', 'F'),
('Lucas Silva', '7', 'M'),
('Caroline Silva', '19', 'F'),
('Djalma Medeiros', '65', 'M'),
('Artur Paes', '5', 'M'),
('Eduarda Duda', '8', 'F')
go

--3 ok--
select * from TblAlunos where sexo='M' --select nome,sexo from TblAlunos where sexo like 'M' | 
										--em algumas aplicações, isso é 'F' diferente disso 'f', mas se colocar o "check upper" no sexo, não tem problema
go

--4 ok--
select nome, idade from TblAlunos where nome like '%Medeiros%' order by idade
go

--5 ok--
select avg(idade) as Media_Idade from TblAlunos
go

--6 ok--
select max(idade) as 'Max Idade' from TblAlunos -- | len() é para nome, já que max é só pra int
go

--7 ok--
select count(idade) as Menor20 from TblAlunos --sempre coloca o campo que está sendo pedido no count
	where idade < 20
go

--8 ok--
select matricula, idade from TblAlunos 
	where nome like 'Lucas Silva'
go

--9 ok--
select count(idade) as Entre10e20 from TblAlunos
	where sexo like 'M' and (idade>10 and idade<20) --| idade between 10 and 20
go

--10 ok--
select count(sexo) as Mulheres from TblAlunos
	where sexo like 'F'
go

--11 ok--
select sexo, count(sexo) as Ocorrencias from TblAlunos group by sexo --| se colocar count(*), vai contar tudo, 
--então por exemplo, se tiver um 'M' em nome, vai contar ele também, então coloca a coluna dentro do count -> sexo, count(sexo) pra contar só essa coluna mesmo