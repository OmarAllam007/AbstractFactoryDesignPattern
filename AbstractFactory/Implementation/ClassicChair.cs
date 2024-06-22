using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
    internal class ClassicChair: Chair
    {
        public ClassicChair()
        {
            Console.WriteLine("Classic Chair Created");
        }

        public string ChairMethod()
        {
            return "Classic Chair Created from ChairMethod";
        }
    }
}
