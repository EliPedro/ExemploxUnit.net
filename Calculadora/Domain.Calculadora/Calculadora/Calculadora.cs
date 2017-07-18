namespace Domain.Calculadora.Calculadora
{
    public class Calculadora
    {
        public static int Soma(int v1, int v2) 
        => v1 + v2;
        public static int Divisao(int v1, int v2) 
        => v1 / v2;
        public static int Multiplicacao(int v1, int v2) 
        => v1 * v2;
        public static int Subtracao(int v1, int v2) 
        => v1 / v2;
        public static bool EhPar(int v1)
         => v1 % 2 == 0;
    }
}