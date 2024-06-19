/* Um município deseja saber a porcentagem de votos de três candidatos, além da porcentagem de votos brancos e nulos. 
Monte um programa que receba como entrada o número de votos de cada um dos três candidatos e também os votos nulos e brancos. 
Ao final, o programa deve apresentar o total de votos e a porcentagem, em relação a todos os eleitores que votaram, de votos de cada candidato, votos nulos e votos em branco. */

using System;

class Program
{
    static void Main()
    {
        /* Solicitação e leitura dos votos de cada candidato, nulos e brancos */
        Console.WriteLine("Digite o número de votos para cada candidato:");
        Console.Write("Candidato 1: ");
        int votosCandidato1 = int.Parse(Console.ReadLine());

        Console.Write("Candidato 2: ");
        int votosCandidato2 = int.Parse(Console.ReadLine());

        Console.Write("Candidato 3: ");
        int votosCandidato3 = int.Parse(Console.ReadLine());

        Console.Write("Votos em branco: ");
        int votosBranco = int.Parse(Console.ReadLine());

        Console.Write("Votos nulos: ");
        int votosNulo = int.Parse(Console.ReadLine());

        /* Total de votos */
        int totalVotos = votosCandidato1 + votosCandidato2 + votosCandidato3 + votosBranco + votosNulo;

        /* Cálculo das porcentagens */
        double percentualCandidato1 = (double)votosCandidato1 / totalVotos * 100;
        double percentualCandidato2 = (double)votosCandidato2 / totalVotos * 100;
        double percentualCandidato3 = (double)votosCandidato3 / totalVotos * 100;
        double percentualBranco = (double)votosBranco / totalVotos * 100;
        double percentualNulo = (double)votosNulo / totalVotos * 100;

        /* Exibição dos resultados */
        Console.WriteLine("\nRESULTADO DA VOTAÇÃO");
        Console.WriteLine($"Total de votos: {totalVotos}");
        Console.WriteLine($"Porcentagem de votos do Candidato 1: {percentualCandidato1:F2}%");
        Console.WriteLine($"Porcentagem de votos do Candidato 2: {percentualCandidato2:F2}%");
        Console.WriteLine($"Porcentagem de votos do Candidato 3: {percentualCandidato3:F2}%");
        Console.WriteLine($"Porcentagem de votos em branco: {percentualBranco:F2}%");
        Console.WriteLine($"Porcentagem de votos nulos: {percentualNulo:F2}%");

        Console.ReadLine(); /* Aguarda o usuário pressionar Enter para fechar o programa */
    }
}
