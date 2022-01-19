using System;
using System.Collections.Generic;
using System.Text;

namespace BookBridge.Providers
{
    public interface IbookContentProvider
    {
        IEnumerable<string> GetContent();
    }
}
