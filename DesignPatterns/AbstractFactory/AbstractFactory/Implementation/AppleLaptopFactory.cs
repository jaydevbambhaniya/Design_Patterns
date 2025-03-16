using Factory.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory.Implementation
{
    public class AppleLaptopFactory : IComputerFactory
    {
        public IComputerBrand GetComputerBrand()
        {
            return new Apple();
        }

        public IComputerProcessor GetComputerProcessor()
        {
            return new I7();
        }

        public IComputerType GetComputerType()
        {
            return new Laptop();
        }
    }
}
