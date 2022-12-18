create database DB_CDS2
use DB_CDS2
go 

use master
drop database DB_CDS2
go

create table tblArtista1 (
	cod_art int not null primary key,
	nome_art varchar(100) not null
)
go

insert tblArtista1 values
(1, 'Marisa Monte'),
(2, 'Gilberto Gil'),
(3, 'Caetano Veloso'),
(4, 'Milton Nascimento'),
(5, 'Legião Urbana'),
(6, 'The Beatles'),
(7, 'Rita Lee')
go

create table tblGravadora1 (
	cod_grav int not null primary key,
	nome_grav varchar(50) not null
)
go

insert tblGravadora1 values --
(1, 'Polygram'),
(2, 'EMI'),
(3, 'Som Livre'),
(4, 'Sony Music')
go

create table tblCategoria1 (
	cod_cat int not null primary key,
	nome_grav varchar(50) not null
)
go

insert tblCategoria1 values
(1, 'MPB'),
(2, 'Trilha Sonora'),
(3, 'Rock Internacional'),
(4, 'Rock Nacional')
go

create table tblEstado1 (
	sigla_est char(2) not null primary key,
	nome_est char(20) not null
)
go

insert tblEstado1 values
('SP', 'São Paulo'),
('MG', 'Mnas Gerais'),
('RJ', 'Rio de Janeiro'),
('ES', 'Espírito Santo')
go

create table tblCidade1(
	cod_cid int not null primary key,
	nome_cid varchar(100) not null,
	sigla_est_fk char(2) foreign key
		references tblEstado1(sigla_est)
)
go

insert tblCidade1 values
(1, 'São Paulo', 'SP'),
(2, 'Sorocaba', 'SP'),
(3, 'Jundiaí', 'SP'),
(4, 'Americana', 'SP'),
(5, 'Araraquara', 'SP'),
(6, 'Ouro Preto', 'MG'),
(7, 'Cachoeiro Itapemirim', 'ES')
go

create table tblCliente1 (
	cod_cli int not null primary key,
	cod_cid_fk int not null foreign key 
		references tblCidade1(cod_cid),
	nome_cli varchar(100) not null,
	end_cli varchar(200) not null,
	renda_cli dec(10,2) not null default '0',
	sexo_cli char(1) not null default 'F'
)
go

insert tblCliente1 values
(1, 1, 'José Nogueria', 'Rua A', 1500.00, 'M'),
(2, 1, 'Angelo Pereira', 'Rua B', 2000.00, 'M'),
(3, 1, 'Além Mar Paranhos', 'Rua C', 1500.00, 'M'),
(4, 1, 'Catarina Souza', 'Rua D', 892.00, 'F'),
(5, 1, 'Vagner Costa', 'Rua E', 950.00, 'M'),
(6, 2, 'Antenor da Costa', 'Rua F', 1582.00, 'M'),
(7, 2, 'Maria Amélia de Souza', 'Rua G', 1152.02, 'F'),
(8, 2, 'Paulo Roberto Silva', 'Rua H', 3250.00, 'M'),
(9, 3, 'Fátima Souza', 'Rua I', 632.00, 'F'),
(10, 3, 'Joel da Rocha', 'Rua J', 2000.00, 'M')
go

create table tblConjuge1 (
	cod_cli_fk int not null foreign key 
		references tblCliente1(cod_cli),
	nome_conj varchar(100) not null,
	renda_conj dec(10,2) not null default '0',
	sexo_conj char(1) not null default 'M'
)
go

insert tblConjuge1 values
(1, 'Carla Nogueira', 2500.00, 'M'),
(2, 'Emitia Pereira', 5500.00, 'F'),
(3, 'Altiva da Costa', 3000.00, 'F'),
(4, 'Carlos de Souza', 3250.00, 'M')
go

create table tblFuncionario1(
	cod_func int not null primary key,
	nome_func varchar(100) not null,
	end_func varchar(200) not null,
	sal_func dec(10,2) not null default '0',
	sexo_func char(1) not null default 'F'
)
go

insert tblFuncionario1 values
(1, 'Vânia Gabriela Pereira', 'Rua A', 2500.00, 'F'),
(2, 'Norberto pereira da Silva', 'Rua B', 300.00, 'M'),
(3, 'Olavo Linhares', 'Rua C', 580.00, 'M'),
(4, 'Paula da Silva', 'Rua D', 3000.00, 'F'),
(5, 'Rolando Rocha', 'Rua E', 2000.00, 'M')
go

create table tblDependente1(
	cod_dep int not null primary key,
	cod_func_fk int not null foreign key
		references tblFuncionario1(cod_func),
	nome_dep varchar(100) not null,
	sexo_dep char(1) not null default 'M'
)
go

