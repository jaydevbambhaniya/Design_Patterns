using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory.Abstract
{
    public interface IComputerFactory
    {
        public IComputerBrand GetComputerBrand();
        public IComputerProcessor GetComputerProcessor();
        public IComputerType GetComputerType();
        public string GetComputerInfo()
        {
            IComputerBrand brand = GetComputerBrand();
            IComputerType type = GetComputerType();
            IComputerProcessor processor = GetComputerProcessor();

            return string.Format("Type: {0}, Brand: {1}, Processor: {2}", type.GetComputerType(),
                brand.GetComputerBrand(),
                processor.GetComputerProcessor());
        }
    }
}

