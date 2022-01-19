using AnaliseCreditos.SubSistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseCreditos.Facade
{
    public class AnaliseCreditoFacade
    {
       private  Cadastro _cadastro;

        private Cadin _cadin ;

        private Serasa _serasa;

        private LimiteDeCredito _limiteDeCredito;



        public AnaliseCreditoFacade()
        {
            _cadastro = new Cadastro();
            _cadin = new Cadin();
            _serasa = new Serasa();
            _limiteDeCredito = new LimiteDeCredito();
        }

        public bool ConcederEmprestimo(Cliente cliente ,decimal valor)
        {

            Console.WriteLine($"Cliente deseja um emprestivo de {valor }");

            _cadastro.CadastrarCliente(cliente);


            bool podeConcederEmprestrimo = true;


            if (_serasa.EstaNoSerasa(cliente))
            {
                Console.WriteLine($"Cliente possue restrição no Serasa");
                podeConcederEmprestrimo = false;
            }

            else if (_cadin.EstaNoCadin(cliente))
            {
                Console.WriteLine($"Cliente possue restrição no Cadin");
                podeConcederEmprestrimo = false;

            }

            else if (!_limiteDeCredito.PossueLimiteCredito(cliente, valor))
            {

                Console.WriteLine($"Cliente não possue limite de crédito!");
                podeConcederEmprestrimo = false;
            }

            return podeConcederEmprestrimo;


        }

            

    }
}
