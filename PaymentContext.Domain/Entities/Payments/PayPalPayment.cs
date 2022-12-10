using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities.Payments
{
    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; private set; }

        public PayPalPayment(
            string transactionCode,
            DateTime paidTime,
            DateTime expireDate,
            decimal total,
            decimal paidTotal,
            string payer,
            string document,
             string address,
             string email) : base(paidTime, expireDate, total, paidTotal, payer, document, address, email)
        {
            TransactionCode = transactionCode;
        }
    }
}