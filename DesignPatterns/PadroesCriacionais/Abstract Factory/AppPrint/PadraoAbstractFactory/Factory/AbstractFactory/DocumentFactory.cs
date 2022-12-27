using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Factory.AbstractFactory
{
    public abstract class DocumentFactory
    {
        public abstract PDFDocument GetPDF();
        public abstract ExcelDocument GetExcel();
    }
}