insert tblDependente1 values
(1, 1, 'Ana Pereira', 'F'),
(2, 1, 'Roberto Pereira', 'M'),
(3, 1, 'Celso Pereira', 'M'),
(4, 3, 'Brisa Linhares', 'F'),
(5, 3, 'Mari Sol Linhares', 'F'),
(6, 4, 'Sônia da Silva', 'F')
go

create table tblTitulo1(
	cod_tit int not null primary key,
	cod_cat_fk int not null foreign key -- esta sem é cat 2
		references tblCategoria1 (cod_cat),
	cod_grav_fk int not null foreign key -- nunca foi 4 na grav
		references tblGravadora1(cod_grav),
	nome_CD varchar(100) not null,
	val_CD dec(10,2) not null,
	otd_estq int not null
)
go

insert tblTitulo1 values --
(1, 1, 1, 'Tribalistas', 30.00, 1500),
(2, 1, 2, 'Tropicália', 50.00, 500),
(3, 1, 1, 'Aquele Abraço', 50.00, 600),
(4, 1, 2, 'Refazenda', 60.00, 1000),
(5, 1, 3, 'Totalmente Demais', 50.00, 2000),
(6, 1, 3, 'Travessia', 55.00, 500),
(7, 1, 2, 'Courage', 30.00, 200),
(8, 4, 3, 'Legião Urbana', 20.00, 100),
(9, 3, 2, 'The Beatles', 30.00, 300),
(10, 4, 1, 'Rita Lee', 30.00, 500)
go

create table tblPedido1(
	num_ped int not null primary key,
	cod_cli_fk int not null foreign key 
		references tblCliente1(cod_cli),
	cod_func_fk int not null foreign key
		references tblFuncionario1(cod_func),
	data_ped date not null,
	val_ped dec(10,2) not null default '0'
)
go

insert tblPedido1 values --func 3 nunca recebeu ped
(1, 1, 2, '02-05-02', 1500.00),
(2, 3, 4, '02-05-02', 50.00),
(3, 4, 5, '02-06-02', 100.00),
(4, 1, 4, '02-02-03', 200.00),
(5, 7, 5, '02-03-03', 300.00),
(6, 4, 4, '02-03-03', 100.00),
(7, 5, 5, '02-03-03', 50.00),
(8, 8, 2, '02-03-03', 50.00),
(9, 2, 2, '02-03-03', 2000.00),
(10, 7, 1, '02-03-03', 3000.00)
go

create table tblTitulo_Pedido1 (
	num_ped_fk int not null foreign key
		references tblPedido1 (num_ped),
	cod_tit_fk int not null foreign key 
		references tblTitulo1(cod_tit),
	qtd_CD int not null default '1',
	val_CD dec(10,2) not null
)
go

insert tblTitulo_Pedido1 values
(1, 1, 2, 30.00),
(1, 2, 3, 20.00),
(2, 1, 1, 50.00),
(2, 2, 3, 30.00),
(3, 1, 2, 40.00),
(4, 2, 3, 20.00),
(5, 1, 2, 25.00),
(6, 2, 3, 30.00),
(6, 3, 1, 35.00),
(7, 4, 2, 55.00)
go

create table tblTitulo_Artista1 (
	cod_tit_fk int not null foreign key
		references tblTitulo1(cod_tit),
	cod_art_fk int not null foreign key
		references tblArtista1(cod_art)
)
go

insert tblTitulo_Artista1 values
(2, 2),
(3, 2),
(4, 2),
(5, 3),
(6, 4),
(7, 4),
(8, 5),
(9, 6),
(10, 7)
go

--EXERCICIOS
--1 – Apresentar todos os clientes solteiros; not in conjuge
select nome_cli from tblCliente1 
	where cod_cli not in
		(select cod_cli_fk from tblConjuge1)

--2 – Apresentar todos os clientes casados;
select nome_cli from tblCliente1
	where cod_cli in
		(select cod_cli_fk from tblConjuge1)

--3 – Apresentar todas as categorias que estão sem CD;
select cod_cat from tblCategoria1 
	where cod_cat not in
		(select cod_cat_fk from tblTitulo1)

--4 – Apresentar todas as gravadoras que nunca gravaram CD; cd not in grav
select * from tblGravadora1
	where cod_grav not in
		(select cod_grav_fk from tblTitulo1)

--5 – Apresentar apenas os funcionários que tem dependentes e que nunca atenderam a algum pedido;
--func que nunca pedido:
select cod_func, nome_func from tblFuncionario1 
	where cod_func not in 
		(select cod_func_fk from tblPedido1)

--tem dependentes:
select cod_func, nome_func from tblFuncionario1 
	where cod_func in 
		(select cod_func_fk from tblDependente1)

--juntar:
select cod_func, nome_func from tblFuncionario1
	where 
		(cod_func not in (select cod_func_fk from tblPedido1)) and (cod_func in (select cod_func_fk from tblDependente1))

--6 – Mostrar todos os funcionários que atenderam a pedidos de clientes casados;
--clientes casados:
select nome_cli from tblCliente1
	where cod_cli in
		(select cod_cli_fk from tblConjuge1)

