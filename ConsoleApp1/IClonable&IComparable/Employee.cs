using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IClonable
{//there is another way before we skip this point in the abcoming days will speak about , this way is 
    //copy constructor 
    public class Department:ICloneable
    {
        public string DepName { get; set; }
        public int DepId { get; set; }

        public object Clone()
        {
            return new Department()
            {
                DepName = this.DepName,
                DepId = this.DepId
            };
        }

        public override string ToString()
        {
            return $"Department Name is {DepName} and the Id of Deparment is {DepId}";
        }
    }
    public class Employee :ICloneable,IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        //Aggregation Relationsahilp 
        public Department EmpDepartment { get; set; }
        public object Clone()
        {
            return new Employee()
            {
                Name = this.Name,
                Age = this.Age,
                Id = this.Id,

                EmpDepartment = (Department)this.EmpDepartment.Clone()
            };
        }

        public int CompareTo(object? obj)
        {
            Employee ParamEmployee = (Employee)obj;

            if(this.Id < ParamEmployee.Id)
            {
                return -1;
            }
            else if(this.Id > ParamEmployee.Id)
                return 1;
            else 
                return 0;
        }

        public override string ToString()
        {
            return $"the name of Employee is {Name},the Age of Employee is {Age} , the Id of Employee is{Id} and also this is the Department: {EmpDepartment}";
        }
    }
}
