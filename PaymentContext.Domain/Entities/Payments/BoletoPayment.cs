using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities.Payments
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumbers, string transactionCode,
            DateTime paidTime,
            DateTime expireDate,
            decimal total,
            decimal paidTotal,
            string payer,
            string document,
            string address,
            string email) : base(paidTime, expireDate, total, paidTotal, payer, document, address, email)
        {
            BarCode = barCode;
            BoletoNumbers = boletoNumbers;
        }

        public string BarCode { get; private set; }
        public string BoletoNumbers { get; private set; }
    }

}