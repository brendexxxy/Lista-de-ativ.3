/*-------------------------------------------------------------------
 Questão 3: Gerenciamento de Inventário com Limite e Tipos de
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não
@Lista: 03 - Condicionais
@Autor: Brenda kelly Tavares 
@Data: 08/09/2024
---------------------------------------------------------------------*/
using System;

class GerenciamentoInventario
{
    static void Main(string[] args)
    {
       
        Console.Write("Quantos itens você deseja armazenar no inventário? ");
        int tiposDeItens = int.Parse(Console.ReadLine());

        int totalItens = 0;
        int contador = 1;

        
        while (contador <= tiposDeItens)
        {
            Console.Write($"Digite o nome do item {contador}: ");
            string nomeItem = Console.ReadLine();

            Console.Write($"Quantos itens do tipo {nomeItem} você possui? ");
            int quantidade = int.Parse(Console.ReadLine());

            totalItens += quantidade; 
            contador++;
        }
        
        Console.Write("Qual é a capacidade máxima do inventário? ");
        int capacidadeMaxima = int.Parse(Console.ReadLine());

  
        Console.WriteLine($"\nTotal de itens no inventário: {totalItens}");
        Console.WriteLine(totalItens > capacidadeMaxima ? "Capacidade do inventário EXCEDIDA!" : "Capacidade do inventário OK.");
    }
}
