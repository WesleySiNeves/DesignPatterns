using ATMDispense.HandlerBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMDispense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSacar.Click += BtnSacar_Click;
        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {



            //create handlers
            var bills50s = new NotaEmDinheiro(50, GetQuantidadeNotas(TipoNotaSaque.Nota50));
            var bills20s = new NotaEmDinheiro(20, GetQuantidadeNotas(TipoNotaSaque.Nota20));
            var bills10s = new NotaEmDinheiro(10, GetQuantidadeNotas(TipoNotaSaque.Nota10));


            bills50s.GetProximaNota(bills20s).GetProximaNota(bills10s);




            var isParsed = int.TryParse(textBox1.Text, out var amount);

            if (isParsed)
            {

                //sender pass the request to first handler in the pipeline
                var isDepensible = bills50s.DispenseRequest(amount);
                if (isDepensible)
                {
                    string message = $"Vc sacou   ${ amount}!";
                    MessageBox.Show(message);

                }
                else
                {
                    string message = $"Desculpe , não há notas suficientes para sacar ${amount}!";
                    MessageBox.Show(message);

                }
            }

        }


        public int GetQuantidadeNotas(TipoNotaSaque tipo)
        {
            int retorno = 0;

            switch (tipo)
            {
                case TipoNotaSaque.Nota50:
                    return int.Parse(UpQuantidadeNotas50.Value.ToString());

                case TipoNotaSaque.Nota20:
                    return int.Parse(UpQuantidadeNotas20.Value.ToString());

                case TipoNotaSaque.Nota10:
                    return int.Parse(UpQuantidadeNotas10.Value.ToString());
                default:
                    break;
            }

            return retorno;
        }


    }

    public enum TipoNotaSaque : int
    {
        Nota50 = 50,
        Nota20 = 20,
        Nota10 = 10
    }


}
