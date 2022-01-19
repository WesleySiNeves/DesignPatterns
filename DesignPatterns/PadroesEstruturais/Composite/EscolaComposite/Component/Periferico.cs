using VendaComputadoresComposite.Leaf;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendaComputadoresComposite.Component
{
    /// <summary>
    /// Representa o Component
    /// </summary>
    public abstract class Periferico
    {

        public string Nome { get; set; }


        public virtual void Add(Periferico component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Periferico component)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// metodo para retornar se pode ter filhos
        /// </summary>
        /// <returns></returns>
        public virtual bool IsComposite()
        {
            return true;
        }
        public abstract decimal GetValor();
    }
}
