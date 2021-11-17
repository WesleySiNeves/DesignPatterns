using Conceptual.ConcretPrototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShallowCopy = Conceptual.ConcretPrototype.ShallowCopy;
using DeepCopy = Conceptual.ConcretPrototype.DeepCopy;

namespace SoldadoUi
{
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
            btnDeepCopy.Click += BtnDeepCopy_Click;
            btnShallowCopy.Click += BtnShallowCopy_Click;
        }



        private void BtnShallowCopy_Click(object sender, EventArgs e)
        {
            List<ShallowCopy.Soldado> listaSoldados = new List<ShallowCopy.Soldado>();

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();



            var soldado = CriarSoldado();


            int quantidade = int.Parse(txtQuantidadeSoldados.Text);


          
            stopwatch.Start();


            for (int i = 0; i < quantidade; i++)
            {
                ShallowCopy.Soldado newSoldado = (ShallowCopy.Soldado)soldado.Clone();
                newSoldado.Id = Guid.NewGuid();
                newSoldado.Nome = Guid.NewGuid().ToString();

                listaSoldados.Add(newSoldado);
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            lblTempoShallowCopy.Text = ts.ToString("mm\\:ss\\.ff");

            /// <summary>
            /// ShallowCopy ao mapear as entidades complexas , executa o mapeamento apenas da referencia.
            /// </summary>
            listaSoldados.Last().Acessorio.Nome = "Fuzil";

            string resumo = string.Empty;

            if (listaSoldados.Count <= 4)
            {
                foreach (var item in listaSoldados)
                {
                    resumo += $"Soldado : {item.Nome}, Idade :{item.Idade} \n";

                    resumo += $"Acessorios : {item.Acessorio.Nome}\n";

                }

                MessageBox.Show(resumo, "informações.");
            }
            Empty(listaSoldados);
        }

        private void BtnDeepCopy_Click(object sender, EventArgs e)
        {
            List<DeepCopy.Soldado> listaSoldados = new List<DeepCopy.Soldado>();

            var soldado = CriarSoldadoDeepCopy();

            int quantidade = int.Parse(txtQuantidadeSoldados.Text);



            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < quantidade; i++)
            {
                DeepCopy.Soldado newSoldado = (DeepCopy.Soldado)soldado.Clone();
                newSoldado.Id = Guid.NewGuid();
                newSoldado.Nome = Guid.NewGuid().ToString();

                listaSoldados.Add(newSoldado);
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            lblDeepCopy.Text = ts.ToString("mm\\:ss\\.ff");

            /// <summary>
            /// ShallowCopy ao mapear as entidades complexas , executa o mapeamento apenas da referencia.
            /// </summary>
            listaSoldados.Last().Acessorio.Nome = "Fuzil";

            string resumo = string.Empty;

            if (listaSoldados.Count <= 4)
            {
                foreach (var item in listaSoldados)
                {
                    resumo += $"Soldado : {item.Nome}, Idade :{item.Idade} \n";

                    resumo += $"Acessorios : {item.Acessorio.Nome}\n";

                }

                MessageBox.Show(resumo, "informações.");
            }
            EmptyDeepCopy(listaSoldados);
        }



        public ShallowCopy.Soldado CriarSoldado()
        {
            var soldado = new ShallowCopy.Soldado();

            soldado.Nome = Guid.NewGuid().ToString();
            soldado.Id = Guid.NewGuid();
            soldado.Idade = Conceptual.Util.RandonUtil.GetRandonInt(18, 55);

            soldado.Acessorio = new ShallowCopy.Acessorio();

            if (ListBoxAcessorios.CheckedItems[0] != null)
            {
                string item = ListBoxAcessorios.CheckedItems[0].ToString();

                soldado.Acessorio = new ShallowCopy.Acessorio { Nome = item };
            }


            return soldado;
        }


        public DeepCopy.Soldado CriarSoldadoDeepCopy()
        {
            var soldado = new DeepCopy.Soldado();

            soldado.Nome = Guid.NewGuid().ToString();
            soldado.Id = Guid.NewGuid();
            soldado.Idade = Conceptual.Util.RandonUtil.GetRandonInt(18, 55);

            soldado.Acessorio = new DeepCopy.Acessorio();

            if (ListBoxAcessorios.CheckedItems[0] != null)
            {
                string item = ListBoxAcessorios.CheckedItems[0].ToString();

                soldado.Acessorio = new DeepCopy.Acessorio { Nome = item };
            }


            return soldado;
        }

        public void Empty(List<ShallowCopy.Soldado> lista)
        {
            lista.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void EmptyDeepCopy(List<DeepCopy.Soldado> lista)
        {
            lista.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

    }
}
