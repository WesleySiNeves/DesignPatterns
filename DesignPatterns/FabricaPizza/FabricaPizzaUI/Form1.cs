using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Padrao = PadraoFactoryMethod;
namespace FabricaPizzaUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFazerPedido_Click(object sender, EventArgs e)
        {
            var localEscolhido = cmbLocalidade.SelectedItem.ToString();


            var pedidos = ListBoxSaboresPizza.SelectedItems;

            try
            {
                Padrao.Creator.PizzaFactoryMethod pizzaria = Padrao.Factory.PizzariaFactory.NewPizzaria(localEscolhido);

                List<Padrao.IProduct.Pizza> pizzas = new List<Padrao.IProduct.Pizza>();

                
                foreach (string sabor in pedidos)
                {
                    Padrao.IProduct.Pizza pizza;
                    if (sabor == "Calabresa")
                    {
                        pizza = pizzaria.MontarPizza(Padrao.ValueObjects.PizzaType.Calabresa);
                        pizza.Mensagens.Add(pizza.Preparar());
                        pizzas.Add(pizza);
                    }
                    if (sabor == "Mussarela")
                    {
                        pizza = pizzaria.MontarPizza(Padrao.ValueObjects.PizzaType.Mussarela);
                        pizza.Mensagens.Add(pizza.Preparar());
                        pizzas.Add(pizza);

                    }
                    if (sabor == "Margarita")
                    {
                        pizza = pizzaria.MontarPizza(Padrao.ValueObjects.PizzaType.Margarita);
                        pizza.Mensagens.Add(pizza.Preparar());
                        pizzas.Add(pizza);

                    }
                }

                foreach (var resumo in pizzas.SelectMany(x=>x.Mensagens))
                {
                    MessageBox.Show(resumo);
                }

                MessageBox.Show("Fizzas Finalizadas");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
             
            }
            

        }
    }
}
