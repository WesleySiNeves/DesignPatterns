using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MementoCalc.Carectaker;
using MementoCalc.Interface;

namespace MementoCalc.Originator
{
    public class Calculadora : ICalculadora

    {
        private int primeiroNumero;
        private int segundoNumero;

        public ICarectaker CreateMemento()
        {
            return new Memento.Memento(primeiroNumero, segundoNumero);
        }

        public void SetMemento(ICarectaker memento)
        {
            primeiroNumero = ((IOriginator)memento).GetPrimeiroNumero();
            segundoNumero = ((IOriginator)memento).GetSegundoNumero();
        }

        public int GetCalculoResultado()
        {
            return primeiroNumero + segundoNumero;
        }

        public void SetPrimeiroNumero(int numero1)
        {
            primeiroNumero = numero1;
        }

        public void SetSegundoNumero(int numero2)
        {
            segundoNumero = numero2;
        }
    }
}