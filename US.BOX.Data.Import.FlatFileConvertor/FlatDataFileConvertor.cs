using System;
using System.Collections.Generic;
using US.BOX.Data.Import.Core.Entities;
using US.BOX.Data.Import.FileConvertor;

namespace US.BOX.Data.Import.FlatFileConvertor
{
    public class FlatDataFileConvertor : Convertor
    {
        protected override List<USDFCase> GetCases(string fileName)
        {
            Console.WriteLine("Convert Flat File to get cases ");
            return new List<USDFCase>();
        }
        protected override List<USDFTransaction> GetTransactions(string fileName)
        {
            return new List<USDFTransaction>();
        }
    }
}
