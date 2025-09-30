//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
      int idade;

        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você pode votar.");
        }
        else
        {
            Console.WriteLine("Você não pode votar.");
        }

    }
}