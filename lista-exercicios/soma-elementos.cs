//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        int[] vetor = new int[5];
        int soma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite um número para a soma: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            soma += vetor[i];
        }
        Console.WriteLine($"A soma de todos os números é: {soma}");
  }
}