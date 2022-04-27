
namespace Structural.ConcrectColleague
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class ConcreteColleague1 : Colleague.Colleague
    {
        // Constructor
        public ConcreteColleague1(Mediator.Mediator mediator)
            : base(mediator)
        {
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 recebe a messagem: "
                              + message);
        }
    }
}
