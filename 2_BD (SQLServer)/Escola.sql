create database Escola
go
use Escola
go

create table TblAlocacao (
	cod_turma numeric(6) not null primary key,
	nome_sala char(10),
	dia date,
	inicio "time", 
	fim "time")
go


create table TblAluno(
	cod_aluno numeric(6) not null primary key,
	nome_aluno char(30),
	endereco char(50),
	bairro char(20),
	cidade char(20),
	cep numeric(8), 
	telefone char(20),
	e_mail_aluno char(50))
go

create table TblContrato (
	cod_contrato numeric(6) not null primary key,
	nome_firma char(50),
	contato char(30),
	telefone_firma char(20),
	fax_firma char(20))
go

create table TblCurso (
	cod_curso numeric(6) not null primary key,
	nome_curso char(50),
	carga_horaria int,
	maximo_alunos int,
	minimo_alunos int,
	preco_turma decimal (17,2),
	preco_aluno decimal (17,2),
	equipe_necessaria char(80))
go

create table TblProfessor (
	cod_professor numeric(6) not null primary key,
	nome_professor char(30),
	area char (4),
	ramal numeric(4),
	e_mail_professor char (50))
go

create table TblTurma (
	cod_turma numeric(6) not null primary key,
	cod_curso numeric(6) foreign key references
		TblCurso (cod_curso),
	cod_professor numeric(6) foreign key references
		TblProfessor (cod_professor),
	termino_incricoes date,
	inicio_aulas date,
	fim_aulas date,
	inscritos numeric(3),
	tipo_turma char(1),
	valor_faturado decimal (17,2),
	valor_turma_fechada decimal(17,2),
	carga_horaria_ministra numeric(3))
go

create table TblInscricao (
	cod_turma numeric(6) foreign key references
		TblTurma (cod_turma),
	cod_aluno numeric(6) foreign key references
		TblAluno (cod_aluno),
	valor_cobrado decimal (17,2),
	cod_contrato numeric(6) foreign key references
		TblContrato (cod_contrato),
	conceito char(4))
go

create table TblLaboratorio (
	nome_sala char(10) not null primary key,
	capacidade numeric(3),
	equipe_disponivel char (80))
go

create table TblMinistra (
	cod_professor numeric(6) foreign key references
		TblProfessor (cod_professor),
	cod_curso numeric(6) foreign key references
		TblCurso (cod_curso))
go

--index--
create index IndexAlocacao on TblAlocacao(cod_Turma, nome_sala)
go
create index IndexAluno on TblAluno(cod_aluno)
go
create index IndexContrato on TblContrato(cod_Contrato)
go
create index IndexCurso on TblCurso(cod_Curso)
go
create index IndexProfessor on TblProfessor(cod_Professor)
go
create index IndexTurma on TblTurma(cod_Turma)
go
create index IndexIncricao on TblInscricao(cod_turma,cod_aluno,cod_contrato)
go
create index IndexLaboratorio on TblLaboratorio(nome_sala)
go
create index IndexMinistra on TblMinistra(cod_professor,cod_curso)
go

--insert--
Insert TblAlocacao (cod_turma, nome_sala, dia, inicio, fim) values
(01, 'A', '21-02-2022', '13:00:00', '18:00:00'), 
(02, 'B', '21-02-2022', '13:00:00', '18:00:00'), 
(03, 'C', '21-02-2022', '13:00:00', '18:00:00'), 
(04, 'D', '21-02-2022', '13:00:00', '18:00:00'), 
(05, 'E', '21-02-2022', '13:00:00', '18:00:00')
go

Insert TblAluno (cod_aluno, nome_aluno, endereco, bairro, cidade, cep, telefone, e_mail_aluno) values
(01, 'Ariana', 'Rua Um, 05', 'Tijuca', 'Rio de Janeiro', '00000001', '123456789', 'ariana@gmail.com'), 
(02, 'Bianca', 'Rua Dois, 04', 'Tiradentes', 'Sao Paulo', '00000002', '987654321', 'bianca@gmail.com'), 
(03, 'Carla', 'Rua Tres, 03', 'Morumbi', 'Sao Paulo', '00000003', '123456781', 'carla@gmail.com'), 
(04, 'Dayn', 'Rua Quatro, 02', 'Bom Retiro', 'Sao Paulo', '00000004', '998765432', 'dayn@gmail.com'), 
(05, 'Gabriel', 'Rua Cinco, 01', 'Liberdade', 'Sao Paulo', '00000005', '123456785', 'gabriel@gmail.com')
go

