using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeConceptual
{

    // A classe base Component declara operações comuns para  objetos simples e
    // objetos complexos de uma composição

    /// <summary>
    /// declara a interface para objetos na composição.
    /// implementa o comportamento padrão para a interface comum a todas as classes, conforme apropriado.
    ///  declara uma interface para acessar e gerenciar seus componentes filhos.
    /// </summary>
    public abstract class Component
    {
        public Component()
        {

        }

        public abstract string Operation();

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component component)
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
    }
}
