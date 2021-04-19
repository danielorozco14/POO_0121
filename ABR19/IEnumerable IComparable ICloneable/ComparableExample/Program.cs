using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableExample
{
    public class Vehicle : IComparable
    {
        public int year { get; set; }
        public string name { get; set; }
        
        public int numOfPassengers { get; set; }

        public Vehicle(int year, string name, int numOfPassengers)
        {
            this.year = year;
            this.name = name;
            this.numOfPassengers = numOfPassengers;
        }

        int IComparable.CompareTo(object obj)
        {
            Vehicle objToCompare = (Vehicle)obj;

            if (year > objToCompare.year)
                return 1;
            if (year < objToCompare.year)
                return -1;
           
            return 0;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] cars = new Vehicle[5]
            {
                new Vehicle(1989,"Mustang",4),
                new Vehicle(2004,"Escalade",7),
                new Vehicle(1985,"Cherokee",5),
                new Vehicle(1999,"Explorer",5),
                new Vehicle(2021,"Challenger",4)
            };


            Array.Sort(cars);

            foreach(Vehicle v in cars)
            {
                Console.WriteLine(v.year);
            }
            Console.ReadLine();


        }
    }
}
