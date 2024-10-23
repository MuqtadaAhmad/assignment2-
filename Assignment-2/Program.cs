using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda","Civic");
            Console.Write(car.brand);
            Console.WriteLine(","+car.modelName);
            Truck truck = new Truck("Ford","F-150");
            Console.Write(truck.brand);
            Console.WriteLine("," + truck.modelName);
            Console.ReadLine();
        }
    }
}
