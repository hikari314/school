using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao3BIM
{
    class Calc
    {
        private double _nota1;
        private double _nota2;
        private double _media;
        private string _resultado;

        public double Nota1
        {
            set{
                if (value >= 0 && value <= 10)
                    _nota1 = value;
                else
                    throw new Exception("Atenção: Nota 1 fora do intervalo!!");
            }
        }

        public double Nota2
        {
            set{
                if (value >= 0 && value <= 10)
                    _nota2 = value;
                else
                    throw new Exception("Atenção: Nota 2 fora do intervalo!!");
            }
        }

        public double Media { get => _media; }
        public string Resultado { get => _resultado; }

        public Calc()
        {
            _nota1 = 0.0;
            _nota1 = 0.0;
            _media = 0.0;
            _resultado = "";
        }

        public void CalcularResultado()
        {
            _media = (_nota1 + _nota2) / 2;
            if (_media < 5)
            {
                _resultado = "Retido";
            }
            else
            {
                _resultado = "Promovido";
            }
        }

    }
}
