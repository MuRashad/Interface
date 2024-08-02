using ConsoleApp1.Interface2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface02
{
    internal class SeriesByThree : ISeriese
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }

        public void Reset()
        {
           Current = 0;
        }
    }
}
