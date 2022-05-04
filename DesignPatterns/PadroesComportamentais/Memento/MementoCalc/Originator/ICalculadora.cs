using MementoCalc.Carectaker;

namespace MementoCalc.Interface
{
    public  interface ICalculadora
    {
        //Create Memento
        ICarectaker CreateMemento();
        
        
        //SetMemento
        void SetMemento(ICarectaker calculo);
        
        
        //servicos do Originator
        int GetCalculoResultado();

        void SetPrimeiroNumero( int numero1);

        void SetSegundoNumero(int numero2);
    }
}
