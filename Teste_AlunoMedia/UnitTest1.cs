using Exercicios_POO;

namespace Teste_AlunoMedia
{
    public class UnitTest1
    {
        [Fact]
        public void calcularmedia()
        {
            Aluno aluno3 = new Aluno("Guilherme", 12345, 8.0, 6.5);
            double media = aluno3.calcularMedia();
            Assert.Equal(7.25, media);

        }

        [Fact]
        public void testarAprovado()
        {
            Aluno aluno3 = new Aluno("Guilherme", 12345, 8.0, 6.5);
            string situacao = aluno3.verificarSituacao();
            Assert.Equal("Aprovado", situacao);

        }

        [Fact]
        public void testarreprovado()
        {
            Aluno aluno3 = new Aluno("Guilherme", 12345, 3.0, 6.5);
            string situacao = aluno3.verificarSituacao();
            Assert.Equal("Reprovado", situacao);
        }
    }
}