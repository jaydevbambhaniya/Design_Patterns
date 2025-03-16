using Factory.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory.Implementation
{
    public class DellDesktopFactory : IComputerFactory
    {
        public IComputerBrand GetComputerBrand()
        {
            return new Dell();
        }

        public IComputerProcessor GetComputerProcessor()
        {
            return new M1();
        }

        public IComputerType GetComputerType()
        {
            return new Desktop();
        }
    }
}