Insert TblContrato (cod_contrato, nome_firma, contato, telefone_firma, fax_firma) values
(001, 'Comida', '99999-9999', '2222-2222', '3333-3300'), 
(002, 'Computadores', '99999-9998', '2222-2221', '3333-3311'), 
(003, 'Cadeiras', '99999-9997', '2222-2223', '3333-3322'), 
(004, 'Agua', '99999-9996', '2222-2224', '3333-3333'), 
(005, 'Luz', '99999-9995', '2222-2228', '3333-3344')
go

Insert TblCurso (cod_curso, nome_curso, carga_horaria, maximo_alunos, minimo_alunos, preco_turma, preco_aluno, equipe_necessaria) values
(01, 'Historia', 100, 40, 18, 30000.00, 50.00, 200), 
(02, 'Matematica', 250, 20, 20, 40000.00, 40.00, 100), 
(03, 'Biologia', 250, 30, 15, 50000.00, 45.00, 201), 
(04, 'BD', 100, 40, 10, 20000.00, 58.00, 202), 
(05, 'Android', 150, 10, 25, 10000.00, 51.00,  108)
go

Insert TblProfessor (cod_professor, nome_professor, area, ramal, e_mail_professor) values
(01, 'Ricardo', '1234', '0001', 'ricardo@gmail.com'), 
(02, 'X', '5678', '0002', 'marcia@gmail.com'), 
(03, 'Yara', '9638', '0003', 'yara@gmail.com'), 
(04, 'Rubens', '7418', '0004', 'rubens@gmail.com'), 
(05, 'Gloria', '4321', '0005', 'gloria@gmail.com')
go

Insert TblTurma (cod_turma, cod_professor, termino_incricoes, inicio_aulas, fim_aulas, inscritos, tipo_turma, valor_faturado, valor_turma_fechada, carga_horaria_ministra) values
(01, 01, '10-02-2022', '21-02-2022', '21-11-2022', 90, 'F', 500000.00, 200000.00,  80), 
(02, 02, '10-02-2022', '21-02-2022', '21-11-2022', 120, 'G', 400000.00, 100000.00,  120), 
(03, 03,  '10-02-2022', '21-02-2022', '21-11-2022', 90, 'H', 300000.00, 800000.00,  90), 
(04, 04, '10-02-2022', '21-02-2022', '21-11-2022', 90, 'I', 200000.00, 500000.00,  80), 
(05, 05, '10-02-2022', '21-02-2022', '21-11-2022', 90, 'J', 100000.00, 900000.00,  80)
go

Insert TblInscricao (cod_aluno, valor_cobrado, cod_contrato, conceito) values
(05, 20, 001, '10'), 
(04, 20, 002, '8'), 
(03, 20, 003, '10'), 
(02, 20, 004, '7'), 
(01, 20, 005, '5')
go

Insert TblLaboratorio (nome_sala, capacidade, equipe_disponivel) values
('A', 30, 'Sim'), 
('B', 25, 'Sim'), 
('C', 30, 'Sim'), 
('D', 28, 'Sim'), 
('E', 40, 'Nao')
go

/*Insert TblMinistra (cod_professor, cod_curso) values
(01, 04), 
(02, 02), 
(03, 03), 
(04, 05), 
(05, 01)
go*/

--SELECT--
--select 1
select * from TblAluno
go

--select 2
select nome_curso, preco_aluno from TblCurso
go

--select 3
select nome_curso, (preco_turma/minimo_alunos) from TblCurso --order by cod_curso
go

--select 4
select valor_cobrado from TblInscricao
go

--select 5
select nome_aluno, bairro, cidade from TblAluno 
	order by bairro
go

--select 6
select nome_aluno, cidade, bairro from TblAluno 
	order by bairro, cidade
go

--select 7
select bairro from TblAluno
go

--select 8
select nome_aluno, bairro from TblAluno 
	where bairro like 'Tijuca' order by nome_aluno 
go

--select 9
select nome_curso,preco_turma from TblCurso 
	order by preco_turma desc
go

--select 10
select * from TblInscricao
	where conceito >= 7 and conceito <= 10
go
/*Opção: between 7 and 10 | in (7, 7.5, 8, 8.5, 9, 9.5, 10)*/

--select 11
Insert Into TblProfessor(cod_Professor, nome_professor, area, ramal) values
(6,'Marcos','EXTN', 0000)
