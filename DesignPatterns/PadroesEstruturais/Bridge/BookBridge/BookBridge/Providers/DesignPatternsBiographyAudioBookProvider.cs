using System;
using System.Collections.Generic;
using System.Text;

namespace BookBridge.Providers
{
    public class DesignPatternsBiographyAudioBookProvider : IbookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>()
            {
              "bridge design patterns",
              "https://refactoring.guru/pt-br/design-patterns/bridge"
           
            };
        }
    }
}
