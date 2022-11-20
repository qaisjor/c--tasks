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
            // task 4

            Console.WriteLine("Enter your first name : ");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter your last name : ");
            string lName = Console.ReadLine();


            Console.WriteLine("Enter your Birth year : ");
            string birthYear = Console.ReadLine();


            Console.WriteLine(fName + " " + lName + " " + birthYear);

            //task 5

            string[] numbers = new string[10] ;

            for (int i = 0; i<numbers.Length; i++) {
                Console.WriteLine("Enter a number ");
                numbers[i] =   Console.ReadLine();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write( numbers[i] + " ");
                
            }

            Console.ReadLine();


            //task 6

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
            }

            Console.WriteLine("the numation is : " + sum);

        }
    }
}
