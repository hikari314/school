/* para fazer coment�rio � assim, e para coment�rio de uma linha �: -- */
-- aqui em um linha só --

create database aula01 -- é para criar o banco, nunca muda | CRIAR --
use aula01 -- é para colocar em uso | quando dá erro, seleciona a linha e executa ela (esse erro de o nome do banco j� ser existente) | COLOCAR EM USO --

drop database aula01 -- drop database <nome banco> = � para apagar o BD dentro de um SGBD | APAGAR --
use master -- abre o master, ai para apagar o banco, executa essa linha e depois executa o drop database | para recuperar o banco, s� executa a linha de cria��o do banco --

--CONSTRAINTS: sao regras de integridade do BD: PK, FK, chave unica, regras de validacao e valor padrao--

/*TIPOS DE DADOS - Numéricos: 
Tinyint - de 0 a 225
Smallint
Int
BigInt
Decimal (p,s)
Numeric, Float, Real

- Binários:
Bit = valor de número inteiro com o valor 1 ou 0;
Binary (n)
Varbinary(n)
Varbinary(max)

- Data e hora:
Date = data entre 01/01/01 e 31/12/9999;
Datetime = data e hora entre 01/01/1753 e 31/12/9999;
Smalldatetime = data e hora entre 01/01/1900 e 06/06/2079;
Time

- Strings:
Char (n) = comprimento fixo de no máximo 8000 caracteres. É mais rápido 
	nome_cliente char(100) - foi utilizado 50. Gastara o tamanho de 100 e nada será devolvido
Varchar = mesmo comprimento fixo, mas é mais lento e economiza nos digitos
	nome_cliente varchar(100) - foi usado 50, vai devolver os 50 restantes não utilizados

- Constraints:
Not null = coluna não aceita valor nulo;
Default = valor padrão para uma coluna da tabela:
	Quantidade int default 1
Unique = força a coluna a ter valores unicos, não pode haver 2 registros com um mesmo valor:
	CPF numeric (11) unique
Check = limita os valores que serão recebidos por uma coluna, através do teste de uma condição:
	Salario dec(7,2) check (salario <= 20000.00)
Primary Key = cria a PK (coluna cujo valor deve ser único);
Foreign Key = vinculam duas tabelas em um BD exigindo que os dados nas colunas sujeitas à restrição contenham valores armazenados nas colunas de PK da tabela relacionada;
Identity = indica que um campo terá um valor unico incremental automaticamente gerado eplo sistena tida vez que um novo registro for incluido:
	id_num int IDENTITY (1,1) primary key
*/

-- cria��o de uma tabela: --
create table Tipo (
	Codigo int not null primary key, -- virgula separa os campos, n�o usa ponto e virgula--
	Nome varchar(30) not null)

-- cria��o de uma tabela com chave prim�ria composta de 2 campos: --
create table totalfaturado(
	mes int not null,
	ano integer,
	valor decimal (12,2),
	primary key (mes, ano)) -- converte o mes e o ano em chave prim�ria, por isso essa linha fica aqui --

-- tabela com chave estrangeira --
create table secao (
	codigo int not null primary key,
	descricao varchar(20) not null,
	coddepto int foreign key references
		departamento (codigo) -- d� erro porque a tabela departamento n�o existe, tem que criar a tabela antes onde o dep. � chave prim�ria  --
)

-- tabela com restri��o de preenchimento de campos --
create table animal (
	codigo int not null primary key,
	nome varchar(40) not null,
	sexo char(1) check(upper(sexo) = 'm' or upper(sexo) = 'f'))

