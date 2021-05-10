using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = null;
            int [] quantidade = null;
            double [] valor = null;

            //quantidade de produtos
            Console.WriteLine("Olá! Quantos produtos deseja cadastrar?");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            //Fim quantidade de produtos

            //Nome dos produtos
            Console.WriteLine("Quais produtos deseja cadastrar?");
            nome = new string[quantidadeProdutos];

            for (var i = 0; i < quantidadeProdutos; i++)
            {
            Console.WriteLine($"Insira o nome do {i + 1}ª produto: ");
            nome [i] = Console.ReadLine();
            }
            //Fim nome dos produtos

            //Quantidade de cada produto
            Console.WriteLine("Qual a quantidade de cada produto?");
            // int quantidadeCadaProduto = int.Parse(Console.ReadLine());
            quantidade = new int[quantidadeProdutos];

            for (var i = 0; i < quantidadeProdutos; i++)
            {
            Console.WriteLine($"Insira a quantidade do {i + 1}ª produto: ");
            quantidade [i] = int.Parse(Console.ReadLine());
            }
            //Fim quantidade de cada produto

            //Valor de cada produto
            Console.WriteLine("Qual o valor de cada produto?");
            valor = new double[quantidadeProdutos];

            for (var i = 0; i < quantidadeProdutos; i++)
            {
            Console.WriteLine($"Insira o valor do {i + 1}ª produto: ");
            valor [i] = double.Parse(Console.ReadLine());
            }
            //Fim Valor de cada produto

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($@"-------------------------------
|PRODUTO | QUANTIDADE | VALOR |
-------------------------------"
            );
            Console.ResetColor();

            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($@"{nome [i]}         {quantidade [i]}        {valor [i]}"
                );
            }
            Console.WriteLine($@"-------------------------------");
            Console.ResetColor();
        }
    }
}
