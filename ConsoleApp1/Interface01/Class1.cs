using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface01
{
    internal class Rect:IMyType
    {
        public int x;
        public int y;

        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MyFunc()
        {
            throw new NotImplementedException();
        }

        public int sum()
        {
              return x + y;
        }
    }
}
