//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        string[] vetor = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        
        int indice1 = 2;
        string novoValor1 = "X";
        vetor.SetValue(novoValor1, indice1);
        
        int indice2 = 8;
        string novoValor2 = "Y";
        vetor.SetValue(novoValor2, indice2);
        
        Console.WriteLine("Vetor Modificado! ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Posição {i}: {vetor[i]}");
        }
  }
}