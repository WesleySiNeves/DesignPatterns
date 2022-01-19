using Conceptual.Subsystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        protected Subsystem3 _subsystem3;

        private Facade()
        {
        }
        public Facade(Subsystem1 _subsystem1)
        {
            this._subsystem1 = _subsystem1;
        }

        public Facade(Subsystem1 _subsystem1, Subsystem2 _subsystem2)
        {
            this._subsystem1 = _subsystem1;
            this._subsystem2 = _subsystem2;
        }

        public Facade(Subsystem1 _subsystem1, Subsystem2 _subsystem2, Subsystem3 _subsystem3)
        {
            this._subsystem1 = _subsystem1;
            this._subsystem2 = _subsystem2;
            this._subsystem3 = _subsystem3;
        }

        public string OperationOnSubsystem1And2()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1?.operation1();
            result += this._subsystem2?.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1?.operationN();
            result += this._subsystem2?.operationZ();
            return result;

        }

        public string OperationOnSubsystem1And2And3()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1?.operation1();
            result += this._subsystem2?.operation1();
            result += this._subsystem3?.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1?.operationN();
            result += this._subsystem2?.operationZ();
            result += this._subsystem3?.operationW();
            return result;

        }
    }
}
