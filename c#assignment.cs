using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            double d =  6.0 ;
            string s = " federal poly ilaro ";


            Console.WriteLine("enter the first number");
            int first_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the first double ");
            double second_no= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter a statement");
            string statement = Console.ReadLine();




            Console.WriteLine(i + first_no);

            Console.WriteLine(d + second_no);

            Console.WriteLine(s + statement);





            Console.ReadLine();


                   
        }
    }
}
