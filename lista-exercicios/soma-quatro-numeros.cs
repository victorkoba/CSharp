//Victor Luiz Koba Batista
using System;
class HelloWorld {
  static void Main() {
    int soma = SomarNumeros(6, 7, 7, 10);
        ExibirResultado(soma);
    }
    static int SomarNumeros(int num1, int num2, int num3, int num4)
    {
        int soma = num1 + num2 + num3 + num4;
        return soma;
    }
    static void ExibirResultado(int resultado)
    {
        Console.WriteLine($"A soma dos números é: {resultado}");
    }
}