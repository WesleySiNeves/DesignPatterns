using Conceptual.Observer;
using Conceptual.Subject;

namespace Conceptual.Concrect
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            var state = (subject as Subject.Subject)?.State;
            if (state == 0 || state >= 2)
            {
                Console.WriteLine("Preciso Enviar um Email");
            }

            else
            {
                Console.WriteLine($"A regra é enviar um email se  State == 0 or  State > 2 : valor atual {state}");
            }
        }
    }
}