--pedidos de casados:


--7 – Apresentar os dados dos clientes que possuem a maior renda;
select * from tblCliente1 where renda_cli =
	(select max(renda_cli) from tblCliente1)		--poderia ter colocado "IN", já que retorna só um valor

--8 – Apresentar os dados do CD mais caro
select * from tblTitulo1
	where val_cd = (select max(val_cd) from tblTitulo1)

--9 - Aplicar um aumento salarial de 20% para todos os funcionários que não têm dependentes;
-- sem dependentes:
select * from tblFuncionario1 
	where cod_func not in 
		(select cod_func_fk from tblDependente1)

--aumento
update tblFuncionario1
	set sal_func = sal_func * 1.2 
		where cod_func not in 
			(select cod_func_fk from tblDependente1)

--10 - Aplicar um aumento salarial de 10% para todos os funcionários que têm dependentes;
update tblFuncionario1
	set sal_func = sal_func * 1.1 
		where cod_func in
			(select cod_func_fk from tblDependente1)

--select * from tblFuncionario1 where cod_func in (select cod_func_fk from tblDependente1)

-- 11 - Aumentar em 100.00 a renda de todos os clientes solteiros;
select renda_cli from tblCliente1 where cod_cli not in (select cod_cli_fk from tblConjuge1)

--aumentar
update tblCliente1
	set renda_cli = renda_cli + 100.00
		where cod_cli not in (select cod_cli_fk from tblConjuge1)

--12 - Aumentar em 100.00 a renda de todos os clientes solteiros do sexo feminino;
--solteiros:
select * from tblCliente1 where cod_cli not in (select cod_cli_fk from tblConjuge1) 

--feminino:
select * from tblCliente1 where cod_cli not in (select cod_cli_fk from tblConjuge1) and sexo_cli = 'F'

--aumentar:
update tblCliente1 
	set renda_cli = renda_cli + 100.00									--se apertar 2 vezes, vai dar um aumento de 200 e assim vai
		where cod_cli not in											--where cod_cli not in	
			(select cod_cli_fk from tblConjuge1) and sexo_cli = 'F'		--(select cod_cli from tblConjuge where	sexo_conj = 'M')

--13 - Aumentar em 200.00 a renda de todos os clientes que já fizeram pedidos;
--ja fizeram
select * from tblCliente1 where cod_cli in (select cod_cli_fk from tblPedido1)

--aumentar
update tblCliente1
	set renda_cli = renda_cli + 200.00
		where cod_cli in
			(select cod_cli_fk from tblPedido1)

--14 - Aumentar em 500.00 a renda de todos os clientes solteiros que já fizeram pedidos;
--solteiros
select * from tblCliente1 where cod_cli not in (select cod_cli_fk from tblConjuge1)

--já fizeram pedidos
select * from tblCliente1 where cod_cli in (select cod_cli_fk from tblPedido1)

--juntar
update tblCliente1
	set renda_cli = renda_cli + 500.00
		 where cod_cli in (select cod_cli_fk from tblPedido1) 
			and cod_cli not in (select cod_cli_fk from tblConjuge1)

--15 - Aplicar um desconto de 10% em todos os pedidos onde foi vendido o título de código igual a 1;
--titulo codigo igual a 1:
select * from tblTitulo_Pedido1 where cod_tit_fk = 1

--desconto
update tblTitulo_Pedido1 
	set val_CD = val_CD - 1.1
		where cod_tit_fk = 1

--16 - Aumentar em 500.00 o salário de todos os funcionários que já atenderam a pedidos feitos pelo cliente 1;
--pedidos cliente 1:
select cod_func_fk from tblPedido1 where cod_cli_fk = 1

--funcionarios atenderam
select * from tblFuncionario1 where cod_func in (select cod_func_fk from tblPedido1 where cod_cli_fk = 1)

--aumentar:
update tblFuncionario1 
	set sal_func = sal_func + 500.00
		where cod_func in 
			(select cod_func_fk from tblPedido1 where cod_cli_fk = 1)

--17 - Aplicar um desconto de 10% para todos os CDs (títulos) que nunca foram vendidos;
--nunca vendidos:
select * from tblTitulo1 where cod_tit not in 
	(select cod_tit_fk from tblTitulo_Pedido1)

--desconto:
update tblTitulo1
	set val_CD = val_CD - 1.1
		where cod_tit not in 
			(select cod_tit_fk from tblTitulo_Pedido1)

--18 - Aplicar um aumento salarial de 20% para todos os funcionários que não têm dependentes.
--sem dependentes:
select * from tblFuncionario1 where cod_func not in (select cod_func_fk from tblDependente1)

--juntar:
update tblFuncionario1
	set sal_func = sal_func * 1.2
		where cod_func not in
			(select cod_func_fk from tblDependente1)