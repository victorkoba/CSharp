//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        double nota;
      
        Console.Write("Digite a nota do aluno: ");
        nota = double.Parse(Console.ReadLine());

        if (nota >= 6)
        {
            Console.WriteLine("O aluno foi aprovado.");
        }
        else
        {
            Console.WriteLine("O aluno foi reprovado.");
        }
  }
}