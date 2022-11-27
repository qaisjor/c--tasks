using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooptask
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //int age, string gender, string name, string email, int id, string phoneNumber
            Person p = new Person(12,"male" , "ahmad" , "ahmad@gmail.com" , 12 , "07112345678");

            Console.WriteLine(p.age);
            Console.WriteLine(p.phoneNumber);
        }
    }
}
