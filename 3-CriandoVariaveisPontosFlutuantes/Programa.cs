using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario = 3000.10;

        Console.WriteLine(salario);



        int valor = 12.5;             // não compila.

        int valor2 = 0.0;             // não compila.

        double teste = 125.50;        // compila

        int valor3 = teste;           // não compila.

        //obedece a ordem de algortimo = um debaixo do outro = o int VALOR so vai compilar o 12, mas n o 5


    }
}