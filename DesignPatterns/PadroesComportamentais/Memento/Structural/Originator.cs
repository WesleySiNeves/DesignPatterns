using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural
{

    /// <summary>
    /// Classe , Model ou a objeto  para salvar o state
    /// </summary>
    public class Originator
    {
        string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }
        // Creates memento 
        public Memento Snapshot()
        {
            return (new Memento(state));
        }
        // Restores original state
        public void Restore(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}
