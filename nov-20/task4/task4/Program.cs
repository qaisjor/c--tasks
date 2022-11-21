using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task5 t = new task5();
            t.print();
            //task 1
            Console.WriteLine("-----------------------task 1----------------------------");
            Console.WriteLine("Enter any string : ");
            String str = Console.ReadLine();
            Console.WriteLine(str);

            //task 2 
            Console.WriteLine("-------------------task 2-------------------");
            double number = 12.4;
            string name = "qais darabseh";
            char character = 'a';
            bool boolean = true;
            int integer = 12;
            const double by = 3.14;

            
            Console.WriteLine("double data type: " + number);
            Console.WriteLine("string data type : " + name);
            Console.WriteLine("char data type : " + character);
            Console.WriteLine("boolean data type : " + boolean);
            Console.WriteLine("integer data type : " + integer);
            Console.WriteLine("constant : " + by);

            //task 3
            Console.WriteLine("--------------------------task 3-------------------");
            string[] cars = { "BMW", "marsadese", "volvo" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine("lenfth is : " + cars.Length);

            // task 4
            Console.WriteLine("-----------------------task 4----------------------");
            Console.WriteLine("Enter your first name : ");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter your last name : ");
            string lName = Console.ReadLine();


            Console.WriteLine("Enter your Birth year : ");
            string birthYear = Console.ReadLine();


            Console.WriteLine(fName + " " + lName + " " + birthYear);

            //task 5

            Console.WriteLine("-------------------------task 5--------------------------");
            string[] numbers = new string[10] ;

            for (int i = 0; i<numbers.Length; i++) {
                Console.WriteLine("Enter a number ");
                numbers[i] =   Console.ReadLine();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write( numbers[i] + " ");
                
            }
            //task 6

            Console.WriteLine("--------------------------task 6---------------------------");
            int[] nums = { 1, 2, 3};
            int sum = 0;
            sum = nums[0] + nums[1] + nums[2];

            Console.WriteLine("the numation is : " + sum);


            
        }
    }
}
