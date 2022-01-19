using CompartilhamentoPastas.Proxy;
using System;

namespace CompartilhamentoPastas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Exemplo da implementação do padrão Proxy");
           

            Funcionario estagiario = new Funcionario();

            estagiario.Nome = "Wesley Neves";

            estagiario.Perfil = "Auxiliar de estágiario";

            PastaCompartilhadaProxy proxy = new PastaCompartilhadaProxy();
            proxy.SetFuncionario(estagiario);

            proxy.OperacaoLeituraEGravacao();


            Funcionario Ceo = new Funcionario();

            Ceo.Nome = "Felipe Campos";

            Ceo.Perfil = "CEO";

            proxy.SetFuncionario(Ceo);

            proxy.OperacaoLeituraEGravacao();


            Funcionario usuario = new Funcionario();

            usuario.Nome = "?";

            usuario.Perfil = "CEO";

            proxy.SetFuncionario(usuario);

            proxy.OperacaoLeituraEGravacao();




        }
    }
}
