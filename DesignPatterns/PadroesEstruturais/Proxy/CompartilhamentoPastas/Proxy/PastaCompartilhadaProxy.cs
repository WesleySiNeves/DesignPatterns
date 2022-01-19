using CompartilhamentoPastas.RealSubject;
using CompartilhamentoPastas.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompartilhamentoPastas.Proxy
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada pastaCompartilhada;
        private Funcionario funcionario;




        public void OperacaoLeituraEGravacao()
        {
            if (funcionario != null)
            {
                if (funcionario.Perfil.ToUpper() == "CEO")
                {
                    pastaCompartilhada = new PastaCompartilhada();
                    pastaCompartilhada.OperacaoLeituraEGravacao();

                }
                else
                {
                    Console.WriteLine("##### Vc não tem permissão para acessar essa pasta ####");
                }
            }
            
        }

        public void SetFuncionario(Funcionario func)
        {
            funcionario = func;
        }
    }
}
