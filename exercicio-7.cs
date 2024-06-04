/* A	 partir	 do	 ano	 fornecido	 pelo	 usuário	 escrever	 um	 programa	 que	 diga	 se	 o	 ano	 é	
bissexto. */

using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Informe o ano desejado: ");
    int ano = int.Parse(Console.ReadLine());


    if(((ano % 4 == 0) && (ano % 100 != 0)) || (ano % 400 == 0)){
      Console.WriteLine("É bissexto!");
    }
    else{
      Console.WriteLine("Não é bissexto!");
    }
    
  }
}
