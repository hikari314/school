use master
go

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'programacao')
	DROP DATABASE programacao
go

Create database programacao
go

use programacao
go

create table funcionario(
Cod_func int identity primary key,
Nome_func char(50),
Sal_fuc dec (10,2),
bonus_fuc dec (6,2),
idade int
)
go

insert funcionario (Nome_func,Sal_fuc, idade)values
('Luiz',1000.00,40),
('Ricardo',2100.00,41),
('Lucas',3500.00,42),
('Juliana',6000.00,42),
('Diogo',9858.00,43),
('Carlos',1212.00,43),
('Maria',3569.00,44),
('Vanda',5289.00,45),
('Laura',6985.00,46),
('Lara',6500.00,50),
('Lucia',8788.00,51),
('Natalia',9856.00,30),
('Eduardo',1254.00,32),
('Mateus',4565.00,33),
('Diego',8597.00,34),
('Giovana',1425.00,35),
('Leo',9653.00,40),
('Vladmir',4525.00,41),
('José',7845.00,46),
('Marcelo',5897.00,30),
('Rubens',1000.8569,33),
('Ana ',4125.00,34),
('Jefferson',3659.00,35),
('Nicholas',7458.00,39)
go

select Sal_Fuc from Funcionario 

--EX2
if (select idade from Funcionario where Cod_Func = 1) >= 50
	Begin
		update Funcionario set
		Sal_Fuc = Sal_Fuc * 1.5 where Cod_Func = 1
	End

--DESAFIO IF
--1. Se o func do cod 1 tiver 50 anos ou mais, aplique um aumento salarial de 50% e um bonus de 500 reais
--2. Se n, se o func de cod 1 tiver idade entre 40 e 49 anos, aplique um aumento salarial de 40% e um bonus de 1000 reais
--3. Se n, se o func de cod 1 tiver idade entre 30 e 39 anos, aplique um aumento salarial de 30% e um bonus de 1500 reais
--4. Caso contrario, aplique um aumento de 20% e um bonus de 2000 reais
Declare @idade int = (select idade from funcionario where Cod_func = 1)

if @idade >= 50 
	begin
		update funcionario set Sal_fuc = 1.5 * Sal_fuc , bonus_fuc = 500
			where Cod_func = 1
	end
else if @idade between 40 and 49 
	begin
		update funcionario set Sal_fuc = 1.4 * Sal_fuc , bonus_fuc = 1000
			where Cod_func = 1
	end
else if @idade between 30 and 39 
	begin
		update funcionario set Sal_fuc = 1.3 * Sal_fuc ,bonus_fuc = 1500
			where Cod_func = 1
	end
else
	begin
		update funcionario set Sal_fuc = 1.2 * Sal_fuc , bonus_fuc = 2000
			where Cod_func = 1
	end

--DESAFIO CASE
--Exiba todos os dados de cada func e dependendo da idade de cada um, exiba uma das seguintes frases:
--Se idade entre 18 e 30 escreva "Trabalhador Jovem"
--Se idade entre 30 e 40 escreva ""
--Se idade entre  e  escreva ""
--Se idade entre  e  escreva ""
--Se idade entre  e  escreva ""
--Se idade entre  e  escreva ""
Select *, case
			when idade between 18 and 30 then 'Trabalhador Jovem'
			when idade between 30 and 40 then 'Trabalhador Fase 1'
			when idade between 40 and 50 then 'Trabalhador Fase 2'
			when idade between 50 and 60 then 'Trabalhador Fase 3'
			when idade between 60 and 65 then 'Trabalhador Fase 4'
			--else 'Erro de calculo, idade inválida ou fora dos requesitos'
		end as 'Faixa de idade do funcionário' from funcionario