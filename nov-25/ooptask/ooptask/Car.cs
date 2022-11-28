using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ooptask
{
    class Vehicle
    {
        private string maker;
        private string year;
        private string type;
        private double price;
        private string model;
        private int palletNo;
        private string color;

        public string Maker { get => maker; set => maker = value; }
        public string Year { get => year; set => year = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }
        public int PalletNo { get => palletNo; set => palletNo = value; }
        public string Color { get => color; set => color = value; }

        public Vehicle(string maker, string year, string type, double price, string model, int palletNo, string color)
        {
            Maker = maker;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }



        public void startEngine()
        {
            Console.WriteLine("Engine has Started");
        }

        public void stopEngine()
        {
            Console.WriteLine("Engine has Stoped");
        }

        public void printInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Maker : {Maker} \n year : {Year} \n Type : {Type} \n Price : {Price} \n Model : {Model} \n PalletNo : {PalletNo} \n Color : {Color}";
        }
    }
    internal class Car : Vehicle
    {
        double letter; 

        public Car(string maker, string year, string type, double price, string model, int palletNo, string color, double letter) :
            base(maker, year, type, price, model, palletNo, color)
        {
            this.letter = letter;
         }

        public void MovePerLitter() {
            Console.WriteLine("car move " + letter * 23 + "km per hour"); 
        }
        
    }
}
