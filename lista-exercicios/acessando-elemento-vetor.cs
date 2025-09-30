//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        int[] vetor = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < vetor.Length; i++)
        {
            int valor = (int)vetor.GetValue(i);
            Console.WriteLine($"Valor na posição {i}: {vetor[i]}");
        }
  }
}