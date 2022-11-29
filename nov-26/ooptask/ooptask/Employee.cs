using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ooptask
{
    internal class Employee
    {
        private int id;
        private string name;
        private DateTime birthDate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }

        public Employee(int id, string name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }

        public int calcAge() {
            DateTime today = DateTime.Today;
            int days = (int)today.Subtract(birthDate).TotalDays;
            
            return days/365;
        }

        public virtual void printInfo() {
            Console.WriteLine($"id = {id} \n name = {name} \n birth date = {birthDate}");  
        }
    }

    class Manager : Employee {

        public Manager(int id, string name, DateTime birhDate) :
            base(id, name , birhDate)
        { }


        public override void printInfo()
        {
            Console.WriteLine($"id: {Id} \nname: {Name} \nbirth date: {BirthDate}");
        }
    }

    class Test {

        public void printManagerInfo() {
            DateTime birthdate = new DateTime(1997, 12, 15);

            
            Manager m = new Manager(12, "qais", birthdate);
            m.printInfo();

            Console.WriteLine($"age: {m.calcAge()}");
        }
    }

}
