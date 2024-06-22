using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
    internal class ClassicSofa : Sofa
    {
        public string SofaMethod()
        {
            return "Classic Sofa Created from SofaMethod!";
        }
    }
}
