using System;
class Programa
{
    static void Main(string[] args)
    {
        //numero quebrado
        double salario = 3000.15;
        Console.WriteLine(salario);

        //antes da virgula = nmr inteiro
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //O long é um tipo de variável de 64 bits
        long x = 2000000000000000000;
        Console.WriteLine(x);

        //pequeno
        short y = 15000;
        Console.WriteLine(y);

        //aviso o VS que eu quero usar dps da virgula
        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}