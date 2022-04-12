using ComamandPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComamandPattern.Concret
{
    public class Command : ICommand
    {

        public int Id { get; private set; }

        public string Name { get; private set; }


        public Command( int id , string name)
        {
            Id = id;
            Name = name;

        }

        public void Execute()
        {
            Console.WriteLine($"Command Execute  {this.Id} - {this.Name}");
        }
    }
}
