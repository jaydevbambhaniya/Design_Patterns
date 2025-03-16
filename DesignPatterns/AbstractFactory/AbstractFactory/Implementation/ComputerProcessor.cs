using Factory.AbstractFactory.Abstract;
using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory.Implementation
{
    public class I7 : IComputerProcessor
    {
        public string GetComputerProcessor()
        {
            return ComputerProcessor.I7.ToString();
        }

    }

    public class M1 : IComputerProcessor
    {
        public string GetComputerProcessor()
        {
            return ComputerProcessor.M1.ToString();
        }

    }
}
