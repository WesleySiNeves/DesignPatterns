using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class ComprovanteRecebimentoFranca : ExcelDocument
    {
        public override void PrintExcel()
        {
            Console.WriteLine(this.GetType().Name + ": Detalhes do Salário na Franca em Excel");
        }
    }
}
