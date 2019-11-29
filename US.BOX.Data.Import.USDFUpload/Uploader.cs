using System;
using US.BOX.Data.Import.Core.Entities;
using US.BOX.Data.Import.Core.SystemEntities;
using US.BOX.Data.Import.DataAccess;

namespace US.BOX.Data.Import.USDFUpload
{
    public class Uploader
    {
        public int Upload(USDFInvoiceInfo invoiceInfo)
        {
            Console.WriteLine("Importing data...");

            //Do the import works here

            IUSDFDataAccess dataManager = DataAcccessFactory.GetUSDFDataAccess();
            return dataManager.SaveUSDFInvoiceInfo(invoiceInfo);
        }
    }
}
