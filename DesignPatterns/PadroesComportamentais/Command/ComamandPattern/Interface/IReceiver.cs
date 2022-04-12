using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComamandPattern.Interface
{
    internal interface IReceiver<T>
    {
        void Handle(T commnad);
    }
}
