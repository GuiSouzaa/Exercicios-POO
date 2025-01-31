using Exercicios_POO;

namespace TesteCarro
{
    public class UnitTest1
    {
        [Fact]
        public void acelerar()
        {
            Carro carro1 = new Carro();
            carro1.Acelerar(30);
            Assert.Equal(30, carro1.Velocidade);
        }

        [Fact]
        public void Frear()
        {
            Carro carro1 = new Carro();
            carro1.Acelerar(20);
            carro1.Frear(30);
            Assert.Equal(0, carro1.Velocidade);
        }
    }
}