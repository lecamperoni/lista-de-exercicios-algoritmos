/* Resolucao exercicio 1 - Escreva um programa para que sejam informados 10 (dez) numeros inteiros. 
O programa deve informar o menor e o maior valor informado. */

using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    int menor = numero;
    int maior = numero;

    for(int i=1;i<10;i=i+1){

      Console.Write("Digite um número: ");
      numero = int.Parse(Console.ReadLine());

      if(numero > maior){
        maior = numero;
      }
      else if(numero < menor){
        menor = numero;
      }

    }

    Console.WriteLine("Maior numero: " + maior);
    Console.WriteLine("Menor numero: " + menor);


  }
}