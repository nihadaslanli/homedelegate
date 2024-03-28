using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homedelegate.Model
{
    internal class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Salary { get; set; }

        public int Age { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
