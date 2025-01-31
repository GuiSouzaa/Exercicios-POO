using System;
using System.Security.Cryptography.X509Certificates;
using Exercicios_POO;

class Program
{
    static void Main(string[] args) 
    {
        //CriarContabancaria();
        //Calcularmedia();

    }
    public static void CriarContabancaria()
    {
        ContaBancaria contaGui = new ContaBancaria();
        contaGui.numero_conta = 505;
        contaGui.nome_titular = "Guilherme R.";
        contaGui.saldo = 0;

        Console.WriteLine($"O saldo da sua conta é de: {contaGui.saldo:F2}");

        contaGui.Depositar(1); //Defino a valor que vai ser depositado aqui

        Console.WriteLine($"O valor de: {contaGui.Depositar} foi realizado com sucessos!");
    }
    public static void Calcularmedia()
    {
        Aluno aluno1 = new Aluno("Guilherme", 12345, 8.0, 6.5);
        Console.WriteLine($"O aluno {aluno1.Nome}");
        Console.WriteLine($"Com a matricula {aluno1.Matricula}");
        Console.WriteLine($"A media foi de {aluno1.calcularMedia():F2}");
        Console.WriteLine($"A situacao dele foi: {aluno1.verificarSituacao()}");
    }
}
