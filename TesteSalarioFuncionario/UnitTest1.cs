using Exercicios_POO;

namespace TesteSalarioFuncionario
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Funcionario funcionarioAnalista = new Funcionario
            {
                Nome = "Gui",
                Salario = 500,
                Cargo = "Desenvolvedor"
            };

            double descontos = 100;
            double liquido = 400;

            double salarioLiquido = funcionarioAnalista.calcularSalarioLiquido(descontos);
            Assert.Equal(liquido, salarioLiquido);

            Console.WriteLine($"O valor com descontos é de: {salarioLiquido}");



        }
    }
}