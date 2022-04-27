namespace Structural.ConcrectColleague
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class ConcreteColleague2 : Colleague.Colleague
    {
        // Constructor
        public ConcreteColleague2(Mediator.Mediator mediator)
            : base(mediator)
        {
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 recebe a mensagem: "
                              + message);
        }
    }
}
