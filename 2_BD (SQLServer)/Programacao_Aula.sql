--PROGRAMAÇÃO
/*O SQL é uma linguagem de programação. 

- DECLARAR VARIAVEIS 
Uma variavel local é um objeto nos scripts que mantem um determinado valor. 

	Declare @variavel tipo   | @variavel -> nome de uma variavel, tem que ter o @ antes | tipo = definicao do tipo de dado e tamanho

Pode jogar o conteudo de um select dentro de uma variavel*/


--Declaração de Variavel: (os tres jeitos estao certos)
Declare @a int = 1

Declare @b int = 1, @c int = 2

Declare @d int, @e int
Select @d = 3
Select @e = 4

Declare @f int, @g int
Set @f = 5
Set @g = 6

-- PRINT (mostra o conteudo da variavel)
Declare @h int = 1
Print @h 

/*No sql nao usa chava nem parenteses, so coloca begin e end:
	BEGIN...END => Usados pra iniciar e finalizar um bloco de comando

	If...Else => Usado para testar condicoes quando um comando e executado

	IF condicao_um			IF condicao_um			IF condicao_um
		acao_um					acao_um					acao_um
							ELSE					ELSE IF condicao_dois
								acao_dois				acao_dois
*/

--Exemplo 1
Declare @m int = 1, @n int = 2		--se nao for satisfeito, nao vai aparecer nada no retorno
If @m > @n							
	Begin
		Print @m
		Print 'é maior que'
		Print @n
	End

--Corrigindo o exemplo
Declare @p int = 1, @q int = 2	
If @p > @q							
	Begin
		Print @p
		Print 'é maior que'
		Print @q
	End
Else
	Begin 
		Print @p
		Print 'não é maior que'
		Print @q
	End
Print 'Continua'

--Exemplo 2 (usar o banco programacao)
--Se o funcionario de codigo 1 tiver 50 anos ou mais, aplique um aumento salarial de 50%

if (select Idade_Func from Funcionario where Cod_Func = 1) >= 50
	Begin
		update Funcionario set
		Sal_Func = Sal_Func * 1.5 where Cod_Func = 1
	End

--Exemplo 3 (--)
--Se o funcionario de codigo 1 tiver 50 anos ou mais, aplique-lhe um aumento salarial de 50%. Caso contrario, aplique para o funcionario um aumento salarial de 40%
IF (select Idade_Func from Funcionario where Cod_Func = 1) >= 50
	Begin 
		Update Funcionario set Sal_Func = Sal_Func * 1.5 where Cod_Func = 1
ELSE
		Update Funcionario set Sal_Func = Sal_Func * 1.4 where Cod_Func = 1


--Exemplo 4 
--Se o func de codigo 1 tiver 50 anos ou +, aplique um aumento de 50%. Se ele tiver entre 40 e 49 anos, aplique um aumento de 40%
Declare @idade Tinyint 
Select @idade = Idade_Func from Funcionario where Cod_Func = 1
IF @idade >= 50
	Begin
		update Funcionario set Sal_Func = Sal_Func * 1.5 where Cod_Func = 1
	ELSE IF @idade BETWEEN 40 and 49
		update Funcionario set Sal_Func = Sal_Func * 1.4 where Cod_Func = 1
	End

/*CASE
Ele analisa o valor de uma variavel ou coluna de tabela co mrelacao a uma lista de condicoes e retorna um dos resultados dessa lista. 
Ele evita que sejam utilizados varios comando if's alinhados
Exemplo no banco EMPRESA

datedepart -> pega uma parte da data, o nome do dia da semana nesse caso (weekday)
*/

select codFun, Nome, DataNasc,
	Case DATEPART(weekday, DataNasc)
		When 1 then 'Domingo'
		When 2 then 'Segunda'
		When 3 then 'Terca'
		When 4 then 'Quarta'
		When 5 then 'Quinta'
		When 6 then 'Sexta'
		When 7 then 'Sabado'

/*WHILE
Faz com que um comando ou bloco de comandos SQL seja executado repetidamente, ou seja, cria-se uma repeticao do comando que sera executado enquanto a condicao for verdadeira
*/

Declare @i int = 0
While @i <= 10
	Begin 
		Print @i
		Set @i += 1
	End

Declare @dezena int, @k int = 0
	While @k < 6
		Begin 
			Set @dezena = 60 * rand()
			Print @dezena
			Set @k += 1
			-- set @k = @k + 1
		End
Print 'Boa Sorte!!'

/*STORED PROCEDURE (sao as functions)
É uma colecao nomeada de comandos SQL que é armazenada no servidos (compiladas)
Não pode criar uma procedure dentro da outra nem DEFAULT, RULE, TRIGGER ou VIEW. 
-tipos de procedure
USP -> procedure criada pelo usuario (coloca sempre na frente quando criar)

USE NwindAcces

o "AS" indica que a PROCEDURE vai começar, não tem nada a ver com APELIDO!

- com parametro
A única diferença pra variavel é que não precisa do declare | Não é uma variavel, mas declara como uma | Depois da clausula AS vem as variaveis
*/