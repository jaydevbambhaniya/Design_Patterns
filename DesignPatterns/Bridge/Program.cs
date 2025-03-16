using Bridge.Abstraction;
using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstraction;

Payment p1 = new CardPayment { paymentSystem = new VisaPaymentSystem() };

Payment p2 = new NetBankingPayment { paymentSystem = new PayPalPaymentSystem() };

p1.InitiatePayment();
p2.InitiatePayment();