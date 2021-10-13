using PadraoAbstractFactory.Product.AbstractProduct;
using System;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class ComprovanteRecebimentoIndia : PDFDocument
    {
        public override void PrintPDF()
        {
            Console.WriteLine(this.GetType().Name + ": Detalhes do Salário na India em PDF ");
        }
    }
}
