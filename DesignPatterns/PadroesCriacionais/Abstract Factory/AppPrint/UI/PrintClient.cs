using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class PrintClient
    {
        PDFDocument pDFDocument;
        ExcelDocument excelDocument;


        public PrintClient(DocumentFactory documentFactory)
        {
            pDFDocument = documentFactory.GetPDF();

            excelDocument = documentFactory.GetExcel();




        }

        public void Print()
        {
            pDFDocument.PrintPDF();
            excelDocument.PrintExcel();
        }
    }
}
