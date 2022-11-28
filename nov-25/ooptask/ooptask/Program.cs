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
            //string maker, string year, string type, double price, string model, int palletNo, string color
            Car c = new Car("Bayerische Motoren" , "1993" , "BMW" , 20000 , "2022" , 3455334 , "Black" , 5);

            c.printInfo();
            c.startEngine();
            c.stopEngine();
            c.MovePerLitter();
        }
    }
}
