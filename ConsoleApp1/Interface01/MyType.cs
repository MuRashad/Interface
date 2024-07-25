using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal class MyType : IMyType
    {
        private int age;
        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        /// <summary>
        ///interface method and property
        /// </summary>
        public int Age { get { return age; } set { age=value; } }
        public void MyFunc()
        {
            Console.WriteLine("I have already signed the code contract with IMyType interface___!:)");
        }
    }
}
