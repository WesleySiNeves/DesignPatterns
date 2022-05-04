using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoCalc.Interface
{
    public interface IOriginator
    {
        //Permite  o Originator restaurar seu estado
        int GetPrimeiroNumero();

        int GetSegundoNumero();

    }
}
