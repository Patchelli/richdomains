using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Enum;
using PaymentContext.Domain.ValueObjects;

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
            EDocumentType document,
            Address address,
             Email email) : base(paidTime, expireDate, total, paidTotal, payer, document, address, email)
        {
            TransactionCode = transactionCode;
        }
    }
}