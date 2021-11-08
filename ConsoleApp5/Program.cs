using System;

namespace ConsoleApp5
{

   partial class Class1
    {




        public void Show(ref int val)
        {
            int a = 5;
            val =a ;
            val *= val;
            
           // Console.WriteLine("Value inside the show function " + val);

        }

        static void Main(string[] args)
        {
          //int vae = 50;
              Class1 a1 = new Class1();
            /*  Console.WriteLine("Value before calling the function " + vae);
             a.Show(ref vae);
             Console.WriteLine("Value after calling the function " + vae);*/
            a1.m2();
        }
    }
}
