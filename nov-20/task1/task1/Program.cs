using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //convert string to upper case 
            string upper = "to upper case ";
            Console.WriteLine(upper.ToUpper());
            Console.WriteLine("---------------------------------------------------------");
            //convert string to lower case 
            string lower = "TO LOWER CASE";
            Console.WriteLine(lower.ToLower());
            Console.WriteLine("-----------------------------length----------------------------");

            Console.WriteLine("length of th string : "+lower.Length);
            //concatination 
            string firstName = "qais";
            string lastName = "darabseh";
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(string.Concat(firstName ," ", lastName));

            //note + operator is used for both adding numbers and concat strings in c# 
            Console.WriteLine("----------------------------adding numbers and adding strings-----------------------------");
            int n1 = 10;
            int n2 = 20;

            Console.WriteLine(n1 + n2);

            string str1 = "10";
            //int str3 = 5;
            string str2 = "20";

            Console.WriteLine(str1 + str2 );
            Console.WriteLine("--------------------------interpolation-------------------------------");

            string fullName = $" {firstName} {lastName}";
            Console.WriteLine( "you full name is " + fullName);

            Console.WriteLine("-------------------------indexOf method --------------------------------");

            string greating = "Hi every one ";
            Console.WriteLine(greating.IndexOf('e'));

            Console.WriteLine("-------------------------substring mehtod\b\b\b --------------------------------");
            Console.WriteLine(greating.Substring(3,4));
            


            
            
        }
    }
}
