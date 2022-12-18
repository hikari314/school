using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao3
{
    class ClsCalcular
    {
        private double _num;
        private string _show;
        
        public double Num
        {
            set
            {
                _num = value;
            }
        }

        public void Check()
        {
            if (_num <= 1)
            {
                _show = "Não é primo";
                return;
            }

            Double resto;

            for (int i = 2; i< _num; i++)
            {
                    resto = _num % i;

                    if(resto == 0)
                    {
                        _show = "Não é primo";
                        return;
                    }
            }

            _show = "É primo";

        }

        public string Show{ get => _show; }

        public ClsCalcular()
        {
            _num = 0;
            _show = "";
        }

    }
}
