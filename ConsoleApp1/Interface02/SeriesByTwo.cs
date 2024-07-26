﻿using ConsoleApp1.Interface2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface02
{
    public class SeriesByTwo : ISeriese
    {
        private int current;

        public int Current
        {
            get { return current; }
            set { current = value; }
        }
        public void GetNext()
        {
            Current += 2;
        }

        
        public void Reset()
        {
            Current = 0;
        }

    }
}
