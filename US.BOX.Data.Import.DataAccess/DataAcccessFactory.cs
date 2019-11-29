using System;
using System.Collections.Generic;
using System.Text;
using US.BOX.Data.Import.Core.SystemEntities;

namespace US.BOX.Data.Import.DataAccess
{
    public class DataAcccessFactory
    {
        public static IUSDFDataAccess GetUSDFDataAccess()
        {
            return new USDFDataManager();
        }
    }
}
