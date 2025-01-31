using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }


        public double calcularSalarioLiquido(double descontos)
        {
            return Salario -= descontos;

        }

    }
}
