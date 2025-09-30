//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        double[] notas = new double[7];
        double soma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota do aluno {i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
        double media = soma / notas.Length;
        Console.WriteLine($"A média das notas é: {media}");
  }
}