using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MementoCalc.Carectaker;
using MementoCalc.Interface;

namespace MementoCalc.Memento
{
    public class Memento  : ICarectaker,IOriginator
    {
        private int _primeiroNumero;
        private int _segundoNumero;

        public Memento( int primeiroNumero, int segundoNumero)
        {
            this._primeiroNumero = primeiroNumero;
            this._segundoNumero = segundoNumero;


        }
        public int GetPrimeiroNumero()
        {
            return _primeiroNumero;
        }

        public int GetSegundoNumero()
        {
            return _segundoNumero;
        }
    }
}
