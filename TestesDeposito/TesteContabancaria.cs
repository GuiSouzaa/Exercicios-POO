using Exercicios_POO;

namespace TestesDeposito
{
    public class TesteContabancaria
    {
        [Fact]
        public void ContaBancariaTests()
        {
            ContaBancaria conta = new ContaBancaria();
            conta.saldo = 100;

            conta.Depositar(50);

            Assert.Equal(150, conta.saldo);
            
        }

        [Fact]
        public void saque()
        {
            ContaBancaria conta1 = new ContaBancaria();
            conta1.saldo = 50;
            conta1.Sacar(10);

            Assert.Equal(40, conta1.saldo);
            

            // O Assert verifica o resultado esperado.
        }
    }
}
