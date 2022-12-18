USE MASTER 
GO

IF EXISTS(SELECT 1 FROM SYSDATABASES WHERE NAME = 'faculdade')
	DROP DATABASE faculdade


CREATE DATABASE faculdade
go

Use faculdade
go

create table tblDepto
(
	codDepto char(8),
	nomeDepto varchar(20),
	primary key (codDepto)
);
go

insert into tblDepto values ('INF01', 'Informática' );
insert into tblDepto values ('MAT01', 'Matemática');
insert into tblDepto values ('ELE01', 'Eletrônica') ;
go

create table tblDisciplina
(
	codDepto char(8),
	numDisc char(10),
	nomeDisc varchar(20),
	creditosDisc integer ,
	primary key (codDepto, numDisc),
	foreign key (codDepto) references tblDepto );
go

insert into tblDisciplina values ('INF01','DIS01','Ling Formais', 4);
insert into tblDisciplina values ('INF01','DIS02','Teoria da Comp', 4);
insert into tblDisciplina values ('INF01','DIS03','Programacao I', 8);
insert into tblDisciplina values ('MAT01','DIS04','Cálculo 1', 4);
insert into tblDisciplina values ('MAT01','DIS01','Cálculo 2', 6);
go

create table tblPreReq
(
	codDepto char(8),
	numDisc char(10),
	codDeptoPreReq char(8),
	numDiscPreReq char(10),
	primary key (codDepto, numDisc, codDeptoPreReq, numDiscPreReq),
	foreign key (codDepto, numDisc) references tbldisciplina,
	foreign key (codDeptoPreReq, numDiscPreReq) references tbldisciplina);
go

insert into tblPreReq values ('INF01', 'DIS02', 'INF01', 'DIS01');
insert into tblPreReq values ('MAT01', 'DIS04', 'MAT01', 'DIS01');
insert into tblPreReq values ('INF01', 'DIS03', 'INF01', 'DIS02');
go 

create table tblTurma
(
	anoSem integer ,
	codDepto char(8),
	numDisc char(10),
	siglaTur char(5),
	capacTur integer ,
	primary key (anoSem, codDepto, numDisc, siglaTur),
	foreign key (codDepto, numDisc) references tblDisciplina
)
go

insert into tblturma values (20021, 'INF01', 'DIS01', 'TUR01', 30);
insert into tblturma values (20022, 'INF01', 'DIS01', 'TUR01', 30);
insert into tblturma values (20021, 'INF01', 'DIS02', 'TUR02', 30);
insert into tblturma values (20022, 'INF01', 'DIS03', 'TUR01', 200);
insert into tblturma values (20031, 'INF01', 'DIS03', 'TUR02', 30);
insert into tblturma values (20021, 'MAT01', 'DIS01', 'TUR01', 15);
insert into tblturma values (20022, 'INF01', 'DIS03', 'TUR02', 25);
go

create table tblPredio
(
	codPred integer ,
	nomePred varchar(30),
	primary key (codPred)
)
go


insert into tblpredio values (43423, 'Informáti ca-Aulas' );
insert into tblpredio values (43421, 'Administração');
insert into tblpredio values (43424, 'Laboratórios');
go

create table tblSala 
(
	codPred integer ,
	numSala integer,
	capacSala integer ,
	primary key (codPred, numSala),
	foreign key(codPred)references tblPredio
);
go


insert into tblsala values (43423, 101, 30);
insert into tblsala values (43421, 102, 50);
insert into tblsala values (43424, 215, 40);
go

create table tblHorario
(
	anoSem integer ,
	codDepto char(8),
	numDisc char(10),
	siglaTur char(5),
	diaSem integer,
	horaInicio char(5),
	numHoras integer ,
	codPredio integer ,
	numSala integer,
	primary key (anoSem, codDepto, numDisc, siglaTur, diaSem,horaInicio),
	foreign key (anoSem, codDepto, numDisc, siglaTur) references tblturma,
	foreign key (codPredio, numSala) references tblsala
);
go

insert into tblhorario values (20021, 'INF01', 'DIS01', 'TUR01', 2, '10:30', 60, 43423, 101);
insert into tblhorario values (20021, 'INF01', 'DIS02', 'TUR02', 3, '10:30', 60, 43423, 101);
insert into tblhorario values (20022, 'INF01', 'DIS03', 'TUR02', 4, '08:30', 45, 43424, 215);
insert into tblhorario values (20021, 'INF01', 'DIS01', 'TUR01', 4, '13:30', 60, 43423, 101);
go

create table tblTitulacao
(
	codTit integer ,
	nomeTit varchar(20),
	primary key (codTit)
);
go

insert into tblTitulacao values (1, 'Doutor');
insert into tblTitulacao values (2, 'Mestre');
insert into tblTitulacao values (3, 'Especial i sta') ;
insert into tblTitulacao values (4, 'Graduado' )
go

create table tblProfessor
(
	codProf char(5),
	nomeProf varchar(50),
	codTit integer ,
	codDepto char(8),
	primary key (codProf),
	foreign key (codTit) references tblTitulacao,
	foreign key (codDepto) references tblDepto 
);
go

