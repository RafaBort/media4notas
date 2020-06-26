using System;

namespace media4notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VAMOS CALCULAR SUA MÉDIA...");
            Console.WriteLine("digite a primeira nota...");

            String numero1 = Console.ReadLine();
            Decimal numero10 = Convert.ToDecimal(numero1);

            Console.WriteLine("digite a segunda nota...");

            String numero2 = Console.ReadLine();
            Decimal numero20 = Convert.ToDecimal(numero2);

            Console.WriteLine("digite a terceira nota...");

            String numero3 = Console.ReadLine();
            Decimal numero30 = Convert.ToDecimal(numero3);

             Console.WriteLine("digite a quarta nota...");

            String numero4 = Console.ReadLine();
            Decimal numero40 = Convert.ToDecimal(numero4);
            
            Decimal resultado = numero10 + numero20 + numero30 + numero40;

            Decimal resultadofinal = resultado / 4;

            Console.WriteLine( resultadofinal );

        }
    }
}
