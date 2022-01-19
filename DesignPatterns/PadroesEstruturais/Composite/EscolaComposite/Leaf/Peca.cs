using VendaComputadoresComposite.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendaComputadoresComposite.Leaf
{
    public class Peca : Periferico
    {

        public decimal Valor { get; set; }

      

        public override decimal GetValor()
        {
            Console.WriteLine($"A peça  {Nome}  Custa  {Valor} R$");
            return Valor;
        }


        public override bool IsComposite()
        {
            return false;
        }


    }


}
