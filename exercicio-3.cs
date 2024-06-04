/* Elabore	um	programa	que	receba	a	nota	de	um	aluno	e	diga	se	o	mesmo	foi	aprovado	ou	
reprovado.	O	aluno	é	aprovado	com	nova	maior	ou	igual	a	6,0	(seis). */

using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Digite a nota final: ");
    float nota = float.Parse(Console.ReadLine());

    if(nota >= 6){
      Console.WriteLine("Aprovado");
    }
    else{
      Console.WriteLine("Reprovado");
    }
  }
}