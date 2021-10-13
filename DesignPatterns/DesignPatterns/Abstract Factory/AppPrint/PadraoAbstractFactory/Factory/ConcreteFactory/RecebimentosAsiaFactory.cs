using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.Product.ConcreteProduct;

namespace PadraoAbstractFactory.Factory.ConcreteFactory
{
    public class RecebimentosAsiaFactory : DocumentFactory
    {
        public override ExcelDocument GetExcel()
        {
            return new ComprovanteRecebimentoJapao();
        }

        public override PDFDocument GetPDF()
        {
            return new ComprovanteRecebimentoIndia();
        }
    }
}
