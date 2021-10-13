using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.ValueObjects
{
    public enum PizzaType : byte
    {

        Calabresa = 1,
        Mussarela = 2,
        Margarita = 3,


    }

    public enum TipoMassa : byte
    {

        Pizza = 1,
        Bolo = 2
    }

    public enum TipoBolo : byte
    {

        Chocolate = 1,
        Milho = 2
    }
}
