using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcMementoGenerateSenhasConsole.Memento;

namespace CalcMementoGenerateSenhasConsole.Originator
{
    // O Originador mantém algum estado importante que pode mudar com o tempo. Isto
    // também define um método para salvar o estado dentro de um memento e outro
    // método para restaurar o estado dele.
    public class Originator
    {
       
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originator: Meu estado inicial é: " + state);
        }

       
        public void GerarSenha()
        {
            Console.WriteLine("Originator: estou fazendo algo importante.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originator: e meu estado mudou para: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }


        #region Padrao


        // CreateMemento
        public IMemento CreateMemento()
        {
            return new Memento.ConcreteMemento(this._state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IMemento memento)
        {
            if (!(memento is Memento.ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }

#endregion
    }
}
