using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
    internal class ClassicFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ClassicChair();
        }

        public CoffeeTable createCoffeeTable()
        {
           return new ClassicCoffeeTable();
        }

        public Sofa createSofa()
        {
            return new ClassicSofa();
        }
    }
}
