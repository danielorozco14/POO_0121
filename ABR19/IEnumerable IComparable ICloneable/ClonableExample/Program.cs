using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClonableExample
{

    public class Vehicle : ICloneable
    {
        public string name { get; set; }
        public int numOfPassengers { get; set; }

        public Vehicle(string name, int numOfPassengers)
        {
            this.name = name;
            this.numOfPassengers = numOfPassengers;
        }

        public object Clone()
        {
            Vehicle copy = new Vehicle(name, numOfPassengers);

            return copy;
        }

        public void showInfo()
        {
            Console.WriteLine("Name: " + this.name + " / Num of Passengers: " + this.numOfPassengers);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            Vehicle vehicle1 = new Vehicle("Camaro", 4);
            Vehicle vehicle2 = vehicle1;

            vehicle1.showInfo();
            vehicle2.showInfo();

            vehicle1.name = "Explorer";
            vehicle1.numOfPassengers = 5;

            Console.WriteLine("----------------");

            vehicle1.showInfo();
            vehicle2.showInfo();


            Console.ReadLine();

            
            
        }
    }
}
