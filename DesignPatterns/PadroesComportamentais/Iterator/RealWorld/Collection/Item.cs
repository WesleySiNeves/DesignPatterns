using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Collection
{
    /// <summary>
    /// A collection item
    /// </summary>
    public class Item
    {
        string name;
        // Constructor
        public Item(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
