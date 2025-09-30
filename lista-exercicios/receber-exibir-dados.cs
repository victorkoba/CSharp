//Victor Luiz Koba Batista
using System;
class HelloWorld {
    static void Main()
    {
        Console.WriteLine("Por favor, insira seu nome:");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Por favor, insira sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Por favor, insira seu telefone:");
        string telefone = Console.ReadLine();
        
        Console.WriteLine("Por favor, insira seu e-mail:");
        string email = Console.ReadLine();
        ExibirDados(nome, idade, telefone, email);
    }
    static void ExibirDados(string nome, int idade, string telefone, string email)
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Telefone: " + telefone);
        Console.WriteLine("E-mail: " + email);
    }
}