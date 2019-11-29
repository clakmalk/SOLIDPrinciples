using System;
using System.Collections.Generic;
using System.Text;
using US.BOX.Data.Import.Core.Entities;

namespace US.BOX.Data.Import.Core.SystemEntities
{
    public interface INoteConvtor
    {
        List<USDFNote> GetNotes(string fileName);
    }
}
