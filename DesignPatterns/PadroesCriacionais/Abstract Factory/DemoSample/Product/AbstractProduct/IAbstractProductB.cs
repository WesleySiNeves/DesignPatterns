using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSample.Product.AbstractProduct
{
    /// <summary>
    /// declara uma interface para um tipo de objeto de produto
    /// </summary>
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
