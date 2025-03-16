using Factory.AbstractFactory.Abstract;
using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory.Implementation
{
    public class Apple : IComputerBrand
    {
        public string GetComputerBrand()
        {
            return ComputerBrand.Apple.ToString();
        }
    }

    public class Dell : IComputerBrand
    {
        public string GetComputerBrand()
        {
            return ComputerBrand.Dell.ToString();
        }
    }
}
