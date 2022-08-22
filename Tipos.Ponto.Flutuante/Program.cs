using System;

namespace Tipos.Ponto.Flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            var valorDigitado1 = Console.ReadLine();
            decimal primeiroValor = decimal.Parse(valorDigitado1);

            var valorDigitado2 = Console.ReadLine();
            decimal segundoValor = decimal.Parse(valorDigitado2);

            Console.WriteLine("Soma = " + (primeiroValor + segundoValor));

            #region pontos flutuantes

            //int inteiro1 = 1;
            //int inteiro2 = 2;

            //float float1 = 10.10f;
            //float float2 = 20.20f;

            //decimal decimal1 = 10.10m;
            //decimal decimal2 = 20.20m;

            //Console.WriteLine("Resultado comparação float= " + ((float1 + float2) == 30.30f));
            //Console.WriteLine("Resultado soma = " + (float1 + float2));

            //Console.WriteLine("Resultado comparação decimal= " + ((decimal1 + decimal2) == 30.30m));
            //Console.WriteLine("Resultado soma = " + (decimal1 + decimal2));

            //Console.WriteLine("float1 = " + float1);
            //Console.WriteLine("float2 = " + float2);
            //Console.WriteLine("Valor minimo inteiro = " + int.MinValue);
            //Console.WriteLine("Valor maximo inteiro = " + int.MaxValue);
            //Console.WriteLine("Valor minimo float = " + float.MinValue);
            //Console.WriteLine("Valor maximo float = " + float.MaxValue);
            //Console.WriteLine("Valor minimo decimal = " + decimal.MinValue);
            //Console.WriteLine("Valor maximo decimal = " + decimal.MaxValue);
            
            #endregion pontos flutuantes

            Console.ReadKey();
        }
    }
}
