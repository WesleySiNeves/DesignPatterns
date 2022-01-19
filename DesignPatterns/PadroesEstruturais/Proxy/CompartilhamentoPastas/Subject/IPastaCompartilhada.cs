using System;
using System.Collections.Generic;
using System.Text;

namespace CompartilhamentoPastas.Subject
{
    public interface IPastaCompartilhada
    {
        void OperacaoLeituraEGravacao();

        void SetFuncionario(Funcionario funcionario);
    }
}