-- tabela com algumas regras de intregridade --
create table tblfuncionario ( -- sempre usa a abrevia��o tbl quando cria tabela--
	codfunc int identity,
	nomefunc varchar(50),
	rgfunc char(15),
	sexofunc char default 'f',
	salfunc dec(10,2) default 240.00,
	constraint pk_func primary key(codfunc), -- desse jeito � o mais usado, porque coloca a regra(constraint), atribui o nome da regra (pk_func) e descreve ela --
	constraint uq_func unique(rgfunc),
	constraint ck_func1 check(sexofunc in ('f', 'm')), -- t� falando que os dois unicos valores possiveis: f e m --
	constraint ck_func2 check(salfunc > 0)) -- a �ncia restri��o � que o sal�rio n�o pode ser menor que 0, n�o tem limite --

/*se voc� colocar o "go" entre comandos, essa clausula vai for�ar a executar o comando debaixo (se tiver certo, claro) - 
mas ai voc� s� coloca o cursor na primeira linha e o resto vai sozinho, n�o precisa selecionar o c�digo todo - o exemplo t� no ExeVeiculo*/

/*INDICE: o indice facilita a busca de informa��es, j� que vai ter uma marca��o "indice" na tabela - afun��o principal � ajudar na pesquisa dentro do BD 
| Create index Xcliente (nome do index - X � de index - d� para saber que � da tabela cliente) on cliente (idCliente) (pode colocar at� 16 campos dentro dos parenteses)
| cria o indice depois de criar a tabela - Exemplo nos ExeSQL*/

/*INSERT: vai inserir valores | se tiver um campo "identity", vai autom�tico, ent�o pula esse campo 
| se o campo for not null, tem que colocar obrigatoriamente no insert 
| o "into Cliente", esse into � opcional: Insert into Cliente ou Insert Cliente |
mais de um valor dentro do mesmo insert:
INSERT CLIENTE (COD_CLI, NOME_CLI) VALUES
(1, 'ANA'),
(2, 'LRS'),
(3, 'BIA')*/

create table tblClientes (
	idcliente int not null primary key,
	nomecliente varchar(50))
go
create index XtblClientes on tblClientes (idcliente, nomecliente)
go

Insert into tblClientes (idcliente, nomecliente) values
	(1, 'Ana'),
	(2, 'Beatriz'),
	(3, 'Clara')

go
Insert tblClientes values 
	(4,'Fernanda'),
	(5,'Kayle'),
	(6,'Olivia')

/*SELECT - recuperar um dado de dentro do banco | verifica se o login ou a senha existem no banco, e se existirem, quando clicar em entrar d� acesso ao sistema
| o bot�o entrar � feito de C# ou ASPX ou PhP + SQL (select)
Exe1: select CodCidade, NomeCidade from tblCidade (campos especificos); 
Exe2: select * from tblCidade (* = todos os campos); 
Exe3: SELECT NomeCidade FROM Cidade
		WHERE CodCidade > 4 AND CodCidade < 8 (o WHERE � o filtro, reduz o codigo em uma linha s� que tem o filtro | como � AND, as 2 situa��es tem que ser verdadeiras)
	  SELECT login, senha FROM Aluno
		WHERE login = lrs AND senha = 123 (se colocar o OR ali no lugar do AND, se fosse um invasor, poderia entrar, por isso login tem que ser AND)
	  Select ([colunas]) from [tabela] where ([condi��es])*/

/*Order by (dentro de select)
	Select nome, endere�o, from alunos order by nome (como n�o colocou nada, a ordem � ascendente, que � ASC: de A - Z)
	Select idCliente, Nome, Fone fro mclientes where IdCliente >= 5 order By IdCliente DESC (DESC � de A - Z, seria do ultimo valor at� o primeiro)*/

Select idcliente from tblClientes 
	where nomecliente = 'Ana' AND idcliente = 1

Select nomecliente from tblClientes
	where idcliente = 1

Select nomecliente from tblClientes order by nomecliente
Select nomecliente from tblClientes order by idcliente DESC
Select idcliente from tblClientes order by idcliente DESC

