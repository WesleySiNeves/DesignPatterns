using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.Product.ConcreteProduct;
using System;

namespace PadraoAbstractFactory.Factory.ConcreteFactory
{
    public class RecebimentosEuropaFactory : DocumentFactory
    {
        public override ExcelDocument GetExcel()
        {
            return new ComprovanteRecebimentoFranca();
        }

        public override PDFDocument GetPDF()
        {
            return new ComprovanteRecebimentoReinoUnido();
        }
    }
}
