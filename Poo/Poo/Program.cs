using Poo;
using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Car car = new Car("ETC20F",new Account("Toya","12345676788990"));
            //car.getPassanger = 4;
            //car.ImprimirCar();

            //Car car1 = new Car("CAS880",new Account("Tello","1151212213"));
            //car1.getPassanger = 5;
            //car1.ImprimirCar();

            UberX Carro1 = new UberX("QTR123", new Account("Deiber","0987832424"),"Chevrolet","Spark");
            Carro1.getPassanger = 4;
            Carro1.ImprimirCar();

            //UberPool Carro2 = new UberPool("ZXC567", new Account("Ana", "000000000001"),"Dogge","Zafiro");
            //Carro2.ImprimirCar();
        }
    }
}