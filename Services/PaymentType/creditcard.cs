﻿using ProvaPub.Abstract;
using ProvaPub.Models;

namespace ProvaPub.Services.PaymentType
{
    public class creditcard : Payment
    {
        public override Order Pagamento(decimal paymentValue, int customerId)
        {
            //Implementação do pagamento.
            return new Order()
            {
                Value = paymentValue
            };
        }
    }
}
