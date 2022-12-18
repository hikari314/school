using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe022__POO___OOL_
{
    class ClsOperacao
    {
        //sempre quando comeca, usa os 4 passos para fazer a classe | _valor -> o underline sabe que é private

        //DECLARACAO DOS ATRIBUTOS (VARIAVEIS) E DOS GET E SET
        private int _value1;    //1) Declara as variaveis
        private int _value2;    //faz private para proteger dos "vandalos" | o programa principal n consegue ver essas, só as outras embaixo

        //2) Criar o get e set (liga o programa principal para a classe - se não quiser deixar os valores aberto pros outros, não coloca o get e set)
            //o Visual cria, só aperta no campo e coloca ações e depois encapsula (primeira opção):
        public int Value1 { get => _value1; set => _value1 = value; } //aqui virou maiusculo
        public int Value2 { get => _value2; set => _value2 = value; } //set(manda info) -> manda pro value1 | get(busca info) -> só pega do value1 pra Value1

        //3) Metodo Construtor (mesmo nome da classe):
        public ClsOperacao()
        {
            _value1 = 0;
            _value2 = 0;
        }

        //4) Criar o Metodo de Somar (passa os dois valores pelo get e set):
        public int Add()
        {
            return _value1 + _value2;
        }

        //o que tiver de processamento, deixa pra classe
    }
}
