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

// Versão 2

using System;

class Program {
  public static void Main (string[] args) {
    //COLETA DE DADOS
    double nota1 = pedirNota("Informe a nota 01: ");
    double nota2 = pedirNota("Informe a nota 02: ");
    double nota3 = pedirNota("Informe a nota 03: ");

    //PROCESSAMENTO
    double media = calcularMedia(nota1, nota2, nota3);
    string situacao = verificarSituacao(media);

    //SAÍDA DE DADOS
    Console.WriteLine($"Media = {media});
    Console.WriteLine($"Situação = {situacao});                  
  }
  public static double pedirNota(string msg)
  { 
    Console.WriteLine(msg);
    double nota = Convert.ToDouble(Console ReadLine());
    retun nota;
  }

  public static double calcularMedia(double n1, double n2, double n3)
  { 
    double m = (n1 + n2 + n3) / 3;
    return m;
  }  

  public static string verificarSituacao(double media)
  {
    string s = " ";
    if (media >=6)
    { 
      s = "Aprovado";
      }
    else
    {
      s = "Reprovado";
      }   
    return s;
  }  
}


    
    
