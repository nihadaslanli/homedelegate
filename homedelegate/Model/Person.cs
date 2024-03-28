using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homedelegate.Model
{
    internal class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Surname:{Surname} Adress:{Adress}Salary:{Salary}";
        }
    }
}
