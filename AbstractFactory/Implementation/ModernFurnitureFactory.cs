using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
    internal class ModernFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ModernChair();
        }

        public CoffeeTable createCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public Sofa createSofa()
        {
            return new ModernSofa();
        }
    }
}
