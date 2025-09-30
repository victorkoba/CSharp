//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
      
        double num1;
        double num2;
        double num3;
      
        Console.WriteLine("Digite três números para serem classificados em ordem crescente:");

        Console.Write("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        num3 = double.Parse(Console.ReadLine());
        
        if (num1>num2){
            double temp = num1;
            num1 = num2;
            num2 = temp;
        }
        
        if (num2 > num3){
            double temp = num2;
            num2 = num3;
            num3 = temp;
            
        }
            
        if (num1 > num2){
            double temp = num1;
            num1 = num2;
            num2 = temp;
            
        }
        Console.WriteLine("Os números em ordem crescente ficaram: ");
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
  }
}