using System;
using System.Collections.Generic;
using System.Text;

namespace US.BOX.Data.Import.Core.Entities
{
    public class USDFHeader
    {
        private string _messageId = string.Empty;
        private string _fileName = string.Empty;
        private decimal _invoiceSum = 0;
        private decimal _paymentSum = 0;

        public string MessageId { get => _messageId; set => _messageId = value; }
        public string FileName { get => _fileName; set => _fileName = value; }
        public decimal InvoiceSum { get => _invoiceSum; set => _invoiceSum = value; }
        public decimal PaymentSum { get => _paymentSum; set => _paymentSum = value; }
    }
}
