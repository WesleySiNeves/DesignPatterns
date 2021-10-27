
using Conceptual.Builder.Concrect;
using Conceptual.Builder.Contract;
using Conceptual.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace ContrucaoCasa.Padrao.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnContruirCasaPadrao.Click += BtnContruirCasaPadrao_Click;
            btnCasaComJardins.Click += BtnCasaComJardins_Click;
            btnCasaComObrasDeArtes.Click += BtnCasaComObrasDeArtes_Click;
            btnCasaComPiscina.Click += BtnCasaComPiscina_Click;


            btnCustomizarCasa.Click += BtnCustomizar_Click;




        }

        private void BtnCasaComPiscina_Click(object sender, EventArgs e)
        {
            var director = new CasaDirector();
            ICasaBuilder builder = new CasaBuilder();
            director.Builder = builder;


            director.BuildCasaComPiscina(QuantidadeQuartos, QuantidadeBanheiros);

            var resumo = builder.Build().getOpcoesSelecionadas().Aggregate((a, b) => a + "\n" + b);


            lbPrecoCasa.Text = builder.Build().getPrecoCasa().ToString("n2");


            MessageBox.Show(resumo, "Resumo da Casa.",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCasaComObrasDeArtes_Click(object sender, EventArgs e)
        {
            var director = new CasaDirector();
            var builder = new CasaBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildCasaComObraDeArtes(QuantidadeQuartos, QuantidadeBanheiros);

            var resumo = builder.Build().getOpcoesSelecionadas().Aggregate((a, b) => a + "\n" + b);


            lbPrecoCasa.Text = builder.Build().getPrecoCasa().ToString("n2");


            MessageBox.Show(resumo, "Resumo da Casa.");
        }

        private void BtnCasaComJardins_Click(object sender, EventArgs e)
        {
            var director = new CasaDirector();
            var builder = new CasaBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildCasaComJardins(QuantidadeQuartos, QuantidadeBanheiros);

            var resumo = builder.Build().getOpcoesSelecionadas().Aggregate((a, b) => a + "\n" + b);


            lbPrecoCasa.Text = builder.Build().getPrecoCasa().ToString("n2");


            MessageBox.Show(resumo, "Resumo da Casa.");
        }

        private void BtnContruirCasaPadrao_Click(object sender, EventArgs e)
        {
            var director = new CasaDirector();
            var builder = new CasaBuilder();
            director.Builder = builder;


            director.BuildCasaPadrao();

            var resumo = builder.Build().getOpcoesSelecionadas().Aggregate((a, b) => a + "\n" + b);


            lbPrecoCasa.Text = builder.Build().getPrecoCasa().ToString("n2");


            MessageBox.Show(resumo, "Resumo da Casa.");

        }

        private void BtnCustomizar_Click(object sender, EventArgs e)
        {
            var director = new CasaDirector();
            var builder = new CasaBuilder();
            director.Builder = builder;

            builder.AddBanheiros(QuantidadeBanheiros).AddQuartos(QuantidadeQuartos);




            if (TemGaragem)
            {
                builder.AddGaragem();
            }
            if (TemJardim)
            {
                builder.AddJardins();
            }

            if (TemObrasDeArtes)
            {
                builder.AddObrasDeArtes();
            }

            if (TemPiscina)
            {
                builder.AddPiscina();
            }


            var resumo = builder.Build().getOpcoesSelecionadas().Aggregate((a, b) => a + "\n" + b);
            lbPrecoCasa.Text = builder.Build().getPrecoCasa().ToString("n2");

            MessageBox.Show(resumo, "Resumo da Casa.");
        }




        public int QuantidadeQuartos
        {
            get
            {
                return int.Parse(UpDownQuantidadeQuartos.Value.ToString());
            }
            set
            {
                UpDownQuantidadeQuartos.Value = value;
            }

        }
        public int QuantidadeBanheiros
        {
            get
            {
                return int.Parse(UpDownQuantidadeBanheiros.Value.ToString());
            }
            set
            {
                UpDownQuantidadeBanheiros.Value = value;
            }

        }
        public bool TemGaragem
        {
            get
            {
                return GetItensSelecionados().Contains("Casa com Garagem");
            }


        }


        public bool TemJardim
        {
            get { return GetItensSelecionados().Contains("Casa com Jardins"); }


        }
        public bool TemPiscina
        {
            get { return GetItensSelecionados().Contains("Casa com Piscina"); }


        }
        public bool TemObrasDeArtes
        {
            get { return GetItensSelecionados().Contains("Casa com Obras de artes"); }

        }

        public List<string> GetItensSelecionados()
        {
            List<string> retorno = new List<string>();

            foreach (var item in checkedListOpcoes.CheckedItems)
            {
                retorno.Add(item.ToString());

            }
            return retorno;
        }

    }
}
