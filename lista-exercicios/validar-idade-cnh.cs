//Victor Luiz Koba Batista
using System;
class HelloWorld {
    static void Main()
    {
        Console.WriteLine("Por favor, insira sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (ValidarIdadeParaCNH(idade))
        {
            Console.WriteLine("Você possui idade para tirar CNH.");
        }
        else
        {
            Console.WriteLine("Você não possui idade para tirar CNH.");
        }
    }
    static bool ValidarIdadeParaCNH(int idade)
    {
        return idade >= 18;
    }
}