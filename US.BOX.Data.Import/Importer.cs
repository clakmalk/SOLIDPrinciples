using System;
using System.Collections.Generic;
using System.Text;
using US.BOX.Data.Import.Core.Entities;
using US.BOX.Data.Import.FileConvertor;
using US.BOX.Data.Import.ImportDataIntoBOX;
using US.BOX.Data.Import.ImportReceitHandler;
using US.BOX.Data.Import.USDFUpload;

namespace US.BOX.Data.Import
{
    public class Importer
    {
        public ImportREceipt ImportFile(string file)
        {
            //1. Read the file and Map into USDF Structure
            Convertor convertor = new Convertor(); 
            USDFInvoiceInfo invoiceInfo = convertor.Convert(file);
            // 2. Upload the data into USDF Tables
            Uploader uploader = new Uploader();
            int token = uploader.Upload(invoiceInfo);
            // 3. Trigger Data import process to import the files
            DataImporter importer = new DataImporter();
            importer.Import(token);
            // 4. Create Output receipt for imported data
            ReceiptCreator receiptCreator = new ReceiptCreator();
            ImportREceipt receipt = receiptCreator.CreateReceipt(token);
            // 5. Return the Receipt back to the caller
            return receipt;
        }

    }
}
