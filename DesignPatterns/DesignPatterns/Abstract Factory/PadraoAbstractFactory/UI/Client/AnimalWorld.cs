using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Client
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;


        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
        public void RunFoodChain()
        {
            _herbivore.Comer();
            _carnivore.Comer(_herbivore);

        }
    }
}
