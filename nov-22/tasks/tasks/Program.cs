using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //task 2 

            //Banana = 1
            //Tomato = 0

            Console.WriteLine("-----------task3------------------");
            //task 3
            string[] food = { "kabsa", "mansaf", "magloba", "sea food", "barbique" };
            string[] sports = { "soccer", "table tennis", "swimming" };
            string[] movies = { "the green mile", "mad max", "inttersteller" };
            foreach (string f in food)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            foreach (string f in sports)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            foreach (string f in movies)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            //task 4 

            Console.WriteLine("Enter three numbers seperated by comma ");
            string numbers = Console.ReadLine();

            string[] nums = numbers.Split(',');

            int sum = 0;

            foreach (string n in nums)
            {
                sum += Convert.ToInt32(n);
            }

            Console.WriteLine("sum:" + sum);



            //task 5 

            int sumation = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    sumation += i;
                }
            }

            Console.WriteLine("sumation of odd numbers from 1 to 100 is " + sumation);



            //task 6 
            Console.WriteLine("-----------task6 ----------------");
            int a = 3;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = a; j >= 1; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                a--;
            }

            //task 7
            Console.WriteLine("-----------task7 ----------------");

            int s = 3;
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = s; j >= 1; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{num} ");
                    num++;
                }
                Console.WriteLine();
                s--;
            }

            //task 8

            //int[] numms = { 1, 1, 8, 8, 3, 5, 34, 34, 45, 5, 5 };

            //int[] newnums = new int[numms.Length];

            //newnums[0] = 1;
            //Console.WriteLine(newnums[0]);



            //for (int i = 0; i < numms.Length; i++)
            //{

            //    int correntNumber = numms[i];

            //    for (int j = )

            //}





        }





    }
}
