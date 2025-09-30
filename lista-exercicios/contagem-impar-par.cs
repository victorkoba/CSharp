//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        int[] vetor = new int[8];
        int par = 0, impar = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o valor para a posição {i + 1}: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
        }
        Console.WriteLine($"Quantidade de números pares: {par}");
        Console.WriteLine($"Quantidade de números ímpares: {impar}");
  }
}