using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO
{

    //Implemente uma classe chamada “ContaBancária” que possua atributos para armazenar o
    //número da conta, nome do titular e saldo. Adicione métodos para realizar depósitos e saques.
    public class ContaBancaria
    {
        public int numero_conta { get; set; }
        public string nome_titular {get; set;}
        public double saldo { get; set; }

        public void Depositar(double valor)
        {
            if (valor > 0 )
            {
                saldo += valor;
                Console.WriteLine($"o valor: {valor:F2} foi depositado com sucesso");
            }
        }

        public void Sacar(double valor)
        {
            if(valor > 0)
            {
                saldo -= valor;
                Console.WriteLine("O valor do saque de: ");
            }
        }
       
    }
}
