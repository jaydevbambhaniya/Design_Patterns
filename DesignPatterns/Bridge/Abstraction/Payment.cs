using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction
{
    public abstract class Payment
    {
        public IPaymentSystem paymentSystem;

        public abstract void InitiatePayment();
    }
}
