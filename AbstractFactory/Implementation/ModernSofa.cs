using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{

    internal class ModernSofa : Sofa
    {
        public string SofaMethod()
        {
            return "Modern Sofa Created from SofaMethod!";
        }
    }
}
