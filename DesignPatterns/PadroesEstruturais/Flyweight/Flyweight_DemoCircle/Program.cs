// See https://aka.ms/new-console-template for more information
using Flyweight_DemoCircle;
using Flyweight_DemoCirclePadrao;


int Quantidade = 100000;


Console.WriteLine("\n Circulos Amarelos");

for (int i = 0; i <= Quantidade; i++)
{

    var circulo = (Circulo)FormaFactory.GetForma("circulo");
    circulo.SetCor("Amarelo");
    circulo.Desenhar();

}


Console.WriteLine("\n Circulos Verdes");

for (int i = 0; i <= Quantidade; i++)
{

    var circulo = (Circulo)FormaFactory.GetForma("circulo");
    circulo.SetCor("Verde");
    circulo.Desenhar();

}



Console.WriteLine("\n Circulos Vermelhos");

for (int i = 0; i <= Quantidade; i++)
{

    var circulo = (Circulo)FormaFactory.GetForma("circulo");
    circulo.SetCor("Vermelho");
    circulo.Desenhar();

}





Console.WriteLine("\n Circulos Azuis");

for (int i = 0; i <= Quantidade; i++)
{

    var circulo = (Circulo)FormaFactory.GetForma("circulo");
    circulo.SetCor("Azul");
    circulo.Desenhar();

}


Console.WriteLine("\n Circulos Preto");

for (int i = 0; i <= Quantidade; i++)
{

    var circulo = (Circulo)FormaFactory.GetForma("circulo");
    circulo.SetCor("Preto");
    circulo.Desenhar();

}

Console.WriteLine($"Total de Objetos { FormaFactory.GetTotalItens() }");

Console.ReadKey();