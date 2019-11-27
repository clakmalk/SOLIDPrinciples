using System;
using US.BOX.Data.Import.Core.Entities;

namespace US.BOX.Data.Import.ImportReceitHandler
{
    public class ReceiptCreator
    {
        public ImportREceipt CreateReceipt(int token)
        {
            Console.WriteLine("Start Creating the Receipt");

            //Just create the Receipt here

            Console.WriteLine("Receipt creation done");

            return new ImportREceipt();
        }
    }
}
