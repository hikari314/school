create database Teste
use Teste

create table contatos
(
	id int primary key identity,
	nome varchar(80),
	fone varchar(20)
)
insert into contatos values('ETESP','111')
insert into contatos values('Aluno2','222')
insert into contatos values('Aluno3','333')

go
CREATE PROC usp_login
@nome varchar(80), @fone varchar(20)
AS if(SELECT count(*) from contatos where nome = @nome AND fone = @fone) != 0 
		BEGIN
				PRINT @nome
		SELECT * from contatos where nome = @nome AND fone = @fone
		END
	ELSE
		SELECT 'Login inv�lido' as msg

select * from contatos
exec usp_login 'Aluno2','222'