create database lista02
go

use lista02
go

create table Cliente
(
	cpf numeric(11) primary key,
	nome varchar(60),
	dtNasc date)
go

create table Modelo
(
	codMod int primary key,
	Desc_2 varchar(40))
go

create table Veiculo
(
	placa char(8)primary key,
	codMod int foreign key 
		references modelo(codMod),
	cpf numeric(11) foreign key
		references cliente (cpf),
	cor varchar(20),
	ano varchar(4))
go

create table Patio
(
	num int primary key,
	ender varchar(40),
	capacidade int)
go

create table Estaciona
(
	cod int primary key,
	num int foreign key 
		references patio(num),
	placa char(8) foreign key 
		references veiculo(placa),
	dtEntrada date,
	dtSaida date,
	hrSaida varchar(10))
go

Insert into Cliente values
(12345679888,'Anderson Coan','10-10-1978'),
(78945613233,'Luiz Ricardo','07-10-1978'),
(45612378955,'José Rubens','15-05-1972'),
(12378965411,'Gerson','10-10-1978'),
(74125896366,'Carlos Querido','08-12-1977'),
(25874136988,'José Mendes','09-01-1985')
go

Insert into Modelo values
(1,'Duster'),
(2,'Palio'),
(3,'Pegeout 207'),
(4,'Tucson'),
(5,'Fusca'),
(6,'Gol')
go

Insert into Veiculo values
('JJJ-2020',1,78945613233,'PRATA','2015'),
('JEG-1010',2,12345679888,'VERDE','2000'),
('ELT-2020',3,25874136988,'AZUL','1999'),
('JPG-2020',4,12378965411,'VERMELHO','2008'),
('PNG-2020',5,74125896366,'VERDE','2000'),
('SQL-2015',6,78945613233,'PRETO','2014')
go

Insert into Patio values
(1,'AV CECI,2000',50),
(2,'AV TIRADENTES, 615',85),
(3,'AV PAULISTA,2000',150),
(4,'AV JABAQUARA,2000',30),
(5,'AV DOS BANCOS',100),
(6,'AV INDIANOPOLIS,555',50)
go

Insert into Estaciona values
(1,1,'JJJ-2020','28-04-2010','28-04-2015','18:05'),
(2,2,'JEG-1010','28-01-2011','01-01-2011','00:05'),
(3,3,'ELT-2020','28-03-2012','30-03-2012','22:05'),
(4,4,'JPG-2020','28-05-2013','29-05-2013','10:45'),
(5,5,'JEG-1010','28-06-2014','22-06-2014','14:15'),
(6,6,'JJJ-2020','28-04-2015','18-04-2015','17:30'),
(7,1,'JJJ-2020','28-01-2015','08-01-2015','13:00'),
(8,2,'SQL-2015','28-01-2015','18-01-2014','15:00'),
(9,1,'JJJ-2020','28-01-2015','15-09-2013','10:22'),
(10,1,'JEG-1010','28-01-2015','15-04-2011','20:18'),
(11,1,'JJJ-2020','28-01-2015','10-01-2010','03:09'),
(12,1,'JJJ-2020','28-01-2015','28-01-2012','23:00')

--LISTA JOIN2------------------------------------------------------------------------------------------------------------------
--1 - Exiba o endereço, a data de entrada e de saída dos estacionamentos do veículo de placa “JEG-1010”. ok
select p.ender, e.dtEntrada, e.dtSaida from Patio P
	inner join Estaciona E
		on P.num = E.num 
		 and e.placa = 'JEG-1010'

--2 – Exiba a quantidade de vezes que os veículos de cor azul estacionaram. ok
select count(dtEntrada) as VeiculoAzul from Estaciona E
	inner join Veiculo V
		on E.placa = V.placa 
	and cor = 'AZUL'

--
select count(e.cod) as Qtde from Veiculo V
	inner join Estaciona E
		on V.placa = E.placa 
	where V.cor = 'AZUL'

--3 - Liste todos os clientes que possuem carro de modelo 1. ok
select c.* from Cliente C
	inner join Veiculo V 
		on C.cpf = V.cpf
			inner join Modelo M
				on V.codMod = M.codMod 
					and Desc_2 = 'Duster'
--
select c.* from Cliente C 
	inner join Veiculo V
		on C.cpf = V.cpf 
			where V.codMod = 1

--4 - Liste as placas, os horários de entrada e saída dos veículos de cor verde. ?
select a.placa, b.dtEntrada, b.dtSaida from Estaciona B 
	inner join Veiculo A
		on A.placa = B.placa 
			and cor like 'VERDE'

/* select V.placa, e.he, e.hsSaida from Veiculo V
	 inner join Estaciona E 
		 on V.placa = E.placa
	 where V.cor = 'VERDE' */

--5 - Liste todos os estacionamentos do veículo de placa “JJJ-2020”. ok
select * from Estaciona E 
	where placa = 'JJJ-2020'

--
select e.cod,e.dtEntrada, e.dtSaida from Veiculo V 
	inner join Estaciona E
		on V.placa = E.placa
	where V.placa = 'JJJ-2020'

--6 - Exiba o nome do cliente que possui o veículo cujo código do estacionamento é 2. ok
select c.nome from Cliente C 
	inner join Veiculo V 
		on C.cpf = V.cpf 
	inner join Estaciona E 
		on V.placa = E.placa 
	and E.cod = 2

--7 - Exiba o CPF do cliente que possui o veículo onde o código do estacionamento é 3. ok
select c.cpf from Cliente C
	inner join Veiculo V
		on C.cpf = V.cpf 
	inner join Estaciona E
		on V.placa = E.placa 
	and E.cod = 3

--8 - Exiba a descrição do modelo do veículo cujo código do estacionamento é 2. ok
select m.Desc_2 from Modelo M 
	inner join Veiculo V
		on M.codMod = V.codMod 
	inner join Estaciona E
		on V.placa = E.placa
	and E.cod = 2

--9 - Exiba a placa, o nome dos donos e a descrição dos os modelos de todos os veículos. ok
--placa = estaciona e veiculo | nome = cpf -> cliente e veiculo | descricao = codMod -> veiculo e modelo 
select v.placa, c.nome, m.Desc_2 from Veiculo V
	inner join Cliente C 
		on V.cpf = C.cpf 
	inner join Modelo M
		on V.codMod = M.codMod 

--
select v.placa, c.nome, m.Desc_2 from Modelo M
	inner join Veiculo V
		on M.codMod = V.codMod 
	inner join Cliente C
		on C.cpf = V.cpf
