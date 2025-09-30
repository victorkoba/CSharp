//Victor Luiz Koba Batista
using System;
class HelloWorld {
    static void Main()
    
        {
        string[] informacoesJogador = new string[4];
        Console.WriteLine("Por favor, insira as informações do jogador:");
        
        Console.WriteLine("Nome do personagem:");
        informacoesJogador[0] = Console.ReadLine();
        
        Console.WriteLine("Classe (paladin, Knight, Sorcerer, Druida):");
        informacoesJogador[1] = Console.ReadLine();
        
        Console.WriteLine("Gênero (Male, Female, Others):");
        informacoesJogador[2] = Console.ReadLine();
        
        Console.WriteLine("Servidor (Brazil, Asian, EUA):");
        informacoesJogador[3] = Console.ReadLine();
        
        ExibirInformacoesJogador(informacoesJogador);
    }
    static void ExibirInformacoesJogador(string[] informacoes)
    {
        Console.WriteLine("\nInformações do jogador cadastrado:");
        Console.WriteLine("Nome do personagem: " + informacoes[0]);
        Console.WriteLine("Classe: " + informacoes[1]);
        Console.WriteLine("Gênero: " + informacoes[2]);
        Console.WriteLine("Servidor: " + informacoes[3]);
    }
}