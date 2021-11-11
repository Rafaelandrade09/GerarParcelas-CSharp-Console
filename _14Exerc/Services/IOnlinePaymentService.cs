using System;
using System.Collections.Generic;
using System.Text;

namespace _14Exerc.Services
{
    interface IOnlinePaymentService 
    {
        public double PaymentFree(double amount);

        public double Interest(double amount, int mounths);
    }
}
