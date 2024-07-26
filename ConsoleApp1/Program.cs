using ConsoleApp1.Interface;
using ConsoleApp1.Interface01;
using ConsoleApp1.Interface02;
using ConsoleApp1.Interface2;
using System.Drawing;

namespace ConsoleApp1
{
    public class Program
    {
        public static void PrintSeries(ISeriese series)
        {
            for (int i = 0; i < 10; ++i) {
                if (series == null)
                    return;

                Console.Write($"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Ex01
            //IMyType TypeA = new MyType();
            //MyType TypeB = new MyType(); 
            #endregion

            #region Ex02
            //SeriesByTwo series = new SeriesByTwo(); 
            //SeriesByThree series02 = new SeriesByThree(); 
            //PrintSeries(series);
            //PrintSeries(series02);//invalid
            //ISeriese series03 = new SeriesByTwo();
            //PrintSeries(series03);
            //ISeriese seriese=new SeriesByThree();
            //PrintSeries(seriese); 
            #endregion
        }
    }
}
