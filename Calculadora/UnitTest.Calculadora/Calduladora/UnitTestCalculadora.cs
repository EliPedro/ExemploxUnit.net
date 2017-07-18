using System;
using System.Collections.Generic;
using Xunit;
using Cal = Domain.Calculadora.Calculadora;
namespace UnitTest.Calculadora.Calduladora
{
    // AAA (Arrange, Act, Assert)
    public class UnitTestCalculadora
    {
        public static IEnumerable<object[]> TestData
          => new object [][]  {
                new object[] { 42 },
                new object[] { 21.12 },
                new object[] { DateTime.Now },
                new object[] { null }
          };

        
        [Fact(DisplayName = "Soma")]
        public void Calculadora_Soma_EhValido()
        => Assert.Equal(4, Cal.Calculadora.Soma(2, 2));

        [Fact(DisplayName = "Multiplicacao")]
        public void Calculadora_Multiplicacao_EhValido()
        => Assert.Equal(10, Cal.Calculadora.Multiplicacao(5, 2));


        [Fact(DisplayName = "Não é nulo")]
        [MemberData(nameof(TestData))]
        public void UnitTestCalculadora_NaoEhNull_NaoEhNulo(object data)
        => Assert.NotNull(data);
        
     
        [Theory(DisplayName = "Par")]
        [InlineData(2)]
        public void Calculadora_EhPar_NumeroEhPar(int v)
         => Assert.True(Cal.Calculadora.EhPar(v));


    }

  

}
