/*-----------------------------------------------------------------
Questão 4: Jornada do Herói com Pontos de Vida e Itens de Cura
Contextualização
O herói de um jogo atravessa várias fases, ganhando ou perdendo pontos de vida. Além disso,
em algumas fases, o herói pode usar itens de cura para recuperar pontos de vida.
Comando
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas fases ele deseja jogar.
2. Para cada fase, pergunte quantos pontos de vida o herói ganhou ou perdeu (valores
positivos indicam ganho e negativos indicam perda).
3. Para cada fase, pergunte se o herói usou um item de cura (Sim/Não). Se sim, pergunte
quantos pontos de cura foram usados.
O programa deve calcular e mostrar a vida total do herói ao final da jornada, considerando que
ele começa com 100 pontos de vida.
classe, e raça do personagem e exiba esses dados no console.
@Lista: 02 - Condicionais
@Autor: Brenda kelly 
@Data: 08/09/2024
---------------------------------------------------------------------*/
using System;

class JornadaHeroi
{
    static void Main(string[] args)
    {
        int vidaHeroi = 100; 

        
        Console.Write("Quantas fases você deseja jogar? ");
        int fases = int.Parse(Console.ReadLine());

        int faseAtual = 1;

        
        while (faseAtual <= fases)
        {
            Console.WriteLine($"\nFase {faseAtual}");

            Console.Write("Quantos pontos de vida o herói ganhou ou perdeu nesta fase?: ");
            int pontosDeVida = int.Parse(Console.ReadLine());
            vidaHeroi += pontosDeVida;

        
            Console.Write("O herói usou um item de cura? (Sim/Não): ");
            string usouCura = Console.ReadLine().ToLower();

         
            if (usouCura == "sim")
            {
                Console.Write("Quantos pontos de cura foram usados? ");
                int pontosCura = int.Parse(Console.ReadLine());
                vidaHeroi += pontosCura;
            }

            faseAtual++;
        }

       
        Console.WriteLine($"\nVida total do herói ao final da jornada: {vidaHeroi} pontos de vida.");
    }
}