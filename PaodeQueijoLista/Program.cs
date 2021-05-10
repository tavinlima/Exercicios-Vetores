using System;

namespace PaodeQueijoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pacotes = null;

            Console.WriteLine("Quantos embalagens de pão de queijo tem na prateleira?");
            int quantidadePacotes = int.Parse(Console.ReadLine());
            pacotes = new int[quantidadePacotes];

            for (var i = 0; i < quantidadePacotes; i++)
            {
                Console.WriteLine($"Quantos pães de queijo na {i + 1}ª da embalagem?");
                pacotes [i] = int.Parse(Console.ReadLine());
            }

            int c = 1;
            foreach (var item in pacotes)
            {
                Console.WriteLine($"A {c}ª embalagem possui {item} pães de queijo");
                c++;
            }

    }
}
}
