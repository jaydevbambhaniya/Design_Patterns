﻿using Bridge.Abstraction;
using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RefinedAbstraction
{
    public class NetBankingPayment : Payment
    {
        public override void InitiatePayment()
        {
            paymentSystem.ProcessPayment("NetBanking");
        }
    }
}
