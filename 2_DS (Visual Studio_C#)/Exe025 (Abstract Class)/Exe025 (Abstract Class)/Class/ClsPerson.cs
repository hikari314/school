using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe025__Abstract_Class_.Class
{
    public abstract class ClsPerson
    {
        private string _itr;
        private string _name;
        private string _address;

        public string Itr { get => _itr; set => _itr = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }

        public ClsPerson()
        {
            _itr = "";
            _name = "";
            _address = "";
        }

        public abstract string Add();

        public string Delete()
        {
            return "Data excluded with success";
        }
    }
}
