using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeConceptual
{
    /// <summary>
    /// define o comportamento para componentes que têm filhos. armazena componentes filhos.
    /// implementa operações relacionadas ao filho na interface Component.
    /// </summary>
    class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }
    }
}
