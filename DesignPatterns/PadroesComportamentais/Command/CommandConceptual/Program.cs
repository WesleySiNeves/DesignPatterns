using CommandConceptual.Commands;
using CommandConceptual.Receptores;
using CommandConceptual.Remetente;

namespace CommandConceptual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();


            invoker.SetOnStart(new SimpleCommand("Say Hi!"));

            Receptor receiver = new Receptor();

            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}
