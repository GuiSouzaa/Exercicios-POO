using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public Carro()
        {
            Velocidade = 0;
        }

        public void Acelerar(int aumento)
        {
            Velocidade += aumento;
            Console.WriteLine($"Acelerou para {Velocidade}");
        }

        public void Frear(int reduzir)
        {
            Velocidade -= reduzir;
            if(Velocidade < 0)
            {
                Velocidade = 0;
            }
            Console.WriteLine($"Freou o carro freou para {Velocidade}");
        }

        public void VelocidadeAtual()
        {
            
            Console.WriteLine($"A velocidade do carro é: {Velocidade}");
        }
    }
}
