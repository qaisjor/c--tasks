using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 
            Console.WriteLine("task 1");
            int n1 = 10;
            int n2 = 20;

            int smaller  = (n1<n2) ? n1 : n2;
            Console.WriteLine($"the smallest number is : {smaller}");


            //task 2 
            Console.WriteLine("task 2");
            int number = -4;
            char sign =  (number < 0) ?'-' : '+';

            //task 3
            Console.WriteLine("task 3");

            int a=-4 , b=-3 , c = -2;

            if (a < b && b < c)
            {
                Console.WriteLine(a + "  " + b + "  " + c);
            }
            else if (b < a && a < c)
            {
                Console.WriteLine(b + "  " + a + "  " + c);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c + "  " + a + "  " + b);
            }
            else if (b < c && c < a)
            {
                Console.WriteLine(b + "  " + c + "  " + a);
            }
            else if (c < b && b < a)
            {
                Console.WriteLine(c + "  " + b + "  " + a);
            }
            else if (a < c && c < b) {
                Console.WriteLine(a + "  " + c + "  " + b);
            }



            //task 4
            Console.WriteLine("task 4");
            int num1 = 2, num2 = 3, num3 = 5, num4 = -3, num5 = 10;

            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                Console.WriteLine($"max number is : {num1}");
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5) {
                Console.WriteLine($"max number is : {num2}");
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            {
                Console.WriteLine($"max number is : {num3}");
            }
            else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                Console.WriteLine($"max number is : {num4}");
            }
            else if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
            {
                Console.WriteLine($"max number is : {num5}");
            }


            //task 5
            Console.WriteLine("task 5");
            Console.WriteLine("Enter distance in KM");
            double km = Convert.ToDouble(Console.ReadLine()) ;

            Console.WriteLine("distance in mile is : " +km* 0.62);


            //task 6
            Console.WriteLine("task 6");
            Console.WriteLine("input houres : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input minutes : ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total :"+ (h*60) + m +"minutes");


            //task 7
            Console.WriteLine("task 7");
            Console.WriteLine("Enter minutes  : ");
            double mins = Convert.ToDouble(Console.ReadLine());

            int houres = (int) mins / 60;
            int minutes = (int) mins % 60; 
            Console.WriteLine("houres : " + houres + " : minutes " + minutes );


            //task 8

            Console.WriteLine("task 8");
            string[] sentinces = {
                "Lorem ipsum dolor sit amet",
                "Lorem ipsum dolor sit amet Lorem ipsum dolor sit amet",
                "Lorem ipsum dolor sit amet Lorem ",
                "Lorem ipsum dolor sit amet ",
                "Lorem ipsum dolor sit amet Lorem ipsum dolor sit amet Lorem ipsum dolor sit amet" };

            

            Console.WriteLine($"sentince 1 {sentinces[0].Substring(0,10)}");
            Console.WriteLine($"sentince 2  {sentinces[1].Substring(0, 10)}");
            Console.WriteLine($"sentince 3  {sentinces[2].Substring(0, 10)}");
            Console.WriteLine($"sentince 4 {sentinces[3].Substring(0, 10)}");
            Console.WriteLine($"sentince 5  {sentinces[4].Substring(0, 10)}");



        }
    }
}