/*Top (dentro do select) - limitar a quantidade de registros que ser�o mostrados pelo SELECT
	Select top 3 * from authors (s� vai aparecer as 3 primeiras linhas da tabela)
	Select top 3 * from authors, where turma = 'B'
	Select top 3 * from authors order by id DESC (vai pegar os 3 �ltimos registros)
*/

Select top 4 * from tblClientes
Select top 2 * from tblClientes order by idcliente desc

/*Distinct (dentro do select) - exclui os valores repetidos (ele n�o vai excluir nada, ele s� n�o vai exibir) | s� pode ter um Distinct por select */
--criar exemplo--


/*ALTER TABLE - altera estrutura/campo, N�O valor
- Adicionar campo:
	Alter table vendedor add email varchar(50)

- Adicionar uma constraint:
	Alter table pedido add constraint fk-pedido_cliente foreign key
	(codigo_cliente) references cliente (codigo_cliente) - (o campo j� tem que existir na tabela, tem que ser um campo comum que voce est� mudando para FK)

- Alterar o tamanho do campo:
	Alter table empregados alter column primeiroNome varchar (100)

- Remover uma coluna:
	Alter table empregados DROP COLUMN sexo - (remove campo comum, n�o vai remover PK)*/

Alter table tblClientes add email varchar (20)

/*OPERADORES:
	Igual =
	Nega��o |
	Maior >
	Menor <
	Diferente <> ou !=
	N�o maior !> (menor)
	N�o menor !< (maior)
	Entre Between...And
	Compara��o especial Like
	Compara��o de lista In([lista])

	In (lista de valores como condi��o - pode usar o NOT = NOT IN (2, 3, 4))
		select * from cidade wehre NomeCidade IN ('Bonito'), 'Dourados') - (s� vai me mostrar os dados dessas duas cidades)

	BETWEEN (define faixa de valores como condi��o - pode usar o NOT tamb�m)
		select * from cidade where CodCidade BETWEEN 3 AND 6 (vai mostrar 3, 4, 5 e 6)

	IS NULL (identifica valores nulos no BD)
		select * from cidade where CodCidade IS NULL (o que n�o est� preenchido)
		select * from cidade where CodCidade IS NOT NULL (que est� preenchido)

	Like
	select * from empregado where nomeinc like 'a%' (todos os nomes que come�am com a letra a, n�o importa os outros) - (% - uma ou mais posi��es, substitui varias caracteres - like %LI% - que contenha LI em qualquer posi��o)

	select * from empregado where nomeinc like '%ce' (termine em 'CE', n�o sabe o que tem antes nem a quantidade)

	select * from empregado where nomeinc like '_o___' (tem 5 posicoes e só sabe a segunda (_ = uma posicao s�, substitui um unico caracter 
	| se colocasse a porcentagem antes e depois, assim %o%, o O viria em qualquer posicao 
	| %o_ - n�o sabe as primeiras, mas sabe a penultima))

	select nome from empregado where nome like '[D_F]%' (qualquer nome que comeca entre o intervalo de D e F = D, E, F)

	select nome from empregado where nome like '[^A-C]%' (que n�o comece com as letras desse intervalo, o circunflexo � o negativo)

	select nome from empregado where nome like '[A-C, F-G]%' (que comece A, B ou C ou ent�o, F ou G) */


/*UPDATE: atualiza o conteudo de um campo | aqui mexe nos valores, não nos campos como o alter table | têm que especificar, se não TODOS MUDAM | para a alteração de sneha, por exmeplo, usa o update + programação
	Update alunos SET nome_turma = '3° Info A' (set é pra mudanca e atribuição de valores)
		where codcurso = 1
	(todo aluno com codigo 1 vai receber esse nome)

	Update funcionarios SET salario = salario * 1.1 (primeiro o nome da tabela e depois o campo -> Update TABELA set CAMPO ... WHERE)
		where depto between 1 and 5
	(aumento dew 10% para os setores de 1 a 5 da empresa)*/

	
