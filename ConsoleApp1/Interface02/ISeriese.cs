using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface2
{
    public interface ISeriese
    {
        //signature for property 

        public int Current { get; set; }
        public void GetNext();
        public void Reset();

    }
}
