using System;
using System.Collections.Generic;

namespace ContrucaoCasaUISemPadraoCode.Product
{
    public class CasaSemPadraoBuilder : ICasaSemPadraoBuilder
    {
        private readonly decimal _valorPorQuarto = 30000;
        private readonly decimal _valorPorBanheiro = 8000;
        private readonly decimal _valorComPiscina = 100000;
        private readonly decimal _valorComObrasArtes = 10000;
        private readonly decimal _valorComGaragem = 100000;
        private readonly decimal _valorComJardins = 50000;


        public int QuantidadeQuartos { get; set; }

        public int QuantidadeBanheiros { get; set; }

        public bool Temgaragem { get; set; }

        public bool TemJardim { get; set; }


        public bool TemPiscina { get; set; }

        public bool TemObrasDeArtes { get; set; }

        public CasaSemPadraoBuilder(int quantidadeQuartos, int quantidadeBanheiros)
        {
            this.QuantidadeQuartos = quantidadeQuartos;
            this.QuantidadeBanheiros = quantidadeBanheiros;

        }
        public CasaSemPadraoBuilder(int quantidadeQuartos, int quantidadeBanheiros, bool temGaragem)
            : this(quantidadeQuartos, quantidadeBanheiros)
        {

            this.Temgaragem = temGaragem;

        }

        public CasaSemPadraoBuilder(int quantidadeQuartos, int quantidadeBanheiros, bool temGaragem, bool temPiscina)
            : this(quantidadeQuartos, quantidadeBanheiros, temGaragem)
        {
            this.TemPiscina = temPiscina;

        }

        public CasaSemPadraoBuilder(int quantidadeQuartos, int quantidadeBanheiros, bool temGaragem, bool temPiscina, bool temJardim)
             : this(quantidadeQuartos, quantidadeBanheiros, temGaragem, temPiscina)
        {

            this.TemJardim = temJardim;


        }

        public CasaSemPadraoBuilder(int quantidadeQuartos, int quantidadeBanheiros, bool temGaragem, bool temPiscina, bool temJardim, bool temObraArte)
             : this(quantidadeQuartos, quantidadeBanheiros, temGaragem, temPiscina, temJardim)
        {
            this.TemObrasDeArtes = temObraArte;
        }

        public List<string> getAllOpcoes()
        {
            List<string> retorno = new List<string>();

            retorno.Add("Casa com Garagem");
            retorno.Add("Casa com Piscina");
            retorno.Add("Casa com Obras de artes");
            retorno.Add("Casa com Jardins");



            return retorno;
        }


        public List<string> getOpcoesSelecionadas()
        {
            List<string> retorno = new List<string>();

            retorno.Add($"Casa com {QuantidadeQuartos} quartos");

            retorno.Add($"Casa com {QuantidadeBanheiros} banheiros");

            if (Temgaragem)
                retorno.Add("Casa com Garagem");

            if (TemJardim)
                retorno.Add("Casa com Jardins");

            if (TemPiscina)
                retorno.Add("Casa com Piscina");

            if (TemObrasDeArtes)
                retorno.Add("Casa com Obras de artes");


            return retorno;
        }


        public decimal getPrecoCasa()
        {
            decimal precoInicial = 50000;

            precoInicial += QuantidadeQuartos * _valorPorQuarto;
            precoInicial += QuantidadeBanheiros * _valorPorBanheiro;

            if (Temgaragem)
            {
                precoInicial += _valorComGaragem;
            }

            if (TemJardim)
            {
                precoInicial += _valorComJardins;
            }

            if (TemObrasDeArtes)
            {
                precoInicial += _valorComObrasArtes;
            }

            if (TemPiscina)
            {
                precoInicial += _valorComPiscina;
            }

            return precoInicial;
        }
    }
}
