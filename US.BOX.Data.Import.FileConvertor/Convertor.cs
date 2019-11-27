using System;
using US.BOX.Data.Import.Core.Entities;

namespace US.BOX.Data.Import.FileConvertor
{
    public class Convertor
    {
        public USDFInvoiceInfo Convert(string fileName)
        {
            Console.WriteLine("Converting.....");
            //Conver here
            //First Create USDF Header
            //Create List of Claim objects from data
            //List of Transactions
            //List of Debtors
            //List Addresses
            //List of Notes
            //List of Transactions
            //List of Notes
            Console.WriteLine("Convertion Done");
            return new USDFInvoiceInfo();
        }
    }
}
