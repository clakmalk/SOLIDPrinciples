using System;
using US.BOX.Data.Import.Core.Entities;
using US.BOX.Data.Import.Core.SystemEntities;
using US.BOX.Data.Import.DataAccess.Actions;

namespace US.BOX.Data.Import.DataAccess
{
    public class USDFDataManager : IUSDFDataAccess
    {
        public int SaveUSDFInvoiceInfo(USDFInvoiceInfo invoiceInfo)
        {
            return new SaveUSDFInvoiceInfoAction().SaveUSDF(invoiceInfo);
        }
    }
}
