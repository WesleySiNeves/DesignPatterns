using System;
using System.Collections.Generic;

namespace DemoSingleton
{
    public class CreditosBancariosBusiness
    {
        private static CreditosBancariosBusiness _instance;

        public static CreditosBancariosBusiness Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new CreditosBancariosBusiness();
                }

                return _instance;
            }

        }

        /// <summary>
        /// No padrão singleton a ideia principal e ter somente uma instancia do objeto
        /// Logo o construtor deve ser privado
        /// </summary>
        private CreditosBancariosBusiness()
        {

        }

        public List<String> BuscarCreditos()
        {
            List<String> retorno = new List<string>();

            retorno.Add("credito 1");
            retorno.Add("credito 2");

            return retorno;
        }

        public List<String> BuscarCreditosSimples()
        {
            List<String> retorno = new List<string>();

            retorno.Add("credito 3");

            return retorno;
        }
    }
}
