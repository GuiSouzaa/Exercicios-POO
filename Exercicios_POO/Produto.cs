using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int quantidadeEstoque { get; set; }
        

        public double verificarValor()
        {
            return Preco * quantidadeEstoque;
        }

        public bool verificaDisponibilidade()//Usar bool para ver se é verdadeiro ou falso a quantidade que eu defini.
        {
            if (quantidadeEstoque >=1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
