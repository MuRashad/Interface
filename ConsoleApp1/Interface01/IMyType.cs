using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{ 
    //you can write just in namespace Access Modifier internal and public 
    internal interface IMyType
    {
        //Default Access Modifier inside interface =>public ;
        //private not allowed in interface 
        //what i can write in interface 
            //=>>signature for property
            //==>signature for methode 
            //==>Default implemented methode  
        //this property internal  interface we call it signature for property
        //but in Class or struct we call it Automatic property 
        public int Age { set; get; }

        //signature for methode 
        public void MyFunc(); 
        
        //default signature methode 
        public void Print()
        {
            Console.WriteLine("this is the default implemented methode in interface");
        }
    }
}
