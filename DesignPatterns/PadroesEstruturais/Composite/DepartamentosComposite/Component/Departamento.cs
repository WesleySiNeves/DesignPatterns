using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentosComposite.Component
{
    /// <summary>
    /// Representa o Component
    /// 
    /// </summary>
  public abstract  class Departamento
    {

        public string Nome { get; set; }


        public virtual void Add(Departamento component)
        {
            throw  new  NotImplementedException();
        }

        public virtual void Remove(Departamento component)
        {
            throw new NotImplementedException();
        }


        public abstract int GetHorasTrabalhadas();
    }
}
