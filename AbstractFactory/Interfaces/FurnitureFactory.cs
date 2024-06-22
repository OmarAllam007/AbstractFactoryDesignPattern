using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    internal interface FurnitureFactory
    {
        public  Chair createChair();
        public  Sofa createSofa();
        public  CoffeeTable createCoffeeTable();
    }
}
