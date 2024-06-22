using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
    internal class ModernChair : Chair
    {
        public ModernChair()
        {
            Console.WriteLine("Modern Chair Created");
        }
        public string ChairMethod()
        {
            return "Modern Chair Created from ChairMethod";
        }
    }
}
