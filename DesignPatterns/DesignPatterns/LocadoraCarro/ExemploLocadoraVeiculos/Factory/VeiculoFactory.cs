
using PadraoFactoryMethod.ConcreteProduct;
using PadraoFactoryMethod.IProduct;

namespace PadraoFactoryMethod.Factory
{
    public static class VeiculoFactory
    {
        public static IVeiculo Build(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 1:
                    return new Monociclo();
                case 2:
                case 3:
                    return new Moto();
                case 4:
                    return new Carro();
                default:
                    return new Caminhao();

            }
        }
    }
}
