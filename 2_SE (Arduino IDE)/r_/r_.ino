/*
 * ferramentas -> monitor serial 
 * 
 * \r (da maquina de escrever, que coloca pra voltar)
 * \n (new line)
 * 
 * "nenhum final de linha" = não manda nem \r nem \n
 * "nova linha" = coloca um \n automaticamente
 * "retorno de carro" = só o \r
 * "ambos" = manda \n e \b
 * 
 * é melhor escrever no monitor serial e não mandar nada (nenhum final de linha)
 * - tem que mandar algum caracter especial para indicar fim de buffer (enche o balde e faz uma interrupção que manda pra uma variavel = Windows)
*/
