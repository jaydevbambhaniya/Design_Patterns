﻿using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RefinedAbstraction
{
    public class CardPayment : Payment
    {
        public override void InitiatePayment()
        {
            paymentSystem.ProcessPayment("Card");
        }
    }
}
