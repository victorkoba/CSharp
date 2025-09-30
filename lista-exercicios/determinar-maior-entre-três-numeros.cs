//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        double num1;
        double num2;
        double num3;
        double maiorNumero;
      
        Console.WriteLine("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número: ");
        num3 = double.Parse(Console.ReadLine());
        
        if (num1 > num2){
            maiorNumero = num1;
        } else{
            maiorNumero = num2;
        }
        
        if (num3 > maiorNumero){
            maiorNumero = num3;
        }
        
        Console.WriteLine("O maior número é o: " + maiorNumero);
        
    }
}