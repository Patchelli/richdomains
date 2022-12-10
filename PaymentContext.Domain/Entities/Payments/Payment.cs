using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Enum;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities.Payments
{
    public abstract class Payment
    {
        public Payment(DateTime paidTime, DateTime expireDate, decimal total, decimal paidTotal, string payer, EDocumentType document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidTime = paidTime;
            ExpireDate = expireDate;
            Total = total;
            PaidTotal = paidTotal;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaidTime { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal PaidTotal { get; private set; }
        public string Payer { get; private set; }
        public EDocumentType Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; set; }
    }
}