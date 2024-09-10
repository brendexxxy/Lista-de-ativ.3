/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade. Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1.
Pergunte ao jogador quantas missões ele completou.
2.
Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3.
Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
•
Fácil: 50 pontos por inimigo
•
Médio: 100 pontos por inimigo
@Lista: 03 - Condicionais
@Autor: brenda kelly 
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
            string? nivel;
            int tipomissoes=0, nivelinimigos, final = 0,fina1 = 0,final2 = 0,final3 = 0;
            Console.WriteLine(" número de missões completadas?");
            int.TryParse(Console.ReadLine(), out tipomissoes);
            for (int i = 0; i < tipomissoes; i++)
        {
            Console.WriteLine("A cada missão, qual o nível de dificuldade?");
            nivel = Console.ReadLine();
            if (nivel == "facil")
            {
                Console.WriteLine("Quantos inimigos foram derrotados durante a missão?");
                int.TryParse(Console.ReadLine(), out nivelinimigos);
                final = 50 * nivelinimigos;
            }
             else if (nivel == "medio")
            {
                Console.WriteLine("Quantos inimigos foram derrotados durante a missão?");
                int.TryParse(Console.ReadLine(), out nivelinimigos);
                fina1  = 100 * nivelinimigos;
            }
             else if (nivel == "dificil")
            {
                Console.WriteLine("Quantos inimigos foram derrotados durante a missão?");
                int.TryParse(Console.ReadLine(), out nivelinimigos);
                final2 = 150 * nivelinimigos;
            }
            final3= final+fina1+final2;
        }
            Console.WriteLine($"Você ganhou {final3} pontos!");
    }
}
