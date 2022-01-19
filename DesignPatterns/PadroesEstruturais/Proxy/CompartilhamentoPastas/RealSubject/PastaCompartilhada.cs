using CompartilhamentoPastas.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompartilhamentoPastas.RealSubject
{
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoLeituraEGravacao()
        {
            Console.WriteLine("##### Operação de leitura e escrita na pasta compartilhada ####");
        }

        public void SetFuncionario(Funcionario funcionario)
        {
            
        }
    }
}
