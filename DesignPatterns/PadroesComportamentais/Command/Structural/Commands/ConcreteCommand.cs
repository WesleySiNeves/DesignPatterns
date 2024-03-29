﻿using Structural.Interface;
using Structural.Receptores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Commands
{
    public class ConcreteCommand : Command
    {
        // Constructor
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }
        public override void Execute()
        {
            receiver.Action();
        }
    }
}
