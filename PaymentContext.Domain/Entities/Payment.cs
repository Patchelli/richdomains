using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public Guid Number { get; set; }
        public DateTime PaidTime { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal PaidTotal { get; set; }
        public string Payer { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
    }

    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        public string BoletoNumbers { get; set; }
    }

    public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransctionNumber { get; set; }
    }

    public class PayPalPaymente : Payment
    {
        public string CardHolderName { get; set; }
    }
}