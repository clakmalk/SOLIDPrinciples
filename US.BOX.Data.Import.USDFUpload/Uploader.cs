using System;
using US.BOX.Data.Import.Core.Entities;

namespace US.BOX.Data.Import.USDFUpload
{
    public class Uploader
    {
        public int Upload(USDFInvoiceInfo invoiceInfo)
        {
            Console.WriteLine("Importing data...");

            //Do the import works here

            Console.WriteLine("Import done");
            return new Random().Next();
        }
    }
}
