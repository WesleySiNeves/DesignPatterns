using System;
using System.Collections.Generic;
using System.Text;

namespace BookBridge.Providers
{
    public class AutoBiographyAudioBookProvider : IbookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>()
            {
              "Hoje vou tentar mostrar um pouco de design patterns",
              "Vamos ver o padrão  Bridge",
              "será que vou conseguir explicar ?"
            };
        }
    }
}
