//Victor Luiz Koba Batista

using System;
class HelloWorld {
  static void Main(){
  
        int number1;
        int number2;
        char operacao;
        double resultado = 0;
      
        Console.WriteLine("Insira um número: ");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira um segundo número: ");
        number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a operação que deseja realizar (adição = +, subtração = -, divisão = /, multiplicação = *): ");
        operacao = char.Parse(Console.ReadLine());
    
        switch (operacao){
            case '+':
            resultado = number1 + number2;
            Console.WriteLine(resultado);
            break;
            case '-':
            resultado = number1 - number2;
            Console.WriteLine(resultado);
            break;
            case '*':
            resultado = number1 * number2;
            Console.WriteLine(resultado);
            break;
            case '/':
            resultado = number1 * number2;
            Console.WriteLine(resultado);
            break;
        }
  }
}