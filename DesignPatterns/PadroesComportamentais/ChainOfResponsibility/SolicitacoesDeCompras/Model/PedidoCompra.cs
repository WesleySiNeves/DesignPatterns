using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitacoesDeCompras.Model
{
    public class PedidoCompra
    {
        int number;
        double amount;
        string purpose;
        // Constructor
        public PedidoCompra(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }
        // Gets or sets purchase number
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        // Gets or sets purchase amount
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        // Gets or sets purchase purpose
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
    }   
}
