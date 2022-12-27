using Conceptual.Observer;
using Conceptual.Subject;

namespace Conceptual.Concrect
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            var state = (subject as Subject.Subject)?.State;

            if (state < 3)
            {

                Console.WriteLine("Preciso atualizar o Saldo");
            }
            else
            {
                Console.WriteLine($"A regra é atualizar o saldo se State for < 3 : valor atual {state}");
            }
        }
    }
}
