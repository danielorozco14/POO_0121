using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EnumerableExample
{

    public class Vehicle
    {
        public string name { get; }
        public int numOfPassengers { get;}

        public Vehicle(string name, int numOfPassengers)
        {
            this.name = name;
            this.numOfPassengers = numOfPassengers;
        }

    }


    public class Car : IEnumerable
    {

        private Vehicle[] _cars;

        public Car (Vehicle[] vArray)
        {
            _cars = new Vehicle[vArray.Length];

            for(int i =0; i < vArray.Length; i++)
            {
                _cars[i] = vArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public CarEnum GetEnumerator()
        {
            return new CarEnum(_cars);
        }
    }


    public class CarEnum : IEnumerator
    {
        public Vehicle[] _cars;

        int position = -1;

        public CarEnum(Vehicle[] list)
        {
            _cars = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _cars.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Vehicle Current
        {
            get
            {
                try
                {
                    return _cars[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehiclesArray = new Vehicle[3]
            {
                new Vehicle("Ford Mustang", 4),
                new Vehicle("Chevrolet Corvette", 2),
                new Vehicle("Toyota Corolla", 5)
            };

            Car carsList = new Car(vehiclesArray);

            foreach(Vehicle v in carsList)
            {
                Console.WriteLine("Car name: "+ v.name + " / " + 
                        "Number of Passengers: " + v.numOfPassengers );
            }
            Console.ReadLine();
        }
    }
}
