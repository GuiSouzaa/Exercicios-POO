using Exercicios_POO;

namespace TesteEstoque
{
    public class UnitTest1
    {
        [Fact]
        public void verificarValor()
        {
            Produto produtoPerifericos = new Produto
            {
                Nome = "Mouse",
                Preco = 50,
                quantidadeEstoque = 10
            };

            double esperado = 500;
            double resultado = produtoPerifericos.verificarValor();

            Assert.Equal(esperado, resultado);

        }

        [Fact]
        public void verificarDisponibilidade()
        {
            Produto produtoMonitor = new Produto
            {
                Nome = "monitor",
                Preco = 10,
                quantidadeEstoque = 1
            };

            bool resultado = produtoMonitor.verificaDisponibilidade();
            Assert.True(resultado);
        }
    }
}