using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface03
{
    internal class Car : vehicle, IMovable
    {
        public void Backword()
        {
            throw new NotImplementedException();
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
