using System;
using System.Collections.Generic;
using System.Text;

namespace US.BOX.Data.Import.Core.Entities
{
    public class USDFInvoiceInfo
    {
        private List<USDFCase> _cases = new List<USDFCase>();
        private List<USDFTransaction> _transactions = new List<USDFTransaction>();
        private List<USDFNote> _notes = new List<USDFNote>();

        public USDFHeader Header{set;get;}
        public List<USDFTransaction> Transactions { get => _transactions; set => _transactions = value; }
        public List<USDFNote> Notes { get => _notes; set => _notes = value; }
        public List<USDFCase> Cases { get => _cases; set => _cases = value; }
    }
}
