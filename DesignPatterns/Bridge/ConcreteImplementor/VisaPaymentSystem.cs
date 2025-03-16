using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ConcreteImplementor
{
    class VisaPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string type)
        {

            Console.WriteLine("Processing Payment of type {0} through Visa.", type);
        }
    }
}
