using Conceptual;
using Conceptual.Util;
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
            btnClonar.Click += BtnClonar_Click;
            btnCriarCarro.Click += BtnCriarCarro_Click;
        }

        private void BtnCriarCarro_Click(object sender, EventArgs e)
        {
            List<Carro> listaCarros = new List<Carro>();

            var carroPai = CriarCarro();

            int quantidade = int.Parse(txtQuantidadeCarros.Text);


            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < quantidade; i++)
            {
                var newCarro = carroPai.DeepCopy();
               
                listaCarros.Add(newCarro);
            }
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            lblTempoGastoNew.Text = ts.ToString("mm\\:ss\\.ff");
            Empty(listaCarros);
        }

        private void BtnClonar_Click(object sender, EventArgs e)
        {
            List<Carro> listaCarros = new List<Carro>();

            var carroPai = CriarCarro();

            int quantidade = int.Parse(txtQuantidadeCarros.Text);
            
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < quantidade; i++)
            {
                var newCarro = carroPai.ShallowCopy();
                newCarro.Chassi = Guid.NewGuid();

                listaCarros.Add(newCarro);
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            lblTempoGastoClonagem.Text = ts.ToString("mm\\:ss\\.ff");

            Empty(listaCarros);
        }

        public Carro CriarCarro()
        {
            var carroPai = new Carro(chassi: Guid.NewGuid());
            carroPai.Ano = (int)txtAno.Value;
            carroPai.Marca = txtMarca.Text;
            carroPai.Modelo = txtModelo.Text;

            //carroPai.MotorCarro = new Motor();
            //carroPai.MotorCarro.Potencia = txtPotencia.Text;
            //carroPai.MotorCarro.QuantidadCavalos = int.Parse(txtQuantidadeCavalos.Text);

            return carroPai;
        }

        public void Empty(List<Carro> lista)
        {
            lista.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
