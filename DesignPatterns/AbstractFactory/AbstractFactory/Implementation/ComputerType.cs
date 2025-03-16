using Factory.AbstractFactory.Abstract;
using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory.Implementation
{
    public class Desktop : IComputerType
    {
        public string GetComputerType()
        {
            return ComputerType.Desktop.ToString();
        }
    }

    public class Laptop : IComputerType
    {
        public string GetComputerType()
        {
            return ComputerType.Laptop.ToString();
        }
    }
}
