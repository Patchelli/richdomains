using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Enum;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities.Payments
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransctionNumber, string transactionCode,
            DateTime paidTime,
            DateTime expireDate,
            decimal total,
            decimal paidTotal,
            string payer,
            EDocumentType document,
            Address address,
            Email email) : base(paidTime, expireDate, total, paidTotal, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransctionNumber = lastTransctionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransctionNumber { get; private set; }
    }

}