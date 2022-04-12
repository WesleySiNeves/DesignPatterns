using ComamandPattern.Concret;
using ComamandPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComamandPattern.Receiver
{
    public class Receiver : IReceiver<Command>
    {
        public void Handle(Command commnad)
        {
            commnad.Execute();
        }
    }
}
