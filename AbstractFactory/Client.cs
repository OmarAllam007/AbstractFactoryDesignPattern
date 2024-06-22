using AbstractFactory.Implementation;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Client
    {
        public void Run() {

            Console.WriteLine("Abstract Factory Pattern");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Modern Furniture Factory");
            MapFactory(new ModernFurnitureFactory());

            Console.WriteLine("-----------------------");
            Console.WriteLine("Classic Furniture Factory");
            MapFactory(new ClassicFurnitureFactory());
        }

        public void MapFactory(FurnitureFactory furnitureFactory) {
            var chair = furnitureFactory.createChair();
            var sofa = furnitureFactory.createSofa();
            var coffeeTable = furnitureFactory.createCoffeeTable();

            Console.WriteLine(chair.ChairMethod());
            Console.WriteLine("-----------------------");
            Console.WriteLine(sofa.SofaMethod());



        }
    }
}
