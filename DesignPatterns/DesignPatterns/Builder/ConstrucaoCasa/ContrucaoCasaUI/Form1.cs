using ContrucaoCasaUISemPadraoCode.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace ContrucaoCasaUISemPadrao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnConstruir.Click += BtnConstruir_Click;

        }




        private void BtnConstruir_Click(object sender, EventArgs e)
        {

            var newCasa = new CasaSemPadraoBuilder(QuantidadeQuartos, QuantidadeBanheiros);


            if (TemGaragem)
            {
                newCasa = new CasaSemPadraoBuilder(QuantidadeQuartos, QuantidadeBanheiros, temGaragem: true);
            }

            if (TemGaragem && TemPiscina)
            {
                newCasa = new CasaSemPadraoBuilder(QuantidadeQuartos, QuantidadeBanheiros, temGaragem: true,temPiscina:true);
            }
            if (TemGaragem && TemPiscina && TemJardim)
            {
                newCasa = new CasaSemPadraoBuilder(QuantidadeQuartos, QuantidadeBanheiros, temGaragem: true, temPiscina: true, temJardim: true);
            }

            if (TemGaragem && TemPiscina && TemJardim  && TemObrasDeArtes)
            {
                newCasa = new CasaSemPadraoBuilder(QuantidadeQuartos, QuantidadeBanheiros, temGaragem: true, temPiscina: true, temJardim: true, temObraArte : true);
            }

            lbPrecoCasa.Text =  newCasa.getPrecoCasa().ToString("n2");


            var resumo = newCasa.getOpcoesSelecionadas().Aggregate((a, b) => a + "\n"+ b);

            MessageBox.Show(resumo,"Resumo da Casa.");

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
