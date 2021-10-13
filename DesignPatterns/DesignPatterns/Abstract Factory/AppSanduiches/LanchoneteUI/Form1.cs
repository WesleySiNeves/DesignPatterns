using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Factory.ConcretFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanchoneteUI
{
    public partial class Form1 : Form
    {

        CardapioFactory factory;


        public Form1()
        {
            InitializeComponent();
        }

        private void cmbTipoCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = cmbTipoCardapio.SelectedItem.ToString();

            switch (select)
            {
                case "Adulto":
                    factory = new AdultoCardapioFactory();
                    break;

                case "Infantil":
                    factory = new InfantilCardapioFactory();
                    break;

                default:
                    throw new NotImplementedException();


            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateSobremesa();

            List<string> data = new List<string>();

            data.Add(sandwich.GetType().Name);
            data.Add(dessert.GetType().Name);

            checkedListItensCardapio.DataSource = data;
          
        }
    }
}
