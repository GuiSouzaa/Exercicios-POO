using System;

namespace Exercicios_POO
{
    public class Aluno
    {
        // Atributos
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double[] Notas { get; set; }

        // Construtor
        public Aluno(string nome, int matricula, double notas1, double nota2)
        {
            Nome = nome;
            Matricula = matricula;
            Notas = new double[] {notas1, nota2};//A minha array guarda as notas 1 e 2, que pega o atributo "Notas".
        }

        // Método para calcular a média
        public double calcularMedia()
        {
            double soma = 0;//Inicia a variavel com um valor nulo

                //for (inicialização; condição; incremento)
                for (int i = 0; i < Notas.Length; i++)//Percore a minha array
                {
                soma += Notas[i];// pega a variavel acima e junta com a lista "Notas".
                }
                 return soma / Notas.Length;//Retorna a variavel fazendo a divisao.(Sempre usar o "Length" quando for uma lista
        }

        public string verificarSituacao()//Aqui uma funcao para realizar a verificao
        {
            double media = calcularMedia();// A variavel vai pegar toda a funcao "calcular media"

            if(media >= 7)//Faz a verificacao se for maior que sete vai dar aprovado.
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
