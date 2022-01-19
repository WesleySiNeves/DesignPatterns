using System;
using System.Collections.Generic;
using System.Text;
using VendaComputadoresComposite.Component;

namespace VendaComputadoresComposite.Composite
{
    public class Computador : Periferico
    {
        protected List<Periferico> perifericos = new List<Periferico>();

        public override void Add(Periferico component)
        {
            perifericos.Add(component);
        }


        public override void Remove(Periferico component)
        {
            perifericos.Remove(component);
        }

        public override decimal GetValor()
        {
            decimal precoComputador = 0;

            foreach (var departamento in perifericos)
            {
                precoComputador += departamento.GetValor();
            }

            Console.WriteLine($"{Nome}  Valor de  [{precoComputador}] R$ \n");

            return precoComputador;
        }
    }

}
