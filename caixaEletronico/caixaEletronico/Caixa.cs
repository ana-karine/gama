using System;
using System.Collections.Generic;
using System.Text;

namespace caixaEletronico
{
    public class Caixa
    {
        public Caixa(int valor)
        {
            Valor = valor;
        }

        public int Valor { get; set; }

        public int Sacar()
        {
            int quociente, resto, nota;

            resto = Valor;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");

            Console.WriteLine();
            Console.WriteLine("Valor Total Sacado (R$): ");
            return Valor;
        }
    }
}
