using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe024___Budget__OOP_
{
    class ClsCalculate
    {
        decimal _value = 0;

        public decimal Value { get => _value; set => _value = value; }

        public ClsCalculate()
        {
            _value = 0;
        }

        //pagar a vista
        public string CalculateValue()
        {
            decimal valueInstallments = (_value * 85) / 100;
            string text = "The total price of the budget with discount is " + valueInstallments.ToString("C2");
            //o C2 exibe no formato de dinheiro
            return text;
        }

        //pagamento parcelado
        public string CalculateValue(int numInstallments)
        {
            decimal valueInstallments = _value / numInstallments;
            string text = "The price will be shared in " + numInstallments + " installments of " + valueInstallments.ToString("C2");
            return text;
        }
    }
}
