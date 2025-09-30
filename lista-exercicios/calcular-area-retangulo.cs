//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        double baseRetangulo;
        double alturaRetangulo;
        
        Console.WriteLine("Calculadora de Área do Retângulo");

        Console.Write("Digite a base do retângulo: ");
        baseRetangulo = double.Parse(Console.ReadLine());
    
        Console.Write("Digite a altura do retângulo: ");
        alturaRetangulo = double.Parse(Console.ReadLine());
    
        double areaRetangulo = baseRetangulo * alturaRetangulo;
    
        Console.WriteLine("A área do retângulo é: " + areaRetangulo);
    }
}