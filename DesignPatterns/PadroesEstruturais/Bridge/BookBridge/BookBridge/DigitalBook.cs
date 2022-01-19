using BookBridge.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookBridge
{
    /// <summary>
    /// ConcreteImplementor   
    /// implementa a interface do Implementor e define sua implementação concreta.
    /// </summary>
    public class DigitalBook : IBook
    {
        private readonly IbookContentProvider _IbookContentProvider;

        public DigitalBook(IbookContentProvider ibookContentProvider)
        {
            _IbookContentProvider = ibookContentProvider;
        }
        public void Publish()
        {
            IEnumerable<string> bookContent = _IbookContentProvider.GetContent();

            Console.WriteLine($"upload digital book to amazon. (${bookContent.Count()} lines )");


        }


    }
}
