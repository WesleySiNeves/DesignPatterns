using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class ComprovanteRecebimentoReinoUnido : PDFDocument
    {
        public override void PrintPDF()
        {
            Console.WriteLine(this.GetType().Name + ": Detalhes do Salário no Reino Unido em PDF");
        }
    }
}
