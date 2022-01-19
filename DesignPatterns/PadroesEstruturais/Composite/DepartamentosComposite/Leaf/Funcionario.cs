using DepartamentosComposite.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentosComposite.Leaf
{
    public class Funcionario : Departamento
    {
        public int Id { get; set; }

        public int Horas { get; set; }


        public override int GetHorasTrabalhadas()
        {
            Console.WriteLine($"O funcionário {Nome}  registrou {Horas} trabalhadas" );
            return Horas;
        }
    }
}
