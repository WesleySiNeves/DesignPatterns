using DepartamentosComposite.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentosComposite.Composite
{
    public class Organizacao : Departamento
    {
        protected List<Departamento> departamentos = new List<Departamento>();

        public override void Add(Departamento component)
        {
            departamentos.Add(component);
        }

        public override void Remove(Departamento component)
        {
            departamentos.Remove(component);
        }

        public override int GetHorasTrabalhadas()
        {
            int horasTrabalhadas = 0;

            foreach (var departamento  in departamentos)
            {
                horasTrabalhadas += departamento.GetHorasTrabalhadas();
            }

            Console.WriteLine($"{Nome}  registrou  um total  de [{horasTrabalhadas}]  horas \n");

            return horasTrabalhadas;
        }
    }
}
