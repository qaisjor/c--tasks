using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9 };
            //calcSumAndAVG(numbers);

            //task 2 
            //cube(2);

            ////task 3
            //int[] years = { 1959, 1940, 1990, 2034, 1930, 1980 };
            //int[] newy =  getYears(years);

            //foreach (int year in newy) {
            //   Console.WriteLine(year);
            //}


            //task 4 

            //int years = 12;
            //Console.WriteLine (getAgeInDays(years));


            //task 5
            //animals(2, 3, 4) ;


            //task 7 
            //Console.WriteLine(pow(3));


            //task 8 
            //getLeapYears();

            //task 9 
            //isPrime(4);

            // task 10 
            // getNumberOfWord("Create function that accept a sentence, and return the number of words");


            //Console.WriteLine((login("qais@gmail.com", "123456")) ? "pass" : "fail" );


        }

        static void calcSumAndAVG(int[] numbers ) {
            int sum = 0 ;
            int avg = 0;

            foreach (int number in numbers) {
                sum += number;
            }

            avg = sum / numbers.Length;

            Console.WriteLine($"the sum of 10 no is : {sum}");
            Console.WriteLine($"the avg of 10 no is : {avg}");
        }
        //////////////////////////////////////////////////////////////////
        static void cube(int number) {
            Console.WriteLine ( $"the number is {number} and cube of {number} is :"+Math.Pow(number, 3));  
        }

        //////////////////////////////////////////////////////////////////

        static int[] getYears(int[] years) {
            int index = 0;
            int[] newYears = { }; 
            foreach (int year in years) {
                if (year > 1950) {
                    Array.Resize(ref newYears, newYears.Length+1);
                    newYears[index++] = year;
                }
            }

            return newYears;
        }

        //////////////////////////////////////////////////////////////////
        static int getAgeInDays(int years) {
            return years * 365;  
        }
        //////////////////////////////////////////////////////////////////////

        static void animals(int chekens , int cows , int pigs) {

            int legsCount = (chekens * 2) + (cows * 4) + (pigs * 4);

            Console.WriteLine("legs are : " + legsCount);
        }
        ////////////////////////////////////////////////////////////////////
        static bool login(string email, string password) {
            string[] emails = { "qais@gmail.com", "samer@gmail.com", "ahmad@gmail.com" };
            string[] passwords = { "123456", "654321", "12345" };

            for (int i = 0; i < 3; i++) {
                if (email == emails[i] && password == passwords[i])
                    return true; 
            }

            return false;
        }
        ////////////////////////////////////////////////////////////////////
        static double pow(double number) {
            return number * number; 
        }

        /////////////////////////////////////////////////////////////////////

        static void getLeapYears() {

          
            
            for (int i = 1900; i <= 2022; i++)
            {
                if (  ((i % 4 == 0) && (i % 100 != 0)) || ((i % 4 == 0) && (i % 100 == 0) && (i % 400 == 0))   )
                {
                    Console.Write(i + " ");
                }
            }
        }
        /////////////////////////////////////////////////////////////////////
        static void isPrime(int number) {
            for (int i = 2; i <number; i++) {
                if (number % i == 0) {
                    Console.WriteLine($"{number} is not prime number");
                    return; 
                }

                    
            }

            Console.WriteLine($"{number} is  prime number");
        }

        /////////////////////////////////////////////////////////////////////
        ///

        static void getNumberOfWord(string sentence) {
            string[]words = sentence.Split(' ');

            Console.WriteLine($"number of words is {words.Length}");
        }
    }
}
