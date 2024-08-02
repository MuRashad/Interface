using ConsoleApp1.IClonable;
using ConsoleApp1.Interface;
using ConsoleApp1.Interface01;
using ConsoleApp1.Interface02;
using ConsoleApp1.Interface03;
using ConsoleApp1.Interface2;
using System.Collections.Immutable;
using System.Drawing;
using System.Text;

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

            #region Explicite and Implicite implementation in interface
            /*acces modifier in Airplane is private
             * then i cannot access from class must to make refernce from interface point to a class
             * as well methode 2 reference has 2 methods points to a class 
             * this class implement the interface , then methods is accessible to be implemnted 
             */
            //IFlyable flyable = new Airplane();
            //IMovable movable = new Airplane();
            //flyable.Forward();
            //movable.Forward();

            #endregion

            #region Deep Copy and Shallow Copy to Array of integer => value type 

            //Deep copy and shallow copy 
            //=>clone is a shallow copy 
            //copy take a copy from original address
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine(Arr01.GetHashCode());
            ////shallow copy => Arr01 point to the address of Arr02
            //Arr02 = Arr01;
            //Console.WriteLine("this is a shallow copy..!");
            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine(Arr01.GetHashCode());

            //clone methode will generate new object 
            //with new and different ideintity 
            //unsafe casting ....
            //deep copy
            //Arr02 = (int[])Arr01.Clone(); //not boxing and not unboxing
            //Console.WriteLine("After deep copy ");
            ////clone will make new object has the same value of the array but different identity 
            ////if i change any value in one another has no effect at any one of them 
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            #endregion


            #region Deep Copy and Shallow Copy to Array of string => reference type 
            //Name01 will Make a reference will point to Array with 1 index have one value "Mustafa" 
            //string[] Name01 = new string[]{ "Mustafa" };
            ////Name02 will Make a reference will point to Array with 1 index have one value "Null" 
            //string[] Name02 = new string[1];

            //Console.WriteLine("print the address");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());
            ////let's take a shallow copy

            ////the reference of Name02 will have the same reference of Name01 as well both point to object"Mustafa" with same address 

            //Name02 = Name01;
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            ////our prdeiction that address is the same all will change "Mustafa" and become unreachable object then  both of them will have Wael the same value 

            //Name01[0] = "Wael";
            //Console.WriteLine("After Changing the value of Name01");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //let's see Deep copy 


            //Console.WriteLine("print the address");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());

            //Name02 =(string[]) Name01.Clone();
            //////the reference of Name02 will be differnct reference to Name01 as well the new referece will point to the same object   

            //Console.WriteLine("after deep copy");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            ////string is immutable as well if i change  the value of reference , string will generate new object"Samy" but refernce still the same 
            //Name02[0] = "Samy";
            //Console.WriteLine("after changing Name02");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #region StringBulider  
            //  StringBuilder[] Name01 = new StringBuilder[1];
            //  Name01[0] = new StringBuilder("Mustafa");
            //  StringBuilder[] Name02 = new StringBuilder[] {new StringBuilder("")};
            //  Console.WriteLine(Name01.GetHashCode());
            //  Console.WriteLine(Name02.GetHashCode());
            //  Console.WriteLine(Name01[0]);
            //  Console.WriteLine(Name02[0]);

            //  //after shallow copy 
            //  Name02 = Name01;
            //  Console.WriteLine(Name01.GetHashCode());
            //  Console.WriteLine(Name02.GetHashCode());
            //  Console.WriteLine(Name01[0]);
            //  Console.WriteLine(Name02[0]);

            //  //get the change of shallow copy 
            //  Name01[0].Append("Olaaa");
            //  Console.WriteLine(Name01.GetHashCode());
            //  Console.WriteLine(Name02.GetHashCode());
            //  Console.WriteLine(Name01[0]);
            //  Console.WriteLine(Name02[0]);
            ////---------------------------------------------------
            //  //after Deep copy 
            //  Name02 = (StringBuilder[]) Name01.Clone();
            //  Console.WriteLine(Name01.GetHashCode());
            //  Console.WriteLine(Name02.GetHashCode());
            //  Console.WriteLine(Name01[0]);
            //  Console.WriteLine(Name02[0]);

            //  //get the change of Deep copy 
            //  Name01[0].Append("Doaaa");
            //  Console.WriteLine(Name01.GetHashCode());
            //  Console.WriteLine(Name02.GetHashCode());
            //  Console.WriteLine(Name01[0]);
            //  Console.WriteLine(Name02[0]);
            #endregion

            #region Icloneable 

            //Employee Emp01 =new Employee()
            //{
            //    Name="Samy",
            //    Age=25 ,
            //    Id =1
            //};
            //Employee Emp02 =new Employee()
            //{
            //    Name="Ahmed",
            //    Age=30 ,
            //    Id =2
            //};
            //Console.WriteLine(Emp01.GetHashCode());
            //Console.WriteLine(Emp02.GetHashCode());
            //Emp02 = Emp01;//shallow copy 

            //Console.WriteLine(Emp01.GetHashCode());
            //Console.WriteLine(Emp02.GetHashCode());
            //Console.WriteLine(Emp01);
            //Console.WriteLine(Emp02);

            //i don't have the methode clone here in the class , the main purpose to Take another
            //reference from the same data of employee , so we need deep copy and need to implememtn Iclonable interface 
            //Employee Emp01 = new Employee()
            //{
            //    Name = "Samy",
            //    Age = 25,
            //    Id = 1,
            //    EmpDepartment = new Department()
            //    {
            //        DepName = "management",
            //        DepId = 2
            //    }

            //};
            //Employee Emp02 = new Employee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Id = 2,
            //    EmpDepartment = new Department()
            //    {
            //        DepName = "HR",
            //        DepId = 2
            //    }
            //};
            ////this is a deep copy , i have taken a new reference with the same data of the object if i need to change something has no effect to another 
            //Emp01 = (Employee)Emp02.Clone();
            //Console.WriteLine(Emp02);    
            //Console.WriteLine(Emp01);    
            //Console.WriteLine(Emp01.GetHashCode());    
            //Console.WriteLine(Emp02.GetHashCode()); 
            //Console.WriteLine(":):):):):)):):)::):):):):)):)\n");
            //Emp02.Name = "Doaa";
            //Emp02.Age = 10;
            //Console.WriteLine(Emp02);
            //Console.WriteLine(Emp01);
            //Console.WriteLine(Emp01.GetHashCode());
            //Console.WriteLine(Emp02.GetHashCode());
            //Console.WriteLine(":):):):):)):):)::):):):):)):)\n");
            ////let's go deeply in details about cloneable
            #endregion
            #region Icomparable
            Employee[] employees = new Employee[]
            {
                new Employee(){Name="Mahmoud" ,Age=25 ,Id=1},
                new Employee(){Name="Sally" ,Age=40 ,Id=2},
                new Employee(){Name="Doaa" ,Age=30 ,Id=3},
                new Employee(){Name="Mona" ,Age=50 ,Id=4}
            };
            Array.Sort(employees);
            foreach (Employee employee in employees) {
                Console.WriteLine(employee); 
            }

            #endregion
        }
    }
}