/*FUNÇÕES AGREGADAS = retornam dados estatisticos do banco de dados | só funciona pra campo tipo NUMERO

	- Avarage(AVG): AVG(NOMECAMPO) from NOMETABELA = retorna a média aritmetica de uma coluna 
		Select avg(salario) from cadfun
		Select avg(distintic salario) from cadfun | se tiver dois salarios 1000, só vai pegar um pra fazer a média, só pega valores únicos
		Select avg(salario) fro mcadfun where depto = 3

	- Count() = conta a quantidade de registros de determinada coluna/linhas | retorna o valor numerico inteiro de um campo | conta campos preenchidos
		Select count(*) from cadfun where depto in (3,5) | só conta desses departamentos: 3, 4 e 5
		Select count(filhos) from cadfun
		Select count(*) from cadfun where salario > 2000

	- Max() = retorna o maior valor de uma coluna (só retorna um valor)
		Select Max(salario) fro mcadfun

	- Min() = retorna o menor valor de uam coluna (aqui tbm só retorna um valor)
		Select Min(salario) fro mcadfun 

	- Sum() = retorna o resultado de uam soma de uma coluna | 
		Select Sum(filhos) from cadfun
		Select Sum(salario) from cadfun
		Select Sum(salario) from cadfun where depto in (3,5)

		ID | FILHOS   =>	Select count(filhos) from cadfun	=	3   (quantidade de funcionarios que tem filhos)
		1	2		  =>	Select sum(filhos) from cadfun		=	6   (quantidade de presentes que precisa compra)
		2	3
		3	-			(aqui não conta pq o numero de filhos deveria ser maior que 0, se tivesse colocado 0, ia contar no COUNT = 4 e NÃO pode receber o 0 pq ele tem valor)
		4	1
*/

/*AGRUPAMENTO DE RESULTADOS (ultima parte do select)
	A clausula Group By agrupa linhas de uma tabela com base nos  valores de determinadas colunas
		- Select depto, count(*) as quantidade from cadfun  
			group by depto

		DEPTO | QUANTIDADE
		 1		 10
		 2		 30
		 3		 5
		 4		 5

		- Select depto, sum(salario) as 'Salario Total' from cadfun | não pode ter espaço, mas se quiser coloca entre aspas duplas ou coloca _
			group by depto

		DEPTO | SALARIO TOTAL								(having é a mesma coisa que where)
		 1		 50000
		 2		 29000
		 3		 15000
		 4		 50000

		 - Select codMusica, count(*) from musicaAutor group by codMusica having codMusica < 15		(primeiro agrupa e depois verifica/pergunta, se atender permanece agrupa e se não atender descarta)
		 - Select codMusica, count(*) from musicaAutor where codMusica < 15 group by codMusica		(pergunta primeiro e depois agrupa)
		 -> as duas de cima chegam na mesma conclusão
		 -> como não tem "as", vai ficar assim:
			codMusica | coluna sem nome
				1			1
				2			1
				3			1
				.			1
				.			1
				.			1
				14			1
*/

--OBS: b(com risquinho), 0 e NULL são DIFERENTES
/*branco = não digitou nada, já que cada tecla tem um valor e ele vai ser armazenado se digitar
0 = vai armazenar o valor 0, então deve tratar de armazenar o zero
null = "não aceitada nada" ou digitar incorretamente */

