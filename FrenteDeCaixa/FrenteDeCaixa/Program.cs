using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;


            Console.WriteLine("======MERCADIM 1,99======\n\n");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("1 - VENDER\n");
            Console.Write("Escolha a opção desejada: ");
            op = Convert.ToInt16(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 0:

                        break;

                    case 1:
                        Calculadora calc = new Calculadora();

                        Console.Clear();

                        Console.WriteLine("=========VENDAS========= \n");
                        Console.Write("Quantidade de prod: ");
                        calc.Qtd = Convert.ToInt16(Console.ReadLine());

                        decimal total = calc.Total();
                        Console.WriteLine("Total da compra: " + total);
                        Console.WriteLine("");
                        Console.Write("Dinheiro do cliente: R$ ");
                        calc.Valor = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine();
                        decimal troco = calc.Troco();
                        Console.Write("Troco: " + troco);

                        Console.WriteLine("\n\nDeseja fazer mais uma venda? S/N");
                        char resposta = Convert.ToChar(Console.ReadLine());

                        if (resposta == 's' || resposta == 'S')
                        {

                        }
                        else
                        {
                            op = 0;
                        }



                        break;
                }

            } while (op != 0);
        }

    }
}

