using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProspectMemento.Caretaker
{
    public class Caretaker
    {
        Memento.Memento memento;

        public Memento.Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
