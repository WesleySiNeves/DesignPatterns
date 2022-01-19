// See https://aka.ms/new-console-template for more information
using FlyweightSoldado;

Console.WriteLine("Jogos dos Power Ranges");


CreateSoldier(TipoSoldado.PowerRanger, "Penihel", "Vermelho");

Console.WriteLine();

CreateSoldier(TipoSoldado.PowerRanger, "Wesley", "Preto");

Console.WriteLine();

CreateSoldier(TipoSoldado.PowerRanger, "Felipe", "Verde");

Console.WriteLine();

CreateSoldier(TipoSoldado.PowerRanger, "Miller", "Azul");


Console.WriteLine();

CreateSoldier(TipoSoldado.PowerRanger, "Paulo R", "Dourado");


Console.WriteLine();

CreateSoldier(TipoSoldado.PowerRanger, "?", "Rosa");


Console.WriteLine("Total de itens {0}",SoldadoFactory.GetTotalItens());



/*Version Criando uma arena de batalha*/


int quantidade = 100000;
SoldadoFactory.Clear();

DoCreator(quantidade, TipoSoldado.Arma);
DoCreator(quantidade, TipoSoldado.Espada);
DoCreator(quantidade, TipoSoldado.Lanca);


Console.WriteLine("Total de itens {0}", SoldadoFactory.GetTotalItens());




/// <summary>
/// Criando Soldados Armados
/// </summary>



void DoCreator(int quantidade, TipoSoldado tipo)
{
    for (int index = 0; index < quantidade; index++)
    {
        if (index < 1000)
        {
            CreateSoldier(tipo, $"Boot {index}", "Vermelho");
        }

        if (index >= 1000 && index <= 3000)
        {
            CreateSoldier(tipo, $"Boot {index}", "Azul");
        }

        if (index >= 3000 && index <= 3000)
        {
            CreateSoldier(tipo, $"Boot {quantidade}", "Verde");
        }

    }
}





void CreateSoldier(TipoSoldado Tipo, string name, string Cor)
{

    Soldado soldier = SoldadoFactory.GetSoldier(Tipo);

    soldier.RenderSoldado(name, Cor);

}


