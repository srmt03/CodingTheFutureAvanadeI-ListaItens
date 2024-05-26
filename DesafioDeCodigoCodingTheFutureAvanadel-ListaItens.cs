using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        for (int i = 1; i <=3; i++)
        {
            //Console.WriteLine($"Digite o nome do {i}º personagem: ");
            string nomePersonagem = Console.ReadLine();
            itens.Add(nomePersonagem);
        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    }
}