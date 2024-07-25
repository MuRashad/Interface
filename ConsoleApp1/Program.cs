using ConsoleApp1.Interface;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMyType TypeA= new MyType();
            MyType TypeB= new MyType();
            TypeA.Print();
           
        }
    }
}
