using System;
using Exercicios_POO;

class Program
{
    static void Main(string[] args) 
    {
        ContaBancaria contaGui = new ContaBancaria();
        contaGui.numero_conta = 505;
        contaGui.nome_titular = "Guilherme R.";
        contaGui.saldo = 0;

        Console.WriteLine($"O saldo da sua conta é de: {contaGui.saldo:F2}");

        contaGui.Depositar(1); //Defino a valor que vai ser depositado aqui

        Console.WriteLine($"O valor de: {contaGui.Depositar} foi realizado com sucessos!");
    }
}
