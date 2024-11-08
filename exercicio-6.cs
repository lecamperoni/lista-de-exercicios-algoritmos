/* Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu). */

using System;

class Program {

 static void Main () { 
            int anoAtual;
            int anoNascimento;
            
            Console.WriteLine("Digite o ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano que você nasceu: ");
            anoNascimento = int.Parse(Console.ReadLine());

            if (anoAtual - anoNascimento < 16) {
                Console.WriteLine("Você não pode votar.");
            } 
            else if (anoAtual - anoNascimento == 16 || anoAtual - anoNascimento == 17 || anoAtual - anoNascimento > 70) {
                Console.WriteLine("Você não é obrigado a votar, mas pode se quiser.");
            } 
            else {
                Console.WriteLine("Você é obrigado a votar.");
            }
        }
    }