/*SQL é relacionado a Objeto ^ e C# e ASPX é Orientado a Objetos, ai precisa orientar a objetos ai se fazem adequações para que a linguagem trabalhe bem com o banco de dados
	AQUI é sempre dentro do BANCO

		Pessoa	(G)				-  o comum a PF e PJ colcoa aqui, pór exemplo ID, NOME, END, TEL
		^	 ^						- as setas são que PF e PJ herdam tudo da classe PESSOA, ou seja, Pessoa é a classe Pai e PF E PJ são classes Filhos 
	PF(E)		PJ(E)					| em BD, Pessoa é genérico e PF e PJ são especificos
										| de cima pra baixo é Especificação e de baixo pra cima é Generalização
										|uma pessoa nunca vai poder ser PF e PJ ao mesmo tempo 

- PJ = é uma empresa, logo o que é especifico dela é o CNPJ, INSCRIÇÃO ESTADUAL...
- PF = agora as especifidades aqui são CPF, RG... 

-> Se faz Especialização => uma entidade que é um subconjunto de uma outra entidade. É um processo para classificar o conjunto de entidades em conjunto de entidades especializadas
-> Se tem Generalização => é o processo inverso da especialização. Uma entidade é superconjunto de uma outra
*/

--!OBS.: NÃO APAGA REGISTRO DE BANCO, SE DESATIVA/INATIVA (não perde nada, porque se apagar, perde TODOS os registros)

/*SUBQUERIE - select dentro de outro
	O retorno de um select serve pra outro
	Só retorna UMA coluna/campo e sempre coloca entre parenteses

	- Subqueries com IN

		SELECT * FROM CARGO
			WHERE COD_CARGO IN								- vai fazer de trás pra frente
				(SELECT COD_CARGO FROM FUNCIONARIO)			- aqui retorna, por exemplo: (1,2,3)
		|aqui vê quais cargos tem funcionario


		SELECT * FROM CARGO
			WHERE COD-CARGO IN
				(SELECT COD_CARGO FROM FUNCIONARIO
					WHERE COD_FUNC IN
						(SELECT COD_FUNC FROM DEPENDENTE))
		|todos os cargos de todos os funcionarios que tem dependente


		SELECT * FROM CARGO WHERE COD_CARGO
			NOT IN (SELECT COD_CARGO FROM FUNCIONARIO)
		|cargos que não tem funcionario, ou seja, o inverso do primeiro


		SELECT * FROM FUNCIONARIO
			WHERE SAL_FUNC=
				(SELECT MAX(SAL_FUNC) FROM FUNCIONARIO)
		|mostra todos os dados do funcionario que tem salario = maior salario


		SELECT * FROM FUNCIONARIO WHERE SAL_FUNC =
			(SELECT MIN(SAL_FUNC) FROM FUNCIONARIO WHERE COD_FUNC IN		->AQUI
				(SELECT COD_FUNC FROM DEPENDENTE))							->E AQUI tem que ser o mesmo campo (cod_func)
		|funcionario que possu dependente e depois que tem o menor salario (tem que ter os dois, dependente e menor salario)

		SELECT *,
			(SELECT COUNT(*) FROM DEPENDENTE
				WHERE COD_FUNC = FUNCIONARIO.COD_FUNC) AS	- compara o codigo do funcionario da tabela funcionario for igual ao codigo do dependente da tabela funcionario, e só se eles forem iguais, ai conta
					QTD_DEP FROM FUNCIONARIO
		|esse subquery retorna uma quarto campo:
			* = c1, c2, c3 e ai * = c1, c2, c3 , QNT_DEP


	- Subqueries com NOT
*/

