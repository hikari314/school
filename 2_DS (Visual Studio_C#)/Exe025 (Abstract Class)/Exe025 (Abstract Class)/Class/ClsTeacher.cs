using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe025__Abstract_Class_.Class
{
    public class ClsTeacher : ClsPerson
    {
        private string _degree;
        private string _category;

        public string Degree { get => _degree; set => _degree = value; }
        public string Category { get => _category; set => _category = value; }

        public ClsTeacher()
        {
            _degree = "";
            _category = "";
        }

        public override string Add()
        {
            return "Teacher data included with success:\n"
            + Itr + " \n"
            + Name + "\n"
            + Address + "\n"
            + Degree + "\n"
            + Category;
        }
    }
}
