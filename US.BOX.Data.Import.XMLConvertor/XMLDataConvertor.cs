using System;
using System.Collections.Generic;
using US.BOX.Data.Import.Core.Entities;
using US.BOX.Data.Import.Core.SystemEntities;
using US.BOX.Data.Import.FileConvertor;

namespace US.BOX.Data.Import.XMLConvertor
{
    public class XMLDataConvertor : Convertor, INoteConvtor
    {
        protected override List<USDFCase> GetCases(string fileName)
        {
            Console.WriteLine("Convert XML File to get cases ");
            return new List<USDFCase>();
        }

        protected override List<USDFTransaction> GetTransactions(string fileName)
        {
            return new List<USDFTransaction>();
        }

        List<USDFNote> INoteConvtor.GetNotes(string fileName)
        {
            return new List<USDFNote>();
        }
    }
}
