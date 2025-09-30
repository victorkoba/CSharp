//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        string[] animes = { "Naruto", "One Piece", "Dragon Ball" };
        
        Console.WriteLine("Digite o nome de um anime: ");
        string animeResposta = Console.ReadLine();
        
        int posicao = Array.IndexOf(animes, animeResposta);

        if (posicao != -1)
        {
            Console.WriteLine($"O anime {animeResposta} foi encontrado na posição {posicao} do vetor.");
        }
        else
        {
            Console.WriteLine($"O anime {animeResposta} não foi encontrado.");
        }
  }
}