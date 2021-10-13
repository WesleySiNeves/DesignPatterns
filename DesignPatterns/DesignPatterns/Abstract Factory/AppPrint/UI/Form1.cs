using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Factory.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnExecutar.Click += BtnExecutar_Click;
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            DocumentFactory abstractFactoryAsia = new RecebimentosAsiaFactory();
            DocumentFactory abstractFactoryEuropa = new RecebimentosEuropaFactory();

            // Instantiating & Initializing the Client class 
            // in order to delegate the responsibility of invoking the method(s) defined inside the AbstractFactory
            PrintClient oPrintClientAsia = new PrintClient(abstractFactoryAsia);
            PrintClient oPrintClientEurope = new PrintClient(abstractFactoryEuropa);

            // Invoke the method to get the actual product using object of Client  
            oPrintClientAsia.Print();
            oPrintClientEurope.Print();

          
        }
    }
}