insert into tblProfessor values ('Pro01', 'Antunes', 1, 'INF01');
insert into tblProfessor values ('Pro02', 'Maria dos Santos', 2, 'INF01');
insert into tblProfessor values ('Pro03', 'Paulo', 3, 'MAT01');
insert into tblProfessor values ('Pro04', 'Gabriel' , 2, 'MAT01');
go

create table tblProfTurma
(
	anoSem integer ,
	codDepto char(8),
	numDisc char(10),
	siglaTur char(5),
	codProf char(5),
	primary key (anoSem, codDepto, numDisc, siglaTur, codProf),
	foreign key (anoSem, codDepto, numDisc, siglaTur) references tblTurma,
	foreign key (codProf) references tblProfessor
);
go

insert into tblProfTurma values (20021, 'INF01','DIS01','TUR01','Pro01');
insert into tblProfTurma values (20022, 'INF01','DIS01','TUR01','Pro01');
insert into tblProfTurma values (20021, 'INF01','DIS02','TUR02','Pro02');
insert into tblProfTurma values (20021, 'MAT01','DIS01','TUR01','Pro03');
insert into tblProfTurma values (20021, 'MAT01','DIS01','TUR01','Pro02');
go

--LISTA 01--------------------------------------------------------------------------------
--1) Obter todos os dados dos professoresSELECT * from tblProfessor

--2) Obter o código e o nome dos professores
select codProf, nomeProf from tblProfessor

--3) Obter a capacidade das turmas sem repetiçãoselect distinct siglaTur, capacTur from tblTurma

--4) Obter os diferentes valores de capacidade de turmas
select siglaTur, capacTur from tblTurma

--5) Obter o nome das disciplinas do departamento INF01, desde que tenham mais de 5 créditos
select nomeDisc from tblDisciplina 
	where codDepto = 'INF01' and creditosDisc > 5

--6) Obter o código do prédio chamado laboratórios
select codPred from tblPredio where nomePred = 'Laboratórios'

--7) Obter o código da sala e o código do prédio, desde que a sala tenha capacidade superior a 35 lugares
select numSala, codPred from tblSala where capacSala > 35

--8) Obter o nome dos professores que têm titulação 1 e que trabalham no departamento inf01
select nomeProf from tblProfessor where codTit = 1 and codDepto = 'INF01'

--9) Obter o nome dos professores que possui titulação 2 ou que trabalham no departamento inf01
select nomeProf from tblProfessor where codTit = 2 OR codDepto = 'INF01'

--10)Retorne o código e o nome dos professores que possuem o sobrenome Santos
select codProf, nomeProf from tblProfessor where 
	nomeProf like '%Santos'

--11)Sabendo que cada crédito de disciplina corresponde a 15 horas-aulas, retorne o nome da disciplina e o seu número de horas-aula
alter table tblDisciplina add horas char(10)

update tblDisciplina 
	set horas = creditosDisc * 15

select nomeDisc, horas from tblDisciplina

--11) Opcao
select nomeDisc, creditosDisc * 15 as 'horas_aula' from tblDisciplina

--LISTA 02----------------------------------------------------------------------------------
--1) Obtenha os nomes das disciplinas seguidas do nome de seu departamento
select a.nomeDisc, o.nomeDepto from tblDepto o
	right join tblDisciplina a
		on o.codDepto = a.codDepto

--2) Obtenha os nomes dos professores que possuem a titulação Doutor
select nomeProf from tblProfessor 
	where codTit = (select codTit from tblTitulacao 
		where codTit = 1)	

--3) Obtenha os nomes dos professores que ministraram aulas em 2002/2
select nomeProf from tblProfessor 
	where codProf = (select codProf from tblProfTurma
		where anoSem = 20022)

--4) Obtenha os números das salas do prédio de nome laboratórios cuja capacidade seja maior que 30
select numSala from tblSala 
	where codPred = (select codPred from tblPredio where codPred = 43424)
		and capacSala > 30

--5) Obtenha os nomes das disciplinas que foram oferecidas em 2002/1
select nomeDisc from tblDisciplina 
	where numDisc in (select numDisc from tblProfTurma
		where anoSem = 20021)

--6) Obtenha os números das salas do prédio Laboratórios.
select numSala from tblSala 
	where codPred = 43424

--7) Obtenha os nomes dos professores seguidos dos nomes de seu departamento
select p.nomeProf, o.nomeDepto from tblProfessor p
	right join tblDepto o
		on o.codDepto = p.codDepto

--8) Obtenha os códigos dos professores que não possuem turma em 1999/2
select codProf from tblProfessor
	where codProf in (select codProf from tblProfTurma
		where anoSem = 19992)

--9) Nomes dos professores que possuem disciplinas que não apresentam pré-requisito
select nomeProf from tblProfessor
	where codProf in (select codProf from tblProfTurma
		where numDisc not in(select numDisc from tblPreReq))

--10) Obtenha os códigos dos professores que ministraram aulas em 1999/2 e 2000/1
select codProf from tblProfessor
	where codProf in (select codProf from tblProfTurma
		where anoSem = 19992 and anoSem = 20001)

--11) Obtenha os nomes dos departamentos em que há pelo menos uma disciplina com mais de três créditos
select nomeDepto from tblDepto 
	where codDepto in (select codDepto from tblDisciplina 
		where creditosDisc > 3) 
