using System;
using System.Collections.Generic;
using System.Globalization;

namespace caixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            List<int> saques = new List<int>();

            while (opcao == 1)
            {
                int valorSaque;

                Console.Write("Informe o valor para saque (R$): ");
                valorSaque = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                if (valorSaque % 5 != 0)
                {
                    Console.WriteLine("valor inválido");
                }
                else
                {
                    saques.Add(valorSaque);

                    Console.WriteLine("Histórico de saques: ");
                    foreach (int s in saques)
                    {
                        Console.WriteLine(s + " " + DateTime.Now.ToString());
                    }
                    Console.WriteLine();

                    var caixa = new Caixa1(valorSaque);
                    // var caixa = new Caixa2(valorSaque);

                    OperacaoSaque(caixa);
                }

                Console.WriteLine();
                var texto = $@"
Digite: 
1 - para outro saque
2 - para encerrar
";
                Console.Write(texto);

                opcao = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
            }
        }
        static void OperacaoSaque(ICaixa valor)
        {
            Console.WriteLine(valor.Sacar());
        }
    }
}
