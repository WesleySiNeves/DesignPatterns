using RestauranteAPP.Concret;
using RestauranteAPP.Invoker;
using RestauranteAPP.Receiver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Receiver
            Cheff cheff = new Cheff();


            //Command
            PedidoCommand pedido = new PedidoCommand(cheff,txtPedido.Text);//#Sobremesa

            //Invoker
            Garcon garcon = new Garcon(pedido);

            garcon.Executar();

        }
    }
}