/*FUNCOES DE DATA 
	Getdate() - retorna a data e a hora atual do sistema | select getdate()*/
	select getdate(); --nao precisa estar dentro do banco
	
	create table TblEg(
		data_cadastro date default getdate())  -- aqui vai armazenar a data do sistema (dá pra fazer com cadastro, inscricao mas nao com data de nascimento

/*  retornam o dia, o mes ou o ano de uam data especifica, separados.
	Day() - select nome,day(dataNascto) from funcionario
	Month() - select nome,month(dataNascto) from funcionario
	Year() - select nome,year(dataNascto) from funcionario
	
	DateAdd() - soma dias, meses ou anos a uma data especifica
	select dateadd(day, 5, dataNascto) from funcionario --adicionando 5 dias a data de nascimento

	DateDiff() - quer saber a idade da pessoa, faz a diferenca em dias (quando dias a pessoa viveu em relação ao dia atual | pedido com atraso)
	select datediff(day, dataNascto, getdate()) from funcionario --se quiser aprecer anos, troca o day por year e assim vai

	DateName() - mostra o nome do dia da semana que a pessoa nasceu 
	select datename(weekday, dataNascto) from funcionario
*/

/*JOINS
	Join é uma cláusula que permite a associacao entre varias tabelas, com base na relacao existente entre elas. Por meio dela os dados de uma tablea sao
	utilizados para selecionar dados pertencentes a outra tabela:
		...from<nome primeira tablea><tipo join><nome segunda tabela>[on <condicao | define um criterio para avaliar as duas linhas de dados ja associados>]

	Só usa com PK e FK com tabelas relacionadas | Se não forem relacionadas, tem que unidr tabelas (A com B e depois B com C)
	Sempre vai ter ON 
	A PK tem que ser igual a FK

- Inner Join
Por meio dessa cláusula os registros COMUNS de duas tabelas sao utilizados para que sejam gerados os dados relacionados de ambos:

	INNER JOIN tableaB as B				    Nome | Nome						-- a.Nome é a PK de A e b.Nome é a FK que está relacionada com B => A.IDA_A = B.ID_A FK
		ON a.Nome = b.Nome			1     Luiz      Luiz
									2	Fernando  Fernando
	
- Left Join (A interseccao B)
Todos os registros que estão na tabelaA (mesmo que não estejam na tabelaB) e os registros da tabelaB que sao comuns na tabelaA:
	
	Select a.Nome, b.Nome from tabelaA as A
	LEFT JOIN tabelaB as B					Nome | Nome						--vai pegar a tabelaA e da interseccao 
		ON a.Nome = b.Nome				Fernanda    NULL
										Josefa      NULL
										Luiz	    Luiz					--A Fernanda e a Josefa estao NULL porque sao especificamente do A (apenas do A)
										Fernando    Fernando

- Right Join
Todos os registros que estao na tabelaB (mesmo que nao estejam na tabelaA) e os registros da tabelaA que sao comuns na tabelaB

	Select a.Nome, b.Nome from tabelaA as a			Nome | Nome
		RIGHT JOIN tabelaB as B						NULL   Carlos
			ON a.Nome = b.Nome						NULL   Manoel
													Luiz   Luiz
													Fernando Fernando

--Só muda, ai vai pegar tudo que for comum e tudo especifico da tabela B (pegar foto)
--Se der erro, troca e tenta Left e vice-versa

- Outer Join
Todos os registros que estao na tabelaA e na tabelaB
	Select a.Nome, b.Nome from tabelaA as A
		FULL OUTER JOIN tabelaB as B			--Vai pegar tudo de A, tudo de B e tudo da interseccao 
			ON a.Nome = b.Nome

	Select a.Nome, b.Nome from tabelaA as A 
		FULL JOIN tabelaB as B
			ON a.Nome = b.Nome

-Left Excluiding Join
Neste caso, todos os registros que estao na tabelaA e que nao estejam na tabelaB | só vai estar no A, nao tem interseccao, e é mais facil com select mesmo

	Select a.Nome, b.Nome from tabelaA as A
		LEFT JOIN tabelaB as B
			ON a.Nome = b.Nome
				where b.nome IS NULL

- Cross Join
Exibe o produto cartesiano de duas tabelas | Quer ver tudo que tem nas duas tabelas (Nome do produto e suas categorias)

  tblA = 5 registros  - vai ter 25 linhas
  tblB = 5 registros  -

  Select distinct C.Descr, P.Descr
	from Categorias C CROSS JOIN Produtos P

Se for, por exemplo, uma tabela de 1000 linhas e outra 10000, pode travar o banco porque vai ficar gerando uma lista gigantesca
*/
