using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe025__Abstract_Class_.Class
{
    public class ClsStudent : ClsPerson
    {
        private string _course;
        private string _class;

        public string Course { get => _course; set => _course = value; }
        public string Class { get => _class; set => _class = value; }

        public ClsStudent()
        {
            _course = "";
            _class = "";
        }

        public override string Add()
        {
            return "Student data included with success:\n"
            + Itr + " \n"
            + Name + "\n"
            + Address + "\n"
            + Course + "\n"
            + Class;
        }
    }
}
