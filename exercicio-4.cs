/* Um	caixa	precisa	de	um	programa	que	o	auxilie	no	fornecimento	de	valores	com	o	mínimo	
de	cédulas/moedas	possíveis.	Monte	um	programa	que	seja	fornecido	o	valor	(inteiro)	a	
ser	fornecido	e	tenha	como	saída	o	total	de	cédulas	utilizadas,	nos	valores	de	100,	50,	20,	
10,	5,	2	e	1. */

using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Digite o valor desejado:");
    int valor = int.Parse(Console.ReadLine());
    int resto = 0;
    int resultado = 0;


    if(valor >= 100){
      resto = valor % 100;
      resultado = valor / 100;

      Console.WriteLine("Cédulas de 100: " + resultado);
     

      valor = resto;
    }

    if(resto >= 50){
      resto = valor % 50;
      resultado = valor / 50;

      Console.WriteLine("Cédulas de 50: " + resultado);
      

      valor = resto;
    }

    if(resto >= 20){
      resto = valor % 20;
      resultado = valor / 20;

      Console.WriteLine("Cédulas de 20: " + resultado);
      

      valor = resto;
    }

    if(resto >= 10){
      resto = valor % 10;
      resultado = valor / 10;

      Console.WriteLine("Cédulas de 10: " + resultado);
      

      valor = resto;
    }

    if(resto >= 5){
      resto = valor % 5;
      resultado = valor / 5;

      Console.WriteLine("Cédulas de 5: " + resultado);
      

      valor = resto;
    }

    if(resto >= 2){
      resto = valor % 2;
      resultado = valor / 2;

      Console.WriteLine("Cédulas de 2: " + resultado);

      valor = resto;
    } 
    else{
      Console.WriteLine("Moeda de 1: " + resto);
    }

  }
}