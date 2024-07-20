using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_opp.ICloneable_Interface
{
    internal class Employee :ICloneable ,IComparable
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                Id = Id,
                Name = Name,
                Salary = Salary
                
            };
        }

        public int CompareTo(object? obj)
        {
            Employee passedemployee=(Employee)obj ;
            if (this.Salary > passedemployee.Salary)
                return 1;
            if(this.Salary < passedemployee.Salary)
                return -1;
            else
                return 0;

        }

        public override string ToString()
        {
            return $"ID={Id},Name:{Name},Salary={Salary}";


        }
    }
}
