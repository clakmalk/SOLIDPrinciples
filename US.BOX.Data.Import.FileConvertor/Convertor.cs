using System;
using System.Collections.Generic;
using US.BOX.Data.Import.Core.Entities;

namespace US.BOX.Data.Import.FileConvertor
{
    public abstract class Convertor
    {
        public USDFInvoiceInfo Convert(string fileName)
        {
            Console.WriteLine("Converting Flat data.....");
            //Conver here
            USDFInvoiceInfo invoiceInfo = new USDFInvoiceInfo();
            //First Create USDF Header

            //Create List of Claim objects from data
            invoiceInfo.Cases = GetCases(fileName);
            //List of Transactions
            invoiceInfo.Transactions = GetTransactions(fileName);

            invoiceInfo.Header = CreateHeder(invoiceInfo, fileName);
            Console.WriteLine("Convertion Done");
            return new USDFInvoiceInfo();


        }

        private USDFHeader CreateHeder(USDFInvoiceInfo invoiceInfo, string fileName)
        {
            return new USDFHeader()
            {
                MessageId = Guid.NewGuid().ToString(),
                FileName = fileName
            };
        }

        protected abstract List<USDFTransaction> GetTransactions(string fileName);

        protected abstract List<USDFCase> GetCases(string fileName);
    }
}
