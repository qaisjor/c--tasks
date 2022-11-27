using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooptask
{
    internal class Person
    {
        public int age; //18-60
        public string gender;
        public string name;
        public string email;
        public int id;
        public string phoneNumber = "no number";
        public Person(int age, string gender, string name, string email, int id, string phoneNumber)
        {
            if (age < 18 && age > 60)
            {
                Console.WriteLine("Enter age between 18 - 60");

            }
            else { 
            
                this.age = age;
            }

            if (phoneNumber.Substring(0, 3) == "077"
                || phoneNumber.Substring(0, 3) == "078"
                || phoneNumber.Substring(0, 3) == "079")
            {

                this.phoneNumber = phoneNumber;
            }
            else {
                Console.WriteLine("Enter a valid  phone number "); 
            }
            this.gender = gender;
            this.name = name;
            this.email = email;
            this.id = id;
            
            
        }

        
    }
}
