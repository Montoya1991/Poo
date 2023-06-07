using Poo;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            car.license = "ETC20F";
            car.driver = "Toya";
            car.passanger = 4;
            Console.WriteLine("car licence: " + car.license);

            Car car1 = new Car();
            car1.license = "cas880";
            car1.driver = "Tello";
            car1.passanger = 5;
            car1.ImprimirCar();
        }
    }
}