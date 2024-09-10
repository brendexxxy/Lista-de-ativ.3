/*-----------------------------------------------------------------
Questão 5: Sistema de Recompensas Diárias com Limites e Bônus
Contextualização
Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente.
A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso,
se o jogador atingir certos marcos de dias, recebe bônus adicionais.
Comando
Crie um programa em C# que:
1. Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2. Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3. Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4. (Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias
(Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o
valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os
bônus se aplicável.
Observações:
* Sem considerar bônus (Input 4 = Não): Apenas soma das recompensas diárias.
* Considerando bônus (Input 4 = Sim): Além da soma das recompensas diárias,
adiciona o bônus a cada marco alcançado
@Lista: 02 - Condicionais
@Autor: Brenda kelly 
@Data: 08/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? dbonus;

        int dias, dia, dconsecutivo = 0, bonus = 0, fone = 0, ftwo = 0, v = 0, fthree = 0;
        Console.WriteLine("Quantos dias seguidos você logou no jogo?");

        int.TryParse(Console.ReadLine(), out dias);
        Console.WriteLine("Qual a recompensa inicial em moedas no dia 1?");

        int.TryParse(Console.ReadLine(), out dia);
        Console.WriteLine("Qual foi a melhora da recompensa a cada dia consecutivo?");

        int.TryParse(Console.ReadLine(), out dconsecutivo);
        Console.WriteLine("Deseja atribuir bônus por marcos de dias?");

        dbonus = Console.ReadLine();
        if (dbonus == "sim")
        {
            Console.WriteLine("Qual o valor do bônus?");
            int.TryParse(Console.ReadLine(), out v);
            Console.WriteLine(" quantos dias consecutivos há um bônus?");
            int.TryParse(Console.ReadLine(), out bonus);
        }
        fthree = v * bonus;
        fone = dias * dconsecutivo;
        ftwo = fone + dia + fthree;
        System.Console.WriteLine($"Você tem {ftwo} pontos!");
    }
}