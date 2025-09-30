//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
        
        int numero;
      
        Console.Write("Digite um número para gerar sua tabuada: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabuada do " + (numero));

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine(numero + "x" + i + "=" + (resultado));
        }
  }
}
