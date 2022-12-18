using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe022__POO___OOL_
{
    class ClsClassified
    {
        //private int[] classified = {10514, 30343, 8240, 3125, 50525, 23289, 7310, 9281, 49524, 33001};
        private int[] classified = new int[10];
        private int numRegister;

        public ClsClassified()
        {
            classified[0] = 10514;
            classified[1] = 30343;
            classified[2] = 8240;
            classified[3] = 3125;
            classified[4] = 50525;
            classified[5] = 23289;
            classified[6] = 7310;
            classified[7] = 9281;
            classified[8] = 49524;
            classified[9] = 33001;
        }

        public int NumRegister { get => numRegister; set => numRegister = value; }

        public string Check()
        {
            for (int x = 0; x <= 9; x++)
            {
                if (classified[x] == NumRegister)
                {
                    x++;
                    return "Congratulations! You are classified in the " + (x + 1).ToString() + "° position!";
                }
            }

            return "Wait for the next registration!";
        }
    }
}
